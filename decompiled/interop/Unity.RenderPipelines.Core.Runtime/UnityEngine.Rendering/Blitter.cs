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

namespace UnityEngine.Rendering;

public static class Blitter : Il2CppSystem.Object
{
	public static class BlitShaderIDs : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr__BlitTexture;

		private static readonly System.IntPtr NativeFieldInfoPtr__BlitCubeTexture;

		private static readonly System.IntPtr NativeFieldInfoPtr__BlitScaleBias;

		private static readonly System.IntPtr NativeFieldInfoPtr__BlitScaleBiasRt;

		private static readonly System.IntPtr NativeFieldInfoPtr__BlitMipLevel;

		private static readonly System.IntPtr NativeFieldInfoPtr__BlitTexArraySlice;

		private static readonly System.IntPtr NativeFieldInfoPtr__BlitTextureSize;

		private static readonly System.IntPtr NativeFieldInfoPtr__BlitPaddingSize;

		private static readonly System.IntPtr NativeFieldInfoPtr__BlitDecodeInstructions;

		private static readonly System.IntPtr NativeFieldInfoPtr__InputDepth;

		public unsafe static int _BlitTexture
		{
			get
			{
				Unsafe.SkipInit(out int result);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr__BlitTexture, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr__BlitTexture, (void*)(&value));
			}
		}

		public unsafe static int _BlitCubeTexture
		{
			get
			{
				Unsafe.SkipInit(out int result);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr__BlitCubeTexture, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr__BlitCubeTexture, (void*)(&value));
			}
		}

		public unsafe static int _BlitScaleBias
		{
			get
			{
				Unsafe.SkipInit(out int result);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr__BlitScaleBias, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr__BlitScaleBias, (void*)(&value));
			}
		}

		public unsafe static int _BlitScaleBiasRt
		{
			get
			{
				Unsafe.SkipInit(out int result);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr__BlitScaleBiasRt, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr__BlitScaleBiasRt, (void*)(&value));
			}
		}

		public unsafe static int _BlitMipLevel
		{
			get
			{
				Unsafe.SkipInit(out int result);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr__BlitMipLevel, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr__BlitMipLevel, (void*)(&value));
			}
		}

		public unsafe static int _BlitTexArraySlice
		{
			get
			{
				Unsafe.SkipInit(out int result);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr__BlitTexArraySlice, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr__BlitTexArraySlice, (void*)(&value));
			}
		}

		public unsafe static int _BlitTextureSize
		{
			get
			{
				Unsafe.SkipInit(out int result);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr__BlitTextureSize, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr__BlitTextureSize, (void*)(&value));
			}
		}

		public unsafe static int _BlitPaddingSize
		{
			get
			{
				Unsafe.SkipInit(out int result);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr__BlitPaddingSize, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr__BlitPaddingSize, (void*)(&value));
			}
		}

		public unsafe static int _BlitDecodeInstructions
		{
			get
			{
				Unsafe.SkipInit(out int result);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr__BlitDecodeInstructions, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr__BlitDecodeInstructions, (void*)(&value));
			}
		}

		public unsafe static int _InputDepth
		{
			get
			{
				Unsafe.SkipInit(out int result);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr__InputDepth, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr__InputDepth, (void*)(&value));
			}
		}

		static BlitShaderIDs()
		{
			Il2CppClassPointerStore<BlitShaderIDs>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Blitter>.NativeClassPtr, "BlitShaderIDs");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BlitShaderIDs>.NativeClassPtr);
			NativeFieldInfoPtr__BlitTexture = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlitShaderIDs>.NativeClassPtr, "_BlitTexture");
			NativeFieldInfoPtr__BlitCubeTexture = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlitShaderIDs>.NativeClassPtr, "_BlitCubeTexture");
			NativeFieldInfoPtr__BlitScaleBias = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlitShaderIDs>.NativeClassPtr, "_BlitScaleBias");
			NativeFieldInfoPtr__BlitScaleBiasRt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlitShaderIDs>.NativeClassPtr, "_BlitScaleBiasRt");
			NativeFieldInfoPtr__BlitMipLevel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlitShaderIDs>.NativeClassPtr, "_BlitMipLevel");
			NativeFieldInfoPtr__BlitTexArraySlice = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlitShaderIDs>.NativeClassPtr, "_BlitTexArraySlice");
			NativeFieldInfoPtr__BlitTextureSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlitShaderIDs>.NativeClassPtr, "_BlitTextureSize");
			NativeFieldInfoPtr__BlitPaddingSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlitShaderIDs>.NativeClassPtr, "_BlitPaddingSize");
			NativeFieldInfoPtr__BlitDecodeInstructions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlitShaderIDs>.NativeClassPtr, "_BlitDecodeInstructions");
			NativeFieldInfoPtr__InputDepth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlitShaderIDs>.NativeClassPtr, "_InputDepth");
		}

		public BlitShaderIDs(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	[OriginalName("Unity.RenderPipelines.Core.Runtime.dll", "", "BlitShaderPassNames")]
	public enum BlitShaderPassNames
	{
		Nearest,
		Bilinear,
		NearestQuad,
		BilinearQuad,
		NearestQuadPadding,
		BilinearQuadPadding,
		NearestQuadPaddingRepeat,
		BilinearQuadPaddingRepeat,
		BilinearQuadPaddingOctahedral,
		NearestQuadPaddingAlphaBlend,
		BilinearQuadPaddingAlphaBlend,
		NearestQuadPaddingAlphaBlendRepeat,
		BilinearQuadPaddingAlphaBlendRepeat,
		BilinearQuadPaddingAlphaBlendOctahedral,
		CubeToOctahedral,
		CubeToOctahedralLuminance,
		CubeToOctahedralAlpha,
		CubeToOctahedralRed,
		BilinearQuadLuminance,
		BilinearQuadAlpha,
		BilinearQuadRed,
		NearestCubeToOctahedralPadding,
		BilinearCubeToOctahedralPadding
	}

	[OriginalName("Unity.RenderPipelines.Core.Runtime.dll", "", "BlitColorAndDepthPassNames")]
	public enum BlitColorAndDepthPassNames
	{
		ColorOnly,
		ColorAndDepth
	}

	private static readonly System.IntPtr NativeFieldInfoPtr_s_Copy;

	private static readonly System.IntPtr NativeFieldInfoPtr_s_Blit;

	private static readonly System.IntPtr NativeFieldInfoPtr_s_BlitTexArray;

	private static readonly System.IntPtr NativeFieldInfoPtr_s_BlitTexArraySingleSlice;

	private static readonly System.IntPtr NativeFieldInfoPtr_s_BlitColorAndDepth;

	private static readonly System.IntPtr NativeFieldInfoPtr_s_PropertyBlock;

	private static readonly System.IntPtr NativeFieldInfoPtr_s_TriangleMesh;

	private static readonly System.IntPtr NativeFieldInfoPtr_s_QuadMesh;

	private static readonly System.IntPtr NativeFieldInfoPtr_s_DecodeHdrKeyword;

	private static readonly System.IntPtr NativeFieldInfoPtr_s_BlitShaderPassIndicesMap;

	private static readonly System.IntPtr NativeFieldInfoPtr_s_BlitColorAndDepthShaderPassIndicesMap;

	private static readonly System.IntPtr NativeMethodInfoPtr_Initialize_Public_Static_Void_Shader_Shader_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Cleanup_Public_Static_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetBlitMaterial_Public_Static_Material_TextureDimension_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DrawTriangle_Internal_Static_Void_RasterCommandBuffer_Material_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DrawTriangle_Internal_Static_Void_CommandBuffer_Material_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DrawTriangle_Internal_Static_Void_CommandBuffer_Material_Int32_MaterialPropertyBlock_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DrawQuadMesh_Internal_Static_Void_CommandBuffer_Material_Int32_MaterialPropertyBlock_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DrawQuad_Internal_Static_Void_RasterCommandBuffer_Material_Int32_MaterialPropertyBlock_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DrawQuad_Internal_Static_Void_CommandBuffer_Material_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DrawQuad_Internal_Static_Void_CommandBuffer_Material_Int32_MaterialPropertyBlock_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CanCopyMSAA_Internal_Static_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CanCopyMSAA_Internal_Static_Boolean_byref_TextureDesc_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CopyTexture_Internal_Static_Void_RasterCommandBuffer_Boolean_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_BlitTexture_Internal_Static_Void_CommandBuffer_RTHandle_Vector4_Single_Int32_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_BlitTexture_Internal_Static_Void_CommandBuffer_RTHandle_Vector4_Material_Int32_Single_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_BlitTexture_Public_Static_Void_RasterCommandBuffer_RTHandle_Vector4_Single_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_BlitTexture_Public_Static_Void_CommandBuffer_RTHandle_Vector4_Single_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_BlitTexture2D_Public_Static_Void_RasterCommandBuffer_RTHandle_Vector4_Single_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_BlitTexture2D_Public_Static_Void_CommandBuffer_RTHandle_Vector4_Single_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_BlitColorAndDepth_Public_Static_Void_RasterCommandBuffer_Texture_RenderTexture_Vector4_Single_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_BlitColorAndDepth_Public_Static_Void_CommandBuffer_Texture_RenderTexture_Vector4_Single_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_BlitTexture_Public_Static_Void_RasterCommandBuffer_RTHandle_Vector4_Material_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_BlitTexture_Public_Static_Void_CommandBuffer_RTHandle_Vector4_Material_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_BlitTexture_Public_Static_Void_RasterCommandBuffer_RenderTargetIdentifier_Vector4_Material_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_BlitTexture_Public_Static_Void_CommandBuffer_RenderTargetIdentifier_Vector4_Material_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_BlitTexture_Public_Static_Void_CommandBuffer_RenderTargetIdentifier_RenderTargetIdentifier_Material_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_BlitTexture_Public_Static_Void_CommandBuffer_RenderTargetIdentifier_RenderTargetIdentifier_RenderBufferLoadAction_RenderBufferStoreAction_Material_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_BlitTexture_Public_Static_Void_CommandBuffer_Vector4_Material_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_BlitTexture_Public_Static_Void_RasterCommandBuffer_Vector4_Material_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_BlitCameraTexture_Public_Static_Void_CommandBuffer_RTHandle_RTHandle_Single_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_BlitCameraTexture2D_Public_Static_Void_CommandBuffer_RTHandle_RTHandle_Single_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_BlitCameraTexture_Public_Static_Void_CommandBuffer_RTHandle_RTHandle_Material_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_BlitCameraTexture_Public_Static_Void_CommandBuffer_RTHandle_RTHandle_RenderBufferLoadAction_RenderBufferStoreAction_Material_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_BlitCameraTexture_Public_Static_Void_CommandBuffer_RTHandle_RTHandle_Vector4_Single_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_BlitCameraTexture_Public_Static_Void_CommandBuffer_RTHandle_RTHandle_Rect_Single_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_BlitQuad_Public_Static_Void_CommandBuffer_Texture_Vector4_Vector4_Int32_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_BlitQuadWithPadding_Public_Static_Void_CommandBuffer_Texture_Vector2_Vector4_Vector4_Int32_Boolean_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_BlitQuadWithPaddingMultiply_Public_Static_Void_CommandBuffer_Texture_Vector2_Vector4_Vector4_Int32_Boolean_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_BlitOctahedralWithPadding_Public_Static_Void_CommandBuffer_Texture_Vector2_Vector4_Vector4_Int32_Boolean_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_BlitOctahedralWithPaddingMultiply_Public_Static_Void_CommandBuffer_Texture_Vector2_Vector4_Vector4_Int32_Boolean_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_BlitCubeToOctahedral2DQuad_Public_Static_Void_CommandBuffer_Texture_Vector4_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_BlitCubeToOctahedral2DQuadWithPadding_Public_Static_Void_CommandBuffer_Texture_Vector2_Vector4_Int32_Boolean_Int32_Nullable_1_Vector4_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_BlitCubeToOctahedral2DQuadSingleChannel_Public_Static_Void_CommandBuffer_Texture_Vector4_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_BlitQuadSingleChannel_Public_Static_Void_CommandBuffer_Texture_Vector4_Vector4_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Method_Internal_Static_Il2CppStructArray_1_Vector3_Single_PDM_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Method_Internal_Static_Il2CppStructArray_1_Vector2_PDM_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Method_Internal_Static_Il2CppStructArray_1_Vector3_Single_PDM_1;

	private static readonly System.IntPtr NativeMethodInfoPtr_Method_Internal_Static_Il2CppStructArray_1_Vector2_PDM_1;

	public unsafe static Material s_Copy
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_s_Copy, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_s_Copy, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static Material s_Blit
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_s_Blit, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_s_Blit, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static Material s_BlitTexArray
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_s_BlitTexArray, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_s_BlitTexArray, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static Material s_BlitTexArraySingleSlice
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_s_BlitTexArraySingleSlice, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_s_BlitTexArraySingleSlice, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static Material s_BlitColorAndDepth
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_s_BlitColorAndDepth, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_s_BlitColorAndDepth, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static MaterialPropertyBlock s_PropertyBlock
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_s_PropertyBlock, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<MaterialPropertyBlock>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_s_PropertyBlock, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static Mesh s_TriangleMesh
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_s_TriangleMesh, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Mesh>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_s_TriangleMesh, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static Mesh s_QuadMesh
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_s_QuadMesh, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Mesh>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_s_QuadMesh, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static LocalKeyword s_DecodeHdrKeyword
	{
		get
		{
			System.IntPtr intPtr = (nint)stackalloc byte[(int)(uint)IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<LocalKeyword>.NativeClassPtr, ref *(uint*)null)];
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_s_DecodeHdrKeyword, (void*)intPtr);
			return new LocalKeyword(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<LocalKeyword>.NativeClassPtr, intPtr));
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_s_DecodeHdrKeyword, (void*)IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)value)));
		}
	}

	public unsafe static Il2CppStructArray<int> s_BlitShaderPassIndicesMap
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_s_BlitShaderPassIndicesMap, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_s_BlitShaderPassIndicesMap, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static Il2CppStructArray<int> s_BlitColorAndDepthShaderPassIndicesMap
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_s_BlitColorAndDepthShaderPassIndicesMap, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_s_BlitColorAndDepthShaderPassIndicesMap, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	static Blitter()
	{
		Il2CppClassPointerStore<Blitter>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Core.Runtime.dll", "UnityEngine.Rendering", "Blitter");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Blitter>.NativeClassPtr);
		NativeFieldInfoPtr_s_Copy = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Blitter>.NativeClassPtr, "s_Copy");
		NativeFieldInfoPtr_s_Blit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Blitter>.NativeClassPtr, "s_Blit");
		NativeFieldInfoPtr_s_BlitTexArray = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Blitter>.NativeClassPtr, "s_BlitTexArray");
		NativeFieldInfoPtr_s_BlitTexArraySingleSlice = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Blitter>.NativeClassPtr, "s_BlitTexArraySingleSlice");
		NativeFieldInfoPtr_s_BlitColorAndDepth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Blitter>.NativeClassPtr, "s_BlitColorAndDepth");
		NativeFieldInfoPtr_s_PropertyBlock = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Blitter>.NativeClassPtr, "s_PropertyBlock");
		NativeFieldInfoPtr_s_TriangleMesh = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Blitter>.NativeClassPtr, "s_TriangleMesh");
		NativeFieldInfoPtr_s_QuadMesh = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Blitter>.NativeClassPtr, "s_QuadMesh");
		NativeFieldInfoPtr_s_DecodeHdrKeyword = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Blitter>.NativeClassPtr, "s_DecodeHdrKeyword");
		NativeFieldInfoPtr_s_BlitShaderPassIndicesMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Blitter>.NativeClassPtr, "s_BlitShaderPassIndicesMap");
		NativeFieldInfoPtr_s_BlitColorAndDepthShaderPassIndicesMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Blitter>.NativeClassPtr, "s_BlitColorAndDepthShaderPassIndicesMap");
		NativeMethodInfoPtr_Initialize_Public_Static_Void_Shader_Shader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Blitter>.NativeClassPtr, 100666496);
		NativeMethodInfoPtr_Cleanup_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Blitter>.NativeClassPtr, 100666497);
		NativeMethodInfoPtr_GetBlitMaterial_Public_Static_Material_TextureDimension_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Blitter>.NativeClassPtr, 100666498);
		NativeMethodInfoPtr_DrawTriangle_Internal_Static_Void_RasterCommandBuffer_Material_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Blitter>.NativeClassPtr, 100666499);
		NativeMethodInfoPtr_DrawTriangle_Internal_Static_Void_CommandBuffer_Material_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Blitter>.NativeClassPtr, 100666500);
		NativeMethodInfoPtr_DrawTriangle_Internal_Static_Void_CommandBuffer_Material_Int32_MaterialPropertyBlock_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Blitter>.NativeClassPtr, 100666501);
		NativeMethodInfoPtr_DrawQuadMesh_Internal_Static_Void_CommandBuffer_Material_Int32_MaterialPropertyBlock_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Blitter>.NativeClassPtr, 100666502);
		NativeMethodInfoPtr_DrawQuad_Internal_Static_Void_RasterCommandBuffer_Material_Int32_MaterialPropertyBlock_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Blitter>.NativeClassPtr, 100666503);
		NativeMethodInfoPtr_DrawQuad_Internal_Static_Void_CommandBuffer_Material_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Blitter>.NativeClassPtr, 100666504);
		NativeMethodInfoPtr_DrawQuad_Internal_Static_Void_CommandBuffer_Material_Int32_MaterialPropertyBlock_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Blitter>.NativeClassPtr, 100666505);
		NativeMethodInfoPtr_CanCopyMSAA_Internal_Static_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Blitter>.NativeClassPtr, 100666506);
		NativeMethodInfoPtr_CanCopyMSAA_Internal_Static_Boolean_byref_TextureDesc_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Blitter>.NativeClassPtr, 100666507);
		NativeMethodInfoPtr_CopyTexture_Internal_Static_Void_RasterCommandBuffer_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Blitter>.NativeClassPtr, 100666508);
		NativeMethodInfoPtr_BlitTexture_Internal_Static_Void_CommandBuffer_RTHandle_Vector4_Single_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Blitter>.NativeClassPtr, 100666509);
		NativeMethodInfoPtr_BlitTexture_Internal_Static_Void_CommandBuffer_RTHandle_Vector4_Material_Int32_Single_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Blitter>.NativeClassPtr, 100666510);
		NativeMethodInfoPtr_BlitTexture_Public_Static_Void_RasterCommandBuffer_RTHandle_Vector4_Single_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Blitter>.NativeClassPtr, 100666511);
		NativeMethodInfoPtr_BlitTexture_Public_Static_Void_CommandBuffer_RTHandle_Vector4_Single_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Blitter>.NativeClassPtr, 100666512);
		NativeMethodInfoPtr_BlitTexture2D_Public_Static_Void_RasterCommandBuffer_RTHandle_Vector4_Single_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Blitter>.NativeClassPtr, 100666513);
		NativeMethodInfoPtr_BlitTexture2D_Public_Static_Void_CommandBuffer_RTHandle_Vector4_Single_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Blitter>.NativeClassPtr, 100666514);
		NativeMethodInfoPtr_BlitColorAndDepth_Public_Static_Void_RasterCommandBuffer_Texture_RenderTexture_Vector4_Single_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Blitter>.NativeClassPtr, 100666515);
		NativeMethodInfoPtr_BlitColorAndDepth_Public_Static_Void_CommandBuffer_Texture_RenderTexture_Vector4_Single_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Blitter>.NativeClassPtr, 100666516);
		NativeMethodInfoPtr_BlitTexture_Public_Static_Void_RasterCommandBuffer_RTHandle_Vector4_Material_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Blitter>.NativeClassPtr, 100666517);
		NativeMethodInfoPtr_BlitTexture_Public_Static_Void_CommandBuffer_RTHandle_Vector4_Material_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Blitter>.NativeClassPtr, 100666518);
		NativeMethodInfoPtr_BlitTexture_Public_Static_Void_RasterCommandBuffer_RenderTargetIdentifier_Vector4_Material_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Blitter>.NativeClassPtr, 100666519);
		NativeMethodInfoPtr_BlitTexture_Public_Static_Void_CommandBuffer_RenderTargetIdentifier_Vector4_Material_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Blitter>.NativeClassPtr, 100666520);
		NativeMethodInfoPtr_BlitTexture_Public_Static_Void_CommandBuffer_RenderTargetIdentifier_RenderTargetIdentifier_Material_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Blitter>.NativeClassPtr, 100666521);
		NativeMethodInfoPtr_BlitTexture_Public_Static_Void_CommandBuffer_RenderTargetIdentifier_RenderTargetIdentifier_RenderBufferLoadAction_RenderBufferStoreAction_Material_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Blitter>.NativeClassPtr, 100666522);
		NativeMethodInfoPtr_BlitTexture_Public_Static_Void_CommandBuffer_Vector4_Material_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Blitter>.NativeClassPtr, 100666523);
		NativeMethodInfoPtr_BlitTexture_Public_Static_Void_RasterCommandBuffer_Vector4_Material_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Blitter>.NativeClassPtr, 100666524);
		NativeMethodInfoPtr_BlitCameraTexture_Public_Static_Void_CommandBuffer_RTHandle_RTHandle_Single_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Blitter>.NativeClassPtr, 100666525);
		NativeMethodInfoPtr_BlitCameraTexture2D_Public_Static_Void_CommandBuffer_RTHandle_RTHandle_Single_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Blitter>.NativeClassPtr, 100666526);
		NativeMethodInfoPtr_BlitCameraTexture_Public_Static_Void_CommandBuffer_RTHandle_RTHandle_Material_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Blitter>.NativeClassPtr, 100666527);
		NativeMethodInfoPtr_BlitCameraTexture_Public_Static_Void_CommandBuffer_RTHandle_RTHandle_RenderBufferLoadAction_RenderBufferStoreAction_Material_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Blitter>.NativeClassPtr, 100666528);
		NativeMethodInfoPtr_BlitCameraTexture_Public_Static_Void_CommandBuffer_RTHandle_RTHandle_Vector4_Single_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Blitter>.NativeClassPtr, 100666529);
		NativeMethodInfoPtr_BlitCameraTexture_Public_Static_Void_CommandBuffer_RTHandle_RTHandle_Rect_Single_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Blitter>.NativeClassPtr, 100666530);
		NativeMethodInfoPtr_BlitQuad_Public_Static_Void_CommandBuffer_Texture_Vector4_Vector4_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Blitter>.NativeClassPtr, 100666531);
		NativeMethodInfoPtr_BlitQuadWithPadding_Public_Static_Void_CommandBuffer_Texture_Vector2_Vector4_Vector4_Int32_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Blitter>.NativeClassPtr, 100666532);
		NativeMethodInfoPtr_BlitQuadWithPaddingMultiply_Public_Static_Void_CommandBuffer_Texture_Vector2_Vector4_Vector4_Int32_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Blitter>.NativeClassPtr, 100666533);
		NativeMethodInfoPtr_BlitOctahedralWithPadding_Public_Static_Void_CommandBuffer_Texture_Vector2_Vector4_Vector4_Int32_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Blitter>.NativeClassPtr, 100666534);
		NativeMethodInfoPtr_BlitOctahedralWithPaddingMultiply_Public_Static_Void_CommandBuffer_Texture_Vector2_Vector4_Vector4_Int32_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Blitter>.NativeClassPtr, 100666535);
		NativeMethodInfoPtr_BlitCubeToOctahedral2DQuad_Public_Static_Void_CommandBuffer_Texture_Vector4_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Blitter>.NativeClassPtr, 100666536);
		NativeMethodInfoPtr_BlitCubeToOctahedral2DQuadWithPadding_Public_Static_Void_CommandBuffer_Texture_Vector2_Vector4_Int32_Boolean_Int32_Nullable_1_Vector4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Blitter>.NativeClassPtr, 100666537);
		NativeMethodInfoPtr_BlitCubeToOctahedral2DQuadSingleChannel_Public_Static_Void_CommandBuffer_Texture_Vector4_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Blitter>.NativeClassPtr, 100666538);
		NativeMethodInfoPtr_BlitQuadSingleChannel_Public_Static_Void_CommandBuffer_Texture_Vector4_Vector4_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Blitter>.NativeClassPtr, 100666539);
		NativeMethodInfoPtr_Method_Internal_Static_Il2CppStructArray_1_Vector3_Single_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Blitter>.NativeClassPtr, 100666541);
		NativeMethodInfoPtr_Method_Internal_Static_Il2CppStructArray_1_Vector2_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Blitter>.NativeClassPtr, 100666542);
		NativeMethodInfoPtr_Method_Internal_Static_Il2CppStructArray_1_Vector3_Single_PDM_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Blitter>.NativeClassPtr, 100666543);
		NativeMethodInfoPtr_Method_Internal_Static_Il2CppStructArray_1_Vector2_PDM_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Blitter>.NativeClassPtr, 100666544);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1050512, RefRangeEnd = 1050513, XrefRangeStart = 1050344, XrefRangeEnd = 1050512, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void Initialize(Shader blitPS, Shader blitColorAndDepthPS)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)blitPS);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)blitColorAndDepthPS);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Initialize_Public_Static_Void_Shader_Shader_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1050554, RefRangeEnd = 1050555, XrefRangeStart = 1050513, XrefRangeEnd = 1050554, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void Cleanup()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Cleanup_Public_Static_Void_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(14)]
	[CachedScanResults(RefRangeStart = 1050570, RefRangeEnd = 1050584, XrefRangeStart = 1050555, XrefRangeEnd = 1050570, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Material GetBlitMaterial(TextureDimension dimension, bool singleSlice = false)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&dimension);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &singleSlice;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetBlitMaterial_Public_Static_Material_TextureDimension_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1050584, XrefRangeEnd = 1050589, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void DrawTriangle(RasterCommandBuffer cmd, Material material, int shaderPass)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)cmd);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)material);
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &shaderPass;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DrawTriangle_Internal_Static_Void_RasterCommandBuffer_Material_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(10)]
	[CachedScanResults(RefRangeStart = 1050598, RefRangeEnd = 1050608, XrefRangeStart = 1050589, XrefRangeEnd = 1050598, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void DrawTriangle(CommandBuffer cmd, Material material, int shaderPass)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)cmd);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)material);
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &shaderPass;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DrawTriangle_Internal_Static_Void_CommandBuffer_Material_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1050613, RefRangeEnd = 1050614, XrefRangeStart = 1050608, XrefRangeEnd = 1050613, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void DrawTriangle(CommandBuffer cmd, Material material, int shaderPass, MaterialPropertyBlock propertyBlock)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)cmd);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)material);
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &shaderPass;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)propertyBlock);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DrawTriangle_Internal_Static_Void_CommandBuffer_Material_Int32_MaterialPropertyBlock_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1050621, RefRangeEnd = 1050622, XrefRangeStart = 1050614, XrefRangeEnd = 1050621, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void DrawQuadMesh(CommandBuffer cmd, Material material, int shaderPass, MaterialPropertyBlock propertyBlock)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)cmd);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)material);
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &shaderPass;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)propertyBlock);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DrawQuadMesh_Internal_Static_Void_CommandBuffer_Material_Int32_MaterialPropertyBlock_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1050622, XrefRangeEnd = 1050627, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void DrawQuad(RasterCommandBuffer cmd, Material material, int shaderPass, MaterialPropertyBlock propertyBlock)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)cmd);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)material);
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &shaderPass;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)propertyBlock);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DrawQuad_Internal_Static_Void_RasterCommandBuffer_Material_Int32_MaterialPropertyBlock_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(15)]
	[CachedScanResults(RefRangeStart = 1050632, RefRangeEnd = 1050647, XrefRangeStart = 1050627, XrefRangeEnd = 1050632, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void DrawQuad(CommandBuffer cmd, Material material, int shaderPass)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)cmd);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)material);
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &shaderPass;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DrawQuad_Internal_Static_Void_CommandBuffer_Material_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 1050652, RefRangeEnd = 1050656, XrefRangeStart = 1050647, XrefRangeEnd = 1050652, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void DrawQuad(CommandBuffer cmd, Material material, int shaderPass, MaterialPropertyBlock propertyBlock)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)cmd);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)material);
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &shaderPass;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)propertyBlock);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DrawQuad_Internal_Static_Void_CommandBuffer_Material_Int32_MaterialPropertyBlock_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1050662, RefRangeEnd = 1050663, XrefRangeStart = 1050656, XrefRangeEnd = 1050662, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool CanCopyMSAA()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CanCopyMSAA_Internal_Static_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1050677, RefRangeEnd = 1050679, XrefRangeStart = 1050663, XrefRangeEnd = 1050677, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool CanCopyMSAA([In] ref TextureDesc sourceDesc)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)sourceDesc);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CanCopyMSAA_Internal_Static_Boolean_byref_TextureDesc_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1050694, RefRangeEnd = 1050696, XrefRangeStart = 1050679, XrefRangeEnd = 1050694, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void CopyTexture(RasterCommandBuffer cmd, bool isMSAA, bool force2DForXR = false)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)cmd);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &isMSAA;
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &force2DForXR;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CopyTexture_Internal_Static_Void_RasterCommandBuffer_Boolean_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1050723, RefRangeEnd = 1050724, XrefRangeStart = 1050696, XrefRangeEnd = 1050723, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void BlitTexture(CommandBuffer cmd, RTHandle source, Vector4 scaleBias, float sourceMipLevel, int sourceDepthSlice, bool bilinear)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[6];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)cmd);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)source);
		*(Vector4**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &scaleBias;
		*(float**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &sourceMipLevel;
		*(int**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &sourceDepthSlice;
		*(bool**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = &bilinear;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_BlitTexture_Internal_Static_Void_CommandBuffer_RTHandle_Vector4_Single_Int32_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1050724, XrefRangeEnd = 1050737, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void BlitTexture(CommandBuffer cmd, RTHandle source, Vector4 scaleBias, Material material, int pass, float sourceMipLevel, int sourceDepthSlice)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[7];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)cmd);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)source);
		*(Vector4**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &scaleBias;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)material);
		*(int**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &pass;
		*(float**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = &sourceMipLevel;
		*(int**)((byte*)ptr + checked((nuint)6u * unchecked((nuint)sizeof(System.IntPtr)))) = &sourceDepthSlice;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_BlitTexture_Internal_Static_Void_CommandBuffer_RTHandle_Vector4_Material_Int32_Single_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1050741, RefRangeEnd = 1050743, XrefRangeStart = 1050737, XrefRangeEnd = 1050741, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void BlitTexture(RasterCommandBuffer cmd, RTHandle source, Vector4 scaleBias, float mipLevel, bool bilinear)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)cmd);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)source);
		*(Vector4**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &scaleBias;
		*(float**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &mipLevel;
		*(bool**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &bilinear;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_BlitTexture_Public_Static_Void_RasterCommandBuffer_RTHandle_Vector4_Single_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 1050765, RefRangeEnd = 1050770, XrefRangeStart = 1050743, XrefRangeEnd = 1050765, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void BlitTexture(CommandBuffer cmd, RTHandle source, Vector4 scaleBias, float mipLevel, bool bilinear)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)cmd);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)source);
		*(Vector4**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &scaleBias;
		*(float**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &mipLevel;
		*(bool**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &bilinear;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_BlitTexture_Public_Static_Void_CommandBuffer_RTHandle_Vector4_Single_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1050770, XrefRangeEnd = 1050774, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void BlitTexture2D(RasterCommandBuffer cmd, RTHandle source, Vector4 scaleBias, float mipLevel, bool bilinear)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)cmd);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)source);
		*(Vector4**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &scaleBias;
		*(float**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &mipLevel;
		*(bool**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &bilinear;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_BlitTexture2D_Public_Static_Void_RasterCommandBuffer_RTHandle_Vector4_Single_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1050794, RefRangeEnd = 1050796, XrefRangeStart = 1050774, XrefRangeEnd = 1050794, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void BlitTexture2D(CommandBuffer cmd, RTHandle source, Vector4 scaleBias, float mipLevel, bool bilinear)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)cmd);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)source);
		*(Vector4**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &scaleBias;
		*(float**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &mipLevel;
		*(bool**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &bilinear;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_BlitTexture2D_Public_Static_Void_CommandBuffer_RTHandle_Vector4_Single_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1050796, XrefRangeEnd = 1050800, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void BlitColorAndDepth(RasterCommandBuffer cmd, Texture sourceColor, RenderTexture sourceDepth, Vector4 scaleBias, float mipLevel, bool blitDepth)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[6];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)cmd);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)sourceColor);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)sourceDepth);
		*(Vector4**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &scaleBias;
		*(float**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &mipLevel;
		*(bool**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = &blitDepth;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_BlitColorAndDepth_Public_Static_Void_RasterCommandBuffer_Texture_RenderTexture_Vector4_Single_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1050829, RefRangeEnd = 1050830, XrefRangeStart = 1050800, XrefRangeEnd = 1050829, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void BlitColorAndDepth(CommandBuffer cmd, Texture sourceColor, RenderTexture sourceDepth, Vector4 scaleBias, float mipLevel, bool blitDepth)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[6];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)cmd);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)sourceColor);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)sourceDepth);
		*(Vector4**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &scaleBias;
		*(float**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &mipLevel;
		*(bool**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = &blitDepth;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_BlitColorAndDepth_Public_Static_Void_CommandBuffer_Texture_RenderTexture_Vector4_Single_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(20)]
	[CachedScanResults(RefRangeStart = 1050834, RefRangeEnd = 1050854, XrefRangeStart = 1050830, XrefRangeEnd = 1050834, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void BlitTexture(RasterCommandBuffer cmd, RTHandle source, Vector4 scaleBias, Material material, int pass)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)cmd);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)source);
		*(Vector4**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &scaleBias;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)material);
		*(int**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &pass;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_BlitTexture_Public_Static_Void_RasterCommandBuffer_RTHandle_Vector4_Material_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(14)]
	[CachedScanResults(RefRangeStart = 1050874, RefRangeEnd = 1050888, XrefRangeStart = 1050854, XrefRangeEnd = 1050874, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void BlitTexture(CommandBuffer cmd, RTHandle source, Vector4 scaleBias, Material material, int pass)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)cmd);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)source);
		*(Vector4**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &scaleBias;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)material);
		*(int**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &pass;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_BlitTexture_Public_Static_Void_CommandBuffer_RTHandle_Vector4_Material_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1050888, XrefRangeEnd = 1050906, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void BlitTexture(RasterCommandBuffer cmd, RenderTargetIdentifier source, Vector4 scaleBias, Material material, int pass)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)cmd);
		*(RenderTargetIdentifier**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &source;
		*(Vector4**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &scaleBias;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)material);
		*(int**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &pass;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_BlitTexture_Public_Static_Void_RasterCommandBuffer_RenderTargetIdentifier_Vector4_Material_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1050906, XrefRangeEnd = 1050921, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void BlitTexture(CommandBuffer cmd, RenderTargetIdentifier source, Vector4 scaleBias, Material material, int pass)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)cmd);
		*(RenderTargetIdentifier**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &source;
		*(Vector4**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &scaleBias;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)material);
		*(int**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &pass;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_BlitTexture_Public_Static_Void_CommandBuffer_RenderTargetIdentifier_Vector4_Material_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1050921, XrefRangeEnd = 1050939, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void BlitTexture(CommandBuffer cmd, RenderTargetIdentifier source, RenderTargetIdentifier destination, Material material, int pass)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)cmd);
		*(RenderTargetIdentifier**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &source;
		*(RenderTargetIdentifier**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &destination;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)material);
		*(int**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &pass;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_BlitTexture_Public_Static_Void_CommandBuffer_RenderTargetIdentifier_RenderTargetIdentifier_Material_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1050939, XrefRangeEnd = 1050957, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void BlitTexture(CommandBuffer cmd, RenderTargetIdentifier source, RenderTargetIdentifier destination, RenderBufferLoadAction loadAction, RenderBufferStoreAction storeAction, Material material, int pass)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[7];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)cmd);
		*(RenderTargetIdentifier**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &source;
		*(RenderTargetIdentifier**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &destination;
		*(RenderBufferLoadAction**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &loadAction;
		*(RenderBufferStoreAction**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &storeAction;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)material);
		*(int**)((byte*)ptr + checked((nuint)6u * unchecked((nuint)sizeof(System.IntPtr)))) = &pass;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_BlitTexture_Public_Static_Void_CommandBuffer_RenderTargetIdentifier_RenderTargetIdentifier_RenderBufferLoadAction_RenderBufferStoreAction_Material_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1050957, XrefRangeEnd = 1050968, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void BlitTexture(CommandBuffer cmd, Vector4 scaleBias, Material material, int pass)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)cmd);
		*(Vector4**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &scaleBias;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)material);
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &pass;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_BlitTexture_Public_Static_Void_CommandBuffer_Vector4_Material_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1050968, XrefRangeEnd = 1050982, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void BlitTexture(RasterCommandBuffer cmd, Vector4 scaleBias, Material material, int pass)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)cmd);
		*(Vector4**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &scaleBias;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)material);
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &pass;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_BlitTexture_Public_Static_Void_RasterCommandBuffer_Vector4_Material_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1050995, RefRangeEnd = 1050996, XrefRangeStart = 1050982, XrefRangeEnd = 1050995, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void BlitCameraTexture(CommandBuffer cmd, RTHandle source, RTHandle destination, float mipLevel = 0f, bool bilinear = false)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)cmd);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)source);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)destination);
		*(float**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &mipLevel;
		*(bool**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &bilinear;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_BlitCameraTexture_Public_Static_Void_CommandBuffer_RTHandle_RTHandle_Single_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1050996, XrefRangeEnd = 1051009, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void BlitCameraTexture2D(CommandBuffer cmd, RTHandle source, RTHandle destination, float mipLevel = 0f, bool bilinear = false)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)cmd);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)source);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)destination);
		*(float**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &mipLevel;
		*(bool**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &bilinear;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_BlitCameraTexture2D_Public_Static_Void_CommandBuffer_RTHandle_RTHandle_Single_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(11)]
	[CachedScanResults(RefRangeStart = 1051022, RefRangeEnd = 1051033, XrefRangeStart = 1051009, XrefRangeEnd = 1051022, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void BlitCameraTexture(CommandBuffer cmd, RTHandle source, RTHandle destination, Material material, int pass)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)cmd);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)source);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)destination);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)material);
		*(int**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &pass;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_BlitCameraTexture_Public_Static_Void_CommandBuffer_RTHandle_RTHandle_Material_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(34)]
	[CachedScanResults(RefRangeStart = 1051046, RefRangeEnd = 1051080, XrefRangeStart = 1051033, XrefRangeEnd = 1051046, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void BlitCameraTexture(CommandBuffer cmd, RTHandle source, RTHandle destination, RenderBufferLoadAction loadAction, RenderBufferStoreAction storeAction, Material material, int pass)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[7];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)cmd);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)source);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)destination);
		*(RenderBufferLoadAction**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &loadAction;
		*(RenderBufferStoreAction**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &storeAction;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)material);
		*(int**)((byte*)ptr + checked((nuint)6u * unchecked((nuint)sizeof(System.IntPtr)))) = &pass;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_BlitCameraTexture_Public_Static_Void_CommandBuffer_RTHandle_RTHandle_RenderBufferLoadAction_RenderBufferStoreAction_Material_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1051080, XrefRangeEnd = 1051088, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void BlitCameraTexture(CommandBuffer cmd, RTHandle source, RTHandle destination, Vector4 scaleBias, float mipLevel = 0f, bool bilinear = false)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[6];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)cmd);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)source);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)destination);
		*(Vector4**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &scaleBias;
		*(float**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &mipLevel;
		*(bool**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = &bilinear;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_BlitCameraTexture_Public_Static_Void_CommandBuffer_RTHandle_RTHandle_Vector4_Single_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1051088, XrefRangeEnd = 1051102, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void BlitCameraTexture(CommandBuffer cmd, RTHandle source, RTHandle destination, Rect destViewport, float mipLevel = 0f, bool bilinear = false)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[6];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)cmd);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)source);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)destination);
		*(Rect**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &destViewport;
		*(float**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &mipLevel;
		*(bool**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = &bilinear;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_BlitCameraTexture_Public_Static_Void_CommandBuffer_RTHandle_RTHandle_Rect_Single_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1051126, RefRangeEnd = 1051128, XrefRangeStart = 1051102, XrefRangeEnd = 1051126, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void BlitQuad(CommandBuffer cmd, Texture source, Vector4 scaleBiasTex, Vector4 scaleBiasRT, int mipLevelTex, bool bilinear)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[6];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)cmd);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)source);
		*(Vector4**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &scaleBiasTex;
		*(Vector4**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &scaleBiasRT;
		*(int**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &mipLevelTex;
		*(bool**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = &bilinear;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_BlitQuad_Public_Static_Void_CommandBuffer_Texture_Vector4_Vector4_Int32_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1051166, RefRangeEnd = 1051167, XrefRangeStart = 1051128, XrefRangeEnd = 1051166, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void BlitQuadWithPadding(CommandBuffer cmd, Texture source, Vector2 textureSize, Vector4 scaleBiasTex, Vector4 scaleBiasRT, int mipLevelTex, bool bilinear, int paddingInPixels)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[8];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)cmd);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)source);
		*(Vector2**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &textureSize;
		*(Vector4**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &scaleBiasTex;
		*(Vector4**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &scaleBiasRT;
		*(int**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = &mipLevelTex;
		*(bool**)((byte*)ptr + checked((nuint)6u * unchecked((nuint)sizeof(System.IntPtr)))) = &bilinear;
		*(int**)((byte*)ptr + checked((nuint)7u * unchecked((nuint)sizeof(System.IntPtr)))) = &paddingInPixels;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_BlitQuadWithPadding_Public_Static_Void_CommandBuffer_Texture_Vector2_Vector4_Vector4_Int32_Boolean_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1051205, RefRangeEnd = 1051206, XrefRangeStart = 1051167, XrefRangeEnd = 1051205, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void BlitQuadWithPaddingMultiply(CommandBuffer cmd, Texture source, Vector2 textureSize, Vector4 scaleBiasTex, Vector4 scaleBiasRT, int mipLevelTex, bool bilinear, int paddingInPixels)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[8];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)cmd);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)source);
		*(Vector2**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &textureSize;
		*(Vector4**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &scaleBiasTex;
		*(Vector4**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &scaleBiasRT;
		*(int**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = &mipLevelTex;
		*(bool**)((byte*)ptr + checked((nuint)6u * unchecked((nuint)sizeof(System.IntPtr)))) = &bilinear;
		*(int**)((byte*)ptr + checked((nuint)7u * unchecked((nuint)sizeof(System.IntPtr)))) = &paddingInPixels;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_BlitQuadWithPaddingMultiply_Public_Static_Void_CommandBuffer_Texture_Vector2_Vector4_Vector4_Int32_Boolean_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1051235, RefRangeEnd = 1051236, XrefRangeStart = 1051206, XrefRangeEnd = 1051235, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void BlitOctahedralWithPadding(CommandBuffer cmd, Texture source, Vector2 textureSize, Vector4 scaleBiasTex, Vector4 scaleBiasRT, int mipLevelTex, bool bilinear, int paddingInPixels)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[8];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)cmd);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)source);
		*(Vector2**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &textureSize;
		*(Vector4**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &scaleBiasTex;
		*(Vector4**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &scaleBiasRT;
		*(int**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = &mipLevelTex;
		*(bool**)((byte*)ptr + checked((nuint)6u * unchecked((nuint)sizeof(System.IntPtr)))) = &bilinear;
		*(int**)((byte*)ptr + checked((nuint)7u * unchecked((nuint)sizeof(System.IntPtr)))) = &paddingInPixels;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_BlitOctahedralWithPadding_Public_Static_Void_CommandBuffer_Texture_Vector2_Vector4_Vector4_Int32_Boolean_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1051265, RefRangeEnd = 1051266, XrefRangeStart = 1051236, XrefRangeEnd = 1051265, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void BlitOctahedralWithPaddingMultiply(CommandBuffer cmd, Texture source, Vector2 textureSize, Vector4 scaleBiasTex, Vector4 scaleBiasRT, int mipLevelTex, bool bilinear, int paddingInPixels)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[8];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)cmd);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)source);
		*(Vector2**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &textureSize;
		*(Vector4**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &scaleBiasTex;
		*(Vector4**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &scaleBiasRT;
		*(int**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = &mipLevelTex;
		*(bool**)((byte*)ptr + checked((nuint)6u * unchecked((nuint)sizeof(System.IntPtr)))) = &bilinear;
		*(int**)((byte*)ptr + checked((nuint)7u * unchecked((nuint)sizeof(System.IntPtr)))) = &paddingInPixels;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_BlitOctahedralWithPaddingMultiply_Public_Static_Void_CommandBuffer_Texture_Vector2_Vector4_Vector4_Int32_Boolean_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1051289, RefRangeEnd = 1051290, XrefRangeStart = 1051266, XrefRangeEnd = 1051289, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void BlitCubeToOctahedral2DQuad(CommandBuffer cmd, Texture source, Vector4 scaleBiasRT, int mipLevelTex)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)cmd);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)source);
		*(Vector4**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &scaleBiasRT;
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &mipLevelTex;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_BlitCubeToOctahedral2DQuad_Public_Static_Void_CommandBuffer_Texture_Vector4_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1051335, RefRangeEnd = 1051336, XrefRangeStart = 1051290, XrefRangeEnd = 1051335, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void BlitCubeToOctahedral2DQuadWithPadding(CommandBuffer cmd, Texture source, Vector2 textureSize, Vector4 scaleBiasRT, int mipLevelTex, bool bilinear, int paddingInPixels, Il2CppSystem.Nullable<Vector4> decodeInstructions = null)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[8];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)cmd);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)source);
		*(Vector2**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &textureSize;
		*(Vector4**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &scaleBiasRT;
		*(int**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &mipLevelTex;
		*(bool**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = &bilinear;
		*(int**)((byte*)ptr + checked((nuint)6u * unchecked((nuint)sizeof(System.IntPtr)))) = &paddingInPixels;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)7u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)decodeInstructions));
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_BlitCubeToOctahedral2DQuadWithPadding_Public_Static_Void_CommandBuffer_Texture_Vector2_Vector4_Int32_Boolean_Int32_Nullable_1_Vector4_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1051369, RefRangeEnd = 1051370, XrefRangeStart = 1051336, XrefRangeEnd = 1051369, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void BlitCubeToOctahedral2DQuadSingleChannel(CommandBuffer cmd, Texture source, Vector4 scaleBiasRT, int mipLevelTex)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)cmd);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)source);
		*(Vector4**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &scaleBiasRT;
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &mipLevelTex;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_BlitCubeToOctahedral2DQuadSingleChannel_Public_Static_Void_CommandBuffer_Texture_Vector4_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1051403, RefRangeEnd = 1051404, XrefRangeStart = 1051370, XrefRangeEnd = 1051403, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void BlitQuadSingleChannel(CommandBuffer cmd, Texture source, Vector4 scaleBiasTex, Vector4 scaleBiasRT, int mipLevelTex)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)cmd);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)source);
		*(Vector4**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &scaleBiasTex;
		*(Vector4**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &scaleBiasRT;
		*(int**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &mipLevelTex;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_BlitQuadSingleChannel_Public_Static_Void_CommandBuffer_Texture_Vector4_Vector4_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1051404, XrefRangeEnd = 1051407, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Il2CppStructArray<Vector3> Method_Internal_Static_Il2CppStructArray_1_Vector3_Single_PDM_0(float z)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&z);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Method_Internal_Static_Il2CppStructArray_1_Vector3_Single_PDM_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<Vector3>>(intPtr2) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1051407, XrefRangeEnd = 1051412, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Il2CppStructArray<Vector2> Method_Internal_Static_Il2CppStructArray_1_Vector2_PDM_0()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Method_Internal_Static_Il2CppStructArray_1_Vector2_PDM_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<Vector2>>(intPtr2) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1051412, XrefRangeEnd = 1051415, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Il2CppStructArray<Vector3> Method_Internal_Static_Il2CppStructArray_1_Vector3_Single_PDM_1(float z)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&z);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Method_Internal_Static_Il2CppStructArray_1_Vector3_Single_PDM_1, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<Vector3>>(intPtr2) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1051415, XrefRangeEnd = 1051419, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Il2CppStructArray<Vector2> Method_Internal_Static_Il2CppStructArray_1_Vector2_PDM_1()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Method_Internal_Static_Il2CppStructArray_1_Vector2_PDM_1, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<Vector2>>(intPtr2) : null;
	}

	public Blitter(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
