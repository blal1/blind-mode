using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem;

namespace UnityEngine.Rendering.Universal;

public static class PostProcessUtils : Il2CppSystem.Object
{
	public static class ShaderConstants : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr__Grain_Texture;

		private static readonly System.IntPtr NativeFieldInfoPtr__Grain_Params;

		private static readonly System.IntPtr NativeFieldInfoPtr__Grain_TilingParams;

		private static readonly System.IntPtr NativeFieldInfoPtr__BlueNoise_Texture;

		private static readonly System.IntPtr NativeFieldInfoPtr__Dithering_Params;

		private static readonly System.IntPtr NativeFieldInfoPtr__SourceSize;

		public unsafe static int _Grain_Texture
		{
			get
			{
				Unsafe.SkipInit(out int result);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr__Grain_Texture, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr__Grain_Texture, (void*)(&value));
			}
		}

		public unsafe static int _Grain_Params
		{
			get
			{
				Unsafe.SkipInit(out int result);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr__Grain_Params, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr__Grain_Params, (void*)(&value));
			}
		}

		public unsafe static int _Grain_TilingParams
		{
			get
			{
				Unsafe.SkipInit(out int result);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr__Grain_TilingParams, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr__Grain_TilingParams, (void*)(&value));
			}
		}

		public unsafe static int _BlueNoise_Texture
		{
			get
			{
				Unsafe.SkipInit(out int result);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr__BlueNoise_Texture, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr__BlueNoise_Texture, (void*)(&value));
			}
		}

		public unsafe static int _Dithering_Params
		{
			get
			{
				Unsafe.SkipInit(out int result);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr__Dithering_Params, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr__Dithering_Params, (void*)(&value));
			}
		}

		public unsafe static int _SourceSize
		{
			get
			{
				Unsafe.SkipInit(out int result);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr__SourceSize, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr__SourceSize, (void*)(&value));
			}
		}

		static ShaderConstants()
		{
			Il2CppClassPointerStore<ShaderConstants>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PostProcessUtils>.NativeClassPtr, "ShaderConstants");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ShaderConstants>.NativeClassPtr);
			NativeFieldInfoPtr__Grain_Texture = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderConstants>.NativeClassPtr, "_Grain_Texture");
			NativeFieldInfoPtr__Grain_Params = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderConstants>.NativeClassPtr, "_Grain_Params");
			NativeFieldInfoPtr__Grain_TilingParams = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderConstants>.NativeClassPtr, "_Grain_TilingParams");
			NativeFieldInfoPtr__BlueNoise_Texture = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderConstants>.NativeClassPtr, "_BlueNoise_Texture");
			NativeFieldInfoPtr__Dithering_Params = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderConstants>.NativeClassPtr, "_Dithering_Params");
			NativeFieldInfoPtr__SourceSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderConstants>.NativeClassPtr, "_SourceSize");
		}

		public ShaderConstants(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	private static readonly System.IntPtr NativeMethodInfoPtr_ConfigureDithering_Public_Static_Int32_PostProcessData_Int32_Camera_Material_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ConfigureDithering_Public_Static_Int32_PostProcessData_Int32_Int32_Int32_Material_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ConfigureFilmGrain_Public_Static_Void_PostProcessData_FilmGrain_Camera_Material_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ConfigureFilmGrain_Public_Static_Void_PostProcessData_FilmGrain_Int32_Int32_Material_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetSourceSize_Internal_Static_Void_RasterCommandBuffer_RTHandle_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetSourceSize_Internal_Static_Void_CommandBuffer_RTHandle_0;

	static PostProcessUtils()
	{
		Il2CppClassPointerStore<PostProcessUtils>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Universal.Runtime.dll", "UnityEngine.Rendering.Universal", "PostProcessUtils");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PostProcessUtils>.NativeClassPtr);
		NativeMethodInfoPtr_ConfigureDithering_Public_Static_Int32_PostProcessData_Int32_Camera_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PostProcessUtils>.NativeClassPtr, 100665167);
		NativeMethodInfoPtr_ConfigureDithering_Public_Static_Int32_PostProcessData_Int32_Int32_Int32_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PostProcessUtils>.NativeClassPtr, 100665168);
		NativeMethodInfoPtr_ConfigureFilmGrain_Public_Static_Void_PostProcessData_FilmGrain_Camera_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PostProcessUtils>.NativeClassPtr, 100665169);
		NativeMethodInfoPtr_ConfigureFilmGrain_Public_Static_Void_PostProcessData_FilmGrain_Int32_Int32_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PostProcessUtils>.NativeClassPtr, 100665170);
		NativeMethodInfoPtr_SetSourceSize_Internal_Static_Void_RasterCommandBuffer_RTHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PostProcessUtils>.NativeClassPtr, 100665171);
		NativeMethodInfoPtr_SetSourceSize_Internal_Static_Void_CommandBuffer_RTHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PostProcessUtils>.NativeClassPtr, 100665172);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1096081, XrefRangeEnd = 1096084, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int ConfigureDithering(PostProcessData data, int index, Camera camera, Material material)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)data);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &index;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)camera);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)material);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ConfigureDithering_Public_Static_Int32_PostProcessData_Int32_Camera_Material_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(6)]
	[CachedScanResults(RefRangeStart = 1096097, RefRangeEnd = 1096103, XrefRangeStart = 1096084, XrefRangeEnd = 1096097, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int ConfigureDithering(PostProcessData data, int index, int cameraPixelWidth, int cameraPixelHeight, Material material)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)data);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &index;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &cameraPixelWidth;
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &cameraPixelHeight;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)material);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ConfigureDithering_Public_Static_Int32_PostProcessData_Int32_Int32_Int32_Material_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1096103, XrefRangeEnd = 1096106, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void ConfigureFilmGrain(PostProcessData data, FilmGrain settings, Camera camera, Material material)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)data);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)settings);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)camera);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)material);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ConfigureFilmGrain_Public_Static_Void_PostProcessData_FilmGrain_Camera_Material_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(6)]
	[CachedScanResults(RefRangeStart = 1096128, RefRangeEnd = 1096134, XrefRangeStart = 1096106, XrefRangeEnd = 1096128, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void ConfigureFilmGrain(PostProcessData data, FilmGrain settings, int cameraPixelWidth, int cameraPixelHeight, Material material)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)data);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)settings);
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &cameraPixelWidth;
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &cameraPixelHeight;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)material);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ConfigureFilmGrain_Public_Static_Void_PostProcessData_FilmGrain_Int32_Int32_Material_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(8)]
	[CachedScanResults(RefRangeStart = 1096142, RefRangeEnd = 1096150, XrefRangeStart = 1096134, XrefRangeEnd = 1096142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SetSourceSize(RasterCommandBuffer cmd, RTHandle source)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)cmd);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)source);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetSourceSize_Internal_Static_Void_RasterCommandBuffer_RTHandle_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 1096155, RefRangeEnd = 1096160, XrefRangeStart = 1096150, XrefRangeEnd = 1096155, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SetSourceSize(CommandBuffer cmd, RTHandle source)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)cmd);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)source);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetSourceSize_Internal_Static_Void_CommandBuffer_RTHandle_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public PostProcessUtils(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
