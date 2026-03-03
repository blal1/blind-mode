using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace Il2CppTMPro;

public static class ShaderUtilities : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_ID_MainTex;

	private static readonly System.IntPtr NativeFieldInfoPtr_ID_FaceTex;

	private static readonly System.IntPtr NativeFieldInfoPtr_ID_FaceColor;

	private static readonly System.IntPtr NativeFieldInfoPtr_ID_FaceDilate;

	private static readonly System.IntPtr NativeFieldInfoPtr_ID_Shininess;

	private static readonly System.IntPtr NativeFieldInfoPtr_ID_OutlineOffset1;

	private static readonly System.IntPtr NativeFieldInfoPtr_ID_OutlineOffset2;

	private static readonly System.IntPtr NativeFieldInfoPtr_ID_OutlineOffset3;

	private static readonly System.IntPtr NativeFieldInfoPtr_ID_OutlineMode;

	private static readonly System.IntPtr NativeFieldInfoPtr_ID_IsoPerimeter;

	private static readonly System.IntPtr NativeFieldInfoPtr_ID_Softness;

	private static readonly System.IntPtr NativeFieldInfoPtr_ID_UnderlayColor;

	private static readonly System.IntPtr NativeFieldInfoPtr_ID_UnderlayOffsetX;

	private static readonly System.IntPtr NativeFieldInfoPtr_ID_UnderlayOffsetY;

	private static readonly System.IntPtr NativeFieldInfoPtr_ID_UnderlayDilate;

	private static readonly System.IntPtr NativeFieldInfoPtr_ID_UnderlaySoftness;

	private static readonly System.IntPtr NativeFieldInfoPtr_ID_UnderlayOffset;

	private static readonly System.IntPtr NativeFieldInfoPtr_ID_UnderlayIsoPerimeter;

	private static readonly System.IntPtr NativeFieldInfoPtr_ID_WeightNormal;

	private static readonly System.IntPtr NativeFieldInfoPtr_ID_WeightBold;

	private static readonly System.IntPtr NativeFieldInfoPtr_ID_OutlineTex;

	private static readonly System.IntPtr NativeFieldInfoPtr_ID_OutlineWidth;

	private static readonly System.IntPtr NativeFieldInfoPtr_ID_OutlineSoftness;

	private static readonly System.IntPtr NativeFieldInfoPtr_ID_OutlineColor;

	private static readonly System.IntPtr NativeFieldInfoPtr_ID_Outline2Color;

	private static readonly System.IntPtr NativeFieldInfoPtr_ID_Outline2Width;

	private static readonly System.IntPtr NativeFieldInfoPtr_ID_Padding;

	private static readonly System.IntPtr NativeFieldInfoPtr_ID_GradientScale;

	private static readonly System.IntPtr NativeFieldInfoPtr_ID_ScaleX;

	private static readonly System.IntPtr NativeFieldInfoPtr_ID_ScaleY;

	private static readonly System.IntPtr NativeFieldInfoPtr_ID_PerspectiveFilter;

	private static readonly System.IntPtr NativeFieldInfoPtr_ID_Sharpness;

	private static readonly System.IntPtr NativeFieldInfoPtr_ID_TextureWidth;

	private static readonly System.IntPtr NativeFieldInfoPtr_ID_TextureHeight;

	private static readonly System.IntPtr NativeFieldInfoPtr_ID_BevelAmount;

	private static readonly System.IntPtr NativeFieldInfoPtr_ID_GlowColor;

	private static readonly System.IntPtr NativeFieldInfoPtr_ID_GlowOffset;

	private static readonly System.IntPtr NativeFieldInfoPtr_ID_GlowPower;

	private static readonly System.IntPtr NativeFieldInfoPtr_ID_GlowOuter;

	private static readonly System.IntPtr NativeFieldInfoPtr_ID_GlowInner;

	private static readonly System.IntPtr NativeFieldInfoPtr_ID_LightAngle;

	private static readonly System.IntPtr NativeFieldInfoPtr_ID_EnvMap;

	private static readonly System.IntPtr NativeFieldInfoPtr_ID_EnvMatrix;

	private static readonly System.IntPtr NativeFieldInfoPtr_ID_EnvMatrixRotation;

	private static readonly System.IntPtr NativeFieldInfoPtr_ID_MaskCoord;

	private static readonly System.IntPtr NativeFieldInfoPtr_ID_ClipRect;

	private static readonly System.IntPtr NativeFieldInfoPtr_ID_MaskSoftnessX;

	private static readonly System.IntPtr NativeFieldInfoPtr_ID_MaskSoftnessY;

	private static readonly System.IntPtr NativeFieldInfoPtr_ID_VertexOffsetX;

	private static readonly System.IntPtr NativeFieldInfoPtr_ID_VertexOffsetY;

	private static readonly System.IntPtr NativeFieldInfoPtr_ID_UseClipRect;

	private static readonly System.IntPtr NativeFieldInfoPtr_ID_StencilID;

	private static readonly System.IntPtr NativeFieldInfoPtr_ID_StencilOp;

	private static readonly System.IntPtr NativeFieldInfoPtr_ID_StencilComp;

	private static readonly System.IntPtr NativeFieldInfoPtr_ID_StencilReadMask;

	private static readonly System.IntPtr NativeFieldInfoPtr_ID_StencilWriteMask;

	private static readonly System.IntPtr NativeFieldInfoPtr_ID_ShaderFlags;

	private static readonly System.IntPtr NativeFieldInfoPtr_ID_ScaleRatio_A;

	private static readonly System.IntPtr NativeFieldInfoPtr_ID_ScaleRatio_B;

	private static readonly System.IntPtr NativeFieldInfoPtr_ID_ScaleRatio_C;

	private static readonly System.IntPtr NativeFieldInfoPtr_Keyword_Bevel;

	private static readonly System.IntPtr NativeFieldInfoPtr_Keyword_Glow;

	private static readonly System.IntPtr NativeFieldInfoPtr_Keyword_Underlay;

	private static readonly System.IntPtr NativeFieldInfoPtr_Keyword_Ratios;

	private static readonly System.IntPtr NativeFieldInfoPtr_Keyword_MASK_SOFT;

	private static readonly System.IntPtr NativeFieldInfoPtr_Keyword_MASK_HARD;

	private static readonly System.IntPtr NativeFieldInfoPtr_Keyword_MASK_TEX;

	private static readonly System.IntPtr NativeFieldInfoPtr_Keyword_Outline;

	private static readonly System.IntPtr NativeFieldInfoPtr_ShaderTag_ZTestMode;

	private static readonly System.IntPtr NativeFieldInfoPtr_ShaderTag_CullMode;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_clamp;

	private static readonly System.IntPtr NativeFieldInfoPtr_isInitialized;

	private static readonly System.IntPtr NativeFieldInfoPtr_k_ShaderRef_MobileSDF;

	private static readonly System.IntPtr NativeFieldInfoPtr_k_ShaderRef_MobileBitmap;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_ShaderRef_MobileSDF_Internal_Static_get_Shader_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_ShaderRef_MobileBitmap_Internal_Static_get_Shader_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetShaderPropertyIDs_Public_Static_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UpdateShaderRatios_Public_Static_Void_Material_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetFontExtent_Public_Static_Vector4_Material_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsMaskingEnabled_Public_Static_Boolean_Material_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetPadding_Public_Static_Single_Material_Boolean_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ComputePaddingForProperties_Private_Static_Single_Material_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetPadding_Public_Static_Single_Il2CppReferenceArray_1_Material_Boolean_Boolean_0;

	public unsafe static int ID_MainTex
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_ID_MainTex, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_ID_MainTex, (void*)(&value));
		}
	}

	public unsafe static int ID_FaceTex
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_ID_FaceTex, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_ID_FaceTex, (void*)(&value));
		}
	}

	public unsafe static int ID_FaceColor
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_ID_FaceColor, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_ID_FaceColor, (void*)(&value));
		}
	}

	public unsafe static int ID_FaceDilate
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_ID_FaceDilate, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_ID_FaceDilate, (void*)(&value));
		}
	}

	public unsafe static int ID_Shininess
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_ID_Shininess, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_ID_Shininess, (void*)(&value));
		}
	}

	public unsafe static int ID_OutlineOffset1
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_ID_OutlineOffset1, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_ID_OutlineOffset1, (void*)(&value));
		}
	}

	public unsafe static int ID_OutlineOffset2
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_ID_OutlineOffset2, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_ID_OutlineOffset2, (void*)(&value));
		}
	}

	public unsafe static int ID_OutlineOffset3
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_ID_OutlineOffset3, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_ID_OutlineOffset3, (void*)(&value));
		}
	}

	public unsafe static int ID_OutlineMode
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_ID_OutlineMode, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_ID_OutlineMode, (void*)(&value));
		}
	}

	public unsafe static int ID_IsoPerimeter
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_ID_IsoPerimeter, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_ID_IsoPerimeter, (void*)(&value));
		}
	}

	public unsafe static int ID_Softness
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_ID_Softness, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_ID_Softness, (void*)(&value));
		}
	}

	public unsafe static int ID_UnderlayColor
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_ID_UnderlayColor, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_ID_UnderlayColor, (void*)(&value));
		}
	}

	public unsafe static int ID_UnderlayOffsetX
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_ID_UnderlayOffsetX, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_ID_UnderlayOffsetX, (void*)(&value));
		}
	}

	public unsafe static int ID_UnderlayOffsetY
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_ID_UnderlayOffsetY, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_ID_UnderlayOffsetY, (void*)(&value));
		}
	}

	public unsafe static int ID_UnderlayDilate
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_ID_UnderlayDilate, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_ID_UnderlayDilate, (void*)(&value));
		}
	}

	public unsafe static int ID_UnderlaySoftness
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_ID_UnderlaySoftness, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_ID_UnderlaySoftness, (void*)(&value));
		}
	}

	public unsafe static int ID_UnderlayOffset
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_ID_UnderlayOffset, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_ID_UnderlayOffset, (void*)(&value));
		}
	}

	public unsafe static int ID_UnderlayIsoPerimeter
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_ID_UnderlayIsoPerimeter, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_ID_UnderlayIsoPerimeter, (void*)(&value));
		}
	}

	public unsafe static int ID_WeightNormal
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_ID_WeightNormal, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_ID_WeightNormal, (void*)(&value));
		}
	}

	public unsafe static int ID_WeightBold
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_ID_WeightBold, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_ID_WeightBold, (void*)(&value));
		}
	}

	public unsafe static int ID_OutlineTex
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_ID_OutlineTex, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_ID_OutlineTex, (void*)(&value));
		}
	}

	public unsafe static int ID_OutlineWidth
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_ID_OutlineWidth, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_ID_OutlineWidth, (void*)(&value));
		}
	}

	public unsafe static int ID_OutlineSoftness
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_ID_OutlineSoftness, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_ID_OutlineSoftness, (void*)(&value));
		}
	}

	public unsafe static int ID_OutlineColor
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_ID_OutlineColor, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_ID_OutlineColor, (void*)(&value));
		}
	}

	public unsafe static int ID_Outline2Color
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_ID_Outline2Color, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_ID_Outline2Color, (void*)(&value));
		}
	}

	public unsafe static int ID_Outline2Width
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_ID_Outline2Width, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_ID_Outline2Width, (void*)(&value));
		}
	}

	public unsafe static int ID_Padding
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_ID_Padding, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_ID_Padding, (void*)(&value));
		}
	}

	public unsafe static int ID_GradientScale
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_ID_GradientScale, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_ID_GradientScale, (void*)(&value));
		}
	}

	public unsafe static int ID_ScaleX
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_ID_ScaleX, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_ID_ScaleX, (void*)(&value));
		}
	}

	public unsafe static int ID_ScaleY
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_ID_ScaleY, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_ID_ScaleY, (void*)(&value));
		}
	}

	public unsafe static int ID_PerspectiveFilter
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_ID_PerspectiveFilter, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_ID_PerspectiveFilter, (void*)(&value));
		}
	}

	public unsafe static int ID_Sharpness
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_ID_Sharpness, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_ID_Sharpness, (void*)(&value));
		}
	}

	public unsafe static int ID_TextureWidth
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_ID_TextureWidth, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_ID_TextureWidth, (void*)(&value));
		}
	}

	public unsafe static int ID_TextureHeight
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_ID_TextureHeight, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_ID_TextureHeight, (void*)(&value));
		}
	}

	public unsafe static int ID_BevelAmount
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_ID_BevelAmount, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_ID_BevelAmount, (void*)(&value));
		}
	}

	public unsafe static int ID_GlowColor
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_ID_GlowColor, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_ID_GlowColor, (void*)(&value));
		}
	}

	public unsafe static int ID_GlowOffset
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_ID_GlowOffset, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_ID_GlowOffset, (void*)(&value));
		}
	}

	public unsafe static int ID_GlowPower
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_ID_GlowPower, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_ID_GlowPower, (void*)(&value));
		}
	}

	public unsafe static int ID_GlowOuter
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_ID_GlowOuter, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_ID_GlowOuter, (void*)(&value));
		}
	}

	public unsafe static int ID_GlowInner
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_ID_GlowInner, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_ID_GlowInner, (void*)(&value));
		}
	}

	public unsafe static int ID_LightAngle
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_ID_LightAngle, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_ID_LightAngle, (void*)(&value));
		}
	}

	public unsafe static int ID_EnvMap
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_ID_EnvMap, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_ID_EnvMap, (void*)(&value));
		}
	}

	public unsafe static int ID_EnvMatrix
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_ID_EnvMatrix, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_ID_EnvMatrix, (void*)(&value));
		}
	}

	public unsafe static int ID_EnvMatrixRotation
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_ID_EnvMatrixRotation, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_ID_EnvMatrixRotation, (void*)(&value));
		}
	}

	public unsafe static int ID_MaskCoord
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_ID_MaskCoord, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_ID_MaskCoord, (void*)(&value));
		}
	}

	public unsafe static int ID_ClipRect
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_ID_ClipRect, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_ID_ClipRect, (void*)(&value));
		}
	}

	public unsafe static int ID_MaskSoftnessX
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_ID_MaskSoftnessX, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_ID_MaskSoftnessX, (void*)(&value));
		}
	}

	public unsafe static int ID_MaskSoftnessY
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_ID_MaskSoftnessY, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_ID_MaskSoftnessY, (void*)(&value));
		}
	}

	public unsafe static int ID_VertexOffsetX
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_ID_VertexOffsetX, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_ID_VertexOffsetX, (void*)(&value));
		}
	}

	public unsafe static int ID_VertexOffsetY
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_ID_VertexOffsetY, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_ID_VertexOffsetY, (void*)(&value));
		}
	}

	public unsafe static int ID_UseClipRect
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_ID_UseClipRect, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_ID_UseClipRect, (void*)(&value));
		}
	}

	public unsafe static int ID_StencilID
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_ID_StencilID, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_ID_StencilID, (void*)(&value));
		}
	}

	public unsafe static int ID_StencilOp
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_ID_StencilOp, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_ID_StencilOp, (void*)(&value));
		}
	}

	public unsafe static int ID_StencilComp
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_ID_StencilComp, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_ID_StencilComp, (void*)(&value));
		}
	}

	public unsafe static int ID_StencilReadMask
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_ID_StencilReadMask, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_ID_StencilReadMask, (void*)(&value));
		}
	}

	public unsafe static int ID_StencilWriteMask
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_ID_StencilWriteMask, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_ID_StencilWriteMask, (void*)(&value));
		}
	}

	public unsafe static int ID_ShaderFlags
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_ID_ShaderFlags, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_ID_ShaderFlags, (void*)(&value));
		}
	}

	public unsafe static int ID_ScaleRatio_A
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_ID_ScaleRatio_A, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_ID_ScaleRatio_A, (void*)(&value));
		}
	}

	public unsafe static int ID_ScaleRatio_B
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_ID_ScaleRatio_B, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_ID_ScaleRatio_B, (void*)(&value));
		}
	}

	public unsafe static int ID_ScaleRatio_C
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_ID_ScaleRatio_C, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_ID_ScaleRatio_C, (void*)(&value));
		}
	}

	public unsafe static string Keyword_Bevel
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_Keyword_Bevel, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_Keyword_Bevel, (void*)IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe static string Keyword_Glow
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_Keyword_Glow, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_Keyword_Glow, (void*)IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe static string Keyword_Underlay
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_Keyword_Underlay, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_Keyword_Underlay, (void*)IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe static string Keyword_Ratios
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_Keyword_Ratios, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_Keyword_Ratios, (void*)IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe static string Keyword_MASK_SOFT
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_Keyword_MASK_SOFT, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_Keyword_MASK_SOFT, (void*)IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe static string Keyword_MASK_HARD
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_Keyword_MASK_HARD, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_Keyword_MASK_HARD, (void*)IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe static string Keyword_MASK_TEX
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_Keyword_MASK_TEX, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_Keyword_MASK_TEX, (void*)IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe static string Keyword_Outline
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_Keyword_Outline, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_Keyword_Outline, (void*)IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe static string ShaderTag_ZTestMode
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_ShaderTag_ZTestMode, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_ShaderTag_ZTestMode, (void*)IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe static string ShaderTag_CullMode
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_ShaderTag_CullMode, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_ShaderTag_CullMode, (void*)IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe static float m_clamp
	{
		get
		{
			Unsafe.SkipInit(out float result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_m_clamp, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_m_clamp, (void*)(&value));
		}
	}

	public unsafe static bool isInitialized
	{
		get
		{
			Unsafe.SkipInit(out bool result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_isInitialized, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_isInitialized, (void*)(&value));
		}
	}

	public unsafe static Shader k_ShaderRef_MobileSDF
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_k_ShaderRef_MobileSDF, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Shader>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_k_ShaderRef_MobileSDF, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static Shader k_ShaderRef_MobileBitmap
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_k_ShaderRef_MobileBitmap, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Shader>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_k_ShaderRef_MobileBitmap, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static Shader ShaderRef_MobileSDF
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1129009, RefRangeEnd = 1129010, XrefRangeStart = 1128990, XrefRangeEnd = 1129009, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_ShaderRef_MobileSDF_Internal_Static_get_Shader_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Shader>(intPtr2) : null;
		}
	}

	public unsafe static Shader ShaderRef_MobileBitmap
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1129029, RefRangeEnd = 1129030, XrefRangeStart = 1129010, XrefRangeEnd = 1129029, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_ShaderRef_MobileBitmap_Internal_Static_get_Shader_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Shader>(intPtr2) : null;
		}
	}

	static ShaderUtilities()
	{
		Il2CppClassPointerStore<ShaderUtilities>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.TextMeshPro.dll", "TMPro", "ShaderUtilities");
		NativeFieldInfoPtr_ID_MainTex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderUtilities>.NativeClassPtr, "ID_MainTex");
		NativeFieldInfoPtr_ID_FaceTex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderUtilities>.NativeClassPtr, "ID_FaceTex");
		NativeFieldInfoPtr_ID_FaceColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderUtilities>.NativeClassPtr, "ID_FaceColor");
		NativeFieldInfoPtr_ID_FaceDilate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderUtilities>.NativeClassPtr, "ID_FaceDilate");
		NativeFieldInfoPtr_ID_Shininess = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderUtilities>.NativeClassPtr, "ID_Shininess");
		NativeFieldInfoPtr_ID_OutlineOffset1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderUtilities>.NativeClassPtr, "ID_OutlineOffset1");
		NativeFieldInfoPtr_ID_OutlineOffset2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderUtilities>.NativeClassPtr, "ID_OutlineOffset2");
		NativeFieldInfoPtr_ID_OutlineOffset3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderUtilities>.NativeClassPtr, "ID_OutlineOffset3");
		NativeFieldInfoPtr_ID_OutlineMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderUtilities>.NativeClassPtr, "ID_OutlineMode");
		NativeFieldInfoPtr_ID_IsoPerimeter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderUtilities>.NativeClassPtr, "ID_IsoPerimeter");
		NativeFieldInfoPtr_ID_Softness = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderUtilities>.NativeClassPtr, "ID_Softness");
		NativeFieldInfoPtr_ID_UnderlayColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderUtilities>.NativeClassPtr, "ID_UnderlayColor");
		NativeFieldInfoPtr_ID_UnderlayOffsetX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderUtilities>.NativeClassPtr, "ID_UnderlayOffsetX");
		NativeFieldInfoPtr_ID_UnderlayOffsetY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderUtilities>.NativeClassPtr, "ID_UnderlayOffsetY");
		NativeFieldInfoPtr_ID_UnderlayDilate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderUtilities>.NativeClassPtr, "ID_UnderlayDilate");
		NativeFieldInfoPtr_ID_UnderlaySoftness = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderUtilities>.NativeClassPtr, "ID_UnderlaySoftness");
		NativeFieldInfoPtr_ID_UnderlayOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderUtilities>.NativeClassPtr, "ID_UnderlayOffset");
		NativeFieldInfoPtr_ID_UnderlayIsoPerimeter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderUtilities>.NativeClassPtr, "ID_UnderlayIsoPerimeter");
		NativeFieldInfoPtr_ID_WeightNormal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderUtilities>.NativeClassPtr, "ID_WeightNormal");
		NativeFieldInfoPtr_ID_WeightBold = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderUtilities>.NativeClassPtr, "ID_WeightBold");
		NativeFieldInfoPtr_ID_OutlineTex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderUtilities>.NativeClassPtr, "ID_OutlineTex");
		NativeFieldInfoPtr_ID_OutlineWidth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderUtilities>.NativeClassPtr, "ID_OutlineWidth");
		NativeFieldInfoPtr_ID_OutlineSoftness = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderUtilities>.NativeClassPtr, "ID_OutlineSoftness");
		NativeFieldInfoPtr_ID_OutlineColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderUtilities>.NativeClassPtr, "ID_OutlineColor");
		NativeFieldInfoPtr_ID_Outline2Color = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderUtilities>.NativeClassPtr, "ID_Outline2Color");
		NativeFieldInfoPtr_ID_Outline2Width = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderUtilities>.NativeClassPtr, "ID_Outline2Width");
		NativeFieldInfoPtr_ID_Padding = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderUtilities>.NativeClassPtr, "ID_Padding");
		NativeFieldInfoPtr_ID_GradientScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderUtilities>.NativeClassPtr, "ID_GradientScale");
		NativeFieldInfoPtr_ID_ScaleX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderUtilities>.NativeClassPtr, "ID_ScaleX");
		NativeFieldInfoPtr_ID_ScaleY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderUtilities>.NativeClassPtr, "ID_ScaleY");
		NativeFieldInfoPtr_ID_PerspectiveFilter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderUtilities>.NativeClassPtr, "ID_PerspectiveFilter");
		NativeFieldInfoPtr_ID_Sharpness = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderUtilities>.NativeClassPtr, "ID_Sharpness");
		NativeFieldInfoPtr_ID_TextureWidth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderUtilities>.NativeClassPtr, "ID_TextureWidth");
		NativeFieldInfoPtr_ID_TextureHeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderUtilities>.NativeClassPtr, "ID_TextureHeight");
		NativeFieldInfoPtr_ID_BevelAmount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderUtilities>.NativeClassPtr, "ID_BevelAmount");
		NativeFieldInfoPtr_ID_GlowColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderUtilities>.NativeClassPtr, "ID_GlowColor");
		NativeFieldInfoPtr_ID_GlowOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderUtilities>.NativeClassPtr, "ID_GlowOffset");
		NativeFieldInfoPtr_ID_GlowPower = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderUtilities>.NativeClassPtr, "ID_GlowPower");
		NativeFieldInfoPtr_ID_GlowOuter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderUtilities>.NativeClassPtr, "ID_GlowOuter");
		NativeFieldInfoPtr_ID_GlowInner = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderUtilities>.NativeClassPtr, "ID_GlowInner");
		NativeFieldInfoPtr_ID_LightAngle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderUtilities>.NativeClassPtr, "ID_LightAngle");
		NativeFieldInfoPtr_ID_EnvMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderUtilities>.NativeClassPtr, "ID_EnvMap");
		NativeFieldInfoPtr_ID_EnvMatrix = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderUtilities>.NativeClassPtr, "ID_EnvMatrix");
		NativeFieldInfoPtr_ID_EnvMatrixRotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderUtilities>.NativeClassPtr, "ID_EnvMatrixRotation");
		NativeFieldInfoPtr_ID_MaskCoord = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderUtilities>.NativeClassPtr, "ID_MaskCoord");
		NativeFieldInfoPtr_ID_ClipRect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderUtilities>.NativeClassPtr, "ID_ClipRect");
		NativeFieldInfoPtr_ID_MaskSoftnessX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderUtilities>.NativeClassPtr, "ID_MaskSoftnessX");
		NativeFieldInfoPtr_ID_MaskSoftnessY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderUtilities>.NativeClassPtr, "ID_MaskSoftnessY");
		NativeFieldInfoPtr_ID_VertexOffsetX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderUtilities>.NativeClassPtr, "ID_VertexOffsetX");
		NativeFieldInfoPtr_ID_VertexOffsetY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderUtilities>.NativeClassPtr, "ID_VertexOffsetY");
		NativeFieldInfoPtr_ID_UseClipRect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderUtilities>.NativeClassPtr, "ID_UseClipRect");
		NativeFieldInfoPtr_ID_StencilID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderUtilities>.NativeClassPtr, "ID_StencilID");
		NativeFieldInfoPtr_ID_StencilOp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderUtilities>.NativeClassPtr, "ID_StencilOp");
		NativeFieldInfoPtr_ID_StencilComp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderUtilities>.NativeClassPtr, "ID_StencilComp");
		NativeFieldInfoPtr_ID_StencilReadMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderUtilities>.NativeClassPtr, "ID_StencilReadMask");
		NativeFieldInfoPtr_ID_StencilWriteMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderUtilities>.NativeClassPtr, "ID_StencilWriteMask");
		NativeFieldInfoPtr_ID_ShaderFlags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderUtilities>.NativeClassPtr, "ID_ShaderFlags");
		NativeFieldInfoPtr_ID_ScaleRatio_A = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderUtilities>.NativeClassPtr, "ID_ScaleRatio_A");
		NativeFieldInfoPtr_ID_ScaleRatio_B = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderUtilities>.NativeClassPtr, "ID_ScaleRatio_B");
		NativeFieldInfoPtr_ID_ScaleRatio_C = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderUtilities>.NativeClassPtr, "ID_ScaleRatio_C");
		NativeFieldInfoPtr_Keyword_Bevel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderUtilities>.NativeClassPtr, "Keyword_Bevel");
		NativeFieldInfoPtr_Keyword_Glow = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderUtilities>.NativeClassPtr, "Keyword_Glow");
		NativeFieldInfoPtr_Keyword_Underlay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderUtilities>.NativeClassPtr, "Keyword_Underlay");
		NativeFieldInfoPtr_Keyword_Ratios = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderUtilities>.NativeClassPtr, "Keyword_Ratios");
		NativeFieldInfoPtr_Keyword_MASK_SOFT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderUtilities>.NativeClassPtr, "Keyword_MASK_SOFT");
		NativeFieldInfoPtr_Keyword_MASK_HARD = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderUtilities>.NativeClassPtr, "Keyword_MASK_HARD");
		NativeFieldInfoPtr_Keyword_MASK_TEX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderUtilities>.NativeClassPtr, "Keyword_MASK_TEX");
		NativeFieldInfoPtr_Keyword_Outline = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderUtilities>.NativeClassPtr, "Keyword_Outline");
		NativeFieldInfoPtr_ShaderTag_ZTestMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderUtilities>.NativeClassPtr, "ShaderTag_ZTestMode");
		NativeFieldInfoPtr_ShaderTag_CullMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderUtilities>.NativeClassPtr, "ShaderTag_CullMode");
		NativeFieldInfoPtr_m_clamp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderUtilities>.NativeClassPtr, "m_clamp");
		NativeFieldInfoPtr_isInitialized = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderUtilities>.NativeClassPtr, "isInitialized");
		NativeFieldInfoPtr_k_ShaderRef_MobileSDF = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderUtilities>.NativeClassPtr, "k_ShaderRef_MobileSDF");
		NativeFieldInfoPtr_k_ShaderRef_MobileBitmap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderUtilities>.NativeClassPtr, "k_ShaderRef_MobileBitmap");
		NativeMethodInfoPtr_get_ShaderRef_MobileSDF_Internal_Static_get_Shader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShaderUtilities>.NativeClassPtr, 100664460);
		NativeMethodInfoPtr_get_ShaderRef_MobileBitmap_Internal_Static_get_Shader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShaderUtilities>.NativeClassPtr, 100664461);
		NativeMethodInfoPtr_GetShaderPropertyIDs_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShaderUtilities>.NativeClassPtr, 100664463);
		NativeMethodInfoPtr_UpdateShaderRatios_Public_Static_Void_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShaderUtilities>.NativeClassPtr, 100664464);
		NativeMethodInfoPtr_GetFontExtent_Public_Static_Vector4_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShaderUtilities>.NativeClassPtr, 100664465);
		NativeMethodInfoPtr_IsMaskingEnabled_Public_Static_Boolean_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShaderUtilities>.NativeClassPtr, 100664466);
		NativeMethodInfoPtr_GetPadding_Public_Static_Single_Material_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShaderUtilities>.NativeClassPtr, 100664467);
		NativeMethodInfoPtr_ComputePaddingForProperties_Private_Static_Single_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShaderUtilities>.NativeClassPtr, 100664468);
		NativeMethodInfoPtr_GetPadding_Public_Static_Single_Il2CppReferenceArray_1_Material_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShaderUtilities>.NativeClassPtr, 100664469);
	}

	[CallerCount(8)]
	[CachedScanResults(RefRangeStart = 1129303, RefRangeEnd = 1129311, XrefRangeStart = 1129030, XrefRangeEnd = 1129303, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void GetShaderPropertyIDs()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetShaderPropertyIDs_Public_Static_Void_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1129382, RefRangeEnd = 1129384, XrefRangeStart = 1129311, XrefRangeEnd = 1129382, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void UpdateShaderRatios(Material mat)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)mat);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UpdateShaderRatios_Public_Static_Void_Material_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1129384, XrefRangeEnd = 1129386, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Vector4 GetFontExtent(Material material)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)material);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetFontExtent_Public_Static_Vector4_Material_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(Vector4*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 1129414, RefRangeEnd = 1129419, XrefRangeStart = 1129386, XrefRangeEnd = 1129414, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool IsMaskingEnabled(Material material)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)material);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsMaskingEnabled_Public_Static_Boolean_Material_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(9)]
	[CachedScanResults(RefRangeStart = 1129548, RefRangeEnd = 1129557, XrefRangeStart = 1129419, XrefRangeEnd = 1129548, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static float GetPadding(Material material, bool enableExtraPadding, bool isBold)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)material);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &enableExtraPadding;
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &isBold;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetPadding_Public_Static_Single_Material_Boolean_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1129557, XrefRangeEnd = 1129583, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static float ComputePaddingForProperties(Material mat)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)mat);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ComputePaddingForProperties_Private_Static_Single_Material_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1129583, XrefRangeEnd = 1129688, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static float GetPadding(Il2CppReferenceArray<Material> materials, bool enableExtraPadding, bool isBold)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)materials);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &enableExtraPadding;
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &isBold;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetPadding_Public_Static_Single_Il2CppReferenceArray_1_Material_Boolean_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	public ShaderUtilities(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
