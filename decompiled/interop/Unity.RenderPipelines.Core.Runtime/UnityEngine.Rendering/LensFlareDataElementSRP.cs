using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.Rendering;

[System.Serializable]
public sealed class LensFlareDataElementSRP : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_lensFlareDataSRP;

	private static readonly System.IntPtr NativeFieldInfoPtr_visible;

	private static readonly System.IntPtr NativeFieldInfoPtr_position;

	private static readonly System.IntPtr NativeFieldInfoPtr_positionOffset;

	private static readonly System.IntPtr NativeFieldInfoPtr_angularOffset;

	private static readonly System.IntPtr NativeFieldInfoPtr_translationScale;

	private static readonly System.IntPtr NativeFieldInfoPtr_ringThickness;

	private static readonly System.IntPtr NativeFieldInfoPtr_hoopFactor;

	private static readonly System.IntPtr NativeFieldInfoPtr_noiseAmplitude;

	private static readonly System.IntPtr NativeFieldInfoPtr_noiseFrequency;

	private static readonly System.IntPtr NativeFieldInfoPtr_noiseSpeed;

	private static readonly System.IntPtr NativeFieldInfoPtr_shapeCutOffSpeed;

	private static readonly System.IntPtr NativeFieldInfoPtr_shapeCutOffRadius;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_LocalIntensity;

	private static readonly System.IntPtr NativeFieldInfoPtr_lensFlareTexture;

	private static readonly System.IntPtr NativeFieldInfoPtr_uniformScale;

	private static readonly System.IntPtr NativeFieldInfoPtr_sizeXY;

	private static readonly System.IntPtr NativeFieldInfoPtr_allowMultipleElement;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_Count;

	private static readonly System.IntPtr NativeFieldInfoPtr_preserveAspectRatio;

	private static readonly System.IntPtr NativeFieldInfoPtr_rotation;

	private static readonly System.IntPtr NativeFieldInfoPtr_tintColorType;

	private static readonly System.IntPtr NativeFieldInfoPtr_tint;

	private static readonly System.IntPtr NativeFieldInfoPtr_tintGradient;

	private static readonly System.IntPtr NativeFieldInfoPtr_blendMode;

	private static readonly System.IntPtr NativeFieldInfoPtr_autoRotate;

	private static readonly System.IntPtr NativeFieldInfoPtr_flareType;

	private static readonly System.IntPtr NativeFieldInfoPtr_modulateByLightColor;

	private static readonly System.IntPtr NativeFieldInfoPtr_isFoldOpened;

	private static readonly System.IntPtr NativeFieldInfoPtr_distribution;

	private static readonly System.IntPtr NativeFieldInfoPtr_lengthSpread;

	private static readonly System.IntPtr NativeFieldInfoPtr_positionCurve;

	private static readonly System.IntPtr NativeFieldInfoPtr_scaleCurve;

	private static readonly System.IntPtr NativeFieldInfoPtr_seed;

	private static readonly System.IntPtr NativeFieldInfoPtr_colorGradient;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_IntensityVariation;

	private static readonly System.IntPtr NativeFieldInfoPtr_positionVariation;

	private static readonly System.IntPtr NativeFieldInfoPtr_scaleVariation;

	private static readonly System.IntPtr NativeFieldInfoPtr_rotationVariation;

	private static readonly System.IntPtr NativeFieldInfoPtr_enableRadialDistortion;

	private static readonly System.IntPtr NativeFieldInfoPtr_targetSizeDistortion;

	private static readonly System.IntPtr NativeFieldInfoPtr_distortionCurve;

	private static readonly System.IntPtr NativeFieldInfoPtr_distortionRelativeToCenter;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_FallOff;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_EdgeOffset;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_SideCount;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_SdfRoundness;

	private static readonly System.IntPtr NativeFieldInfoPtr_inverseSDF;

	private static readonly System.IntPtr NativeFieldInfoPtr_uniformAngle;

	private static readonly System.IntPtr NativeFieldInfoPtr_uniformAngleCurve;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Clone_Public_LensFlareDataElementSRP_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_localIntensity_Public_get_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_localIntensity_Public_set_Void_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_count_Public_get_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_count_Public_set_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_intensityVariation_Public_get_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_intensityVariation_Public_set_Void_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_fallOff_Public_get_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_fallOff_Public_set_Void_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_edgeOffset_Public_get_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_edgeOffset_Public_set_Void_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_sideCount_Public_get_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_sideCount_Public_set_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_sdfRoundness_Public_get_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_sdfRoundness_Public_set_Void_Single_0;

	public unsafe LensFlareDataSRP lensFlareDataSRP
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lensFlareDataSRP);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<LensFlareDataSRP>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lensFlareDataSRP)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe bool visible
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_visible);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_visible)) = value;
		}
	}

	public unsafe float position
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_position);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_position)) = value;
		}
	}

	public unsafe Vector2 positionOffset
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_positionOffset);
			return *(Vector2*)num;
		}
		set
		{
			*(Vector2*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_positionOffset)) = value;
		}
	}

	public unsafe float angularOffset
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_angularOffset);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_angularOffset)) = value;
		}
	}

	public unsafe Vector2 translationScale
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_translationScale);
			return *(Vector2*)num;
		}
		set
		{
			*(Vector2*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_translationScale)) = value;
		}
	}

	public unsafe float ringThickness
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ringThickness);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ringThickness)) = value;
		}
	}

	public unsafe float hoopFactor
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_hoopFactor);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_hoopFactor)) = value;
		}
	}

	public unsafe float noiseAmplitude
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_noiseAmplitude);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_noiseAmplitude)) = value;
		}
	}

	public unsafe int noiseFrequency
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_noiseFrequency);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_noiseFrequency)) = value;
		}
	}

	public unsafe float noiseSpeed
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_noiseSpeed);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_noiseSpeed)) = value;
		}
	}

	public unsafe float shapeCutOffSpeed
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_shapeCutOffSpeed);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_shapeCutOffSpeed)) = value;
		}
	}

	public unsafe float shapeCutOffRadius
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_shapeCutOffRadius);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_shapeCutOffRadius)) = value;
		}
	}

	public unsafe float m_LocalIntensity
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_LocalIntensity);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_LocalIntensity)) = value;
		}
	}

	public unsafe Texture lensFlareTexture
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lensFlareTexture);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Texture>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lensFlareTexture)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe float uniformScale
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_uniformScale);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_uniformScale)) = value;
		}
	}

	public unsafe Vector2 sizeXY
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_sizeXY);
			return *(Vector2*)num;
		}
		set
		{
			*(Vector2*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_sizeXY)) = value;
		}
	}

	public unsafe bool allowMultipleElement
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_allowMultipleElement);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_allowMultipleElement)) = value;
		}
	}

	public unsafe int m_Count
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Count);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Count)) = value;
		}
	}

	public unsafe bool preserveAspectRatio
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_preserveAspectRatio);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_preserveAspectRatio)) = value;
		}
	}

	public unsafe float rotation
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_rotation);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_rotation)) = value;
		}
	}

	public unsafe SRPLensFlareColorType tintColorType
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_tintColorType);
			return *(SRPLensFlareColorType*)num;
		}
		set
		{
			*(SRPLensFlareColorType*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_tintColorType)) = value;
		}
	}

	public unsafe Color tint
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_tint);
			return *(Color*)num;
		}
		set
		{
			*(Color*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_tint)) = value;
		}
	}

	public unsafe TextureGradient tintGradient
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_tintGradient);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<TextureGradient>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_tintGradient)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe SRPLensFlareBlendMode blendMode
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_blendMode);
			return *(SRPLensFlareBlendMode*)num;
		}
		set
		{
			*(SRPLensFlareBlendMode*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_blendMode)) = value;
		}
	}

	public unsafe bool autoRotate
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_autoRotate);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_autoRotate)) = value;
		}
	}

	public unsafe SRPLensFlareType flareType
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_flareType);
			return *(SRPLensFlareType*)num;
		}
		set
		{
			*(SRPLensFlareType*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_flareType)) = value;
		}
	}

	public unsafe bool modulateByLightColor
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_modulateByLightColor);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_modulateByLightColor)) = value;
		}
	}

	public unsafe bool isFoldOpened
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isFoldOpened);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isFoldOpened)) = value;
		}
	}

	public unsafe SRPLensFlareDistribution distribution
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_distribution);
			return *(SRPLensFlareDistribution*)num;
		}
		set
		{
			*(SRPLensFlareDistribution*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_distribution)) = value;
		}
	}

	public unsafe float lengthSpread
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lengthSpread);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lengthSpread)) = value;
		}
	}

	public unsafe AnimationCurve positionCurve
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_positionCurve);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<AnimationCurve>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_positionCurve)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe AnimationCurve scaleCurve
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_scaleCurve);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<AnimationCurve>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_scaleCurve)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe int seed
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_seed);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_seed)) = value;
		}
	}

	public unsafe Gradient colorGradient
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_colorGradient);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Gradient>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_colorGradient)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe float m_IntensityVariation
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_IntensityVariation);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_IntensityVariation)) = value;
		}
	}

	public unsafe Vector2 positionVariation
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_positionVariation);
			return *(Vector2*)num;
		}
		set
		{
			*(Vector2*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_positionVariation)) = value;
		}
	}

	public unsafe float scaleVariation
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_scaleVariation);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_scaleVariation)) = value;
		}
	}

	public unsafe float rotationVariation
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_rotationVariation);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_rotationVariation)) = value;
		}
	}

	public unsafe bool enableRadialDistortion
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_enableRadialDistortion);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_enableRadialDistortion)) = value;
		}
	}

	public unsafe Vector2 targetSizeDistortion
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_targetSizeDistortion);
			return *(Vector2*)num;
		}
		set
		{
			*(Vector2*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_targetSizeDistortion)) = value;
		}
	}

	public unsafe AnimationCurve distortionCurve
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_distortionCurve);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<AnimationCurve>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_distortionCurve)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe bool distortionRelativeToCenter
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_distortionRelativeToCenter);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_distortionRelativeToCenter)) = value;
		}
	}

	public unsafe float m_FallOff
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_FallOff);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_FallOff)) = value;
		}
	}

	public unsafe float m_EdgeOffset
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_EdgeOffset);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_EdgeOffset)) = value;
		}
	}

	public unsafe int m_SideCount
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_SideCount);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_SideCount)) = value;
		}
	}

	public unsafe float m_SdfRoundness
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_SdfRoundness);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_SdfRoundness)) = value;
		}
	}

	public unsafe bool inverseSDF
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_inverseSDF);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_inverseSDF)) = value;
		}
	}

	public unsafe float uniformAngle
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_uniformAngle);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_uniformAngle)) = value;
		}
	}

	public unsafe AnimationCurve uniformAngleCurve
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_uniformAngleCurve);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<AnimationCurve>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_uniformAngleCurve)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe float localIntensity
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_localIntensity_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(float*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(0)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_localIntensity_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe int count
	{
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 42195, RefRangeEnd = 42198, XrefRangeStart = 42195, XrefRangeEnd = 42198, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_count_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(0)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_count_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe float intensityVariation
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_intensityVariation_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(float*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(0)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_intensityVariation_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe float fallOff
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_fallOff_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(float*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(0)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_fallOff_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe float edgeOffset
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_edgeOffset_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(float*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(0)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_edgeOffset_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe int sideCount
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_sideCount_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(0)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_sideCount_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe float sdfRoundness
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_sdfRoundness_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(float*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(0)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_sdfRoundness_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	static LensFlareDataElementSRP()
	{
		Il2CppClassPointerStore<LensFlareDataElementSRP>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Core.Runtime.dll", "UnityEngine.Rendering", "LensFlareDataElementSRP");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LensFlareDataElementSRP>.NativeClassPtr);
		NativeFieldInfoPtr_lensFlareDataSRP = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LensFlareDataElementSRP>.NativeClassPtr, "lensFlareDataSRP");
		NativeFieldInfoPtr_visible = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LensFlareDataElementSRP>.NativeClassPtr, "visible");
		NativeFieldInfoPtr_position = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LensFlareDataElementSRP>.NativeClassPtr, "position");
		NativeFieldInfoPtr_positionOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LensFlareDataElementSRP>.NativeClassPtr, "positionOffset");
		NativeFieldInfoPtr_angularOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LensFlareDataElementSRP>.NativeClassPtr, "angularOffset");
		NativeFieldInfoPtr_translationScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LensFlareDataElementSRP>.NativeClassPtr, "translationScale");
		NativeFieldInfoPtr_ringThickness = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LensFlareDataElementSRP>.NativeClassPtr, "ringThickness");
		NativeFieldInfoPtr_hoopFactor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LensFlareDataElementSRP>.NativeClassPtr, "hoopFactor");
		NativeFieldInfoPtr_noiseAmplitude = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LensFlareDataElementSRP>.NativeClassPtr, "noiseAmplitude");
		NativeFieldInfoPtr_noiseFrequency = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LensFlareDataElementSRP>.NativeClassPtr, "noiseFrequency");
		NativeFieldInfoPtr_noiseSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LensFlareDataElementSRP>.NativeClassPtr, "noiseSpeed");
		NativeFieldInfoPtr_shapeCutOffSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LensFlareDataElementSRP>.NativeClassPtr, "shapeCutOffSpeed");
		NativeFieldInfoPtr_shapeCutOffRadius = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LensFlareDataElementSRP>.NativeClassPtr, "shapeCutOffRadius");
		NativeFieldInfoPtr_m_LocalIntensity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LensFlareDataElementSRP>.NativeClassPtr, "m_LocalIntensity");
		NativeFieldInfoPtr_lensFlareTexture = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LensFlareDataElementSRP>.NativeClassPtr, "lensFlareTexture");
		NativeFieldInfoPtr_uniformScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LensFlareDataElementSRP>.NativeClassPtr, "uniformScale");
		NativeFieldInfoPtr_sizeXY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LensFlareDataElementSRP>.NativeClassPtr, "sizeXY");
		NativeFieldInfoPtr_allowMultipleElement = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LensFlareDataElementSRP>.NativeClassPtr, "allowMultipleElement");
		NativeFieldInfoPtr_m_Count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LensFlareDataElementSRP>.NativeClassPtr, "m_Count");
		NativeFieldInfoPtr_preserveAspectRatio = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LensFlareDataElementSRP>.NativeClassPtr, "preserveAspectRatio");
		NativeFieldInfoPtr_rotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LensFlareDataElementSRP>.NativeClassPtr, "rotation");
		NativeFieldInfoPtr_tintColorType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LensFlareDataElementSRP>.NativeClassPtr, "tintColorType");
		NativeFieldInfoPtr_tint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LensFlareDataElementSRP>.NativeClassPtr, "tint");
		NativeFieldInfoPtr_tintGradient = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LensFlareDataElementSRP>.NativeClassPtr, "tintGradient");
		NativeFieldInfoPtr_blendMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LensFlareDataElementSRP>.NativeClassPtr, "blendMode");
		NativeFieldInfoPtr_autoRotate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LensFlareDataElementSRP>.NativeClassPtr, "autoRotate");
		NativeFieldInfoPtr_flareType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LensFlareDataElementSRP>.NativeClassPtr, "flareType");
		NativeFieldInfoPtr_modulateByLightColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LensFlareDataElementSRP>.NativeClassPtr, "modulateByLightColor");
		NativeFieldInfoPtr_isFoldOpened = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LensFlareDataElementSRP>.NativeClassPtr, "isFoldOpened");
		NativeFieldInfoPtr_distribution = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LensFlareDataElementSRP>.NativeClassPtr, "distribution");
		NativeFieldInfoPtr_lengthSpread = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LensFlareDataElementSRP>.NativeClassPtr, "lengthSpread");
		NativeFieldInfoPtr_positionCurve = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LensFlareDataElementSRP>.NativeClassPtr, "positionCurve");
		NativeFieldInfoPtr_scaleCurve = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LensFlareDataElementSRP>.NativeClassPtr, "scaleCurve");
		NativeFieldInfoPtr_seed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LensFlareDataElementSRP>.NativeClassPtr, "seed");
		NativeFieldInfoPtr_colorGradient = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LensFlareDataElementSRP>.NativeClassPtr, "colorGradient");
		NativeFieldInfoPtr_m_IntensityVariation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LensFlareDataElementSRP>.NativeClassPtr, "m_IntensityVariation");
		NativeFieldInfoPtr_positionVariation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LensFlareDataElementSRP>.NativeClassPtr, "positionVariation");
		NativeFieldInfoPtr_scaleVariation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LensFlareDataElementSRP>.NativeClassPtr, "scaleVariation");
		NativeFieldInfoPtr_rotationVariation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LensFlareDataElementSRP>.NativeClassPtr, "rotationVariation");
		NativeFieldInfoPtr_enableRadialDistortion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LensFlareDataElementSRP>.NativeClassPtr, "enableRadialDistortion");
		NativeFieldInfoPtr_targetSizeDistortion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LensFlareDataElementSRP>.NativeClassPtr, "targetSizeDistortion");
		NativeFieldInfoPtr_distortionCurve = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LensFlareDataElementSRP>.NativeClassPtr, "distortionCurve");
		NativeFieldInfoPtr_distortionRelativeToCenter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LensFlareDataElementSRP>.NativeClassPtr, "distortionRelativeToCenter");
		NativeFieldInfoPtr_m_FallOff = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LensFlareDataElementSRP>.NativeClassPtr, "m_FallOff");
		NativeFieldInfoPtr_m_EdgeOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LensFlareDataElementSRP>.NativeClassPtr, "m_EdgeOffset");
		NativeFieldInfoPtr_m_SideCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LensFlareDataElementSRP>.NativeClassPtr, "m_SideCount");
		NativeFieldInfoPtr_m_SdfRoundness = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LensFlareDataElementSRP>.NativeClassPtr, "m_SdfRoundness");
		NativeFieldInfoPtr_inverseSDF = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LensFlareDataElementSRP>.NativeClassPtr, "inverseSDF");
		NativeFieldInfoPtr_uniformAngle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LensFlareDataElementSRP>.NativeClassPtr, "uniformAngle");
		NativeFieldInfoPtr_uniformAngleCurve = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LensFlareDataElementSRP>.NativeClassPtr, "uniformAngleCurve");
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LensFlareDataElementSRP>.NativeClassPtr, 100665983);
		NativeMethodInfoPtr_Clone_Public_LensFlareDataElementSRP_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LensFlareDataElementSRP>.NativeClassPtr, 100665984);
		NativeMethodInfoPtr_get_localIntensity_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LensFlareDataElementSRP>.NativeClassPtr, 100665985);
		NativeMethodInfoPtr_set_localIntensity_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LensFlareDataElementSRP>.NativeClassPtr, 100665986);
		NativeMethodInfoPtr_get_count_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LensFlareDataElementSRP>.NativeClassPtr, 100665987);
		NativeMethodInfoPtr_set_count_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LensFlareDataElementSRP>.NativeClassPtr, 100665988);
		NativeMethodInfoPtr_get_intensityVariation_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LensFlareDataElementSRP>.NativeClassPtr, 100665989);
		NativeMethodInfoPtr_set_intensityVariation_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LensFlareDataElementSRP>.NativeClassPtr, 100665990);
		NativeMethodInfoPtr_get_fallOff_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LensFlareDataElementSRP>.NativeClassPtr, 100665991);
		NativeMethodInfoPtr_set_fallOff_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LensFlareDataElementSRP>.NativeClassPtr, 100665992);
		NativeMethodInfoPtr_get_edgeOffset_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LensFlareDataElementSRP>.NativeClassPtr, 100665993);
		NativeMethodInfoPtr_set_edgeOffset_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LensFlareDataElementSRP>.NativeClassPtr, 100665994);
		NativeMethodInfoPtr_get_sideCount_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LensFlareDataElementSRP>.NativeClassPtr, 100665995);
		NativeMethodInfoPtr_set_sideCount_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LensFlareDataElementSRP>.NativeClassPtr, 100665996);
		NativeMethodInfoPtr_get_sdfRoundness_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LensFlareDataElementSRP>.NativeClassPtr, 100665997);
		NativeMethodInfoPtr_set_sdfRoundness_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LensFlareDataElementSRP>.NativeClassPtr, 100665998);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1046704, RefRangeEnd = 1046705, XrefRangeStart = 1046634, XrefRangeEnd = 1046704, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe LensFlareDataElementSRP()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LensFlareDataElementSRP>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1046705, XrefRangeEnd = 1046760, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe LensFlareDataElementSRP Clone()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Clone_Public_LensFlareDataElementSRP_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<LensFlareDataElementSRP>(intPtr2) : null;
	}

	public LensFlareDataElementSRP(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
