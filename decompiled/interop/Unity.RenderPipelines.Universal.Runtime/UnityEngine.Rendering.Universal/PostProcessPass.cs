using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine.Experimental.Rendering;
using UnityEngine.Rendering.RenderGraphModule;

namespace UnityEngine.Rendering.Universal;

public class PostProcessPass : ScriptableRenderPass
{
	public class MaterialLibrary : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_stopNaN;

		private static readonly System.IntPtr NativeFieldInfoPtr_subpixelMorphologicalAntialiasing;

		private static readonly System.IntPtr NativeFieldInfoPtr_gaussianDepthOfField;

		private static readonly System.IntPtr NativeFieldInfoPtr_gaussianDepthOfFieldCoC;

		private static readonly System.IntPtr NativeFieldInfoPtr_bokehDepthOfField;

		private static readonly System.IntPtr NativeFieldInfoPtr_bokehDepthOfFieldCoC;

		private static readonly System.IntPtr NativeFieldInfoPtr_cameraMotionBlur;

		private static readonly System.IntPtr NativeFieldInfoPtr_paniniProjection;

		private static readonly System.IntPtr NativeFieldInfoPtr_bloom;

		private static readonly System.IntPtr NativeFieldInfoPtr_bloomUpsample;

		private static readonly System.IntPtr NativeFieldInfoPtr_temporalAntialiasing;

		private static readonly System.IntPtr NativeFieldInfoPtr_scalingSetup;

		private static readonly System.IntPtr NativeFieldInfoPtr_easu;

		private static readonly System.IntPtr NativeFieldInfoPtr_uber;

		private static readonly System.IntPtr NativeFieldInfoPtr_finalPass;

		private static readonly System.IntPtr NativeFieldInfoPtr_lensFlareDataDriven;

		private static readonly System.IntPtr NativeFieldInfoPtr_lensFlareScreenSpace;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_PostProcessData_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_Load_Private_Material_Shader_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_Cleanup_Internal_Void_0;

		public unsafe Material stopNaN
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_stopNaN);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Material>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_stopNaN)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		public unsafe Material subpixelMorphologicalAntialiasing
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_subpixelMorphologicalAntialiasing);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Material>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_subpixelMorphologicalAntialiasing)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		public unsafe Material gaussianDepthOfField
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_gaussianDepthOfField);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Material>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_gaussianDepthOfField)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		public unsafe Material gaussianDepthOfFieldCoC
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_gaussianDepthOfFieldCoC);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Material>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_gaussianDepthOfFieldCoC)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		public unsafe Material bokehDepthOfField
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_bokehDepthOfField);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Material>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_bokehDepthOfField)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		public unsafe Material bokehDepthOfFieldCoC
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_bokehDepthOfFieldCoC);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Material>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_bokehDepthOfFieldCoC)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		public unsafe Material cameraMotionBlur
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cameraMotionBlur);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Material>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cameraMotionBlur)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		public unsafe Material paniniProjection
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_paniniProjection);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Material>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_paniniProjection)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		public unsafe Material bloom
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_bloom);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Material>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_bloom)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		public unsafe Il2CppReferenceArray<Material> bloomUpsample
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_bloomUpsample);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Material>>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_bloomUpsample)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		public unsafe Material temporalAntialiasing
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_temporalAntialiasing);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Material>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_temporalAntialiasing)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		public unsafe Material scalingSetup
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_scalingSetup);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Material>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_scalingSetup)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		public unsafe Material easu
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_easu);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Material>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_easu)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		public unsafe Material uber
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_uber);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Material>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_uber)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		public unsafe Material finalPass
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_finalPass);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Material>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_finalPass)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		public unsafe Material lensFlareDataDriven
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lensFlareDataDriven);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Material>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lensFlareDataDriven)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		public unsafe Material lensFlareScreenSpace
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lensFlareScreenSpace);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Material>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lensFlareScreenSpace)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		static MaterialLibrary()
		{
			Il2CppClassPointerStore<MaterialLibrary>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PostProcessPass>.NativeClassPtr, "MaterialLibrary");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MaterialLibrary>.NativeClassPtr);
			NativeFieldInfoPtr_stopNaN = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaterialLibrary>.NativeClassPtr, "stopNaN");
			NativeFieldInfoPtr_subpixelMorphologicalAntialiasing = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaterialLibrary>.NativeClassPtr, "subpixelMorphologicalAntialiasing");
			NativeFieldInfoPtr_gaussianDepthOfField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaterialLibrary>.NativeClassPtr, "gaussianDepthOfField");
			NativeFieldInfoPtr_gaussianDepthOfFieldCoC = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaterialLibrary>.NativeClassPtr, "gaussianDepthOfFieldCoC");
			NativeFieldInfoPtr_bokehDepthOfField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaterialLibrary>.NativeClassPtr, "bokehDepthOfField");
			NativeFieldInfoPtr_bokehDepthOfFieldCoC = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaterialLibrary>.NativeClassPtr, "bokehDepthOfFieldCoC");
			NativeFieldInfoPtr_cameraMotionBlur = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaterialLibrary>.NativeClassPtr, "cameraMotionBlur");
			NativeFieldInfoPtr_paniniProjection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaterialLibrary>.NativeClassPtr, "paniniProjection");
			NativeFieldInfoPtr_bloom = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaterialLibrary>.NativeClassPtr, "bloom");
			NativeFieldInfoPtr_bloomUpsample = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaterialLibrary>.NativeClassPtr, "bloomUpsample");
			NativeFieldInfoPtr_temporalAntialiasing = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaterialLibrary>.NativeClassPtr, "temporalAntialiasing");
			NativeFieldInfoPtr_scalingSetup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaterialLibrary>.NativeClassPtr, "scalingSetup");
			NativeFieldInfoPtr_easu = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaterialLibrary>.NativeClassPtr, "easu");
			NativeFieldInfoPtr_uber = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaterialLibrary>.NativeClassPtr, "uber");
			NativeFieldInfoPtr_finalPass = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaterialLibrary>.NativeClassPtr, "finalPass");
			NativeFieldInfoPtr_lensFlareDataDriven = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaterialLibrary>.NativeClassPtr, "lensFlareDataDriven");
			NativeFieldInfoPtr_lensFlareScreenSpace = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaterialLibrary>.NativeClassPtr, "lensFlareScreenSpace");
			NativeMethodInfoPtr__ctor_Public_Void_PostProcessData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialLibrary>.NativeClassPtr, 100665029);
			NativeMethodInfoPtr_Load_Private_Material_Shader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialLibrary>.NativeClassPtr, 100665030);
			NativeMethodInfoPtr_Cleanup_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialLibrary>.NativeClassPtr, 100665031);
		}

		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1090974, RefRangeEnd = 1090975, XrefRangeStart = 1090934, XrefRangeEnd = 1090974, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MaterialLibrary(PostProcessData data)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MaterialLibrary>.NativeClassPtr))
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)data);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_PostProcessData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		[CallerCount(17)]
		[CachedScanResults(RefRangeStart = 1090996, RefRangeEnd = 1091013, XrefRangeStart = 1090975, XrefRangeEnd = 1090996, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Material Load(Shader shader)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)shader);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Load_Private_Material_Shader_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1091013, XrefRangeEnd = 1091035, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Cleanup()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Cleanup_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		public MaterialLibrary(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	public static class ShaderConstants : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr__TempTarget;

		private static readonly System.IntPtr NativeFieldInfoPtr__TempTarget2;

		private static readonly System.IntPtr NativeFieldInfoPtr__StencilRef;

		private static readonly System.IntPtr NativeFieldInfoPtr__StencilMask;

		private static readonly System.IntPtr NativeFieldInfoPtr__FullCoCTexture;

		private static readonly System.IntPtr NativeFieldInfoPtr__HalfCoCTexture;

		private static readonly System.IntPtr NativeFieldInfoPtr__DofTexture;

		private static readonly System.IntPtr NativeFieldInfoPtr__CoCParams;

		private static readonly System.IntPtr NativeFieldInfoPtr__BokehKernel;

		private static readonly System.IntPtr NativeFieldInfoPtr__BokehConstants;

		private static readonly System.IntPtr NativeFieldInfoPtr__PongTexture;

		private static readonly System.IntPtr NativeFieldInfoPtr__PingTexture;

		private static readonly System.IntPtr NativeFieldInfoPtr__Metrics;

		private static readonly System.IntPtr NativeFieldInfoPtr__AreaTexture;

		private static readonly System.IntPtr NativeFieldInfoPtr__SearchTexture;

		private static readonly System.IntPtr NativeFieldInfoPtr__EdgeTexture;

		private static readonly System.IntPtr NativeFieldInfoPtr__BlendTexture;

		private static readonly System.IntPtr NativeFieldInfoPtr__ColorTexture;

		private static readonly System.IntPtr NativeFieldInfoPtr__Params;

		private static readonly System.IntPtr NativeFieldInfoPtr__SourceTexLowMip;

		private static readonly System.IntPtr NativeFieldInfoPtr__Bloom_Params;

		private static readonly System.IntPtr NativeFieldInfoPtr__Bloom_Texture;

		private static readonly System.IntPtr NativeFieldInfoPtr__LensDirt_Texture;

		private static readonly System.IntPtr NativeFieldInfoPtr__LensDirt_Params;

		private static readonly System.IntPtr NativeFieldInfoPtr__LensDirt_Intensity;

		private static readonly System.IntPtr NativeFieldInfoPtr__Distortion_Params1;

		private static readonly System.IntPtr NativeFieldInfoPtr__Distortion_Params2;

		private static readonly System.IntPtr NativeFieldInfoPtr__Chroma_Params;

		private static readonly System.IntPtr NativeFieldInfoPtr__Vignette_Params1;

		private static readonly System.IntPtr NativeFieldInfoPtr__Vignette_Params2;

		private static readonly System.IntPtr NativeFieldInfoPtr__Vignette_ParamsXR;

		private static readonly System.IntPtr NativeFieldInfoPtr__Lut_Params;

		private static readonly System.IntPtr NativeFieldInfoPtr__UserLut_Params;

		private static readonly System.IntPtr NativeFieldInfoPtr__InternalLut;

		private static readonly System.IntPtr NativeFieldInfoPtr__UserLut;

		private static readonly System.IntPtr NativeFieldInfoPtr__DownSampleScaleFactor;

		private static readonly System.IntPtr NativeFieldInfoPtr__FlareOcclusionRemapTex;

		private static readonly System.IntPtr NativeFieldInfoPtr__FlareOcclusionTex;

		private static readonly System.IntPtr NativeFieldInfoPtr__FlareOcclusionIndex;

		private static readonly System.IntPtr NativeFieldInfoPtr__FlareTex;

		private static readonly System.IntPtr NativeFieldInfoPtr__FlareColorValue;

		private static readonly System.IntPtr NativeFieldInfoPtr__FlareData0;

		private static readonly System.IntPtr NativeFieldInfoPtr__FlareData1;

		private static readonly System.IntPtr NativeFieldInfoPtr__FlareData2;

		private static readonly System.IntPtr NativeFieldInfoPtr__FlareData3;

		private static readonly System.IntPtr NativeFieldInfoPtr__FlareData4;

		private static readonly System.IntPtr NativeFieldInfoPtr__FlareData5;

		private static readonly System.IntPtr NativeFieldInfoPtr__FullscreenProjMat;

		private static readonly System.IntPtr NativeFieldInfoPtr__BloomMipUp;

		private static readonly System.IntPtr NativeFieldInfoPtr__BloomMipDown;

		public unsafe static int _TempTarget
		{
			get
			{
				Unsafe.SkipInit(out int result);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr__TempTarget, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr__TempTarget, (void*)(&value));
			}
		}

		public unsafe static int _TempTarget2
		{
			get
			{
				Unsafe.SkipInit(out int result);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr__TempTarget2, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr__TempTarget2, (void*)(&value));
			}
		}

		public unsafe static int _StencilRef
		{
			get
			{
				Unsafe.SkipInit(out int result);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr__StencilRef, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr__StencilRef, (void*)(&value));
			}
		}

		public unsafe static int _StencilMask
		{
			get
			{
				Unsafe.SkipInit(out int result);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr__StencilMask, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr__StencilMask, (void*)(&value));
			}
		}

		public unsafe static int _FullCoCTexture
		{
			get
			{
				Unsafe.SkipInit(out int result);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr__FullCoCTexture, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr__FullCoCTexture, (void*)(&value));
			}
		}

		public unsafe static int _HalfCoCTexture
		{
			get
			{
				Unsafe.SkipInit(out int result);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr__HalfCoCTexture, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr__HalfCoCTexture, (void*)(&value));
			}
		}

		public unsafe static int _DofTexture
		{
			get
			{
				Unsafe.SkipInit(out int result);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr__DofTexture, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr__DofTexture, (void*)(&value));
			}
		}

		public unsafe static int _CoCParams
		{
			get
			{
				Unsafe.SkipInit(out int result);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr__CoCParams, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr__CoCParams, (void*)(&value));
			}
		}

		public unsafe static int _BokehKernel
		{
			get
			{
				Unsafe.SkipInit(out int result);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr__BokehKernel, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr__BokehKernel, (void*)(&value));
			}
		}

		public unsafe static int _BokehConstants
		{
			get
			{
				Unsafe.SkipInit(out int result);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr__BokehConstants, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr__BokehConstants, (void*)(&value));
			}
		}

		public unsafe static int _PongTexture
		{
			get
			{
				Unsafe.SkipInit(out int result);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr__PongTexture, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr__PongTexture, (void*)(&value));
			}
		}

		public unsafe static int _PingTexture
		{
			get
			{
				Unsafe.SkipInit(out int result);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr__PingTexture, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr__PingTexture, (void*)(&value));
			}
		}

		public unsafe static int _Metrics
		{
			get
			{
				Unsafe.SkipInit(out int result);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr__Metrics, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr__Metrics, (void*)(&value));
			}
		}

		public unsafe static int _AreaTexture
		{
			get
			{
				Unsafe.SkipInit(out int result);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr__AreaTexture, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr__AreaTexture, (void*)(&value));
			}
		}

		public unsafe static int _SearchTexture
		{
			get
			{
				Unsafe.SkipInit(out int result);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr__SearchTexture, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr__SearchTexture, (void*)(&value));
			}
		}

		public unsafe static int _EdgeTexture
		{
			get
			{
				Unsafe.SkipInit(out int result);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr__EdgeTexture, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr__EdgeTexture, (void*)(&value));
			}
		}

		public unsafe static int _BlendTexture
		{
			get
			{
				Unsafe.SkipInit(out int result);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr__BlendTexture, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr__BlendTexture, (void*)(&value));
			}
		}

		public unsafe static int _ColorTexture
		{
			get
			{
				Unsafe.SkipInit(out int result);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr__ColorTexture, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr__ColorTexture, (void*)(&value));
			}
		}

		public unsafe static int _Params
		{
			get
			{
				Unsafe.SkipInit(out int result);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr__Params, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr__Params, (void*)(&value));
			}
		}

		public unsafe static int _SourceTexLowMip
		{
			get
			{
				Unsafe.SkipInit(out int result);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr__SourceTexLowMip, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr__SourceTexLowMip, (void*)(&value));
			}
		}

		public unsafe static int _Bloom_Params
		{
			get
			{
				Unsafe.SkipInit(out int result);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr__Bloom_Params, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr__Bloom_Params, (void*)(&value));
			}
		}

		public unsafe static int _Bloom_Texture
		{
			get
			{
				Unsafe.SkipInit(out int result);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr__Bloom_Texture, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr__Bloom_Texture, (void*)(&value));
			}
		}

		public unsafe static int _LensDirt_Texture
		{
			get
			{
				Unsafe.SkipInit(out int result);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr__LensDirt_Texture, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr__LensDirt_Texture, (void*)(&value));
			}
		}

		public unsafe static int _LensDirt_Params
		{
			get
			{
				Unsafe.SkipInit(out int result);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr__LensDirt_Params, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr__LensDirt_Params, (void*)(&value));
			}
		}

		public unsafe static int _LensDirt_Intensity
		{
			get
			{
				Unsafe.SkipInit(out int result);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr__LensDirt_Intensity, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr__LensDirt_Intensity, (void*)(&value));
			}
		}

		public unsafe static int _Distortion_Params1
		{
			get
			{
				Unsafe.SkipInit(out int result);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr__Distortion_Params1, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr__Distortion_Params1, (void*)(&value));
			}
		}

		public unsafe static int _Distortion_Params2
		{
			get
			{
				Unsafe.SkipInit(out int result);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr__Distortion_Params2, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr__Distortion_Params2, (void*)(&value));
			}
		}

		public unsafe static int _Chroma_Params
		{
			get
			{
				Unsafe.SkipInit(out int result);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr__Chroma_Params, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr__Chroma_Params, (void*)(&value));
			}
		}

		public unsafe static int _Vignette_Params1
		{
			get
			{
				Unsafe.SkipInit(out int result);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr__Vignette_Params1, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr__Vignette_Params1, (void*)(&value));
			}
		}

		public unsafe static int _Vignette_Params2
		{
			get
			{
				Unsafe.SkipInit(out int result);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr__Vignette_Params2, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr__Vignette_Params2, (void*)(&value));
			}
		}

		public unsafe static int _Vignette_ParamsXR
		{
			get
			{
				Unsafe.SkipInit(out int result);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr__Vignette_ParamsXR, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr__Vignette_ParamsXR, (void*)(&value));
			}
		}

		public unsafe static int _Lut_Params
		{
			get
			{
				Unsafe.SkipInit(out int result);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr__Lut_Params, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr__Lut_Params, (void*)(&value));
			}
		}

		public unsafe static int _UserLut_Params
		{
			get
			{
				Unsafe.SkipInit(out int result);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr__UserLut_Params, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr__UserLut_Params, (void*)(&value));
			}
		}

		public unsafe static int _InternalLut
		{
			get
			{
				Unsafe.SkipInit(out int result);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr__InternalLut, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr__InternalLut, (void*)(&value));
			}
		}

		public unsafe static int _UserLut
		{
			get
			{
				Unsafe.SkipInit(out int result);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr__UserLut, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr__UserLut, (void*)(&value));
			}
		}

		public unsafe static int _DownSampleScaleFactor
		{
			get
			{
				Unsafe.SkipInit(out int result);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr__DownSampleScaleFactor, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr__DownSampleScaleFactor, (void*)(&value));
			}
		}

		public unsafe static int _FlareOcclusionRemapTex
		{
			get
			{
				Unsafe.SkipInit(out int result);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr__FlareOcclusionRemapTex, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr__FlareOcclusionRemapTex, (void*)(&value));
			}
		}

		public unsafe static int _FlareOcclusionTex
		{
			get
			{
				Unsafe.SkipInit(out int result);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr__FlareOcclusionTex, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr__FlareOcclusionTex, (void*)(&value));
			}
		}

		public unsafe static int _FlareOcclusionIndex
		{
			get
			{
				Unsafe.SkipInit(out int result);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr__FlareOcclusionIndex, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr__FlareOcclusionIndex, (void*)(&value));
			}
		}

		public unsafe static int _FlareTex
		{
			get
			{
				Unsafe.SkipInit(out int result);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr__FlareTex, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr__FlareTex, (void*)(&value));
			}
		}

		public unsafe static int _FlareColorValue
		{
			get
			{
				Unsafe.SkipInit(out int result);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr__FlareColorValue, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr__FlareColorValue, (void*)(&value));
			}
		}

		public unsafe static int _FlareData0
		{
			get
			{
				Unsafe.SkipInit(out int result);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr__FlareData0, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr__FlareData0, (void*)(&value));
			}
		}

		public unsafe static int _FlareData1
		{
			get
			{
				Unsafe.SkipInit(out int result);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr__FlareData1, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr__FlareData1, (void*)(&value));
			}
		}

		public unsafe static int _FlareData2
		{
			get
			{
				Unsafe.SkipInit(out int result);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr__FlareData2, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr__FlareData2, (void*)(&value));
			}
		}

		public unsafe static int _FlareData3
		{
			get
			{
				Unsafe.SkipInit(out int result);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr__FlareData3, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr__FlareData3, (void*)(&value));
			}
		}

		public unsafe static int _FlareData4
		{
			get
			{
				Unsafe.SkipInit(out int result);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr__FlareData4, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr__FlareData4, (void*)(&value));
			}
		}

		public unsafe static int _FlareData5
		{
			get
			{
				Unsafe.SkipInit(out int result);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr__FlareData5, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr__FlareData5, (void*)(&value));
			}
		}

		public unsafe static int _FullscreenProjMat
		{
			get
			{
				Unsafe.SkipInit(out int result);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr__FullscreenProjMat, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr__FullscreenProjMat, (void*)(&value));
			}
		}

		public unsafe static Il2CppStructArray<int> _BloomMipUp
		{
			get
			{
				Unsafe.SkipInit(out System.IntPtr intPtr);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr__BloomMipUp, (void*)(&intPtr));
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr__BloomMipUp, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		public unsafe static Il2CppStructArray<int> _BloomMipDown
		{
			get
			{
				Unsafe.SkipInit(out System.IntPtr intPtr);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr__BloomMipDown, (void*)(&intPtr));
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr__BloomMipDown, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		static ShaderConstants()
		{
			Il2CppClassPointerStore<ShaderConstants>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PostProcessPass>.NativeClassPtr, "ShaderConstants");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ShaderConstants>.NativeClassPtr);
			NativeFieldInfoPtr__TempTarget = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderConstants>.NativeClassPtr, "_TempTarget");
			NativeFieldInfoPtr__TempTarget2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderConstants>.NativeClassPtr, "_TempTarget2");
			NativeFieldInfoPtr__StencilRef = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderConstants>.NativeClassPtr, "_StencilRef");
			NativeFieldInfoPtr__StencilMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderConstants>.NativeClassPtr, "_StencilMask");
			NativeFieldInfoPtr__FullCoCTexture = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderConstants>.NativeClassPtr, "_FullCoCTexture");
			NativeFieldInfoPtr__HalfCoCTexture = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderConstants>.NativeClassPtr, "_HalfCoCTexture");
			NativeFieldInfoPtr__DofTexture = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderConstants>.NativeClassPtr, "_DofTexture");
			NativeFieldInfoPtr__CoCParams = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderConstants>.NativeClassPtr, "_CoCParams");
			NativeFieldInfoPtr__BokehKernel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderConstants>.NativeClassPtr, "_BokehKernel");
			NativeFieldInfoPtr__BokehConstants = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderConstants>.NativeClassPtr, "_BokehConstants");
			NativeFieldInfoPtr__PongTexture = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderConstants>.NativeClassPtr, "_PongTexture");
			NativeFieldInfoPtr__PingTexture = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderConstants>.NativeClassPtr, "_PingTexture");
			NativeFieldInfoPtr__Metrics = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderConstants>.NativeClassPtr, "_Metrics");
			NativeFieldInfoPtr__AreaTexture = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderConstants>.NativeClassPtr, "_AreaTexture");
			NativeFieldInfoPtr__SearchTexture = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderConstants>.NativeClassPtr, "_SearchTexture");
			NativeFieldInfoPtr__EdgeTexture = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderConstants>.NativeClassPtr, "_EdgeTexture");
			NativeFieldInfoPtr__BlendTexture = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderConstants>.NativeClassPtr, "_BlendTexture");
			NativeFieldInfoPtr__ColorTexture = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderConstants>.NativeClassPtr, "_ColorTexture");
			NativeFieldInfoPtr__Params = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderConstants>.NativeClassPtr, "_Params");
			NativeFieldInfoPtr__SourceTexLowMip = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderConstants>.NativeClassPtr, "_SourceTexLowMip");
			NativeFieldInfoPtr__Bloom_Params = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderConstants>.NativeClassPtr, "_Bloom_Params");
			NativeFieldInfoPtr__Bloom_Texture = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderConstants>.NativeClassPtr, "_Bloom_Texture");
			NativeFieldInfoPtr__LensDirt_Texture = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderConstants>.NativeClassPtr, "_LensDirt_Texture");
			NativeFieldInfoPtr__LensDirt_Params = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderConstants>.NativeClassPtr, "_LensDirt_Params");
			NativeFieldInfoPtr__LensDirt_Intensity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderConstants>.NativeClassPtr, "_LensDirt_Intensity");
			NativeFieldInfoPtr__Distortion_Params1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderConstants>.NativeClassPtr, "_Distortion_Params1");
			NativeFieldInfoPtr__Distortion_Params2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderConstants>.NativeClassPtr, "_Distortion_Params2");
			NativeFieldInfoPtr__Chroma_Params = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderConstants>.NativeClassPtr, "_Chroma_Params");
			NativeFieldInfoPtr__Vignette_Params1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderConstants>.NativeClassPtr, "_Vignette_Params1");
			NativeFieldInfoPtr__Vignette_Params2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderConstants>.NativeClassPtr, "_Vignette_Params2");
			NativeFieldInfoPtr__Vignette_ParamsXR = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderConstants>.NativeClassPtr, "_Vignette_ParamsXR");
			NativeFieldInfoPtr__Lut_Params = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderConstants>.NativeClassPtr, "_Lut_Params");
			NativeFieldInfoPtr__UserLut_Params = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderConstants>.NativeClassPtr, "_UserLut_Params");
			NativeFieldInfoPtr__InternalLut = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderConstants>.NativeClassPtr, "_InternalLut");
			NativeFieldInfoPtr__UserLut = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderConstants>.NativeClassPtr, "_UserLut");
			NativeFieldInfoPtr__DownSampleScaleFactor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderConstants>.NativeClassPtr, "_DownSampleScaleFactor");
			NativeFieldInfoPtr__FlareOcclusionRemapTex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderConstants>.NativeClassPtr, "_FlareOcclusionRemapTex");
			NativeFieldInfoPtr__FlareOcclusionTex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderConstants>.NativeClassPtr, "_FlareOcclusionTex");
			NativeFieldInfoPtr__FlareOcclusionIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderConstants>.NativeClassPtr, "_FlareOcclusionIndex");
			NativeFieldInfoPtr__FlareTex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderConstants>.NativeClassPtr, "_FlareTex");
			NativeFieldInfoPtr__FlareColorValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderConstants>.NativeClassPtr, "_FlareColorValue");
			NativeFieldInfoPtr__FlareData0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderConstants>.NativeClassPtr, "_FlareData0");
			NativeFieldInfoPtr__FlareData1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderConstants>.NativeClassPtr, "_FlareData1");
			NativeFieldInfoPtr__FlareData2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderConstants>.NativeClassPtr, "_FlareData2");
			NativeFieldInfoPtr__FlareData3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderConstants>.NativeClassPtr, "_FlareData3");
			NativeFieldInfoPtr__FlareData4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderConstants>.NativeClassPtr, "_FlareData4");
			NativeFieldInfoPtr__FlareData5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderConstants>.NativeClassPtr, "_FlareData5");
			NativeFieldInfoPtr__FullscreenProjMat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderConstants>.NativeClassPtr, "_FullscreenProjMat");
			NativeFieldInfoPtr__BloomMipUp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderConstants>.NativeClassPtr, "_BloomMipUp");
			NativeFieldInfoPtr__BloomMipDown = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderConstants>.NativeClassPtr, "_BloomMipDown");
		}

		public ShaderConstants(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	public class UpdateCameraResolutionPassData : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_newCameraTargetSize;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		public unsafe Vector2Int newCameraTargetSize
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_newCameraTargetSize);
				return *(Vector2Int*)num;
			}
			set
			{
				*(Vector2Int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_newCameraTargetSize)) = value;
			}
		}

		static UpdateCameraResolutionPassData()
		{
			Il2CppClassPointerStore<UpdateCameraResolutionPassData>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PostProcessPass>.NativeClassPtr, "UpdateCameraResolutionPassData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UpdateCameraResolutionPassData>.NativeClassPtr);
			NativeFieldInfoPtr_newCameraTargetSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpdateCameraResolutionPassData>.NativeClassPtr, "newCameraTargetSize");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpdateCameraResolutionPassData>.NativeClassPtr, 100665033);
		}

		[CallerCount(1950)]
		[CachedScanResults(RefRangeStart = 20036, RefRangeEnd = 21986, XrefRangeStart = 20036, XrefRangeEnd = 21986, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UpdateCameraResolutionPassData()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UpdateCameraResolutionPassData>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		public UpdateCameraResolutionPassData(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	public class StopNaNsPassData : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_stopNaNTarget;

		private static readonly System.IntPtr NativeFieldInfoPtr_sourceTexture;

		private static readonly System.IntPtr NativeFieldInfoPtr_stopNaN;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		public unsafe TextureHandle stopNaNTarget
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_stopNaNTarget);
				return *(TextureHandle*)num;
			}
			set
			{
				*(TextureHandle*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_stopNaNTarget)) = value;
			}
		}

		public unsafe TextureHandle sourceTexture
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_sourceTexture);
				return *(TextureHandle*)num;
			}
			set
			{
				*(TextureHandle*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_sourceTexture)) = value;
			}
		}

		public unsafe Material stopNaN
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_stopNaN);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Material>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_stopNaN)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		static StopNaNsPassData()
		{
			Il2CppClassPointerStore<StopNaNsPassData>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PostProcessPass>.NativeClassPtr, "StopNaNsPassData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StopNaNsPassData>.NativeClassPtr);
			NativeFieldInfoPtr_stopNaNTarget = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StopNaNsPassData>.NativeClassPtr, "stopNaNTarget");
			NativeFieldInfoPtr_sourceTexture = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StopNaNsPassData>.NativeClassPtr, "sourceTexture");
			NativeFieldInfoPtr_stopNaN = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StopNaNsPassData>.NativeClassPtr, "stopNaN");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StopNaNsPassData>.NativeClassPtr, 100665034);
		}

		[CallerCount(1950)]
		[CachedScanResults(RefRangeStart = 20036, RefRangeEnd = 21986, XrefRangeStart = 20036, XrefRangeEnd = 21986, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe StopNaNsPassData()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StopNaNsPassData>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		public StopNaNsPassData(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	public class SMAASetupPassData : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_metrics;

		private static readonly System.IntPtr NativeFieldInfoPtr_areaTexture;

		private static readonly System.IntPtr NativeFieldInfoPtr_searchTexture;

		private static readonly System.IntPtr NativeFieldInfoPtr_stencilRef;

		private static readonly System.IntPtr NativeFieldInfoPtr_stencilMask;

		private static readonly System.IntPtr NativeFieldInfoPtr_antialiasingQuality;

		private static readonly System.IntPtr NativeFieldInfoPtr_material;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		public unsafe Vector4 metrics
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_metrics);
				return *(Vector4*)num;
			}
			set
			{
				*(Vector4*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_metrics)) = value;
			}
		}

		public unsafe Texture2D areaTexture
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_areaTexture);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Texture2D>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_areaTexture)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		public unsafe Texture2D searchTexture
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_searchTexture);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Texture2D>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_searchTexture)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		public unsafe float stencilRef
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_stencilRef);
				return *(float*)num;
			}
			set
			{
				*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_stencilRef)) = value;
			}
		}

		public unsafe float stencilMask
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_stencilMask);
				return *(float*)num;
			}
			set
			{
				*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_stencilMask)) = value;
			}
		}

		public unsafe AntialiasingQuality antialiasingQuality
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_antialiasingQuality);
				return *(AntialiasingQuality*)num;
			}
			set
			{
				*(AntialiasingQuality*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_antialiasingQuality)) = value;
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

		static SMAASetupPassData()
		{
			Il2CppClassPointerStore<SMAASetupPassData>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PostProcessPass>.NativeClassPtr, "SMAASetupPassData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SMAASetupPassData>.NativeClassPtr);
			NativeFieldInfoPtr_metrics = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SMAASetupPassData>.NativeClassPtr, "metrics");
			NativeFieldInfoPtr_areaTexture = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SMAASetupPassData>.NativeClassPtr, "areaTexture");
			NativeFieldInfoPtr_searchTexture = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SMAASetupPassData>.NativeClassPtr, "searchTexture");
			NativeFieldInfoPtr_stencilRef = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SMAASetupPassData>.NativeClassPtr, "stencilRef");
			NativeFieldInfoPtr_stencilMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SMAASetupPassData>.NativeClassPtr, "stencilMask");
			NativeFieldInfoPtr_antialiasingQuality = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SMAASetupPassData>.NativeClassPtr, "antialiasingQuality");
			NativeFieldInfoPtr_material = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SMAASetupPassData>.NativeClassPtr, "material");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SMAASetupPassData>.NativeClassPtr, 100665035);
		}

		[CallerCount(1950)]
		[CachedScanResults(RefRangeStart = 20036, RefRangeEnd = 21986, XrefRangeStart = 20036, XrefRangeEnd = 21986, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SMAASetupPassData()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SMAASetupPassData>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		public SMAASetupPassData(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	public class SMAAPassData : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_destinationTexture;

		private static readonly System.IntPtr NativeFieldInfoPtr_sourceTexture;

		private static readonly System.IntPtr NativeFieldInfoPtr_depthStencilTexture;

		private static readonly System.IntPtr NativeFieldInfoPtr_blendTexture;

		private static readonly System.IntPtr NativeFieldInfoPtr_material;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		public unsafe TextureHandle destinationTexture
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_destinationTexture);
				return *(TextureHandle*)num;
			}
			set
			{
				*(TextureHandle*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_destinationTexture)) = value;
			}
		}

		public unsafe TextureHandle sourceTexture
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_sourceTexture);
				return *(TextureHandle*)num;
			}
			set
			{
				*(TextureHandle*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_sourceTexture)) = value;
			}
		}

		public unsafe TextureHandle depthStencilTexture
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_depthStencilTexture);
				return *(TextureHandle*)num;
			}
			set
			{
				*(TextureHandle*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_depthStencilTexture)) = value;
			}
		}

		public unsafe TextureHandle blendTexture
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_blendTexture);
				return *(TextureHandle*)num;
			}
			set
			{
				*(TextureHandle*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_blendTexture)) = value;
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

		static SMAAPassData()
		{
			Il2CppClassPointerStore<SMAAPassData>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PostProcessPass>.NativeClassPtr, "SMAAPassData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SMAAPassData>.NativeClassPtr);
			NativeFieldInfoPtr_destinationTexture = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SMAAPassData>.NativeClassPtr, "destinationTexture");
			NativeFieldInfoPtr_sourceTexture = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SMAAPassData>.NativeClassPtr, "sourceTexture");
			NativeFieldInfoPtr_depthStencilTexture = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SMAAPassData>.NativeClassPtr, "depthStencilTexture");
			NativeFieldInfoPtr_blendTexture = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SMAAPassData>.NativeClassPtr, "blendTexture");
			NativeFieldInfoPtr_material = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SMAAPassData>.NativeClassPtr, "material");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SMAAPassData>.NativeClassPtr, 100665036);
		}

		[CallerCount(1950)]
		[CachedScanResults(RefRangeStart = 20036, RefRangeEnd = 21986, XrefRangeStart = 20036, XrefRangeEnd = 21986, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SMAAPassData()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SMAAPassData>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		public SMAAPassData(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	public class UberSetupBloomPassData : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_bloomParams;

		private static readonly System.IntPtr NativeFieldInfoPtr_dirtScaleOffset;

		private static readonly System.IntPtr NativeFieldInfoPtr_dirtIntensity;

		private static readonly System.IntPtr NativeFieldInfoPtr_dirtTexture;

		private static readonly System.IntPtr NativeFieldInfoPtr_highQualityFilteringValue;

		private static readonly System.IntPtr NativeFieldInfoPtr_bloomTexture;

		private static readonly System.IntPtr NativeFieldInfoPtr_uberMaterial;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		public unsafe Vector4 bloomParams
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_bloomParams);
				return *(Vector4*)num;
			}
			set
			{
				*(Vector4*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_bloomParams)) = value;
			}
		}

		public unsafe Vector4 dirtScaleOffset
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_dirtScaleOffset);
				return *(Vector4*)num;
			}
			set
			{
				*(Vector4*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_dirtScaleOffset)) = value;
			}
		}

		public unsafe float dirtIntensity
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_dirtIntensity);
				return *(float*)num;
			}
			set
			{
				*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_dirtIntensity)) = value;
			}
		}

		public unsafe Texture dirtTexture
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_dirtTexture);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Texture>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_dirtTexture)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		public unsafe bool highQualityFilteringValue
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_highQualityFilteringValue);
				return *(bool*)num;
			}
			set
			{
				*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_highQualityFilteringValue)) = value;
			}
		}

		public unsafe TextureHandle bloomTexture
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_bloomTexture);
				return *(TextureHandle*)num;
			}
			set
			{
				*(TextureHandle*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_bloomTexture)) = value;
			}
		}

		public unsafe Material uberMaterial
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_uberMaterial);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Material>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_uberMaterial)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		static UberSetupBloomPassData()
		{
			Il2CppClassPointerStore<UberSetupBloomPassData>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PostProcessPass>.NativeClassPtr, "UberSetupBloomPassData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UberSetupBloomPassData>.NativeClassPtr);
			NativeFieldInfoPtr_bloomParams = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UberSetupBloomPassData>.NativeClassPtr, "bloomParams");
			NativeFieldInfoPtr_dirtScaleOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UberSetupBloomPassData>.NativeClassPtr, "dirtScaleOffset");
			NativeFieldInfoPtr_dirtIntensity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UberSetupBloomPassData>.NativeClassPtr, "dirtIntensity");
			NativeFieldInfoPtr_dirtTexture = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UberSetupBloomPassData>.NativeClassPtr, "dirtTexture");
			NativeFieldInfoPtr_highQualityFilteringValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UberSetupBloomPassData>.NativeClassPtr, "highQualityFilteringValue");
			NativeFieldInfoPtr_bloomTexture = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UberSetupBloomPassData>.NativeClassPtr, "bloomTexture");
			NativeFieldInfoPtr_uberMaterial = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UberSetupBloomPassData>.NativeClassPtr, "uberMaterial");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UberSetupBloomPassData>.NativeClassPtr, 100665037);
		}

		[CallerCount(1950)]
		[CachedScanResults(RefRangeStart = 20036, RefRangeEnd = 21986, XrefRangeStart = 20036, XrefRangeEnd = 21986, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UberSetupBloomPassData()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UberSetupBloomPassData>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		public UberSetupBloomPassData(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	public class BloomPassData : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_mipCount;

		private static readonly System.IntPtr NativeFieldInfoPtr_material;

		private static readonly System.IntPtr NativeFieldInfoPtr_upsampleMaterials;

		private static readonly System.IntPtr NativeFieldInfoPtr_sourceTexture;

		private static readonly System.IntPtr NativeFieldInfoPtr_bloomMipUp;

		private static readonly System.IntPtr NativeFieldInfoPtr_bloomMipDown;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		public unsafe int mipCount
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mipCount);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mipCount)) = value;
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

		public unsafe Il2CppReferenceArray<Material> upsampleMaterials
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_upsampleMaterials);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Material>>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_upsampleMaterials)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		public unsafe TextureHandle sourceTexture
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_sourceTexture);
				return *(TextureHandle*)num;
			}
			set
			{
				*(TextureHandle*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_sourceTexture)) = value;
			}
		}

		public unsafe Il2CppStructArray<TextureHandle> bloomMipUp
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_bloomMipUp);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<TextureHandle>>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_bloomMipUp)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		public unsafe Il2CppStructArray<TextureHandle> bloomMipDown
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_bloomMipDown);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<TextureHandle>>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_bloomMipDown)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		static BloomPassData()
		{
			Il2CppClassPointerStore<BloomPassData>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PostProcessPass>.NativeClassPtr, "BloomPassData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BloomPassData>.NativeClassPtr);
			NativeFieldInfoPtr_mipCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BloomPassData>.NativeClassPtr, "mipCount");
			NativeFieldInfoPtr_material = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BloomPassData>.NativeClassPtr, "material");
			NativeFieldInfoPtr_upsampleMaterials = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BloomPassData>.NativeClassPtr, "upsampleMaterials");
			NativeFieldInfoPtr_sourceTexture = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BloomPassData>.NativeClassPtr, "sourceTexture");
			NativeFieldInfoPtr_bloomMipUp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BloomPassData>.NativeClassPtr, "bloomMipUp");
			NativeFieldInfoPtr_bloomMipDown = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BloomPassData>.NativeClassPtr, "bloomMipDown");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BloomPassData>.NativeClassPtr, 100665038);
		}

		[CallerCount(1950)]
		[CachedScanResults(RefRangeStart = 20036, RefRangeEnd = 21986, XrefRangeStart = 20036, XrefRangeEnd = 21986, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BloomPassData()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BloomPassData>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		public BloomPassData(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	[StructLayout(LayoutKind.Explicit)]
	public struct BloomMaterialParams
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_parameters;

		private static readonly System.IntPtr NativeFieldInfoPtr_highQualityFiltering;

		private static readonly System.IntPtr NativeFieldInfoPtr_enableAlphaOutput;

		private static readonly System.IntPtr NativeMethodInfoPtr_Equals_Internal_Boolean_byref_BloomMaterialParams_0;

		[FieldOffset(0)]
		public Vector4 parameters;

		[FieldOffset(16)]
		[MarshalAs(UnmanagedType.U1)]
		public bool highQualityFiltering;

		[FieldOffset(17)]
		[MarshalAs(UnmanagedType.U1)]
		public bool enableAlphaOutput;

		static BloomMaterialParams()
		{
			Il2CppClassPointerStore<BloomMaterialParams>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PostProcessPass>.NativeClassPtr, "BloomMaterialParams");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BloomMaterialParams>.NativeClassPtr);
			NativeFieldInfoPtr_parameters = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BloomMaterialParams>.NativeClassPtr, "parameters");
			NativeFieldInfoPtr_highQualityFiltering = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BloomMaterialParams>.NativeClassPtr, "highQualityFiltering");
			NativeFieldInfoPtr_enableAlphaOutput = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BloomMaterialParams>.NativeClassPtr, "enableAlphaOutput");
			NativeMethodInfoPtr_Equals_Internal_Boolean_byref_BloomMaterialParams_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BloomMaterialParams>.NativeClassPtr, 100665039);
		}

		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1091035, RefRangeEnd = 1091036, XrefRangeStart = 1091035, XrefRangeEnd = 1091035, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Equals(ref BloomMaterialParams other)
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)Unsafe.AsPointer(ref other);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Equals_Internal_Boolean_byref_BloomMaterialParams_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		public unsafe Il2CppSystem.Object BoxIl2CppObject()
		{
			return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<BloomMaterialParams>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
		}
	}

	public class DoFGaussianPassData : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_downsample;

		private static readonly System.IntPtr NativeFieldInfoPtr_renderingData;

		private static readonly System.IntPtr NativeFieldInfoPtr_cocParams;

		private static readonly System.IntPtr NativeFieldInfoPtr_highQualitySamplingValue;

		private static readonly System.IntPtr NativeFieldInfoPtr_sourceTexture;

		private static readonly System.IntPtr NativeFieldInfoPtr_depthTexture;

		private static readonly System.IntPtr NativeFieldInfoPtr_material;

		private static readonly System.IntPtr NativeFieldInfoPtr_materialCoC;

		private static readonly System.IntPtr NativeFieldInfoPtr_halfCoCTexture;

		private static readonly System.IntPtr NativeFieldInfoPtr_fullCoCTexture;

		private static readonly System.IntPtr NativeFieldInfoPtr_pingTexture;

		private static readonly System.IntPtr NativeFieldInfoPtr_pongTexture;

		private static readonly System.IntPtr NativeFieldInfoPtr_multipleRenderTargets;

		private static readonly System.IntPtr NativeFieldInfoPtr_destination;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		public unsafe int downsample
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_downsample);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_downsample)) = value;
			}
		}

		public unsafe RenderingData renderingData
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_renderingData);
				return new RenderingData(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<RenderingData>.NativeClassPtr, (System.IntPtr)num));
			}
			set
			{
				// IL cpblk instruction
				Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_renderingData), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<RenderingData>.NativeClassPtr, ref *(uint*)null));
			}
		}

		public unsafe Vector3 cocParams
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cocParams);
				return *(Vector3*)num;
			}
			set
			{
				*(Vector3*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cocParams)) = value;
			}
		}

		public unsafe bool highQualitySamplingValue
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_highQualitySamplingValue);
				return *(bool*)num;
			}
			set
			{
				*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_highQualitySamplingValue)) = value;
			}
		}

		public unsafe TextureHandle sourceTexture
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_sourceTexture);
				return *(TextureHandle*)num;
			}
			set
			{
				*(TextureHandle*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_sourceTexture)) = value;
			}
		}

		public unsafe TextureHandle depthTexture
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_depthTexture);
				return *(TextureHandle*)num;
			}
			set
			{
				*(TextureHandle*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_depthTexture)) = value;
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

		public unsafe Material materialCoC
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_materialCoC);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Material>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_materialCoC)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		public unsafe TextureHandle halfCoCTexture
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_halfCoCTexture);
				return *(TextureHandle*)num;
			}
			set
			{
				*(TextureHandle*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_halfCoCTexture)) = value;
			}
		}

		public unsafe TextureHandle fullCoCTexture
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fullCoCTexture);
				return *(TextureHandle*)num;
			}
			set
			{
				*(TextureHandle*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fullCoCTexture)) = value;
			}
		}

		public unsafe TextureHandle pingTexture
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_pingTexture);
				return *(TextureHandle*)num;
			}
			set
			{
				*(TextureHandle*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_pingTexture)) = value;
			}
		}

		public unsafe TextureHandle pongTexture
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_pongTexture);
				return *(TextureHandle*)num;
			}
			set
			{
				*(TextureHandle*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_pongTexture)) = value;
			}
		}

		public unsafe Il2CppStructArray<RenderTargetIdentifier> multipleRenderTargets
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_multipleRenderTargets);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<RenderTargetIdentifier>>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_multipleRenderTargets)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		public unsafe TextureHandle destination
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_destination);
				return *(TextureHandle*)num;
			}
			set
			{
				*(TextureHandle*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_destination)) = value;
			}
		}

		static DoFGaussianPassData()
		{
			Il2CppClassPointerStore<DoFGaussianPassData>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PostProcessPass>.NativeClassPtr, "DoFGaussianPassData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DoFGaussianPassData>.NativeClassPtr);
			NativeFieldInfoPtr_downsample = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DoFGaussianPassData>.NativeClassPtr, "downsample");
			NativeFieldInfoPtr_renderingData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DoFGaussianPassData>.NativeClassPtr, "renderingData");
			NativeFieldInfoPtr_cocParams = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DoFGaussianPassData>.NativeClassPtr, "cocParams");
			NativeFieldInfoPtr_highQualitySamplingValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DoFGaussianPassData>.NativeClassPtr, "highQualitySamplingValue");
			NativeFieldInfoPtr_sourceTexture = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DoFGaussianPassData>.NativeClassPtr, "sourceTexture");
			NativeFieldInfoPtr_depthTexture = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DoFGaussianPassData>.NativeClassPtr, "depthTexture");
			NativeFieldInfoPtr_material = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DoFGaussianPassData>.NativeClassPtr, "material");
			NativeFieldInfoPtr_materialCoC = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DoFGaussianPassData>.NativeClassPtr, "materialCoC");
			NativeFieldInfoPtr_halfCoCTexture = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DoFGaussianPassData>.NativeClassPtr, "halfCoCTexture");
			NativeFieldInfoPtr_fullCoCTexture = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DoFGaussianPassData>.NativeClassPtr, "fullCoCTexture");
			NativeFieldInfoPtr_pingTexture = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DoFGaussianPassData>.NativeClassPtr, "pingTexture");
			NativeFieldInfoPtr_pongTexture = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DoFGaussianPassData>.NativeClassPtr, "pongTexture");
			NativeFieldInfoPtr_multipleRenderTargets = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DoFGaussianPassData>.NativeClassPtr, "multipleRenderTargets");
			NativeFieldInfoPtr_destination = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DoFGaussianPassData>.NativeClassPtr, "destination");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DoFGaussianPassData>.NativeClassPtr, 100665040);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1091036, XrefRangeEnd = 1091041, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DoFGaussianPassData()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DoFGaussianPassData>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		public DoFGaussianPassData(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	public class DoFBokehPassData : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_bokehKernel;

		private static readonly System.IntPtr NativeFieldInfoPtr_downSample;

		private static readonly System.IntPtr NativeFieldInfoPtr_uvMargin;

		private static readonly System.IntPtr NativeFieldInfoPtr_cocParams;

		private static readonly System.IntPtr NativeFieldInfoPtr_useFastSRGBLinearConversion;

		private static readonly System.IntPtr NativeFieldInfoPtr_sourceTexture;

		private static readonly System.IntPtr NativeFieldInfoPtr_depthTexture;

		private static readonly System.IntPtr NativeFieldInfoPtr_material;

		private static readonly System.IntPtr NativeFieldInfoPtr_materialCoC;

		private static readonly System.IntPtr NativeFieldInfoPtr_halfCoCTexture;

		private static readonly System.IntPtr NativeFieldInfoPtr_fullCoCTexture;

		private static readonly System.IntPtr NativeFieldInfoPtr_pingTexture;

		private static readonly System.IntPtr NativeFieldInfoPtr_pongTexture;

		private static readonly System.IntPtr NativeFieldInfoPtr_destination;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		public unsafe Il2CppStructArray<Vector4> bokehKernel
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_bokehKernel);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<Vector4>>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_bokehKernel)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		public unsafe int downSample
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_downSample);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_downSample)) = value;
			}
		}

		public unsafe float uvMargin
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_uvMargin);
				return *(float*)num;
			}
			set
			{
				*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_uvMargin)) = value;
			}
		}

		public unsafe Vector4 cocParams
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cocParams);
				return *(Vector4*)num;
			}
			set
			{
				*(Vector4*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cocParams)) = value;
			}
		}

		public unsafe bool useFastSRGBLinearConversion
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_useFastSRGBLinearConversion);
				return *(bool*)num;
			}
			set
			{
				*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_useFastSRGBLinearConversion)) = value;
			}
		}

		public unsafe TextureHandle sourceTexture
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_sourceTexture);
				return *(TextureHandle*)num;
			}
			set
			{
				*(TextureHandle*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_sourceTexture)) = value;
			}
		}

		public unsafe TextureHandle depthTexture
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_depthTexture);
				return *(TextureHandle*)num;
			}
			set
			{
				*(TextureHandle*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_depthTexture)) = value;
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

		public unsafe Material materialCoC
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_materialCoC);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Material>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_materialCoC)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		public unsafe TextureHandle halfCoCTexture
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_halfCoCTexture);
				return *(TextureHandle*)num;
			}
			set
			{
				*(TextureHandle*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_halfCoCTexture)) = value;
			}
		}

		public unsafe TextureHandle fullCoCTexture
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fullCoCTexture);
				return *(TextureHandle*)num;
			}
			set
			{
				*(TextureHandle*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fullCoCTexture)) = value;
			}
		}

		public unsafe TextureHandle pingTexture
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_pingTexture);
				return *(TextureHandle*)num;
			}
			set
			{
				*(TextureHandle*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_pingTexture)) = value;
			}
		}

		public unsafe TextureHandle pongTexture
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_pongTexture);
				return *(TextureHandle*)num;
			}
			set
			{
				*(TextureHandle*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_pongTexture)) = value;
			}
		}

		public unsafe TextureHandle destination
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_destination);
				return *(TextureHandle*)num;
			}
			set
			{
				*(TextureHandle*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_destination)) = value;
			}
		}

		static DoFBokehPassData()
		{
			Il2CppClassPointerStore<DoFBokehPassData>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PostProcessPass>.NativeClassPtr, "DoFBokehPassData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DoFBokehPassData>.NativeClassPtr);
			NativeFieldInfoPtr_bokehKernel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DoFBokehPassData>.NativeClassPtr, "bokehKernel");
			NativeFieldInfoPtr_downSample = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DoFBokehPassData>.NativeClassPtr, "downSample");
			NativeFieldInfoPtr_uvMargin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DoFBokehPassData>.NativeClassPtr, "uvMargin");
			NativeFieldInfoPtr_cocParams = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DoFBokehPassData>.NativeClassPtr, "cocParams");
			NativeFieldInfoPtr_useFastSRGBLinearConversion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DoFBokehPassData>.NativeClassPtr, "useFastSRGBLinearConversion");
			NativeFieldInfoPtr_sourceTexture = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DoFBokehPassData>.NativeClassPtr, "sourceTexture");
			NativeFieldInfoPtr_depthTexture = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DoFBokehPassData>.NativeClassPtr, "depthTexture");
			NativeFieldInfoPtr_material = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DoFBokehPassData>.NativeClassPtr, "material");
			NativeFieldInfoPtr_materialCoC = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DoFBokehPassData>.NativeClassPtr, "materialCoC");
			NativeFieldInfoPtr_halfCoCTexture = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DoFBokehPassData>.NativeClassPtr, "halfCoCTexture");
			NativeFieldInfoPtr_fullCoCTexture = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DoFBokehPassData>.NativeClassPtr, "fullCoCTexture");
			NativeFieldInfoPtr_pingTexture = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DoFBokehPassData>.NativeClassPtr, "pingTexture");
			NativeFieldInfoPtr_pongTexture = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DoFBokehPassData>.NativeClassPtr, "pongTexture");
			NativeFieldInfoPtr_destination = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DoFBokehPassData>.NativeClassPtr, "destination");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DoFBokehPassData>.NativeClassPtr, 100665041);
		}

		[CallerCount(1950)]
		[CachedScanResults(RefRangeStart = 20036, RefRangeEnd = 21986, XrefRangeStart = 20036, XrefRangeEnd = 21986, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DoFBokehPassData()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DoFBokehPassData>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		public DoFBokehPassData(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	public class PaniniProjectionPassData : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_destinationTexture;

		private static readonly System.IntPtr NativeFieldInfoPtr_sourceTexture;

		private static readonly System.IntPtr NativeFieldInfoPtr_sourceTextureDesc;

		private static readonly System.IntPtr NativeFieldInfoPtr_material;

		private static readonly System.IntPtr NativeFieldInfoPtr_paniniParams;

		private static readonly System.IntPtr NativeFieldInfoPtr_isPaniniGeneric;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		public unsafe TextureHandle destinationTexture
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_destinationTexture);
				return *(TextureHandle*)num;
			}
			set
			{
				*(TextureHandle*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_destinationTexture)) = value;
			}
		}

		public unsafe TextureHandle sourceTexture
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_sourceTexture);
				return *(TextureHandle*)num;
			}
			set
			{
				*(TextureHandle*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_sourceTexture)) = value;
			}
		}

		public unsafe RenderTextureDescriptor sourceTextureDesc
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_sourceTextureDesc);
				return *(RenderTextureDescriptor*)num;
			}
			set
			{
				*(RenderTextureDescriptor*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_sourceTextureDesc)) = value;
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

		public unsafe Vector4 paniniParams
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_paniniParams);
				return *(Vector4*)num;
			}
			set
			{
				*(Vector4*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_paniniParams)) = value;
			}
		}

		public unsafe bool isPaniniGeneric
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isPaniniGeneric);
				return *(bool*)num;
			}
			set
			{
				*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isPaniniGeneric)) = value;
			}
		}

		static PaniniProjectionPassData()
		{
			Il2CppClassPointerStore<PaniniProjectionPassData>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PostProcessPass>.NativeClassPtr, "PaniniProjectionPassData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PaniniProjectionPassData>.NativeClassPtr);
			NativeFieldInfoPtr_destinationTexture = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PaniniProjectionPassData>.NativeClassPtr, "destinationTexture");
			NativeFieldInfoPtr_sourceTexture = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PaniniProjectionPassData>.NativeClassPtr, "sourceTexture");
			NativeFieldInfoPtr_sourceTextureDesc = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PaniniProjectionPassData>.NativeClassPtr, "sourceTextureDesc");
			NativeFieldInfoPtr_material = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PaniniProjectionPassData>.NativeClassPtr, "material");
			NativeFieldInfoPtr_paniniParams = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PaniniProjectionPassData>.NativeClassPtr, "paniniParams");
			NativeFieldInfoPtr_isPaniniGeneric = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PaniniProjectionPassData>.NativeClassPtr, "isPaniniGeneric");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PaniniProjectionPassData>.NativeClassPtr, 100665042);
		}

		[CallerCount(1950)]
		[CachedScanResults(RefRangeStart = 20036, RefRangeEnd = 21986, XrefRangeStart = 20036, XrefRangeEnd = 21986, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PaniniProjectionPassData()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PaniniProjectionPassData>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		public PaniniProjectionPassData(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	public class MotionBlurPassData : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_destinationTexture;

		private static readonly System.IntPtr NativeFieldInfoPtr_sourceTexture;

		private static readonly System.IntPtr NativeFieldInfoPtr_motionVectors;

		private static readonly System.IntPtr NativeFieldInfoPtr_material;

		private static readonly System.IntPtr NativeFieldInfoPtr_passIndex;

		private static readonly System.IntPtr NativeFieldInfoPtr_camera;

		private static readonly System.IntPtr NativeFieldInfoPtr_xr;

		private static readonly System.IntPtr NativeFieldInfoPtr_intensity;

		private static readonly System.IntPtr NativeFieldInfoPtr_clamp;

		private static readonly System.IntPtr NativeFieldInfoPtr_enableAlphaOutput;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		public unsafe TextureHandle destinationTexture
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_destinationTexture);
				return *(TextureHandle*)num;
			}
			set
			{
				*(TextureHandle*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_destinationTexture)) = value;
			}
		}

		public unsafe TextureHandle sourceTexture
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_sourceTexture);
				return *(TextureHandle*)num;
			}
			set
			{
				*(TextureHandle*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_sourceTexture)) = value;
			}
		}

		public unsafe TextureHandle motionVectors
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_motionVectors);
				return *(TextureHandle*)num;
			}
			set
			{
				*(TextureHandle*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_motionVectors)) = value;
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

		public unsafe int passIndex
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_passIndex);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_passIndex)) = value;
			}
		}

		public unsafe Camera camera
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_camera);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Camera>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_camera)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		public unsafe XRPass xr
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_xr);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<XRPass>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_xr)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		public unsafe float intensity
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_intensity);
				return *(float*)num;
			}
			set
			{
				*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_intensity)) = value;
			}
		}

		public unsafe float clamp
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_clamp);
				return *(float*)num;
			}
			set
			{
				*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_clamp)) = value;
			}
		}

		public unsafe bool enableAlphaOutput
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_enableAlphaOutput);
				return *(bool*)num;
			}
			set
			{
				*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_enableAlphaOutput)) = value;
			}
		}

		static MotionBlurPassData()
		{
			Il2CppClassPointerStore<MotionBlurPassData>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PostProcessPass>.NativeClassPtr, "MotionBlurPassData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MotionBlurPassData>.NativeClassPtr);
			NativeFieldInfoPtr_destinationTexture = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MotionBlurPassData>.NativeClassPtr, "destinationTexture");
			NativeFieldInfoPtr_sourceTexture = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MotionBlurPassData>.NativeClassPtr, "sourceTexture");
			NativeFieldInfoPtr_motionVectors = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MotionBlurPassData>.NativeClassPtr, "motionVectors");
			NativeFieldInfoPtr_material = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MotionBlurPassData>.NativeClassPtr, "material");
			NativeFieldInfoPtr_passIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MotionBlurPassData>.NativeClassPtr, "passIndex");
			NativeFieldInfoPtr_camera = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MotionBlurPassData>.NativeClassPtr, "camera");
			NativeFieldInfoPtr_xr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MotionBlurPassData>.NativeClassPtr, "xr");
			NativeFieldInfoPtr_intensity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MotionBlurPassData>.NativeClassPtr, "intensity");
			NativeFieldInfoPtr_clamp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MotionBlurPassData>.NativeClassPtr, "clamp");
			NativeFieldInfoPtr_enableAlphaOutput = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MotionBlurPassData>.NativeClassPtr, "enableAlphaOutput");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MotionBlurPassData>.NativeClassPtr, 100665043);
		}

		[CallerCount(1950)]
		[CachedScanResults(RefRangeStart = 20036, RefRangeEnd = 21986, XrefRangeStart = 20036, XrefRangeEnd = 21986, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MotionBlurPassData()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MotionBlurPassData>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		public MotionBlurPassData(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	public class LensFlarePassData : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_destinationTexture;

		private static readonly System.IntPtr NativeFieldInfoPtr_sourceDescriptor;

		private static readonly System.IntPtr NativeFieldInfoPtr_cameraData;

		private static readonly System.IntPtr NativeFieldInfoPtr_material;

		private static readonly System.IntPtr NativeFieldInfoPtr_viewport;

		private static readonly System.IntPtr NativeFieldInfoPtr_paniniDistance;

		private static readonly System.IntPtr NativeFieldInfoPtr_paniniCropToFit;

		private static readonly System.IntPtr NativeFieldInfoPtr_width;

		private static readonly System.IntPtr NativeFieldInfoPtr_height;

		private static readonly System.IntPtr NativeFieldInfoPtr_usePanini;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		public unsafe TextureHandle destinationTexture
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_destinationTexture);
				return *(TextureHandle*)num;
			}
			set
			{
				*(TextureHandle*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_destinationTexture)) = value;
			}
		}

		public unsafe RenderTextureDescriptor sourceDescriptor
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_sourceDescriptor);
				return *(RenderTextureDescriptor*)num;
			}
			set
			{
				*(RenderTextureDescriptor*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_sourceDescriptor)) = value;
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

		public unsafe Rect viewport
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_viewport);
				return *(Rect*)num;
			}
			set
			{
				*(Rect*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_viewport)) = value;
			}
		}

		public unsafe float paniniDistance
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_paniniDistance);
				return *(float*)num;
			}
			set
			{
				*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_paniniDistance)) = value;
			}
		}

		public unsafe float paniniCropToFit
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_paniniCropToFit);
				return *(float*)num;
			}
			set
			{
				*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_paniniCropToFit)) = value;
			}
		}

		public unsafe float width
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_width);
				return *(float*)num;
			}
			set
			{
				*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_width)) = value;
			}
		}

		public unsafe float height
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_height);
				return *(float*)num;
			}
			set
			{
				*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_height)) = value;
			}
		}

		public unsafe bool usePanini
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_usePanini);
				return *(bool*)num;
			}
			set
			{
				*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_usePanini)) = value;
			}
		}

		static LensFlarePassData()
		{
			Il2CppClassPointerStore<LensFlarePassData>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PostProcessPass>.NativeClassPtr, "LensFlarePassData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LensFlarePassData>.NativeClassPtr);
			NativeFieldInfoPtr_destinationTexture = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LensFlarePassData>.NativeClassPtr, "destinationTexture");
			NativeFieldInfoPtr_sourceDescriptor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LensFlarePassData>.NativeClassPtr, "sourceDescriptor");
			NativeFieldInfoPtr_cameraData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LensFlarePassData>.NativeClassPtr, "cameraData");
			NativeFieldInfoPtr_material = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LensFlarePassData>.NativeClassPtr, "material");
			NativeFieldInfoPtr_viewport = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LensFlarePassData>.NativeClassPtr, "viewport");
			NativeFieldInfoPtr_paniniDistance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LensFlarePassData>.NativeClassPtr, "paniniDistance");
			NativeFieldInfoPtr_paniniCropToFit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LensFlarePassData>.NativeClassPtr, "paniniCropToFit");
			NativeFieldInfoPtr_width = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LensFlarePassData>.NativeClassPtr, "width");
			NativeFieldInfoPtr_height = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LensFlarePassData>.NativeClassPtr, "height");
			NativeFieldInfoPtr_usePanini = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LensFlarePassData>.NativeClassPtr, "usePanini");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LensFlarePassData>.NativeClassPtr, 100665044);
		}

		[CallerCount(1950)]
		[CachedScanResults(RefRangeStart = 20036, RefRangeEnd = 21986, XrefRangeStart = 20036, XrefRangeEnd = 21986, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LensFlarePassData()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LensFlarePassData>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		public LensFlarePassData(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	public class LensFlareScreenSpacePassData : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_destinationTexture;

		private static readonly System.IntPtr NativeFieldInfoPtr_streakTmpTexture;

		private static readonly System.IntPtr NativeFieldInfoPtr_streakTmpTexture2;

		private static readonly System.IntPtr NativeFieldInfoPtr_originalBloomTexture;

		private static readonly System.IntPtr NativeFieldInfoPtr_screenSpaceLensFlareBloomMipTexture;

		private static readonly System.IntPtr NativeFieldInfoPtr_result;

		private static readonly System.IntPtr NativeFieldInfoPtr_sourceDescriptor;

		private static readonly System.IntPtr NativeFieldInfoPtr_camera;

		private static readonly System.IntPtr NativeFieldInfoPtr_material;

		private static readonly System.IntPtr NativeFieldInfoPtr_lensFlareScreenSpace;

		private static readonly System.IntPtr NativeFieldInfoPtr_downsample;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		public unsafe TextureHandle destinationTexture
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_destinationTexture);
				return *(TextureHandle*)num;
			}
			set
			{
				*(TextureHandle*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_destinationTexture)) = value;
			}
		}

		public unsafe TextureHandle streakTmpTexture
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_streakTmpTexture);
				return *(TextureHandle*)num;
			}
			set
			{
				*(TextureHandle*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_streakTmpTexture)) = value;
			}
		}

		public unsafe TextureHandle streakTmpTexture2
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_streakTmpTexture2);
				return *(TextureHandle*)num;
			}
			set
			{
				*(TextureHandle*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_streakTmpTexture2)) = value;
			}
		}

		public unsafe TextureHandle originalBloomTexture
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_originalBloomTexture);
				return *(TextureHandle*)num;
			}
			set
			{
				*(TextureHandle*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_originalBloomTexture)) = value;
			}
		}

		public unsafe TextureHandle screenSpaceLensFlareBloomMipTexture
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_screenSpaceLensFlareBloomMipTexture);
				return *(TextureHandle*)num;
			}
			set
			{
				*(TextureHandle*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_screenSpaceLensFlareBloomMipTexture)) = value;
			}
		}

		public unsafe TextureHandle result
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_result);
				return *(TextureHandle*)num;
			}
			set
			{
				*(TextureHandle*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_result)) = value;
			}
		}

		public unsafe RenderTextureDescriptor sourceDescriptor
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_sourceDescriptor);
				return *(RenderTextureDescriptor*)num;
			}
			set
			{
				*(RenderTextureDescriptor*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_sourceDescriptor)) = value;
			}
		}

		public unsafe Camera camera
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_camera);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Camera>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_camera)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
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

		public unsafe ScreenSpaceLensFlare lensFlareScreenSpace
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lensFlareScreenSpace);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ScreenSpaceLensFlare>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lensFlareScreenSpace)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		public unsafe int downsample
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_downsample);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_downsample)) = value;
			}
		}

		static LensFlareScreenSpacePassData()
		{
			Il2CppClassPointerStore<LensFlareScreenSpacePassData>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PostProcessPass>.NativeClassPtr, "LensFlareScreenSpacePassData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LensFlareScreenSpacePassData>.NativeClassPtr);
			NativeFieldInfoPtr_destinationTexture = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LensFlareScreenSpacePassData>.NativeClassPtr, "destinationTexture");
			NativeFieldInfoPtr_streakTmpTexture = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LensFlareScreenSpacePassData>.NativeClassPtr, "streakTmpTexture");
			NativeFieldInfoPtr_streakTmpTexture2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LensFlareScreenSpacePassData>.NativeClassPtr, "streakTmpTexture2");
			NativeFieldInfoPtr_originalBloomTexture = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LensFlareScreenSpacePassData>.NativeClassPtr, "originalBloomTexture");
			NativeFieldInfoPtr_screenSpaceLensFlareBloomMipTexture = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LensFlareScreenSpacePassData>.NativeClassPtr, "screenSpaceLensFlareBloomMipTexture");
			NativeFieldInfoPtr_result = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LensFlareScreenSpacePassData>.NativeClassPtr, "result");
			NativeFieldInfoPtr_sourceDescriptor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LensFlareScreenSpacePassData>.NativeClassPtr, "sourceDescriptor");
			NativeFieldInfoPtr_camera = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LensFlareScreenSpacePassData>.NativeClassPtr, "camera");
			NativeFieldInfoPtr_material = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LensFlareScreenSpacePassData>.NativeClassPtr, "material");
			NativeFieldInfoPtr_lensFlareScreenSpace = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LensFlareScreenSpacePassData>.NativeClassPtr, "lensFlareScreenSpace");
			NativeFieldInfoPtr_downsample = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LensFlareScreenSpacePassData>.NativeClassPtr, "downsample");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LensFlareScreenSpacePassData>.NativeClassPtr, 100665045);
		}

		[CallerCount(1950)]
		[CachedScanResults(RefRangeStart = 20036, RefRangeEnd = 21986, XrefRangeStart = 20036, XrefRangeEnd = 21986, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LensFlareScreenSpacePassData()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LensFlareScreenSpacePassData>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		public LensFlareScreenSpacePassData(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	public class PostProcessingFinalSetupPassData : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_destinationTexture;

		private static readonly System.IntPtr NativeFieldInfoPtr_sourceTexture;

		private static readonly System.IntPtr NativeFieldInfoPtr_material;

		private static readonly System.IntPtr NativeFieldInfoPtr_cameraData;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		public unsafe TextureHandle destinationTexture
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_destinationTexture);
				return *(TextureHandle*)num;
			}
			set
			{
				*(TextureHandle*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_destinationTexture)) = value;
			}
		}

		public unsafe TextureHandle sourceTexture
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_sourceTexture);
				return *(TextureHandle*)num;
			}
			set
			{
				*(TextureHandle*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_sourceTexture)) = value;
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

		static PostProcessingFinalSetupPassData()
		{
			Il2CppClassPointerStore<PostProcessingFinalSetupPassData>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PostProcessPass>.NativeClassPtr, "PostProcessingFinalSetupPassData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PostProcessingFinalSetupPassData>.NativeClassPtr);
			NativeFieldInfoPtr_destinationTexture = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PostProcessingFinalSetupPassData>.NativeClassPtr, "destinationTexture");
			NativeFieldInfoPtr_sourceTexture = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PostProcessingFinalSetupPassData>.NativeClassPtr, "sourceTexture");
			NativeFieldInfoPtr_material = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PostProcessingFinalSetupPassData>.NativeClassPtr, "material");
			NativeFieldInfoPtr_cameraData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PostProcessingFinalSetupPassData>.NativeClassPtr, "cameraData");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PostProcessingFinalSetupPassData>.NativeClassPtr, 100665046);
		}

		[CallerCount(1950)]
		[CachedScanResults(RefRangeStart = 20036, RefRangeEnd = 21986, XrefRangeStart = 20036, XrefRangeEnd = 21986, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PostProcessingFinalSetupPassData()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PostProcessingFinalSetupPassData>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		public PostProcessingFinalSetupPassData(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	public class PostProcessingFinalFSRScalePassData : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_destinationTexture;

		private static readonly System.IntPtr NativeFieldInfoPtr_sourceTexture;

		private static readonly System.IntPtr NativeFieldInfoPtr_material;

		private static readonly System.IntPtr NativeFieldInfoPtr_enableAlphaOutput;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		public unsafe TextureHandle destinationTexture
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_destinationTexture);
				return *(TextureHandle*)num;
			}
			set
			{
				*(TextureHandle*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_destinationTexture)) = value;
			}
		}

		public unsafe TextureHandle sourceTexture
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_sourceTexture);
				return *(TextureHandle*)num;
			}
			set
			{
				*(TextureHandle*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_sourceTexture)) = value;
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

		public unsafe bool enableAlphaOutput
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_enableAlphaOutput);
				return *(bool*)num;
			}
			set
			{
				*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_enableAlphaOutput)) = value;
			}
		}

		static PostProcessingFinalFSRScalePassData()
		{
			Il2CppClassPointerStore<PostProcessingFinalFSRScalePassData>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PostProcessPass>.NativeClassPtr, "PostProcessingFinalFSRScalePassData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PostProcessingFinalFSRScalePassData>.NativeClassPtr);
			NativeFieldInfoPtr_destinationTexture = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PostProcessingFinalFSRScalePassData>.NativeClassPtr, "destinationTexture");
			NativeFieldInfoPtr_sourceTexture = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PostProcessingFinalFSRScalePassData>.NativeClassPtr, "sourceTexture");
			NativeFieldInfoPtr_material = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PostProcessingFinalFSRScalePassData>.NativeClassPtr, "material");
			NativeFieldInfoPtr_enableAlphaOutput = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PostProcessingFinalFSRScalePassData>.NativeClassPtr, "enableAlphaOutput");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PostProcessingFinalFSRScalePassData>.NativeClassPtr, 100665047);
		}

		[CallerCount(1950)]
		[CachedScanResults(RefRangeStart = 20036, RefRangeEnd = 21986, XrefRangeStart = 20036, XrefRangeEnd = 21986, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PostProcessingFinalFSRScalePassData()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PostProcessingFinalFSRScalePassData>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		public PostProcessingFinalFSRScalePassData(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	public class PostProcessingFinalBlitPassData : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_destinationTexture;

		private static readonly System.IntPtr NativeFieldInfoPtr_sourceTexture;

		private static readonly System.IntPtr NativeFieldInfoPtr_material;

		private static readonly System.IntPtr NativeFieldInfoPtr_cameraData;

		private static readonly System.IntPtr NativeFieldInfoPtr_settings;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		public unsafe TextureHandle destinationTexture
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_destinationTexture);
				return *(TextureHandle*)num;
			}
			set
			{
				*(TextureHandle*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_destinationTexture)) = value;
			}
		}

		public unsafe TextureHandle sourceTexture
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_sourceTexture);
				return *(TextureHandle*)num;
			}
			set
			{
				*(TextureHandle*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_sourceTexture)) = value;
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

		public unsafe FinalBlitSettings settings
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_settings);
				return *(FinalBlitSettings*)num;
			}
			set
			{
				*(FinalBlitSettings*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_settings)) = value;
			}
		}

		static PostProcessingFinalBlitPassData()
		{
			Il2CppClassPointerStore<PostProcessingFinalBlitPassData>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PostProcessPass>.NativeClassPtr, "PostProcessingFinalBlitPassData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PostProcessingFinalBlitPassData>.NativeClassPtr);
			NativeFieldInfoPtr_destinationTexture = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PostProcessingFinalBlitPassData>.NativeClassPtr, "destinationTexture");
			NativeFieldInfoPtr_sourceTexture = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PostProcessingFinalBlitPassData>.NativeClassPtr, "sourceTexture");
			NativeFieldInfoPtr_material = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PostProcessingFinalBlitPassData>.NativeClassPtr, "material");
			NativeFieldInfoPtr_cameraData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PostProcessingFinalBlitPassData>.NativeClassPtr, "cameraData");
			NativeFieldInfoPtr_settings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PostProcessingFinalBlitPassData>.NativeClassPtr, "settings");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PostProcessingFinalBlitPassData>.NativeClassPtr, 100665048);
		}

		[CallerCount(1950)]
		[CachedScanResults(RefRangeStart = 20036, RefRangeEnd = 21986, XrefRangeStart = 20036, XrefRangeEnd = 21986, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PostProcessingFinalBlitPassData()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PostProcessingFinalBlitPassData>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		public PostProcessingFinalBlitPassData(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	[StructLayout(LayoutKind.Explicit)]
	public struct FinalBlitSettings
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_isFxaaEnabled;

		private static readonly System.IntPtr NativeFieldInfoPtr_isFsrEnabled;

		private static readonly System.IntPtr NativeFieldInfoPtr_isTaaSharpeningEnabled;

		private static readonly System.IntPtr NativeFieldInfoPtr_requireHDROutput;

		private static readonly System.IntPtr NativeFieldInfoPtr_resolveToDebugScreen;

		private static readonly System.IntPtr NativeFieldInfoPtr_isAlphaOutputEnabled;

		private static readonly System.IntPtr NativeFieldInfoPtr_hdrOperations;

		private static readonly System.IntPtr NativeMethodInfoPtr_Create_Public_Static_FinalBlitSettings_0;

		[FieldOffset(0)]
		[MarshalAs(UnmanagedType.U1)]
		public bool isFxaaEnabled;

		[FieldOffset(1)]
		[MarshalAs(UnmanagedType.U1)]
		public bool isFsrEnabled;

		[FieldOffset(2)]
		[MarshalAs(UnmanagedType.U1)]
		public bool isTaaSharpeningEnabled;

		[FieldOffset(3)]
		[MarshalAs(UnmanagedType.U1)]
		public bool requireHDROutput;

		[FieldOffset(4)]
		[MarshalAs(UnmanagedType.U1)]
		public bool resolveToDebugScreen;

		[FieldOffset(5)]
		[MarshalAs(UnmanagedType.U1)]
		public bool isAlphaOutputEnabled;

		[FieldOffset(8)]
		public HDROutputUtils.Operation hdrOperations;

		static FinalBlitSettings()
		{
			Il2CppClassPointerStore<FinalBlitSettings>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PostProcessPass>.NativeClassPtr, "FinalBlitSettings");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FinalBlitSettings>.NativeClassPtr);
			NativeFieldInfoPtr_isFxaaEnabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FinalBlitSettings>.NativeClassPtr, "isFxaaEnabled");
			NativeFieldInfoPtr_isFsrEnabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FinalBlitSettings>.NativeClassPtr, "isFsrEnabled");
			NativeFieldInfoPtr_isTaaSharpeningEnabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FinalBlitSettings>.NativeClassPtr, "isTaaSharpeningEnabled");
			NativeFieldInfoPtr_requireHDROutput = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FinalBlitSettings>.NativeClassPtr, "requireHDROutput");
			NativeFieldInfoPtr_resolveToDebugScreen = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FinalBlitSettings>.NativeClassPtr, "resolveToDebugScreen");
			NativeFieldInfoPtr_isAlphaOutputEnabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FinalBlitSettings>.NativeClassPtr, "isAlphaOutputEnabled");
			NativeFieldInfoPtr_hdrOperations = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FinalBlitSettings>.NativeClassPtr, "hdrOperations");
			NativeMethodInfoPtr_Create_Public_Static_FinalBlitSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FinalBlitSettings>.NativeClassPtr, 100665049);
		}

		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1091041, RefRangeEnd = 1091042, XrefRangeStart = 1091041, XrefRangeEnd = 1091041, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static FinalBlitSettings Create()
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Create_Public_Static_FinalBlitSettings_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(FinalBlitSettings*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		public unsafe Il2CppSystem.Object BoxIl2CppObject()
		{
			return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<FinalBlitSettings>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
		}
	}

	public class UberPostPassData : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_destinationTexture;

		private static readonly System.IntPtr NativeFieldInfoPtr_sourceTexture;

		private static readonly System.IntPtr NativeFieldInfoPtr_lutTexture;

		private static readonly System.IntPtr NativeFieldInfoPtr_lutParams;

		private static readonly System.IntPtr NativeFieldInfoPtr_userLutTexture;

		private static readonly System.IntPtr NativeFieldInfoPtr_userLutParams;

		private static readonly System.IntPtr NativeFieldInfoPtr_material;

		private static readonly System.IntPtr NativeFieldInfoPtr_cameraData;

		private static readonly System.IntPtr NativeFieldInfoPtr_toneMappingMode;

		private static readonly System.IntPtr NativeFieldInfoPtr_isHdrGrading;

		private static readonly System.IntPtr NativeFieldInfoPtr_isBackbuffer;

		private static readonly System.IntPtr NativeFieldInfoPtr_enableAlphaOutput;

		private static readonly System.IntPtr NativeFieldInfoPtr_hasFinalPass;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		public unsafe TextureHandle destinationTexture
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_destinationTexture);
				return *(TextureHandle*)num;
			}
			set
			{
				*(TextureHandle*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_destinationTexture)) = value;
			}
		}

		public unsafe TextureHandle sourceTexture
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_sourceTexture);
				return *(TextureHandle*)num;
			}
			set
			{
				*(TextureHandle*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_sourceTexture)) = value;
			}
		}

		public unsafe TextureHandle lutTexture
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lutTexture);
				return *(TextureHandle*)num;
			}
			set
			{
				*(TextureHandle*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lutTexture)) = value;
			}
		}

		public unsafe Vector4 lutParams
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lutParams);
				return *(Vector4*)num;
			}
			set
			{
				*(Vector4*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lutParams)) = value;
			}
		}

		public unsafe TextureHandle userLutTexture
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_userLutTexture);
				return *(TextureHandle*)num;
			}
			set
			{
				*(TextureHandle*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_userLutTexture)) = value;
			}
		}

		public unsafe Vector4 userLutParams
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_userLutParams);
				return *(Vector4*)num;
			}
			set
			{
				*(Vector4*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_userLutParams)) = value;
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

		public unsafe TonemappingMode toneMappingMode
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_toneMappingMode);
				return *(TonemappingMode*)num;
			}
			set
			{
				*(TonemappingMode*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_toneMappingMode)) = value;
			}
		}

		public unsafe bool isHdrGrading
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isHdrGrading);
				return *(bool*)num;
			}
			set
			{
				*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isHdrGrading)) = value;
			}
		}

		public unsafe bool isBackbuffer
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isBackbuffer);
				return *(bool*)num;
			}
			set
			{
				*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isBackbuffer)) = value;
			}
		}

		public unsafe bool enableAlphaOutput
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_enableAlphaOutput);
				return *(bool*)num;
			}
			set
			{
				*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_enableAlphaOutput)) = value;
			}
		}

		public unsafe bool hasFinalPass
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_hasFinalPass);
				return *(bool*)num;
			}
			set
			{
				*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_hasFinalPass)) = value;
			}
		}

		static UberPostPassData()
		{
			Il2CppClassPointerStore<UberPostPassData>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PostProcessPass>.NativeClassPtr, "UberPostPassData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UberPostPassData>.NativeClassPtr);
			NativeFieldInfoPtr_destinationTexture = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UberPostPassData>.NativeClassPtr, "destinationTexture");
			NativeFieldInfoPtr_sourceTexture = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UberPostPassData>.NativeClassPtr, "sourceTexture");
			NativeFieldInfoPtr_lutTexture = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UberPostPassData>.NativeClassPtr, "lutTexture");
			NativeFieldInfoPtr_lutParams = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UberPostPassData>.NativeClassPtr, "lutParams");
			NativeFieldInfoPtr_userLutTexture = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UberPostPassData>.NativeClassPtr, "userLutTexture");
			NativeFieldInfoPtr_userLutParams = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UberPostPassData>.NativeClassPtr, "userLutParams");
			NativeFieldInfoPtr_material = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UberPostPassData>.NativeClassPtr, "material");
			NativeFieldInfoPtr_cameraData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UberPostPassData>.NativeClassPtr, "cameraData");
			NativeFieldInfoPtr_toneMappingMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UberPostPassData>.NativeClassPtr, "toneMappingMode");
			NativeFieldInfoPtr_isHdrGrading = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UberPostPassData>.NativeClassPtr, "isHdrGrading");
			NativeFieldInfoPtr_isBackbuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UberPostPassData>.NativeClassPtr, "isBackbuffer");
			NativeFieldInfoPtr_enableAlphaOutput = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UberPostPassData>.NativeClassPtr, "enableAlphaOutput");
			NativeFieldInfoPtr_hasFinalPass = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UberPostPassData>.NativeClassPtr, "hasFinalPass");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UberPostPassData>.NativeClassPtr, 100665050);
		}

		[CallerCount(1950)]
		[CachedScanResults(RefRangeStart = 20036, RefRangeEnd = 21986, XrefRangeStart = 20036, XrefRangeEnd = 21986, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UberPostPassData()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UberPostPassData>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		public UberPostPassData(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	public class PostFXSetupPassData : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		static PostFXSetupPassData()
		{
			Il2CppClassPointerStore<PostFXSetupPassData>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PostProcessPass>.NativeClassPtr, "PostFXSetupPassData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PostFXSetupPassData>.NativeClassPtr);
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PostFXSetupPassData>.NativeClassPtr, 100665051);
		}

		[CallerCount(1950)]
		[CachedScanResults(RefRangeStart = 20036, RefRangeEnd = 21986, XrefRangeStart = 20036, XrefRangeEnd = 21986, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PostFXSetupPassData()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PostFXSetupPassData>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		public PostFXSetupPassData(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	[System.Serializable]
	[ObfuscatedName("UnityEngine.Rendering.Universal.PostProcessPass+<>c")]
	public sealed class __c : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr___9;

		private static readonly System.IntPtr NativeFieldInfoPtr___9__98_0;

		private static readonly System.IntPtr NativeFieldInfoPtr___9__98_1;

		private static readonly System.IntPtr NativeFieldInfoPtr___9__122_0;

		private static readonly System.IntPtr NativeFieldInfoPtr___9__124_0;

		private static readonly System.IntPtr NativeFieldInfoPtr___9__127_0;

		private static readonly System.IntPtr NativeFieldInfoPtr___9__127_1;

		private static readonly System.IntPtr NativeFieldInfoPtr___9__127_2;

		private static readonly System.IntPtr NativeFieldInfoPtr___9__127_3;

		private static readonly System.IntPtr NativeFieldInfoPtr___9__129_0;

		private static readonly System.IntPtr NativeFieldInfoPtr___9__134_0;

		private static readonly System.IntPtr NativeFieldInfoPtr___9__137_0;

		private static readonly System.IntPtr NativeFieldInfoPtr___9__139_0;

		private static readonly System.IntPtr NativeFieldInfoPtr___9__141_0;

		private static readonly System.IntPtr NativeFieldInfoPtr___9__147_0;

		private static readonly System.IntPtr NativeFieldInfoPtr___9__149_0;

		private static readonly System.IntPtr NativeFieldInfoPtr___9__150_1;

		private static readonly System.IntPtr NativeFieldInfoPtr___9__150_2;

		private static readonly System.IntPtr NativeFieldInfoPtr___9__150_0;

		private static readonly System.IntPtr NativeFieldInfoPtr___9__152_0;

		private static readonly System.IntPtr NativeFieldInfoPtr___9__155_0;

		private static readonly System.IntPtr NativeFieldInfoPtr___9__157_0;

		private static readonly System.IntPtr NativeFieldInfoPtr___9__160_0;

		private static readonly System.IntPtr NativeFieldInfoPtr___9__164_0;

		private static readonly System.IntPtr NativeFieldInfoPtr___9__166_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__LensFlareDataDriven_b__98_0_Internal_Single_Light_Camera_Vector3_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__LensFlareDataDriven_b__98_1_Internal_Single_Light_Camera_Vector3_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__UpdateCameraResolution_b__122_0_Internal_Void_UpdateCameraResolutionPassData_UnsafeGraphContext_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__RenderStopNaN_b__124_0_Internal_Void_StopNaNsPassData_RasterGraphContext_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__RenderSMAA_b__127_0_Internal_Void_SMAASetupPassData_RasterGraphContext_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__RenderSMAA_b__127_1_Internal_Void_SMAAPassData_RasterGraphContext_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__RenderSMAA_b__127_2_Internal_Void_SMAAPassData_RasterGraphContext_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__RenderSMAA_b__127_3_Internal_Void_SMAAPassData_RasterGraphContext_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__UberPostSetupBloomPass_b__129_0_Internal_Void_UberSetupBloomPassData_RasterGraphContext_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__RenderBloomTexture_b__134_0_Internal_Void_BloomPassData_UnsafeGraphContext_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__RenderDoFGaussian_b__137_0_Internal_Void_DoFGaussianPassData_UnsafeGraphContext_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__RenderDoFBokeh_b__139_0_Internal_Void_DoFBokehPassData_UnsafeGraphContext_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__RenderPaniniProjection_b__141_0_Internal_Void_PaniniProjectionPassData_RasterGraphContext_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__RenderMotionBlur_b__147_0_Internal_Void_MotionBlurPassData_RasterGraphContext_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__LensFlareDataDrivenComputeOcclusion_b__149_0_Internal_Void_LensFlarePassData_UnsafeGraphContext_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__RenderLensFlareDataDriven_b__150_0_Internal_Void_LensFlarePassData_UnsafeGraphContext_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__RenderLensFlareDataDriven_b__150_1_Internal_Single_Light_Camera_Vector3_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__RenderLensFlareDataDriven_b__150_2_Internal_Single_Light_Camera_Vector3_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__RenderLensFlareScreenSpace_b__152_0_Internal_Void_LensFlareScreenSpacePassData_UnsafeGraphContext_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__RenderFinalSetup_b__155_0_Internal_Void_PostProcessingFinalSetupPassData_RasterGraphContext_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__RenderFinalFSRScale_b__157_0_Internal_Void_PostProcessingFinalFSRScalePassData_RasterGraphContext_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__RenderFinalBlit_b__160_0_Internal_Void_PostProcessingFinalBlitPassData_RasterGraphContext_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__RenderUberPost_b__164_0_Internal_Void_UberPostPassData_RasterGraphContext_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__RenderPostProcessingRenderGraph_b__166_0_Internal_Void_PostFXSetupPassData_RasterGraphContext_0;

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

		public unsafe static Il2CppSystem.Func<Light, Camera, Vector3, float> __9__98_0
		{
			get
			{
				Unsafe.SkipInit(out System.IntPtr intPtr);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr___9__98_0, (void*)(&intPtr));
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Func<Light, Camera, Vector3, float>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr___9__98_0, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		public unsafe static Il2CppSystem.Func<Light, Camera, Vector3, float> __9__98_1
		{
			get
			{
				Unsafe.SkipInit(out System.IntPtr intPtr);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr___9__98_1, (void*)(&intPtr));
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Func<Light, Camera, Vector3, float>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr___9__98_1, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		public unsafe static BaseRenderFunc<UpdateCameraResolutionPassData, UnsafeGraphContext> __9__122_0
		{
			get
			{
				Unsafe.SkipInit(out System.IntPtr intPtr);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr___9__122_0, (void*)(&intPtr));
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<BaseRenderFunc<UpdateCameraResolutionPassData, UnsafeGraphContext>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr___9__122_0, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		public unsafe static BaseRenderFunc<StopNaNsPassData, RasterGraphContext> __9__124_0
		{
			get
			{
				Unsafe.SkipInit(out System.IntPtr intPtr);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr___9__124_0, (void*)(&intPtr));
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<BaseRenderFunc<StopNaNsPassData, RasterGraphContext>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr___9__124_0, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		public unsafe static BaseRenderFunc<SMAASetupPassData, RasterGraphContext> __9__127_0
		{
			get
			{
				Unsafe.SkipInit(out System.IntPtr intPtr);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr___9__127_0, (void*)(&intPtr));
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<BaseRenderFunc<SMAASetupPassData, RasterGraphContext>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr___9__127_0, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		public unsafe static BaseRenderFunc<SMAAPassData, RasterGraphContext> __9__127_1
		{
			get
			{
				Unsafe.SkipInit(out System.IntPtr intPtr);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr___9__127_1, (void*)(&intPtr));
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<BaseRenderFunc<SMAAPassData, RasterGraphContext>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr___9__127_1, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		public unsafe static BaseRenderFunc<SMAAPassData, RasterGraphContext> __9__127_2
		{
			get
			{
				Unsafe.SkipInit(out System.IntPtr intPtr);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr___9__127_2, (void*)(&intPtr));
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<BaseRenderFunc<SMAAPassData, RasterGraphContext>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr___9__127_2, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		public unsafe static BaseRenderFunc<SMAAPassData, RasterGraphContext> __9__127_3
		{
			get
			{
				Unsafe.SkipInit(out System.IntPtr intPtr);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr___9__127_3, (void*)(&intPtr));
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<BaseRenderFunc<SMAAPassData, RasterGraphContext>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr___9__127_3, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		public unsafe static BaseRenderFunc<UberSetupBloomPassData, RasterGraphContext> __9__129_0
		{
			get
			{
				Unsafe.SkipInit(out System.IntPtr intPtr);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr___9__129_0, (void*)(&intPtr));
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<BaseRenderFunc<UberSetupBloomPassData, RasterGraphContext>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr___9__129_0, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		public unsafe static BaseRenderFunc<BloomPassData, UnsafeGraphContext> __9__134_0
		{
			get
			{
				Unsafe.SkipInit(out System.IntPtr intPtr);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr___9__134_0, (void*)(&intPtr));
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<BaseRenderFunc<BloomPassData, UnsafeGraphContext>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr___9__134_0, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		public unsafe static BaseRenderFunc<DoFGaussianPassData, UnsafeGraphContext> __9__137_0
		{
			get
			{
				Unsafe.SkipInit(out System.IntPtr intPtr);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr___9__137_0, (void*)(&intPtr));
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<BaseRenderFunc<DoFGaussianPassData, UnsafeGraphContext>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr___9__137_0, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		public unsafe static BaseRenderFunc<DoFBokehPassData, UnsafeGraphContext> __9__139_0
		{
			get
			{
				Unsafe.SkipInit(out System.IntPtr intPtr);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr___9__139_0, (void*)(&intPtr));
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<BaseRenderFunc<DoFBokehPassData, UnsafeGraphContext>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr___9__139_0, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		public unsafe static BaseRenderFunc<PaniniProjectionPassData, RasterGraphContext> __9__141_0
		{
			get
			{
				Unsafe.SkipInit(out System.IntPtr intPtr);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr___9__141_0, (void*)(&intPtr));
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<BaseRenderFunc<PaniniProjectionPassData, RasterGraphContext>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr___9__141_0, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		public unsafe static BaseRenderFunc<MotionBlurPassData, RasterGraphContext> __9__147_0
		{
			get
			{
				Unsafe.SkipInit(out System.IntPtr intPtr);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr___9__147_0, (void*)(&intPtr));
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<BaseRenderFunc<MotionBlurPassData, RasterGraphContext>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr___9__147_0, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		public unsafe static BaseRenderFunc<LensFlarePassData, UnsafeGraphContext> __9__149_0
		{
			get
			{
				Unsafe.SkipInit(out System.IntPtr intPtr);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr___9__149_0, (void*)(&intPtr));
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<BaseRenderFunc<LensFlarePassData, UnsafeGraphContext>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr___9__149_0, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		public unsafe static Il2CppSystem.Func<Light, Camera, Vector3, float> __9__150_1
		{
			get
			{
				Unsafe.SkipInit(out System.IntPtr intPtr);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr___9__150_1, (void*)(&intPtr));
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Func<Light, Camera, Vector3, float>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr___9__150_1, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		public unsafe static Il2CppSystem.Func<Light, Camera, Vector3, float> __9__150_2
		{
			get
			{
				Unsafe.SkipInit(out System.IntPtr intPtr);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr___9__150_2, (void*)(&intPtr));
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Func<Light, Camera, Vector3, float>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr___9__150_2, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		public unsafe static BaseRenderFunc<LensFlarePassData, UnsafeGraphContext> __9__150_0
		{
			get
			{
				Unsafe.SkipInit(out System.IntPtr intPtr);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr___9__150_0, (void*)(&intPtr));
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<BaseRenderFunc<LensFlarePassData, UnsafeGraphContext>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr___9__150_0, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		public unsafe static BaseRenderFunc<LensFlareScreenSpacePassData, UnsafeGraphContext> __9__152_0
		{
			get
			{
				Unsafe.SkipInit(out System.IntPtr intPtr);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr___9__152_0, (void*)(&intPtr));
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<BaseRenderFunc<LensFlareScreenSpacePassData, UnsafeGraphContext>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr___9__152_0, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		public unsafe static BaseRenderFunc<PostProcessingFinalSetupPassData, RasterGraphContext> __9__155_0
		{
			get
			{
				Unsafe.SkipInit(out System.IntPtr intPtr);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr___9__155_0, (void*)(&intPtr));
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<BaseRenderFunc<PostProcessingFinalSetupPassData, RasterGraphContext>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr___9__155_0, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		public unsafe static BaseRenderFunc<PostProcessingFinalFSRScalePassData, RasterGraphContext> __9__157_0
		{
			get
			{
				Unsafe.SkipInit(out System.IntPtr intPtr);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr___9__157_0, (void*)(&intPtr));
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<BaseRenderFunc<PostProcessingFinalFSRScalePassData, RasterGraphContext>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr___9__157_0, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		public unsafe static BaseRenderFunc<PostProcessingFinalBlitPassData, RasterGraphContext> __9__160_0
		{
			get
			{
				Unsafe.SkipInit(out System.IntPtr intPtr);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr___9__160_0, (void*)(&intPtr));
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<BaseRenderFunc<PostProcessingFinalBlitPassData, RasterGraphContext>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr___9__160_0, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		public unsafe static BaseRenderFunc<UberPostPassData, RasterGraphContext> __9__164_0
		{
			get
			{
				Unsafe.SkipInit(out System.IntPtr intPtr);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr___9__164_0, (void*)(&intPtr));
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<BaseRenderFunc<UberPostPassData, RasterGraphContext>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr___9__164_0, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		public unsafe static BaseRenderFunc<PostFXSetupPassData, RasterGraphContext> __9__166_0
		{
			get
			{
				Unsafe.SkipInit(out System.IntPtr intPtr);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr___9__166_0, (void*)(&intPtr));
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<BaseRenderFunc<PostFXSetupPassData, RasterGraphContext>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr___9__166_0, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		static __c()
		{
			Il2CppClassPointerStore<__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PostProcessPass>.NativeClassPtr, "<>c");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<__c>.NativeClassPtr);
			NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c>.NativeClassPtr, "<>9");
			NativeFieldInfoPtr___9__98_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c>.NativeClassPtr, "<>9__98_0");
			NativeFieldInfoPtr___9__98_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c>.NativeClassPtr, "<>9__98_1");
			NativeFieldInfoPtr___9__122_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c>.NativeClassPtr, "<>9__122_0");
			NativeFieldInfoPtr___9__124_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c>.NativeClassPtr, "<>9__124_0");
			NativeFieldInfoPtr___9__127_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c>.NativeClassPtr, "<>9__127_0");
			NativeFieldInfoPtr___9__127_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c>.NativeClassPtr, "<>9__127_1");
			NativeFieldInfoPtr___9__127_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c>.NativeClassPtr, "<>9__127_2");
			NativeFieldInfoPtr___9__127_3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c>.NativeClassPtr, "<>9__127_3");
			NativeFieldInfoPtr___9__129_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c>.NativeClassPtr, "<>9__129_0");
			NativeFieldInfoPtr___9__134_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c>.NativeClassPtr, "<>9__134_0");
			NativeFieldInfoPtr___9__137_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c>.NativeClassPtr, "<>9__137_0");
			NativeFieldInfoPtr___9__139_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c>.NativeClassPtr, "<>9__139_0");
			NativeFieldInfoPtr___9__141_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c>.NativeClassPtr, "<>9__141_0");
			NativeFieldInfoPtr___9__147_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c>.NativeClassPtr, "<>9__147_0");
			NativeFieldInfoPtr___9__149_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c>.NativeClassPtr, "<>9__149_0");
			NativeFieldInfoPtr___9__150_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c>.NativeClassPtr, "<>9__150_1");
			NativeFieldInfoPtr___9__150_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c>.NativeClassPtr, "<>9__150_2");
			NativeFieldInfoPtr___9__150_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c>.NativeClassPtr, "<>9__150_0");
			NativeFieldInfoPtr___9__152_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c>.NativeClassPtr, "<>9__152_0");
			NativeFieldInfoPtr___9__155_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c>.NativeClassPtr, "<>9__155_0");
			NativeFieldInfoPtr___9__157_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c>.NativeClassPtr, "<>9__157_0");
			NativeFieldInfoPtr___9__160_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c>.NativeClassPtr, "<>9__160_0");
			NativeFieldInfoPtr___9__164_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c>.NativeClassPtr, "<>9__164_0");
			NativeFieldInfoPtr___9__166_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c>.NativeClassPtr, "<>9__166_0");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c>.NativeClassPtr, 100665053);
			NativeMethodInfoPtr__LensFlareDataDriven_b__98_0_Internal_Single_Light_Camera_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c>.NativeClassPtr, 100665054);
			NativeMethodInfoPtr__LensFlareDataDriven_b__98_1_Internal_Single_Light_Camera_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c>.NativeClassPtr, 100665055);
			NativeMethodInfoPtr__UpdateCameraResolution_b__122_0_Internal_Void_UpdateCameraResolutionPassData_UnsafeGraphContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c>.NativeClassPtr, 100665056);
			NativeMethodInfoPtr__RenderStopNaN_b__124_0_Internal_Void_StopNaNsPassData_RasterGraphContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c>.NativeClassPtr, 100665057);
			NativeMethodInfoPtr__RenderSMAA_b__127_0_Internal_Void_SMAASetupPassData_RasterGraphContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c>.NativeClassPtr, 100665058);
			NativeMethodInfoPtr__RenderSMAA_b__127_1_Internal_Void_SMAAPassData_RasterGraphContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c>.NativeClassPtr, 100665059);
			NativeMethodInfoPtr__RenderSMAA_b__127_2_Internal_Void_SMAAPassData_RasterGraphContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c>.NativeClassPtr, 100665060);
			NativeMethodInfoPtr__RenderSMAA_b__127_3_Internal_Void_SMAAPassData_RasterGraphContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c>.NativeClassPtr, 100665061);
			NativeMethodInfoPtr__UberPostSetupBloomPass_b__129_0_Internal_Void_UberSetupBloomPassData_RasterGraphContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c>.NativeClassPtr, 100665062);
			NativeMethodInfoPtr__RenderBloomTexture_b__134_0_Internal_Void_BloomPassData_UnsafeGraphContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c>.NativeClassPtr, 100665063);
			NativeMethodInfoPtr__RenderDoFGaussian_b__137_0_Internal_Void_DoFGaussianPassData_UnsafeGraphContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c>.NativeClassPtr, 100665064);
			NativeMethodInfoPtr__RenderDoFBokeh_b__139_0_Internal_Void_DoFBokehPassData_UnsafeGraphContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c>.NativeClassPtr, 100665065);
			NativeMethodInfoPtr__RenderPaniniProjection_b__141_0_Internal_Void_PaniniProjectionPassData_RasterGraphContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c>.NativeClassPtr, 100665066);
			NativeMethodInfoPtr__RenderMotionBlur_b__147_0_Internal_Void_MotionBlurPassData_RasterGraphContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c>.NativeClassPtr, 100665067);
			NativeMethodInfoPtr__LensFlareDataDrivenComputeOcclusion_b__149_0_Internal_Void_LensFlarePassData_UnsafeGraphContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c>.NativeClassPtr, 100665068);
			NativeMethodInfoPtr__RenderLensFlareDataDriven_b__150_0_Internal_Void_LensFlarePassData_UnsafeGraphContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c>.NativeClassPtr, 100665069);
			NativeMethodInfoPtr__RenderLensFlareDataDriven_b__150_1_Internal_Single_Light_Camera_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c>.NativeClassPtr, 100665070);
			NativeMethodInfoPtr__RenderLensFlareDataDriven_b__150_2_Internal_Single_Light_Camera_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c>.NativeClassPtr, 100665071);
			NativeMethodInfoPtr__RenderLensFlareScreenSpace_b__152_0_Internal_Void_LensFlareScreenSpacePassData_UnsafeGraphContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c>.NativeClassPtr, 100665072);
			NativeMethodInfoPtr__RenderFinalSetup_b__155_0_Internal_Void_PostProcessingFinalSetupPassData_RasterGraphContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c>.NativeClassPtr, 100665073);
			NativeMethodInfoPtr__RenderFinalFSRScale_b__157_0_Internal_Void_PostProcessingFinalFSRScalePassData_RasterGraphContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c>.NativeClassPtr, 100665074);
			NativeMethodInfoPtr__RenderFinalBlit_b__160_0_Internal_Void_PostProcessingFinalBlitPassData_RasterGraphContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c>.NativeClassPtr, 100665075);
			NativeMethodInfoPtr__RenderUberPost_b__164_0_Internal_Void_UberPostPassData_RasterGraphContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c>.NativeClassPtr, 100665076);
			NativeMethodInfoPtr__RenderPostProcessingRenderGraph_b__166_0_Internal_Void_PostFXSetupPassData_RasterGraphContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c>.NativeClassPtr, 100665077);
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
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1091042, XrefRangeEnd = 1091046, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float _LensFlareDataDriven_b__98_0(Light light, Camera cam, Vector3 wo)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[3];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)light);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)cam);
			*(Vector3**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &wo;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__LensFlareDataDriven_b__98_0_Internal_Single_Light_Camera_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(float*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1091046, XrefRangeEnd = 1091050, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float _LensFlareDataDriven_b__98_1(Light light, Camera cam, Vector3 wo)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[3];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)light);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)cam);
			*(Vector3**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &wo;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__LensFlareDataDriven_b__98_1_Internal_Single_Light_Camera_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(float*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1091050, XrefRangeEnd = 1091055, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _UpdateCameraResolution_b__122_0(UpdateCameraResolutionPassData data, UnsafeGraphContext ctx)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[2];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)data);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)ctx);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__UpdateCameraResolution_b__122_0_Internal_Void_UpdateCameraResolutionPassData_UnsafeGraphContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1091055, XrefRangeEnd = 1091068, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _RenderStopNaN_b__124_0(StopNaNsPassData data, RasterGraphContext context)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[2];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)data);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)context));
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__RenderStopNaN_b__124_0_Internal_Void_StopNaNsPassData_RasterGraphContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1091068, XrefRangeEnd = 1091087, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _RenderSMAA_b__127_0(SMAASetupPassData data, RasterGraphContext context)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[2];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)data);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)context));
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__RenderSMAA_b__127_0_Internal_Void_SMAASetupPassData_RasterGraphContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1091087, XrefRangeEnd = 1091100, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _RenderSMAA_b__127_1(SMAAPassData data, RasterGraphContext context)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[2];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)data);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)context));
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__RenderSMAA_b__127_1_Internal_Void_SMAAPassData_RasterGraphContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1091100, XrefRangeEnd = 1091113, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _RenderSMAA_b__127_2(SMAAPassData data, RasterGraphContext context)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[2];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)data);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)context));
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__RenderSMAA_b__127_2_Internal_Void_SMAAPassData_RasterGraphContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1091113, XrefRangeEnd = 1091132, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _RenderSMAA_b__127_3(SMAAPassData data, RasterGraphContext context)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[2];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)data);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)context));
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__RenderSMAA_b__127_3_Internal_Void_SMAAPassData_RasterGraphContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1091132, XrefRangeEnd = 1091162, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _UberPostSetupBloomPass_b__129_0(UberSetupBloomPassData data, RasterGraphContext context)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[2];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)data);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)context));
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__UberPostSetupBloomPass_b__129_0_Internal_Void_UberSetupBloomPassData_RasterGraphContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1091162, XrefRangeEnd = 1091219, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _RenderBloomTexture_b__134_0(BloomPassData data, UnsafeGraphContext context)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[2];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)data);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)context);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__RenderBloomTexture_b__134_0_Internal_Void_BloomPassData_UnsafeGraphContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1091219, XrefRangeEnd = 1091359, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _RenderDoFGaussian_b__137_0(DoFGaussianPassData data, UnsafeGraphContext context)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[2];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)data);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)context);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__RenderDoFGaussian_b__137_0_Internal_Void_DoFGaussianPassData_UnsafeGraphContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1091359, XrefRangeEnd = 1091479, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _RenderDoFBokeh_b__139_0(DoFBokehPassData data, UnsafeGraphContext context)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[2];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)data);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)context);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__RenderDoFBokeh_b__139_0_Internal_Void_DoFBokehPassData_UnsafeGraphContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1091479, XrefRangeEnd = 1091502, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _RenderPaniniProjection_b__141_0(PaniniProjectionPassData data, RasterGraphContext context)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[2];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)data);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)context));
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__RenderPaniniProjection_b__141_0_Internal_Void_PaniniProjectionPassData_RasterGraphContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1091502, XrefRangeEnd = 1091533, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _RenderMotionBlur_b__147_0(MotionBlurPassData data, RasterGraphContext context)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[2];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)data);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)context));
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__RenderMotionBlur_b__147_0_Internal_Void_MotionBlurPassData_RasterGraphContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1091533, XrefRangeEnd = 1091567, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _LensFlareDataDrivenComputeOcclusion_b__149_0(LensFlarePassData data, UnsafeGraphContext ctx)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[2];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)data);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)ctx);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__LensFlareDataDrivenComputeOcclusion_b__149_0_Internal_Void_LensFlarePassData_UnsafeGraphContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1091567, XrefRangeEnd = 1091626, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _RenderLensFlareDataDriven_b__150_0(LensFlarePassData data, UnsafeGraphContext ctx)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[2];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)data);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)ctx);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__RenderLensFlareDataDriven_b__150_0_Internal_Void_LensFlarePassData_UnsafeGraphContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1091626, XrefRangeEnd = 1091630, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float _RenderLensFlareDataDriven_b__150_1(Light light, Camera cam, Vector3 wo)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[3];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)light);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)cam);
			*(Vector3**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &wo;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__RenderLensFlareDataDriven_b__150_1_Internal_Single_Light_Camera_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(float*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1091630, XrefRangeEnd = 1091634, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float _RenderLensFlareDataDriven_b__150_2(Light light, Camera cam, Vector3 wo)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[3];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)light);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)cam);
			*(Vector3**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &wo;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__RenderLensFlareDataDriven_b__150_2_Internal_Single_Light_Camera_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(float*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1091634, XrefRangeEnd = 1091646, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _RenderLensFlareScreenSpace_b__152_0(LensFlareScreenSpacePassData data, UnsafeGraphContext context)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[2];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)data);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)context);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__RenderLensFlareScreenSpace_b__152_0_Internal_Void_LensFlareScreenSpacePassData_UnsafeGraphContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1091646, XrefRangeEnd = 1091656, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _RenderFinalSetup_b__155_0(PostProcessingFinalSetupPassData data, RasterGraphContext context)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[2];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)data);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)context));
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__RenderFinalSetup_b__155_0_Internal_Void_PostProcessingFinalSetupPassData_RasterGraphContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1091656, XrefRangeEnd = 1091677, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _RenderFinalFSRScale_b__157_0(PostProcessingFinalFSRScalePassData data, RasterGraphContext context)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[2];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)data);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)context));
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__RenderFinalFSRScale_b__157_0_Internal_Void_PostProcessingFinalFSRScalePassData_RasterGraphContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1091677, XrefRangeEnd = 1091729, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _RenderFinalBlit_b__160_0(PostProcessingFinalBlitPassData data, RasterGraphContext context)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[2];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)data);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)context));
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__RenderFinalBlit_b__160_0_Internal_Void_PostProcessingFinalBlitPassData_RasterGraphContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1091729, XrefRangeEnd = 1091774, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _RenderUberPost_b__164_0(UberPostPassData data, RasterGraphContext context)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[2];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)data);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)context));
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__RenderUberPost_b__164_0_Internal_Void_UberPostPassData_RasterGraphContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1091774, XrefRangeEnd = 1091782, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _RenderPostProcessingRenderGraph_b__166_0(PostFXSetupPassData data, RasterGraphContext context)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[2];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)data);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)context));
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__RenderPostProcessingRenderGraph_b__166_0_Internal_Void_PostFXSetupPassData_RasterGraphContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		public __c(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	[ObfuscatedName("UnityEngine.Rendering.Universal.PostProcessPass+<>c__DisplayClass89_0")]
	public sealed class __c__DisplayClass89_0 : Il2CppSystem.ValueType
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_source;

		private static readonly System.IntPtr NativeFieldInfoPtr_destination;

		private static readonly System.IntPtr NativeFieldInfoPtr___4__this;

		private static readonly System.IntPtr NativeFieldInfoPtr_amountOfPassesRemaining;

		private static readonly System.IntPtr NativeFieldInfoPtr_cmd;

		public unsafe RTHandle source
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_source);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<RTHandle>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_source)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		public unsafe RTHandle destination
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_destination);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<RTHandle>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_destination)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		public unsafe PostProcessPass __4__this
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr___4__this);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<PostProcessPass>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr___4__this)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		public unsafe int amountOfPassesRemaining
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_amountOfPassesRemaining);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_amountOfPassesRemaining)) = value;
			}
		}

		public unsafe CommandBuffer cmd
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cmd);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<CommandBuffer>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cmd)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		static __c__DisplayClass89_0()
		{
			Il2CppClassPointerStore<__c__DisplayClass89_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PostProcessPass>.NativeClassPtr, "<>c__DisplayClass89_0");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<__c__DisplayClass89_0>.NativeClassPtr);
			NativeFieldInfoPtr_source = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c__DisplayClass89_0>.NativeClassPtr, "source");
			NativeFieldInfoPtr_destination = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c__DisplayClass89_0>.NativeClassPtr, "destination");
			NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c__DisplayClass89_0>.NativeClassPtr, "<>4__this");
			NativeFieldInfoPtr_amountOfPassesRemaining = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c__DisplayClass89_0>.NativeClassPtr, "amountOfPassesRemaining");
			NativeFieldInfoPtr_cmd = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c__DisplayClass89_0>.NativeClassPtr, "cmd");
		}

		public __c__DisplayClass89_0(System.IntPtr pointer)
			: base(pointer)
		{
		}

		public __c__DisplayClass89_0()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<__c__DisplayClass89_0>.NativeClassPtr))
		{
		}
	}

	private static readonly System.IntPtr NativeFieldInfoPtr_m_Descriptor;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_Source;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_Destination;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_Depth;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_InternalLut;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_MotionVectors;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_FullCoCTexture;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_HalfCoCTexture;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_PingTexture;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_PongTexture;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_BloomMipDown;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_BloomMipUp;

	private static readonly System.IntPtr NativeFieldInfoPtr__BloomMipUp;

	private static readonly System.IntPtr NativeFieldInfoPtr__BloomMipDown;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_BlendTexture;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_EdgeColorTexture;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_EdgeStencilTexture;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_TempTarget;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_TempTarget2;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_StreakTmpTexture;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_StreakTmpTexture2;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_ScreenSpaceLensFlareResult;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_UserLut;

	private static readonly System.IntPtr NativeFieldInfoPtr_k_RenderPostProcessingTag;

	private static readonly System.IntPtr NativeFieldInfoPtr_k_RenderFinalPostProcessingTag;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_ProfilingRenderPostProcessing;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_ProfilingRenderFinalPostProcessing;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_Materials;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_Data;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_DepthOfField;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_MotionBlur;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_LensFlareScreenSpace;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_PaniniProjection;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_Bloom;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_LensDistortion;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_ChromaticAberration;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_Vignette;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_ColorLookup;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_ColorAdjustments;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_Tonemapping;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_FilmGrain;

	private static readonly System.IntPtr NativeFieldInfoPtr_k_GaussianDoFPassComputeCoc;

	private static readonly System.IntPtr NativeFieldInfoPtr_k_GaussianDoFPassDownscalePrefilter;

	private static readonly System.IntPtr NativeFieldInfoPtr_k_GaussianDoFPassBlurH;

	private static readonly System.IntPtr NativeFieldInfoPtr_k_GaussianDoFPassBlurV;

	private static readonly System.IntPtr NativeFieldInfoPtr_k_GaussianDoFPassComposite;

	private static readonly System.IntPtr NativeFieldInfoPtr_k_BokehDoFPassComputeCoc;

	private static readonly System.IntPtr NativeFieldInfoPtr_k_BokehDoFPassDownscalePrefilter;

	private static readonly System.IntPtr NativeFieldInfoPtr_k_BokehDoFPassBlur;

	private static readonly System.IntPtr NativeFieldInfoPtr_k_BokehDoFPassPostFilter;

	private static readonly System.IntPtr NativeFieldInfoPtr_k_BokehDoFPassComposite;

	private static readonly System.IntPtr NativeFieldInfoPtr_k_MaxPyramidSize;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_DefaultColorFormat;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_DefaultColorFormatIsAlpha;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_SMAAEdgeFormat;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_GaussianCoCFormat;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_DitheringTextureIndex;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_MRT2;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_BokehKernel;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_BokehHash;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_BokehMaxRadius;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_BokehRCPAspect;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_IsFinalPass;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_HasFinalPass;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_EnableColorEncodingIfNeeded;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_UseFastSRGBLinearConversion;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_SupportScreenSpaceLensFlare;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_SupportDataDrivenLensFlare;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_ResolveToScreen;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_UseSwapBuffer;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_ScalingSetupTarget;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_UpscaledTarget;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_BlitMaterial;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_BloomParamsPrev;

	private static readonly System.IntPtr NativeFieldInfoPtr_k_ShaderPropertyId_ViewProjM;

	private static readonly System.IntPtr NativeFieldInfoPtr_k_ShaderPropertyId_PrevViewProjM;

	private static readonly System.IntPtr NativeFieldInfoPtr_k_ShaderPropertyId_ViewProjMStereo;

	private static readonly System.IntPtr NativeFieldInfoPtr_k_ShaderPropertyId_PrevViewProjMStereo;

	private static readonly System.IntPtr NativeFieldInfoPtr_s_CameraDepthTextureID;

	private static readonly System.IntPtr NativeFieldInfoPtr__TemporalAATargetName;

	private static readonly System.IntPtr NativeFieldInfoPtr__UpscaledColorTargetName;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_RenderPassEvent_PostProcessData_byref_PostProcessParams_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Cleanup_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Dispose_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Setup_Public_Void_byref_RenderTextureDescriptor_byref_RTHandle_Boolean_byref_RTHandle_byref_RTHandle_byref_RTHandle_Boolean_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetupFinalPass_Public_Void_byref_RTHandle_Boolean_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnCameraSetup_Public_Virtual_Void_CommandBuffer_byref_RenderingData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CanRunOnTile_Public_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Void_ScriptableRenderContext_byref_RenderingData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsHDRFormat_Private_Boolean_GraphicsFormat_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsAlphaFormat_Private_Boolean_GraphicsFormat_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetCompatibleDescriptor_Private_RenderTextureDescriptor_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetCompatibleDescriptor_Private_RenderTextureDescriptor_Int32_Int32_GraphicsFormat_GraphicsFormat_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetCompatibleDescriptor_Internal_Static_RenderTextureDescriptor_RenderTextureDescriptor_Int32_Int32_GraphicsFormat_GraphicsFormat_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RequireSRGBConversionBlitToBackBuffer_Private_Boolean_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RequireHDROutput_Private_Boolean_UniversalCameraData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Render_Private_Void_CommandBuffer_byref_RenderingData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DoSubpixelMorphologicalAntialiasing_Private_Void_byref_CameraData_CommandBuffer_RTHandle_RTHandle_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DoDepthOfField_Private_Void_byref_CameraData_CommandBuffer_RTHandle_RTHandle_Rect_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DoGaussianDepthOfField_Private_Void_CommandBuffer_RTHandle_RTHandle_Rect_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_PrepareBokehKernel_Private_Void_Single_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetMaxBokehRadiusInPixels_Private_Static_Single_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DoBokehDepthOfField_Private_Void_CommandBuffer_RTHandle_RTHandle_Rect_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetLensFlareLightAttenuation_Private_Static_Single_Light_Camera_Vector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_LensFlareDataDrivenComputeOcclusion_Private_Void_byref_UniversalCameraData_CommandBuffer_RenderTargetIdentifier_Boolean_Single_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_LensFlareDataDriven_Private_Void_byref_UniversalCameraData_CommandBuffer_RenderTargetIdentifier_Boolean_Single_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DoLensFlareScreenSpace_Private_Void_Camera_CommandBuffer_RenderTargetIdentifier_RTHandle_RTHandle_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UpdateMotionBlurMatrices_Internal_Static_Void_byref_Material_Camera_XRPass_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DoMotionBlur_Private_Void_CommandBuffer_RTHandle_RTHandle_RTHandle_byref_CameraData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DoPaniniProjection_Private_Void_Camera_CommandBuffer_RTHandle_RTHandle_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CalcViewExtents_Private_Vector2_Camera_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CalcCropExtents_Private_Vector2_Camera_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetupBloom_Private_Void_CommandBuffer_RTHandle_Material_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetupLensDistortion_Private_Void_Material_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetupChromaticAberration_Private_Void_Material_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetupVignette_Private_Void_Material_XRPass_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetupColorGrading_Private_Void_CommandBuffer_byref_RenderingData_Material_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetupGrain_Private_Void_UniversalCameraData_Material_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetupDithering_Private_Void_UniversalCameraData_Material_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetupHDROutput_Private_Void_HDRDisplayInformation_ColorGamut_Material_Operation_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RenderFinalPass_Private_Void_CommandBuffer_byref_RenderingData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UpdateCameraResolution_Private_Void_RenderGraph_UniversalCameraData_Vector2Int_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RenderStopNaN_Public_Void_RenderGraph_RenderTextureDescriptor_byref_TextureHandle_byref_TextureHandle_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RenderSMAA_Public_Void_RenderGraph_UniversalResourceData_AntialiasingQuality_byref_TextureHandle_byref_TextureHandle_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UberPostSetupBloomPass_Public_Void_RenderGraph_byref_TextureHandle_Material_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CalcBloomResolution_Public_Vector2Int_Bloom_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CalcBloomMipCount_Public_Int32_Bloom_Vector2Int_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RenderBloomTexture_Public_Void_RenderGraph_byref_TextureHandle_byref_TextureHandle_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RenderDoF_Public_Void_RenderGraph_UniversalResourceData_UniversalCameraData_byref_TextureHandle_byref_TextureHandle_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RenderDoFGaussian_Public_Void_RenderGraph_UniversalResourceData_UniversalCameraData_byref_TextureHandle_TextureHandle_byref_Material_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RenderDoFBokeh_Public_Void_RenderGraph_UniversalResourceData_UniversalCameraData_byref_TextureHandle_byref_TextureHandle_byref_Material_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RenderPaniniProjection_Public_Void_RenderGraph_Camera_byref_TextureHandle_byref_TextureHandle_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RenderTemporalAA_Private_Void_RenderGraph_UniversalResourceData_UniversalCameraData_byref_TextureHandle_byref_TextureHandle_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RenderSTP_Private_Void_RenderGraph_UniversalResourceData_UniversalCameraData_byref_TextureHandle_byref_TextureHandle_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RenderMotionBlur_Public_Void_RenderGraph_UniversalResourceData_UniversalCameraData_byref_TextureHandle_byref_TextureHandle_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_LensFlareDataDrivenComputeOcclusion_Private_Void_RenderGraph_UniversalResourceData_UniversalCameraData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RenderLensFlareDataDriven_Public_Void_RenderGraph_UniversalResourceData_UniversalCameraData_byref_TextureHandle_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RenderLensFlareScreenSpace_Public_TextureHandle_RenderGraph_Camera_byref_TextureHandle_TextureHandle_TextureHandle_Boolean_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ScaleViewportAndBlit_Private_Static_Void_RasterCommandBuffer_RTHandle_RTHandle_UniversalCameraData_Material_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RenderFinalSetup_Public_Void_RenderGraph_UniversalCameraData_byref_TextureHandle_byref_TextureHandle_byref_FinalBlitSettings_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RenderFinalFSRScale_Public_Void_RenderGraph_byref_TextureHandle_byref_TextureHandle_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RenderFinalBlit_Public_Void_RenderGraph_UniversalCameraData_byref_TextureHandle_byref_TextureHandle_byref_TextureHandle_byref_FinalBlitSettings_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RenderFinalPassRenderGraph_Public_Void_RenderGraph_ContextContainer_byref_TextureHandle_byref_TextureHandle_byref_TextureHandle_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_TryGetCachedUserLutTextureHandle_Private_TextureHandle_RenderGraph_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RenderUberPost_Public_Void_RenderGraph_ContextContainer_UniversalCameraData_UniversalPostProcessingData_byref_TextureHandle_byref_TextureHandle_byref_TextureHandle_byref_TextureHandle_Boolean_Boolean_Boolean_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RenderPostProcessingRenderGraph_Public_Void_RenderGraph_ContextContainer_byref_TextureHandle_byref_TextureHandle_byref_TextureHandle_byref_TextureHandle_Boolean_Boolean_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Method_Private_RTHandle_byref___c__DisplayClass89_0_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Method_Private_RTHandle_byref___c__DisplayClass89_0_1;

	private static readonly System.IntPtr NativeMethodInfoPtr_Method_Private_Void_byref_ScriptableRenderer_byref___c__DisplayClass89_0_0;

	public unsafe RenderTextureDescriptor m_Descriptor
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Descriptor);
			return *(RenderTextureDescriptor*)num;
		}
		set
		{
			*(RenderTextureDescriptor*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Descriptor)) = value;
		}
	}

	public unsafe RTHandle m_Source
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Source);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<RTHandle>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Source)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe RTHandle m_Destination
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Destination);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<RTHandle>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Destination)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe RTHandle m_Depth
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Depth);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<RTHandle>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Depth)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe RTHandle m_InternalLut
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_InternalLut);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<RTHandle>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_InternalLut)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe RTHandle m_MotionVectors
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_MotionVectors);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<RTHandle>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_MotionVectors)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe RTHandle m_FullCoCTexture
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_FullCoCTexture);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<RTHandle>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_FullCoCTexture)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe RTHandle m_HalfCoCTexture
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_HalfCoCTexture);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<RTHandle>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_HalfCoCTexture)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe RTHandle m_PingTexture
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_PingTexture);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<RTHandle>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_PingTexture)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe RTHandle m_PongTexture
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_PongTexture);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<RTHandle>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_PongTexture)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe Il2CppReferenceArray<RTHandle> m_BloomMipDown
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_BloomMipDown);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<RTHandle>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_BloomMipDown)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe Il2CppReferenceArray<RTHandle> m_BloomMipUp
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_BloomMipUp);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<RTHandle>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_BloomMipUp)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe Il2CppStructArray<TextureHandle> _BloomMipUp
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__BloomMipUp);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<TextureHandle>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__BloomMipUp)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe Il2CppStructArray<TextureHandle> _BloomMipDown
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__BloomMipDown);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<TextureHandle>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__BloomMipDown)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe RTHandle m_BlendTexture
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_BlendTexture);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<RTHandle>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_BlendTexture)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe RTHandle m_EdgeColorTexture
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_EdgeColorTexture);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<RTHandle>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_EdgeColorTexture)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe RTHandle m_EdgeStencilTexture
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_EdgeStencilTexture);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<RTHandle>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_EdgeStencilTexture)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe RTHandle m_TempTarget
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_TempTarget);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<RTHandle>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_TempTarget)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe RTHandle m_TempTarget2
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_TempTarget2);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<RTHandle>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_TempTarget2)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe RTHandle m_StreakTmpTexture
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_StreakTmpTexture);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<RTHandle>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_StreakTmpTexture)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe RTHandle m_StreakTmpTexture2
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_StreakTmpTexture2);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<RTHandle>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_StreakTmpTexture2)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe RTHandle m_ScreenSpaceLensFlareResult
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_ScreenSpaceLensFlareResult);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<RTHandle>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_ScreenSpaceLensFlareResult)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe RTHandle m_UserLut
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_UserLut);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<RTHandle>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_UserLut)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static string k_RenderPostProcessingTag
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_k_RenderPostProcessingTag, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_k_RenderPostProcessingTag, (void*)IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe static string k_RenderFinalPostProcessingTag
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_k_RenderFinalPostProcessingTag, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_k_RenderFinalPostProcessingTag, (void*)IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe static ProfilingSampler m_ProfilingRenderPostProcessing
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_m_ProfilingRenderPostProcessing, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<ProfilingSampler>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_m_ProfilingRenderPostProcessing, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static ProfilingSampler m_ProfilingRenderFinalPostProcessing
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_m_ProfilingRenderFinalPostProcessing, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<ProfilingSampler>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_m_ProfilingRenderFinalPostProcessing, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe MaterialLibrary m_Materials
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Materials);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<MaterialLibrary>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Materials)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe PostProcessData m_Data
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Data);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<PostProcessData>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Data)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe DepthOfField m_DepthOfField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_DepthOfField);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<DepthOfField>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_DepthOfField)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe MotionBlur m_MotionBlur
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_MotionBlur);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<MotionBlur>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_MotionBlur)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe ScreenSpaceLensFlare m_LensFlareScreenSpace
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_LensFlareScreenSpace);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ScreenSpaceLensFlare>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_LensFlareScreenSpace)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe PaniniProjection m_PaniniProjection
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_PaniniProjection);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<PaniniProjection>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_PaniniProjection)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe Bloom m_Bloom
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Bloom);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Bloom>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Bloom)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe LensDistortion m_LensDistortion
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_LensDistortion);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<LensDistortion>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_LensDistortion)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe ChromaticAberration m_ChromaticAberration
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_ChromaticAberration);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ChromaticAberration>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_ChromaticAberration)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe Vignette m_Vignette
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Vignette);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Vignette>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Vignette)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe ColorLookup m_ColorLookup
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_ColorLookup);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ColorLookup>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_ColorLookup)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe ColorAdjustments m_ColorAdjustments
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_ColorAdjustments);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ColorAdjustments>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_ColorAdjustments)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe Tonemapping m_Tonemapping
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Tonemapping);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Tonemapping>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Tonemapping)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe FilmGrain m_FilmGrain
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_FilmGrain);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<FilmGrain>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_FilmGrain)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static int k_GaussianDoFPassComputeCoc
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_k_GaussianDoFPassComputeCoc, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_k_GaussianDoFPassComputeCoc, (void*)(&value));
		}
	}

	public unsafe static int k_GaussianDoFPassDownscalePrefilter
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_k_GaussianDoFPassDownscalePrefilter, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_k_GaussianDoFPassDownscalePrefilter, (void*)(&value));
		}
	}

	public unsafe static int k_GaussianDoFPassBlurH
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_k_GaussianDoFPassBlurH, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_k_GaussianDoFPassBlurH, (void*)(&value));
		}
	}

	public unsafe static int k_GaussianDoFPassBlurV
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_k_GaussianDoFPassBlurV, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_k_GaussianDoFPassBlurV, (void*)(&value));
		}
	}

	public unsafe static int k_GaussianDoFPassComposite
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_k_GaussianDoFPassComposite, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_k_GaussianDoFPassComposite, (void*)(&value));
		}
	}

	public unsafe static int k_BokehDoFPassComputeCoc
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_k_BokehDoFPassComputeCoc, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_k_BokehDoFPassComputeCoc, (void*)(&value));
		}
	}

	public unsafe static int k_BokehDoFPassDownscalePrefilter
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_k_BokehDoFPassDownscalePrefilter, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_k_BokehDoFPassDownscalePrefilter, (void*)(&value));
		}
	}

	public unsafe static int k_BokehDoFPassBlur
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_k_BokehDoFPassBlur, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_k_BokehDoFPassBlur, (void*)(&value));
		}
	}

	public unsafe static int k_BokehDoFPassPostFilter
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_k_BokehDoFPassPostFilter, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_k_BokehDoFPassPostFilter, (void*)(&value));
		}
	}

	public unsafe static int k_BokehDoFPassComposite
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_k_BokehDoFPassComposite, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_k_BokehDoFPassComposite, (void*)(&value));
		}
	}

	public unsafe static int k_MaxPyramidSize
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_k_MaxPyramidSize, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_k_MaxPyramidSize, (void*)(&value));
		}
	}

	public unsafe GraphicsFormat m_DefaultColorFormat
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_DefaultColorFormat);
			return *(GraphicsFormat*)num;
		}
		set
		{
			*(GraphicsFormat*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_DefaultColorFormat)) = value;
		}
	}

	public unsafe bool m_DefaultColorFormatIsAlpha
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_DefaultColorFormatIsAlpha);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_DefaultColorFormatIsAlpha)) = value;
		}
	}

	public unsafe GraphicsFormat m_SMAAEdgeFormat
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_SMAAEdgeFormat);
			return *(GraphicsFormat*)num;
		}
		set
		{
			*(GraphicsFormat*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_SMAAEdgeFormat)) = value;
		}
	}

	public unsafe GraphicsFormat m_GaussianCoCFormat
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_GaussianCoCFormat);
			return *(GraphicsFormat*)num;
		}
		set
		{
			*(GraphicsFormat*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_GaussianCoCFormat)) = value;
		}
	}

	public unsafe int m_DitheringTextureIndex
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_DitheringTextureIndex);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_DitheringTextureIndex)) = value;
		}
	}

	public unsafe Il2CppStructArray<RenderTargetIdentifier> m_MRT2
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_MRT2);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<RenderTargetIdentifier>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_MRT2)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe Il2CppStructArray<Vector4> m_BokehKernel
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_BokehKernel);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<Vector4>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_BokehKernel)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe int m_BokehHash
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_BokehHash);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_BokehHash)) = value;
		}
	}

	public unsafe float m_BokehMaxRadius
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_BokehMaxRadius);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_BokehMaxRadius)) = value;
		}
	}

	public unsafe float m_BokehRCPAspect
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_BokehRCPAspect);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_BokehRCPAspect)) = value;
		}
	}

	public unsafe bool m_IsFinalPass
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_IsFinalPass);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_IsFinalPass)) = value;
		}
	}

	public unsafe bool m_HasFinalPass
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_HasFinalPass);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_HasFinalPass)) = value;
		}
	}

	public unsafe bool m_EnableColorEncodingIfNeeded
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_EnableColorEncodingIfNeeded);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_EnableColorEncodingIfNeeded)) = value;
		}
	}

	public unsafe bool m_UseFastSRGBLinearConversion
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_UseFastSRGBLinearConversion);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_UseFastSRGBLinearConversion)) = value;
		}
	}

	public unsafe bool m_SupportScreenSpaceLensFlare
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_SupportScreenSpaceLensFlare);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_SupportScreenSpaceLensFlare)) = value;
		}
	}

	public unsafe bool m_SupportDataDrivenLensFlare
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_SupportDataDrivenLensFlare);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_SupportDataDrivenLensFlare)) = value;
		}
	}

	public unsafe bool m_ResolveToScreen
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_ResolveToScreen);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_ResolveToScreen)) = value;
		}
	}

	public unsafe bool m_UseSwapBuffer
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_UseSwapBuffer);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_UseSwapBuffer)) = value;
		}
	}

	public unsafe RTHandle m_ScalingSetupTarget
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_ScalingSetupTarget);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<RTHandle>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_ScalingSetupTarget)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe RTHandle m_UpscaledTarget
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_UpscaledTarget);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<RTHandle>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_UpscaledTarget)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe Material m_BlitMaterial
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_BlitMaterial);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Material>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_BlitMaterial)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe BloomMaterialParams m_BloomParamsPrev
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_BloomParamsPrev);
			return *(BloomMaterialParams*)num;
		}
		set
		{
			*(BloomMaterialParams*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_BloomParamsPrev)) = value;
		}
	}

	public unsafe static int k_ShaderPropertyId_ViewProjM
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_k_ShaderPropertyId_ViewProjM, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_k_ShaderPropertyId_ViewProjM, (void*)(&value));
		}
	}

	public unsafe static int k_ShaderPropertyId_PrevViewProjM
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_k_ShaderPropertyId_PrevViewProjM, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_k_ShaderPropertyId_PrevViewProjM, (void*)(&value));
		}
	}

	public unsafe static int k_ShaderPropertyId_ViewProjMStereo
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_k_ShaderPropertyId_ViewProjMStereo, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_k_ShaderPropertyId_ViewProjMStereo, (void*)(&value));
		}
	}

	public unsafe static int k_ShaderPropertyId_PrevViewProjMStereo
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_k_ShaderPropertyId_PrevViewProjMStereo, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_k_ShaderPropertyId_PrevViewProjMStereo, (void*)(&value));
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

	public unsafe static string _TemporalAATargetName
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr__TemporalAATargetName, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr__TemporalAATargetName, (void*)IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe static string _UpscaledColorTargetName
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr__UpscaledColorTargetName, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr__UpscaledColorTargetName, (void*)IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	static PostProcessPass()
	{
		Il2CppClassPointerStore<PostProcessPass>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Universal.Runtime.dll", "UnityEngine.Rendering.Universal", "PostProcessPass");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PostProcessPass>.NativeClassPtr);
		NativeFieldInfoPtr_m_Descriptor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PostProcessPass>.NativeClassPtr, "m_Descriptor");
		NativeFieldInfoPtr_m_Source = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PostProcessPass>.NativeClassPtr, "m_Source");
		NativeFieldInfoPtr_m_Destination = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PostProcessPass>.NativeClassPtr, "m_Destination");
		NativeFieldInfoPtr_m_Depth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PostProcessPass>.NativeClassPtr, "m_Depth");
		NativeFieldInfoPtr_m_InternalLut = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PostProcessPass>.NativeClassPtr, "m_InternalLut");
		NativeFieldInfoPtr_m_MotionVectors = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PostProcessPass>.NativeClassPtr, "m_MotionVectors");
		NativeFieldInfoPtr_m_FullCoCTexture = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PostProcessPass>.NativeClassPtr, "m_FullCoCTexture");
		NativeFieldInfoPtr_m_HalfCoCTexture = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PostProcessPass>.NativeClassPtr, "m_HalfCoCTexture");
		NativeFieldInfoPtr_m_PingTexture = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PostProcessPass>.NativeClassPtr, "m_PingTexture");
		NativeFieldInfoPtr_m_PongTexture = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PostProcessPass>.NativeClassPtr, "m_PongTexture");
		NativeFieldInfoPtr_m_BloomMipDown = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PostProcessPass>.NativeClassPtr, "m_BloomMipDown");
		NativeFieldInfoPtr_m_BloomMipUp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PostProcessPass>.NativeClassPtr, "m_BloomMipUp");
		NativeFieldInfoPtr__BloomMipUp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PostProcessPass>.NativeClassPtr, "_BloomMipUp");
		NativeFieldInfoPtr__BloomMipDown = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PostProcessPass>.NativeClassPtr, "_BloomMipDown");
		NativeFieldInfoPtr_m_BlendTexture = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PostProcessPass>.NativeClassPtr, "m_BlendTexture");
		NativeFieldInfoPtr_m_EdgeColorTexture = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PostProcessPass>.NativeClassPtr, "m_EdgeColorTexture");
		NativeFieldInfoPtr_m_EdgeStencilTexture = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PostProcessPass>.NativeClassPtr, "m_EdgeStencilTexture");
		NativeFieldInfoPtr_m_TempTarget = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PostProcessPass>.NativeClassPtr, "m_TempTarget");
		NativeFieldInfoPtr_m_TempTarget2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PostProcessPass>.NativeClassPtr, "m_TempTarget2");
		NativeFieldInfoPtr_m_StreakTmpTexture = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PostProcessPass>.NativeClassPtr, "m_StreakTmpTexture");
		NativeFieldInfoPtr_m_StreakTmpTexture2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PostProcessPass>.NativeClassPtr, "m_StreakTmpTexture2");
		NativeFieldInfoPtr_m_ScreenSpaceLensFlareResult = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PostProcessPass>.NativeClassPtr, "m_ScreenSpaceLensFlareResult");
		NativeFieldInfoPtr_m_UserLut = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PostProcessPass>.NativeClassPtr, "m_UserLut");
		NativeFieldInfoPtr_k_RenderPostProcessingTag = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PostProcessPass>.NativeClassPtr, "k_RenderPostProcessingTag");
		NativeFieldInfoPtr_k_RenderFinalPostProcessingTag = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PostProcessPass>.NativeClassPtr, "k_RenderFinalPostProcessingTag");
		NativeFieldInfoPtr_m_ProfilingRenderPostProcessing = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PostProcessPass>.NativeClassPtr, "m_ProfilingRenderPostProcessing");
		NativeFieldInfoPtr_m_ProfilingRenderFinalPostProcessing = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PostProcessPass>.NativeClassPtr, "m_ProfilingRenderFinalPostProcessing");
		NativeFieldInfoPtr_m_Materials = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PostProcessPass>.NativeClassPtr, "m_Materials");
		NativeFieldInfoPtr_m_Data = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PostProcessPass>.NativeClassPtr, "m_Data");
		NativeFieldInfoPtr_m_DepthOfField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PostProcessPass>.NativeClassPtr, "m_DepthOfField");
		NativeFieldInfoPtr_m_MotionBlur = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PostProcessPass>.NativeClassPtr, "m_MotionBlur");
		NativeFieldInfoPtr_m_LensFlareScreenSpace = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PostProcessPass>.NativeClassPtr, "m_LensFlareScreenSpace");
		NativeFieldInfoPtr_m_PaniniProjection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PostProcessPass>.NativeClassPtr, "m_PaniniProjection");
		NativeFieldInfoPtr_m_Bloom = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PostProcessPass>.NativeClassPtr, "m_Bloom");
		NativeFieldInfoPtr_m_LensDistortion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PostProcessPass>.NativeClassPtr, "m_LensDistortion");
		NativeFieldInfoPtr_m_ChromaticAberration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PostProcessPass>.NativeClassPtr, "m_ChromaticAberration");
		NativeFieldInfoPtr_m_Vignette = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PostProcessPass>.NativeClassPtr, "m_Vignette");
		NativeFieldInfoPtr_m_ColorLookup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PostProcessPass>.NativeClassPtr, "m_ColorLookup");
		NativeFieldInfoPtr_m_ColorAdjustments = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PostProcessPass>.NativeClassPtr, "m_ColorAdjustments");
		NativeFieldInfoPtr_m_Tonemapping = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PostProcessPass>.NativeClassPtr, "m_Tonemapping");
		NativeFieldInfoPtr_m_FilmGrain = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PostProcessPass>.NativeClassPtr, "m_FilmGrain");
		NativeFieldInfoPtr_k_GaussianDoFPassComputeCoc = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PostProcessPass>.NativeClassPtr, "k_GaussianDoFPassComputeCoc");
		NativeFieldInfoPtr_k_GaussianDoFPassDownscalePrefilter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PostProcessPass>.NativeClassPtr, "k_GaussianDoFPassDownscalePrefilter");
		NativeFieldInfoPtr_k_GaussianDoFPassBlurH = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PostProcessPass>.NativeClassPtr, "k_GaussianDoFPassBlurH");
		NativeFieldInfoPtr_k_GaussianDoFPassBlurV = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PostProcessPass>.NativeClassPtr, "k_GaussianDoFPassBlurV");
		NativeFieldInfoPtr_k_GaussianDoFPassComposite = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PostProcessPass>.NativeClassPtr, "k_GaussianDoFPassComposite");
		NativeFieldInfoPtr_k_BokehDoFPassComputeCoc = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PostProcessPass>.NativeClassPtr, "k_BokehDoFPassComputeCoc");
		NativeFieldInfoPtr_k_BokehDoFPassDownscalePrefilter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PostProcessPass>.NativeClassPtr, "k_BokehDoFPassDownscalePrefilter");
		NativeFieldInfoPtr_k_BokehDoFPassBlur = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PostProcessPass>.NativeClassPtr, "k_BokehDoFPassBlur");
		NativeFieldInfoPtr_k_BokehDoFPassPostFilter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PostProcessPass>.NativeClassPtr, "k_BokehDoFPassPostFilter");
		NativeFieldInfoPtr_k_BokehDoFPassComposite = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PostProcessPass>.NativeClassPtr, "k_BokehDoFPassComposite");
		NativeFieldInfoPtr_k_MaxPyramidSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PostProcessPass>.NativeClassPtr, "k_MaxPyramidSize");
		NativeFieldInfoPtr_m_DefaultColorFormat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PostProcessPass>.NativeClassPtr, "m_DefaultColorFormat");
		NativeFieldInfoPtr_m_DefaultColorFormatIsAlpha = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PostProcessPass>.NativeClassPtr, "m_DefaultColorFormatIsAlpha");
		NativeFieldInfoPtr_m_SMAAEdgeFormat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PostProcessPass>.NativeClassPtr, "m_SMAAEdgeFormat");
		NativeFieldInfoPtr_m_GaussianCoCFormat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PostProcessPass>.NativeClassPtr, "m_GaussianCoCFormat");
		NativeFieldInfoPtr_m_DitheringTextureIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PostProcessPass>.NativeClassPtr, "m_DitheringTextureIndex");
		NativeFieldInfoPtr_m_MRT2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PostProcessPass>.NativeClassPtr, "m_MRT2");
		NativeFieldInfoPtr_m_BokehKernel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PostProcessPass>.NativeClassPtr, "m_BokehKernel");
		NativeFieldInfoPtr_m_BokehHash = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PostProcessPass>.NativeClassPtr, "m_BokehHash");
		NativeFieldInfoPtr_m_BokehMaxRadius = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PostProcessPass>.NativeClassPtr, "m_BokehMaxRadius");
		NativeFieldInfoPtr_m_BokehRCPAspect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PostProcessPass>.NativeClassPtr, "m_BokehRCPAspect");
		NativeFieldInfoPtr_m_IsFinalPass = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PostProcessPass>.NativeClassPtr, "m_IsFinalPass");
		NativeFieldInfoPtr_m_HasFinalPass = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PostProcessPass>.NativeClassPtr, "m_HasFinalPass");
		NativeFieldInfoPtr_m_EnableColorEncodingIfNeeded = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PostProcessPass>.NativeClassPtr, "m_EnableColorEncodingIfNeeded");
		NativeFieldInfoPtr_m_UseFastSRGBLinearConversion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PostProcessPass>.NativeClassPtr, "m_UseFastSRGBLinearConversion");
		NativeFieldInfoPtr_m_SupportScreenSpaceLensFlare = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PostProcessPass>.NativeClassPtr, "m_SupportScreenSpaceLensFlare");
		NativeFieldInfoPtr_m_SupportDataDrivenLensFlare = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PostProcessPass>.NativeClassPtr, "m_SupportDataDrivenLensFlare");
		NativeFieldInfoPtr_m_ResolveToScreen = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PostProcessPass>.NativeClassPtr, "m_ResolveToScreen");
		NativeFieldInfoPtr_m_UseSwapBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PostProcessPass>.NativeClassPtr, "m_UseSwapBuffer");
		NativeFieldInfoPtr_m_ScalingSetupTarget = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PostProcessPass>.NativeClassPtr, "m_ScalingSetupTarget");
		NativeFieldInfoPtr_m_UpscaledTarget = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PostProcessPass>.NativeClassPtr, "m_UpscaledTarget");
		NativeFieldInfoPtr_m_BlitMaterial = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PostProcessPass>.NativeClassPtr, "m_BlitMaterial");
		NativeFieldInfoPtr_m_BloomParamsPrev = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PostProcessPass>.NativeClassPtr, "m_BloomParamsPrev");
		NativeFieldInfoPtr_k_ShaderPropertyId_ViewProjM = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PostProcessPass>.NativeClassPtr, "k_ShaderPropertyId_ViewProjM");
		NativeFieldInfoPtr_k_ShaderPropertyId_PrevViewProjM = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PostProcessPass>.NativeClassPtr, "k_ShaderPropertyId_PrevViewProjM");
		NativeFieldInfoPtr_k_ShaderPropertyId_ViewProjMStereo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PostProcessPass>.NativeClassPtr, "k_ShaderPropertyId_ViewProjMStereo");
		NativeFieldInfoPtr_k_ShaderPropertyId_PrevViewProjMStereo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PostProcessPass>.NativeClassPtr, "k_ShaderPropertyId_PrevViewProjMStereo");
		NativeFieldInfoPtr_s_CameraDepthTextureID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PostProcessPass>.NativeClassPtr, "s_CameraDepthTextureID");
		NativeFieldInfoPtr__TemporalAATargetName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PostProcessPass>.NativeClassPtr, "_TemporalAATargetName");
		NativeFieldInfoPtr__UpscaledColorTargetName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PostProcessPass>.NativeClassPtr, "_UpscaledColorTargetName");
		NativeMethodInfoPtr__ctor_Public_Void_RenderPassEvent_PostProcessData_byref_PostProcessParams_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PostProcessPass>.NativeClassPtr, 100664960);
		NativeMethodInfoPtr_Cleanup_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PostProcessPass>.NativeClassPtr, 100664961);
		NativeMethodInfoPtr_Dispose_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PostProcessPass>.NativeClassPtr, 100664962);
		NativeMethodInfoPtr_Setup_Public_Void_byref_RenderTextureDescriptor_byref_RTHandle_Boolean_byref_RTHandle_byref_RTHandle_byref_RTHandle_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PostProcessPass>.NativeClassPtr, 100664963);
		NativeMethodInfoPtr_SetupFinalPass_Public_Void_byref_RTHandle_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PostProcessPass>.NativeClassPtr, 100664964);
		NativeMethodInfoPtr_OnCameraSetup_Public_Virtual_Void_CommandBuffer_byref_RenderingData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PostProcessPass>.NativeClassPtr, 100664965);
		NativeMethodInfoPtr_CanRunOnTile_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PostProcessPass>.NativeClassPtr, 100664966);
		NativeMethodInfoPtr_Execute_Public_Virtual_Void_ScriptableRenderContext_byref_RenderingData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PostProcessPass>.NativeClassPtr, 100664967);
		NativeMethodInfoPtr_IsHDRFormat_Private_Boolean_GraphicsFormat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PostProcessPass>.NativeClassPtr, 100664968);
		NativeMethodInfoPtr_IsAlphaFormat_Private_Boolean_GraphicsFormat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PostProcessPass>.NativeClassPtr, 100664969);
		NativeMethodInfoPtr_GetCompatibleDescriptor_Private_RenderTextureDescriptor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PostProcessPass>.NativeClassPtr, 100664970);
		NativeMethodInfoPtr_GetCompatibleDescriptor_Private_RenderTextureDescriptor_Int32_Int32_GraphicsFormat_GraphicsFormat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PostProcessPass>.NativeClassPtr, 100664971);
		NativeMethodInfoPtr_GetCompatibleDescriptor_Internal_Static_RenderTextureDescriptor_RenderTextureDescriptor_Int32_Int32_GraphicsFormat_GraphicsFormat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PostProcessPass>.NativeClassPtr, 100664972);
		NativeMethodInfoPtr_RequireSRGBConversionBlitToBackBuffer_Private_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PostProcessPass>.NativeClassPtr, 100664973);
		NativeMethodInfoPtr_RequireHDROutput_Private_Boolean_UniversalCameraData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PostProcessPass>.NativeClassPtr, 100664974);
		NativeMethodInfoPtr_Render_Private_Void_CommandBuffer_byref_RenderingData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PostProcessPass>.NativeClassPtr, 100664975);
		NativeMethodInfoPtr_DoSubpixelMorphologicalAntialiasing_Private_Void_byref_CameraData_CommandBuffer_RTHandle_RTHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PostProcessPass>.NativeClassPtr, 100664976);
		NativeMethodInfoPtr_DoDepthOfField_Private_Void_byref_CameraData_CommandBuffer_RTHandle_RTHandle_Rect_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PostProcessPass>.NativeClassPtr, 100664977);
		NativeMethodInfoPtr_DoGaussianDepthOfField_Private_Void_CommandBuffer_RTHandle_RTHandle_Rect_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PostProcessPass>.NativeClassPtr, 100664978);
		NativeMethodInfoPtr_PrepareBokehKernel_Private_Void_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PostProcessPass>.NativeClassPtr, 100664979);
		NativeMethodInfoPtr_GetMaxBokehRadiusInPixels_Private_Static_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PostProcessPass>.NativeClassPtr, 100664980);
		NativeMethodInfoPtr_DoBokehDepthOfField_Private_Void_CommandBuffer_RTHandle_RTHandle_Rect_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PostProcessPass>.NativeClassPtr, 100664981);
		NativeMethodInfoPtr_GetLensFlareLightAttenuation_Private_Static_Single_Light_Camera_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PostProcessPass>.NativeClassPtr, 100664982);
		NativeMethodInfoPtr_LensFlareDataDrivenComputeOcclusion_Private_Void_byref_UniversalCameraData_CommandBuffer_RenderTargetIdentifier_Boolean_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PostProcessPass>.NativeClassPtr, 100664983);
		NativeMethodInfoPtr_LensFlareDataDriven_Private_Void_byref_UniversalCameraData_CommandBuffer_RenderTargetIdentifier_Boolean_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PostProcessPass>.NativeClassPtr, 100664984);
		NativeMethodInfoPtr_DoLensFlareScreenSpace_Private_Void_Camera_CommandBuffer_RenderTargetIdentifier_RTHandle_RTHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PostProcessPass>.NativeClassPtr, 100664985);
		NativeMethodInfoPtr_UpdateMotionBlurMatrices_Internal_Static_Void_byref_Material_Camera_XRPass_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PostProcessPass>.NativeClassPtr, 100664986);
		NativeMethodInfoPtr_DoMotionBlur_Private_Void_CommandBuffer_RTHandle_RTHandle_RTHandle_byref_CameraData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PostProcessPass>.NativeClassPtr, 100664987);
		NativeMethodInfoPtr_DoPaniniProjection_Private_Void_Camera_CommandBuffer_RTHandle_RTHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PostProcessPass>.NativeClassPtr, 100664988);
		NativeMethodInfoPtr_CalcViewExtents_Private_Vector2_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PostProcessPass>.NativeClassPtr, 100664989);
		NativeMethodInfoPtr_CalcCropExtents_Private_Vector2_Camera_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PostProcessPass>.NativeClassPtr, 100664990);
		NativeMethodInfoPtr_SetupBloom_Private_Void_CommandBuffer_RTHandle_Material_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PostProcessPass>.NativeClassPtr, 100664991);
		NativeMethodInfoPtr_SetupLensDistortion_Private_Void_Material_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PostProcessPass>.NativeClassPtr, 100664992);
		NativeMethodInfoPtr_SetupChromaticAberration_Private_Void_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PostProcessPass>.NativeClassPtr, 100664993);
		NativeMethodInfoPtr_SetupVignette_Private_Void_Material_XRPass_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PostProcessPass>.NativeClassPtr, 100664994);
		NativeMethodInfoPtr_SetupColorGrading_Private_Void_CommandBuffer_byref_RenderingData_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PostProcessPass>.NativeClassPtr, 100664995);
		NativeMethodInfoPtr_SetupGrain_Private_Void_UniversalCameraData_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PostProcessPass>.NativeClassPtr, 100664996);
		NativeMethodInfoPtr_SetupDithering_Private_Void_UniversalCameraData_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PostProcessPass>.NativeClassPtr, 100664997);
		NativeMethodInfoPtr_SetupHDROutput_Private_Void_HDRDisplayInformation_ColorGamut_Material_Operation_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PostProcessPass>.NativeClassPtr, 100664998);
		NativeMethodInfoPtr_RenderFinalPass_Private_Void_CommandBuffer_byref_RenderingData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PostProcessPass>.NativeClassPtr, 100664999);
		NativeMethodInfoPtr_UpdateCameraResolution_Private_Void_RenderGraph_UniversalCameraData_Vector2Int_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PostProcessPass>.NativeClassPtr, 100665000);
		NativeMethodInfoPtr_RenderStopNaN_Public_Void_RenderGraph_RenderTextureDescriptor_byref_TextureHandle_byref_TextureHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PostProcessPass>.NativeClassPtr, 100665001);
		NativeMethodInfoPtr_RenderSMAA_Public_Void_RenderGraph_UniversalResourceData_AntialiasingQuality_byref_TextureHandle_byref_TextureHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PostProcessPass>.NativeClassPtr, 100665002);
		NativeMethodInfoPtr_UberPostSetupBloomPass_Public_Void_RenderGraph_byref_TextureHandle_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PostProcessPass>.NativeClassPtr, 100665003);
		NativeMethodInfoPtr_CalcBloomResolution_Public_Vector2Int_Bloom_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PostProcessPass>.NativeClassPtr, 100665004);
		NativeMethodInfoPtr_CalcBloomMipCount_Public_Int32_Bloom_Vector2Int_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PostProcessPass>.NativeClassPtr, 100665005);
		NativeMethodInfoPtr_RenderBloomTexture_Public_Void_RenderGraph_byref_TextureHandle_byref_TextureHandle_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PostProcessPass>.NativeClassPtr, 100665006);
		NativeMethodInfoPtr_RenderDoF_Public_Void_RenderGraph_UniversalResourceData_UniversalCameraData_byref_TextureHandle_byref_TextureHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PostProcessPass>.NativeClassPtr, 100665007);
		NativeMethodInfoPtr_RenderDoFGaussian_Public_Void_RenderGraph_UniversalResourceData_UniversalCameraData_byref_TextureHandle_TextureHandle_byref_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PostProcessPass>.NativeClassPtr, 100665008);
		NativeMethodInfoPtr_RenderDoFBokeh_Public_Void_RenderGraph_UniversalResourceData_UniversalCameraData_byref_TextureHandle_byref_TextureHandle_byref_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PostProcessPass>.NativeClassPtr, 100665009);
		NativeMethodInfoPtr_RenderPaniniProjection_Public_Void_RenderGraph_Camera_byref_TextureHandle_byref_TextureHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PostProcessPass>.NativeClassPtr, 100665010);
		NativeMethodInfoPtr_RenderTemporalAA_Private_Void_RenderGraph_UniversalResourceData_UniversalCameraData_byref_TextureHandle_byref_TextureHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PostProcessPass>.NativeClassPtr, 100665011);
		NativeMethodInfoPtr_RenderSTP_Private_Void_RenderGraph_UniversalResourceData_UniversalCameraData_byref_TextureHandle_byref_TextureHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PostProcessPass>.NativeClassPtr, 100665012);
		NativeMethodInfoPtr_RenderMotionBlur_Public_Void_RenderGraph_UniversalResourceData_UniversalCameraData_byref_TextureHandle_byref_TextureHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PostProcessPass>.NativeClassPtr, 100665013);
		NativeMethodInfoPtr_LensFlareDataDrivenComputeOcclusion_Private_Void_RenderGraph_UniversalResourceData_UniversalCameraData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PostProcessPass>.NativeClassPtr, 100665014);
		NativeMethodInfoPtr_RenderLensFlareDataDriven_Public_Void_RenderGraph_UniversalResourceData_UniversalCameraData_byref_TextureHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PostProcessPass>.NativeClassPtr, 100665015);
		NativeMethodInfoPtr_RenderLensFlareScreenSpace_Public_TextureHandle_RenderGraph_Camera_byref_TextureHandle_TextureHandle_TextureHandle_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PostProcessPass>.NativeClassPtr, 100665016);
		NativeMethodInfoPtr_ScaleViewportAndBlit_Private_Static_Void_RasterCommandBuffer_RTHandle_RTHandle_UniversalCameraData_Material_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PostProcessPass>.NativeClassPtr, 100665017);
		NativeMethodInfoPtr_RenderFinalSetup_Public_Void_RenderGraph_UniversalCameraData_byref_TextureHandle_byref_TextureHandle_byref_FinalBlitSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PostProcessPass>.NativeClassPtr, 100665018);
		NativeMethodInfoPtr_RenderFinalFSRScale_Public_Void_RenderGraph_byref_TextureHandle_byref_TextureHandle_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PostProcessPass>.NativeClassPtr, 100665019);
		NativeMethodInfoPtr_RenderFinalBlit_Public_Void_RenderGraph_UniversalCameraData_byref_TextureHandle_byref_TextureHandle_byref_TextureHandle_byref_FinalBlitSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PostProcessPass>.NativeClassPtr, 100665020);
		NativeMethodInfoPtr_RenderFinalPassRenderGraph_Public_Void_RenderGraph_ContextContainer_byref_TextureHandle_byref_TextureHandle_byref_TextureHandle_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PostProcessPass>.NativeClassPtr, 100665021);
		NativeMethodInfoPtr_TryGetCachedUserLutTextureHandle_Private_TextureHandle_RenderGraph_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PostProcessPass>.NativeClassPtr, 100665022);
		NativeMethodInfoPtr_RenderUberPost_Public_Void_RenderGraph_ContextContainer_UniversalCameraData_UniversalPostProcessingData_byref_TextureHandle_byref_TextureHandle_byref_TextureHandle_byref_TextureHandle_Boolean_Boolean_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PostProcessPass>.NativeClassPtr, 100665023);
		NativeMethodInfoPtr_RenderPostProcessingRenderGraph_Public_Void_RenderGraph_ContextContainer_byref_TextureHandle_byref_TextureHandle_byref_TextureHandle_byref_TextureHandle_Boolean_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PostProcessPass>.NativeClassPtr, 100665024);
		NativeMethodInfoPtr_Method_Private_RTHandle_byref___c__DisplayClass89_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PostProcessPass>.NativeClassPtr, 100665026);
		NativeMethodInfoPtr_Method_Private_RTHandle_byref___c__DisplayClass89_0_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PostProcessPass>.NativeClassPtr, 100665027);
		NativeMethodInfoPtr_Method_Private_Void_byref_ScriptableRenderer_byref___c__DisplayClass89_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PostProcessPass>.NativeClassPtr, 100665028);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1091894, RefRangeEnd = 1091896, XrefRangeStart = 1091782, XrefRangeEnd = 1091894, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe PostProcessPass(RenderPassEvent evt, PostProcessData data, ref PostProcessParams postProcessParams)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PostProcessPass>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&evt);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)data);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)postProcessParams);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_RenderPassEvent_PostProcessData_byref_PostProcessParams_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 1091921, RefRangeEnd = 1091925, XrefRangeStart = 1091896, XrefRangeEnd = 1091921, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Cleanup()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Cleanup_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 1091944, RefRangeEnd = 1091947, XrefRangeStart = 1091925, XrefRangeEnd = 1091944, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Dispose()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Dispose_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1091947, XrefRangeEnd = 1091958, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Setup([In] ref RenderTextureDescriptor baseDescriptor, [In] ref RTHandle source, bool resolveToScreen, [In] ref RTHandle depth, [In] ref RTHandle internalLut, [In] ref RTHandle motionVectors, bool hasFinalPass, bool enableColorEncoding)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[8];
		*ptr = (nint)Unsafe.AsPointer(ref baseDescriptor);
		byte* num = (byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)));
		System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)source);
		*(System.IntPtr**)num = &intPtr;
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &resolveToScreen;
		byte* num2 = (byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)));
		System.IntPtr intPtr2 = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)depth);
		*(System.IntPtr**)num2 = &intPtr2;
		byte* num3 = (byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)));
		System.IntPtr intPtr3 = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)internalLut);
		*(System.IntPtr**)num3 = &intPtr3;
		byte* num4 = (byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)));
		System.IntPtr intPtr4 = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)motionVectors);
		*(System.IntPtr**)num4 = &intPtr4;
		*(bool**)((byte*)ptr + checked((nuint)6u * unchecked((nuint)sizeof(System.IntPtr)))) = &hasFinalPass;
		*(bool**)((byte*)ptr + checked((nuint)7u * unchecked((nuint)sizeof(System.IntPtr)))) = &enableColorEncoding;
		Unsafe.SkipInit(out System.IntPtr intPtr5);
		System.IntPtr intPtr6 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Setup_Public_Void_byref_RenderTextureDescriptor_byref_RTHandle_Boolean_byref_RTHandle_byref_RTHandle_byref_RTHandle_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr5);
		Il2CppException.RaiseExceptionIfNecessary(intPtr5);
		System.IntPtr intPtr7 = intPtr;
		source = ((intPtr7 == (System.IntPtr)0) ? null : new RTHandle(intPtr7));
		System.IntPtr intPtr8 = intPtr2;
		depth = ((intPtr8 == (System.IntPtr)0) ? null : new RTHandle(intPtr8));
		System.IntPtr intPtr9 = intPtr3;
		internalLut = ((intPtr9 == (System.IntPtr)0) ? null : new RTHandle(intPtr9));
		System.IntPtr intPtr10 = intPtr4;
		motionVectors = ((intPtr10 == (System.IntPtr)0) ? null : new RTHandle(intPtr10));
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1091958, XrefRangeEnd = 1091964, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetupFinalPass([In] ref RTHandle source, bool useSwapBuffer = false, bool enableColorEncoding = true)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)source);
		*ptr = (nint)(&intPtr);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &useSwapBuffer;
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &enableColorEncoding;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetupFinalPass_Public_Void_byref_RTHandle_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		System.IntPtr intPtr4 = intPtr;
		source = ((intPtr4 == (System.IntPtr)0) ? null : new RTHandle(intPtr4));
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 180371, RefRangeEnd = 180372, XrefRangeStart = 180371, XrefRangeEnd = 180372, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

	[CallerCount(143)]
	[CachedScanResults(RefRangeStart = 9, RefRangeEnd = 152, XrefRangeStart = 9, XrefRangeEnd = 152, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool CanRunOnTile()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CanRunOnTile_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1091964, XrefRangeEnd = 1092037, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1092037, XrefRangeEnd = 1092044, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool IsHDRFormat(GraphicsFormat format)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&format);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsHDRFormat_Private_Boolean_GraphicsFormat_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1092044, XrefRangeEnd = 1092048, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool IsAlphaFormat(GraphicsFormat format)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&format);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsAlphaFormat_Private_Boolean_GraphicsFormat_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1092050, RefRangeEnd = 1092051, XrefRangeStart = 1092048, XrefRangeEnd = 1092050, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe RenderTextureDescriptor GetCompatibleDescriptor()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetCompatibleDescriptor_Private_RenderTextureDescriptor_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(RenderTextureDescriptor*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(15)]
	[CachedScanResults(RefRangeStart = 1092055, RefRangeEnd = 1092070, XrefRangeStart = 1092051, XrefRangeEnd = 1092055, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe RenderTextureDescriptor GetCompatibleDescriptor(int width, int height, GraphicsFormat format, GraphicsFormat depthStencilFormat = GraphicsFormat.None)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = (nint)(&width);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &height;
		*(GraphicsFormat**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &format;
		*(GraphicsFormat**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &depthStencilFormat;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetCompatibleDescriptor_Private_RenderTextureDescriptor_Int32_Int32_GraphicsFormat_GraphicsFormat_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(RenderTextureDescriptor*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1092071, RefRangeEnd = 1092072, XrefRangeStart = 1092070, XrefRangeEnd = 1092071, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static RenderTextureDescriptor GetCompatibleDescriptor(RenderTextureDescriptor desc, int width, int height, GraphicsFormat format, GraphicsFormat depthStencilFormat = GraphicsFormat.None)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = (nint)(&desc);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &width;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &height;
		*(GraphicsFormat**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &format;
		*(GraphicsFormat**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &depthStencilFormat;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetCompatibleDescriptor_Internal_Static_RenderTextureDescriptor_RenderTextureDescriptor_Int32_Int32_GraphicsFormat_GraphicsFormat_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(RenderTextureDescriptor*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	public unsafe bool RequireSRGBConversionBlitToBackBuffer(bool requireSrgbConversion)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&requireSrgbConversion);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RequireSRGBConversionBlitToBackBuffer_Private_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1092072, XrefRangeEnd = 1092073, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool RequireHDROutput(UniversalCameraData cameraData)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)cameraData);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RequireHDROutput_Private_Boolean_UniversalCameraData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1092318, RefRangeEnd = 1092319, XrefRangeStart = 1092073, XrefRangeEnd = 1092318, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Render(CommandBuffer cmd, ref RenderingData renderingData)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)cmd);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)renderingData);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Render_Private_Void_CommandBuffer_byref_RenderingData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1092380, RefRangeEnd = 1092381, XrefRangeStart = 1092319, XrefRangeEnd = 1092380, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void DoSubpixelMorphologicalAntialiasing(ref CameraData cameraData, CommandBuffer cmd, RTHandle source, RTHandle destination)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)cameraData);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)cmd);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)source);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)destination);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DoSubpixelMorphologicalAntialiasing_Private_Void_byref_CameraData_CommandBuffer_RTHandle_RTHandle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1092381, XrefRangeEnd = 1092383, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void DoDepthOfField(ref CameraData cameraData, CommandBuffer cmd, RTHandle source, RTHandle destination, Rect pixelRect)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)cameraData);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)cmd);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)source);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)destination);
		*(Rect**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &pixelRect;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DoDepthOfField_Private_Void_byref_CameraData_CommandBuffer_RTHandle_RTHandle_Rect_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1092448, RefRangeEnd = 1092449, XrefRangeStart = 1092383, XrefRangeEnd = 1092448, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void DoGaussianDepthOfField(CommandBuffer cmd, RTHandle source, RTHandle destination, Rect pixelRect, bool enableAlphaOutput)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)cmd);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)source);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)destination);
		*(Rect**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &pixelRect;
		*(bool**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &enableAlphaOutput;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DoGaussianDepthOfField_Private_Void_CommandBuffer_RTHandle_RTHandle_Rect_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1092461, RefRangeEnd = 1092463, XrefRangeStart = 1092449, XrefRangeEnd = 1092461, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void PrepareBokehKernel(float maxRadius, float rcpAspect)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&maxRadius);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &rcpAspect;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_PrepareBokehKernel_Private_Void_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	public unsafe static float GetMaxBokehRadiusInPixels(float viewportHeight)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&viewportHeight);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetMaxBokehRadiusInPixels_Private_Static_Single_Single_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1092517, RefRangeEnd = 1092519, XrefRangeStart = 1092463, XrefRangeEnd = 1092517, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void DoBokehDepthOfField(CommandBuffer cmd, RTHandle source, RTHandle destination, Rect pixelRect, bool enableAlphaOutput)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)cmd);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)source);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)destination);
		*(Rect**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &pixelRect;
		*(bool**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &enableAlphaOutput;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DoBokehDepthOfField_Private_Void_CommandBuffer_RTHandle_RTHandle_Rect_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 1092526, RefRangeEnd = 1092530, XrefRangeStart = 1092519, XrefRangeEnd = 1092526, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static float GetLensFlareLightAttenuation(Light light, Camera cam, Vector3 wo)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)light);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)cam);
		*(Vector3**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &wo;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetLensFlareLightAttenuation_Private_Static_Single_Light_Camera_Vector3_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1092569, RefRangeEnd = 1092570, XrefRangeStart = 1092530, XrefRangeEnd = 1092569, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void LensFlareDataDrivenComputeOcclusion(ref UniversalCameraData cameraData, CommandBuffer cmd, RenderTargetIdentifier source, bool usePanini, float paniniDistance, float paniniCropToFit)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[6];
		System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)cameraData);
		*ptr = (nint)(&intPtr);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)cmd);
		*(RenderTargetIdentifier**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &source;
		*(bool**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &usePanini;
		*(float**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &paniniDistance;
		*(float**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = &paniniCropToFit;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_LensFlareDataDrivenComputeOcclusion_Private_Void_byref_UniversalCameraData_CommandBuffer_RenderTargetIdentifier_Boolean_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		System.IntPtr intPtr4 = intPtr;
		cameraData = ((intPtr4 == (System.IntPtr)0) ? null : new UniversalCameraData(intPtr4));
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1092624, RefRangeEnd = 1092625, XrefRangeStart = 1092570, XrefRangeEnd = 1092624, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void LensFlareDataDriven(ref UniversalCameraData cameraData, CommandBuffer cmd, RenderTargetIdentifier source, bool usePanini, float paniniDistance, float paniniCropToFit)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[6];
		System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)cameraData);
		*ptr = (nint)(&intPtr);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)cmd);
		*(RenderTargetIdentifier**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &source;
		*(bool**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &usePanini;
		*(float**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &paniniDistance;
		*(float**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = &paniniCropToFit;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_LensFlareDataDriven_Private_Void_byref_UniversalCameraData_CommandBuffer_RenderTargetIdentifier_Boolean_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		System.IntPtr intPtr4 = intPtr;
		cameraData = ((intPtr4 == (System.IntPtr)0) ? null : new UniversalCameraData(intPtr4));
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1092655, RefRangeEnd = 1092656, XrefRangeStart = 1092625, XrefRangeEnd = 1092655, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void DoLensFlareScreenSpace(Camera camera, CommandBuffer cmd, RenderTargetIdentifier source, RTHandle originalBloomTexture, RTHandle screenSpaceLensFlareBloomMipTexture)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)camera);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)cmd);
		*(RenderTargetIdentifier**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &source;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)originalBloomTexture);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)screenSpaceLensFlareBloomMipTexture);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DoLensFlareScreenSpace_Private_Void_Camera_CommandBuffer_RenderTargetIdentifier_RTHandle_RTHandle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1092668, RefRangeEnd = 1092670, XrefRangeStart = 1092656, XrefRangeEnd = 1092668, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void UpdateMotionBlurMatrices(ref Material material, Camera camera, XRPass xr)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)material);
		*ptr = (nint)(&intPtr);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)camera);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)xr);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UpdateMotionBlurMatrices_Internal_Static_Void_byref_Material_Camera_XRPass_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		System.IntPtr intPtr4 = intPtr;
		material = ((intPtr4 == (System.IntPtr)0) ? null : new Material(intPtr4));
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1092698, RefRangeEnd = 1092699, XrefRangeStart = 1092670, XrefRangeEnd = 1092698, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void DoMotionBlur(CommandBuffer cmd, RTHandle source, RTHandle destination, RTHandle motionVectors, ref CameraData cameraData)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)cmd);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)source);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)destination);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)motionVectors);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)cameraData);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DoMotionBlur_Private_Void_CommandBuffer_RTHandle_RTHandle_RTHandle_byref_CameraData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1092718, RefRangeEnd = 1092719, XrefRangeStart = 1092699, XrefRangeEnd = 1092718, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void DoPaniniProjection(Camera camera, CommandBuffer cmd, RTHandle source, RTHandle destination)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)camera);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)cmd);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)source);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)destination);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DoPaniniProjection_Private_Void_Camera_CommandBuffer_RTHandle_RTHandle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1092719, XrefRangeEnd = 1092721, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Vector2 CalcViewExtents(Camera camera)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)camera);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CalcViewExtents_Private_Vector2_Camera_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(Vector2*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1092725, RefRangeEnd = 1092727, XrefRangeStart = 1092721, XrefRangeEnd = 1092725, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Vector2 CalcCropExtents(Camera camera, float d)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)camera);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &d;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CalcCropExtents_Private_Vector2_Camera_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(Vector2*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1092813, RefRangeEnd = 1092814, XrefRangeStart = 1092727, XrefRangeEnd = 1092813, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetupBloom(CommandBuffer cmd, RTHandle source, Material uberMaterial, bool enableAlphaOutput)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)cmd);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)source);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)uberMaterial);
		*(bool**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &enableAlphaOutput;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetupBloom_Private_Void_CommandBuffer_RTHandle_Material_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1092828, RefRangeEnd = 1092830, XrefRangeStart = 1092814, XrefRangeEnd = 1092828, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetupLensDistortion(Material material, bool isSceneView)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)material);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &isSceneView;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetupLensDistortion_Private_Void_Material_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1092839, RefRangeEnd = 1092841, XrefRangeStart = 1092830, XrefRangeEnd = 1092839, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetupChromaticAberration(Material material)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)material);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetupChromaticAberration_Private_Void_Material_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1092857, RefRangeEnd = 1092859, XrefRangeStart = 1092841, XrefRangeEnd = 1092857, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetupVignette(Material material, XRPass xrPass)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)material);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)xrPass);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetupVignette_Private_Void_Material_XRPass_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1092883, RefRangeEnd = 1092884, XrefRangeStart = 1092859, XrefRangeEnd = 1092883, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetupColorGrading(CommandBuffer cmd, ref RenderingData renderingData, Material material)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)cmd);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)renderingData);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)material);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetupColorGrading_Private_Void_CommandBuffer_byref_RenderingData_Material_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1092884, XrefRangeEnd = 1092889, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetupGrain(UniversalCameraData cameraData, Material material)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)cameraData);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)material);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetupGrain_Private_Void_UniversalCameraData_Material_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1092889, XrefRangeEnd = 1092893, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetupDithering(UniversalCameraData cameraData, Material material)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)cameraData);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)material);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetupDithering_Private_Void_UniversalCameraData_Material_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(6)]
	[CachedScanResults(RefRangeStart = 1092909, RefRangeEnd = 1092915, XrefRangeStart = 1092893, XrefRangeEnd = 1092909, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetupHDROutput(HDROutputUtils.HDRDisplayInformation hdrDisplayInformation, ColorGamut hdrDisplayColorGamut, Material material, HDROutputUtils.Operation hdrOperations, bool rendersOverlayUI)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = (nint)(&hdrDisplayInformation);
		*(ColorGamut**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &hdrDisplayColorGamut;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)material);
		*(HDROutputUtils.Operation**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &hdrOperations;
		*(bool**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &rendersOverlayUI;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetupHDROutput_Private_Void_HDRDisplayInformation_ColorGamut_Material_Operation_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1093033, RefRangeEnd = 1093034, XrefRangeStart = 1092915, XrefRangeEnd = 1093033, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void RenderFinalPass(CommandBuffer cmd, ref RenderingData renderingData)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)cmd);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)renderingData);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RenderFinalPass_Private_Void_CommandBuffer_byref_RenderingData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1093072, RefRangeEnd = 1093073, XrefRangeStart = 1093034, XrefRangeEnd = 1093072, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void UpdateCameraResolution(RenderGraph renderGraph, UniversalCameraData cameraData, Vector2Int newCameraTargetSize)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)renderGraph);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)cameraData);
		*(Vector2Int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &newCameraTargetSize;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UpdateCameraResolution_Private_Void_RenderGraph_UniversalCameraData_Vector2Int_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1093128, RefRangeEnd = 1093129, XrefRangeStart = 1093073, XrefRangeEnd = 1093128, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void RenderStopNaN(RenderGraph renderGraph, RenderTextureDescriptor cameraTargetDescriptor, [In] ref TextureHandle activeCameraColor, out TextureHandle stopNaNTarget)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)renderGraph);
		*(RenderTextureDescriptor**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &cameraTargetDescriptor;
		*(void**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref activeCameraColor);
		*(void**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref stopNaNTarget);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RenderStopNaN_Public_Void_RenderGraph_RenderTextureDescriptor_byref_TextureHandle_byref_TextureHandle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1093317, RefRangeEnd = 1093318, XrefRangeStart = 1093129, XrefRangeEnd = 1093317, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void RenderSMAA(RenderGraph renderGraph, UniversalResourceData resourceData, AntialiasingQuality antialiasingQuality, [In] ref TextureHandle source, out TextureHandle SMAATarget)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)renderGraph);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)resourceData);
		*(AntialiasingQuality**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &antialiasingQuality;
		*(void**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref source);
		*(void**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref SMAATarget);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RenderSMAA_Public_Void_RenderGraph_UniversalResourceData_AntialiasingQuality_byref_TextureHandle_byref_TextureHandle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1093376, RefRangeEnd = 1093377, XrefRangeStart = 1093318, XrefRangeEnd = 1093376, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void UberPostSetupBloomPass(RenderGraph rendergraph, [In] ref TextureHandle bloomTexture, Material uberMaterial)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)rendergraph);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref bloomTexture);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)uberMaterial);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UberPostSetupBloomPass_Public_Void_RenderGraph_byref_TextureHandle_Material_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1093378, RefRangeEnd = 1093380, XrefRangeStart = 1093377, XrefRangeEnd = 1093378, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Vector2Int CalcBloomResolution(Bloom bloom)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)bloom);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CalcBloomResolution_Public_Vector2Int_Bloom_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(Vector2Int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1093388, RefRangeEnd = 1093390, XrefRangeStart = 1093380, XrefRangeEnd = 1093388, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int CalcBloomMipCount(Bloom bloom, Vector2Int bloomResolution)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)bloom);
		*(Vector2Int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &bloomResolution;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CalcBloomMipCount_Public_Int32_Bloom_Vector2Int_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1093499, RefRangeEnd = 1093500, XrefRangeStart = 1093390, XrefRangeEnd = 1093499, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void RenderBloomTexture(RenderGraph renderGraph, [In] ref TextureHandle source, out TextureHandle destination, bool enableAlphaOutput)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)renderGraph);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref source);
		*(void**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref destination);
		*(bool**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &enableAlphaOutput;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RenderBloomTexture_Public_Void_RenderGraph_byref_TextureHandle_byref_TextureHandle_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1093519, RefRangeEnd = 1093520, XrefRangeStart = 1093500, XrefRangeEnd = 1093519, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void RenderDoF(RenderGraph renderGraph, UniversalResourceData resourceData, UniversalCameraData cameraData, [In] ref TextureHandle source, out TextureHandle destination)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)renderGraph);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)resourceData);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)cameraData);
		*(void**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref source);
		*(void**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref destination);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RenderDoF_Public_Void_RenderGraph_UniversalResourceData_UniversalCameraData_byref_TextureHandle_byref_TextureHandle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1093520, XrefRangeEnd = 1093599, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void RenderDoFGaussian(RenderGraph renderGraph, UniversalResourceData resourceData, UniversalCameraData cameraData, [In] ref TextureHandle source, TextureHandle destination, ref Material dofMaterial)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[6];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)renderGraph);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)resourceData);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)cameraData);
		*(void**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref source);
		*(TextureHandle**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &destination;
		byte* num = (byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)));
		System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dofMaterial);
		*(System.IntPtr**)num = &intPtr;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RenderDoFGaussian_Public_Void_RenderGraph_UniversalResourceData_UniversalCameraData_byref_TextureHandle_TextureHandle_byref_Material_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		System.IntPtr intPtr4 = intPtr;
		dofMaterial = ((intPtr4 == (System.IntPtr)0) ? null : new Material(intPtr4));
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1093675, RefRangeEnd = 1093676, XrefRangeStart = 1093599, XrefRangeEnd = 1093675, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void RenderDoFBokeh(RenderGraph renderGraph, UniversalResourceData resourceData, UniversalCameraData cameraData, [In] ref TextureHandle source, [In] ref TextureHandle destination, ref Material dofMaterial)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[6];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)renderGraph);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)resourceData);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)cameraData);
		*(void**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref source);
		*(void**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref destination);
		byte* num = (byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)));
		System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dofMaterial);
		*(System.IntPtr**)num = &intPtr;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RenderDoFBokeh_Public_Void_RenderGraph_UniversalResourceData_UniversalCameraData_byref_TextureHandle_byref_TextureHandle_byref_Material_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		System.IntPtr intPtr4 = intPtr;
		dofMaterial = ((intPtr4 == (System.IntPtr)0) ? null : new Material(intPtr4));
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1093738, RefRangeEnd = 1093739, XrefRangeStart = 1093676, XrefRangeEnd = 1093738, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void RenderPaniniProjection(RenderGraph renderGraph, Camera camera, [In] ref TextureHandle source, out TextureHandle destination)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)renderGraph);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)camera);
		*(void**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref source);
		*(void**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref destination);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RenderPaniniProjection_Public_Void_RenderGraph_Camera_byref_TextureHandle_byref_TextureHandle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1093739, XrefRangeEnd = 1093756, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void RenderTemporalAA(RenderGraph renderGraph, UniversalResourceData resourceData, UniversalCameraData cameraData, ref TextureHandle source, out TextureHandle destination)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)renderGraph);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)resourceData);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)cameraData);
		*(void**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref source);
		*(void**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref destination);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RenderTemporalAA_Private_Void_RenderGraph_UniversalResourceData_UniversalCameraData_byref_TextureHandle_byref_TextureHandle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1093777, RefRangeEnd = 1093778, XrefRangeStart = 1093756, XrefRangeEnd = 1093777, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void RenderSTP(RenderGraph renderGraph, UniversalResourceData resourceData, UniversalCameraData cameraData, ref TextureHandle source, out TextureHandle destination)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)renderGraph);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)resourceData);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)cameraData);
		*(void**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref source);
		*(void**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref destination);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RenderSTP_Private_Void_RenderGraph_UniversalResourceData_UniversalCameraData_byref_TextureHandle_byref_TextureHandle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1093853, RefRangeEnd = 1093854, XrefRangeStart = 1093778, XrefRangeEnd = 1093853, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void RenderMotionBlur(RenderGraph renderGraph, UniversalResourceData resourceData, UniversalCameraData cameraData, [In] ref TextureHandle source, out TextureHandle destination)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)renderGraph);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)resourceData);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)cameraData);
		*(void**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref source);
		*(void**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref destination);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RenderMotionBlur_Public_Void_RenderGraph_UniversalResourceData_UniversalCameraData_byref_TextureHandle_byref_TextureHandle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1093908, RefRangeEnd = 1093909, XrefRangeStart = 1093854, XrefRangeEnd = 1093908, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void LensFlareDataDrivenComputeOcclusion(RenderGraph renderGraph, UniversalResourceData resourceData, UniversalCameraData cameraData)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)renderGraph);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)resourceData);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)cameraData);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_LensFlareDataDrivenComputeOcclusion_Private_Void_RenderGraph_UniversalResourceData_UniversalCameraData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1093966, RefRangeEnd = 1093967, XrefRangeStart = 1093909, XrefRangeEnd = 1093966, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void RenderLensFlareDataDriven(RenderGraph renderGraph, UniversalResourceData resourceData, UniversalCameraData cameraData, [In] ref TextureHandle destination)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)renderGraph);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)resourceData);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)cameraData);
		*(void**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref destination);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RenderLensFlareDataDriven_Public_Void_RenderGraph_UniversalResourceData_UniversalCameraData_byref_TextureHandle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1094043, RefRangeEnd = 1094044, XrefRangeStart = 1093967, XrefRangeEnd = 1094043, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe TextureHandle RenderLensFlareScreenSpace(RenderGraph renderGraph, Camera camera, [In] ref TextureHandle destination, TextureHandle originalBloomTexture, TextureHandle screenSpaceLensFlareBloomMipTexture, bool enableXR, bool sameInputOutputTex)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[7];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)renderGraph);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)camera);
		*(void**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref destination);
		*(TextureHandle**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &originalBloomTexture;
		*(TextureHandle**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &screenSpaceLensFlareBloomMipTexture;
		*(bool**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = &enableXR;
		*(bool**)((byte*)ptr + checked((nuint)6u * unchecked((nuint)sizeof(System.IntPtr)))) = &sameInputOutputTex;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RenderLensFlareScreenSpace_Public_TextureHandle_RenderGraph_Camera_byref_TextureHandle_TextureHandle_TextureHandle_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(TextureHandle*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1094061, RefRangeEnd = 1094063, XrefRangeStart = 1094044, XrefRangeEnd = 1094061, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void ScaleViewportAndBlit(RasterCommandBuffer cmd, RTHandle sourceTextureHdl, RTHandle dest, UniversalCameraData cameraData, Material material, bool hasFinalPass)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[6];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)cmd);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)sourceTextureHdl);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dest);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)cameraData);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)material);
		*(bool**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = &hasFinalPass;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ScaleViewportAndBlit_Private_Static_Void_RasterCommandBuffer_RTHandle_RTHandle_UniversalCameraData_Material_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1094136, RefRangeEnd = 1094137, XrefRangeStart = 1094063, XrefRangeEnd = 1094136, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void RenderFinalSetup(RenderGraph renderGraph, UniversalCameraData cameraData, [In] ref TextureHandle source, [In] ref TextureHandle destination, ref FinalBlitSettings settings)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)renderGraph);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)cameraData);
		*(void**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref source);
		*(void**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref destination);
		*(void**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref settings);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RenderFinalSetup_Public_Void_RenderGraph_UniversalCameraData_byref_TextureHandle_byref_TextureHandle_byref_FinalBlitSettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1094184, RefRangeEnd = 1094185, XrefRangeStart = 1094137, XrefRangeEnd = 1094184, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void RenderFinalFSRScale(RenderGraph renderGraph, [In] ref TextureHandle source, [In] ref TextureHandle destination, bool enableAlphaOutput)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)renderGraph);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref source);
		*(void**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref destination);
		*(bool**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &enableAlphaOutput;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RenderFinalFSRScale_Public_Void_RenderGraph_byref_TextureHandle_byref_TextureHandle_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1094249, RefRangeEnd = 1094250, XrefRangeStart = 1094185, XrefRangeEnd = 1094249, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void RenderFinalBlit(RenderGraph renderGraph, UniversalCameraData cameraData, [In] ref TextureHandle source, [In] ref TextureHandle overlayUITexture, [In] ref TextureHandle postProcessingTarget, ref FinalBlitSettings settings)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[6];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)renderGraph);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)cameraData);
		*(void**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref source);
		*(void**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref overlayUITexture);
		*(void**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref postProcessingTarget);
		*(void**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref settings);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RenderFinalBlit_Public_Void_RenderGraph_UniversalCameraData_byref_TextureHandle_byref_TextureHandle_byref_TextureHandle_byref_FinalBlitSettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1094330, RefRangeEnd = 1094331, XrefRangeStart = 1094250, XrefRangeEnd = 1094330, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void RenderFinalPassRenderGraph(RenderGraph renderGraph, ContextContainer frameData, [In] ref TextureHandle source, [In] ref TextureHandle overlayUITexture, [In] ref TextureHandle postProcessingTarget, bool enableColorEncodingIfNeeded)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[6];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)renderGraph);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)frameData);
		*(void**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref source);
		*(void**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref overlayUITexture);
		*(void**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref postProcessingTarget);
		*(bool**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = &enableColorEncodingIfNeeded;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RenderFinalPassRenderGraph_Public_Void_RenderGraph_ContextContainer_byref_TextureHandle_byref_TextureHandle_byref_TextureHandle_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1094348, RefRangeEnd = 1094349, XrefRangeStart = 1094331, XrefRangeEnd = 1094348, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe TextureHandle TryGetCachedUserLutTextureHandle(RenderGraph renderGraph)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)renderGraph);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_TryGetCachedUserLutTextureHandle_Private_TextureHandle_RenderGraph_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(TextureHandle*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1094437, RefRangeEnd = 1094438, XrefRangeStart = 1094349, XrefRangeEnd = 1094437, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void RenderUberPost(RenderGraph renderGraph, ContextContainer frameData, UniversalCameraData cameraData, UniversalPostProcessingData postProcessingData, [In] ref TextureHandle sourceTexture, [In] ref TextureHandle destTexture, [In] ref TextureHandle lutTexture, [In] ref TextureHandle overlayUITexture, bool requireHDROutput, bool enableAlphaOutput, bool resolveToDebugScreen, bool hasFinalPass)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[12];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)renderGraph);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)frameData);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)cameraData);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)postProcessingData);
		*(void**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref sourceTexture);
		*(void**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref destTexture);
		*(void**)((byte*)ptr + checked((nuint)6u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref lutTexture);
		*(void**)((byte*)ptr + checked((nuint)7u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref overlayUITexture);
		*(bool**)((byte*)ptr + checked((nuint)8u * unchecked((nuint)sizeof(System.IntPtr)))) = &requireHDROutput;
		*(bool**)((byte*)ptr + checked((nuint)9u * unchecked((nuint)sizeof(System.IntPtr)))) = &enableAlphaOutput;
		*(bool**)((byte*)ptr + checked((nuint)10u * unchecked((nuint)sizeof(System.IntPtr)))) = &resolveToDebugScreen;
		*(bool**)((byte*)ptr + checked((nuint)11u * unchecked((nuint)sizeof(System.IntPtr)))) = &hasFinalPass;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RenderUberPost_Public_Void_RenderGraph_ContextContainer_UniversalCameraData_UniversalPostProcessingData_byref_TextureHandle_byref_TextureHandle_byref_TextureHandle_byref_TextureHandle_Boolean_Boolean_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1094657, RefRangeEnd = 1094658, XrefRangeStart = 1094438, XrefRangeEnd = 1094657, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void RenderPostProcessingRenderGraph(RenderGraph renderGraph, ContextContainer frameData, [In] ref TextureHandle activeCameraColorTexture, [In] ref TextureHandle lutTexture, [In] ref TextureHandle overlayUITexture, [In] ref TextureHandle postProcessingTarget, bool hasFinalPass, bool resolveToDebugScreen, bool enableColorEndingIfNeeded)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[9];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)renderGraph);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)frameData);
		*(void**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref activeCameraColorTexture);
		*(void**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref lutTexture);
		*(void**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref overlayUITexture);
		*(void**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref postProcessingTarget);
		*(bool**)((byte*)ptr + checked((nuint)6u * unchecked((nuint)sizeof(System.IntPtr)))) = &hasFinalPass;
		*(bool**)((byte*)ptr + checked((nuint)7u * unchecked((nuint)sizeof(System.IntPtr)))) = &resolveToDebugScreen;
		*(bool**)((byte*)ptr + checked((nuint)8u * unchecked((nuint)sizeof(System.IntPtr)))) = &enableColorEndingIfNeeded;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RenderPostProcessingRenderGraph_Public_Void_RenderGraph_ContextContainer_byref_TextureHandle_byref_TextureHandle_byref_TextureHandle_byref_TextureHandle_Boolean_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	public unsafe RTHandle Method_Private_RTHandle_byref___c__DisplayClass89_0_0(ref __c__DisplayClass89_0 A_1)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)A_1);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Method_Private_RTHandle_byref___c__DisplayClass89_0_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<RTHandle>(intPtr2) : null;
	}

	[CallerCount(7)]
	[CachedScanResults(RefRangeStart = 1094674, RefRangeEnd = 1094681, XrefRangeStart = 1094658, XrefRangeEnd = 1094674, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe RTHandle Method_Private_RTHandle_byref___c__DisplayClass89_0_1(ref __c__DisplayClass89_0 A_1)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)A_1);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Method_Private_RTHandle_byref___c__DisplayClass89_0_1, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<RTHandle>(intPtr2) : null;
	}

	[CallerCount(7)]
	[CachedScanResults(RefRangeStart = 1094691, RefRangeEnd = 1094698, XrefRangeStart = 1094681, XrefRangeEnd = 1094691, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Method_Private_Void_byref_ScriptableRenderer_byref___c__DisplayClass89_0_0(ref ScriptableRenderer r, ref __c__DisplayClass89_0 A_2)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)r);
		*ptr = (nint)(&intPtr);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)A_2);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Method_Private_Void_byref_ScriptableRenderer_byref___c__DisplayClass89_0_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		System.IntPtr intPtr4 = intPtr;
		r = ((intPtr4 == (System.IntPtr)0) ? null : new ScriptableRenderer(intPtr4));
	}

	public PostProcessPass(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
