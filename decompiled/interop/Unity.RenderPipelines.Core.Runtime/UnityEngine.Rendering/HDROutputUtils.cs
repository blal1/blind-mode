using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem;

namespace UnityEngine.Rendering;

public static class HDROutputUtils : Il2CppSystem.Object
{
	[OriginalName("Unity.RenderPipelines.Core.Runtime.dll", "", "Operation")]
	[System.Flags]
	public enum Operation
	{
		None = 0,
		ColorConversion = 1,
		ColorEncoding = 2
	}

	[StructLayout(LayoutKind.Explicit)]
	public struct HDRDisplayInformation
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_maxFullFrameToneMapLuminance;

		private static readonly System.IntPtr NativeFieldInfoPtr_maxToneMapLuminance;

		private static readonly System.IntPtr NativeFieldInfoPtr_minToneMapLuminance;

		private static readonly System.IntPtr NativeFieldInfoPtr_paperWhiteNits;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_Single_0;

		[FieldOffset(0)]
		public int maxFullFrameToneMapLuminance;

		[FieldOffset(4)]
		public int maxToneMapLuminance;

		[FieldOffset(8)]
		public int minToneMapLuminance;

		[FieldOffset(12)]
		public float paperWhiteNits;

		static HDRDisplayInformation()
		{
			Il2CppClassPointerStore<HDRDisplayInformation>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<HDROutputUtils>.NativeClassPtr, "HDRDisplayInformation");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HDRDisplayInformation>.NativeClassPtr);
			NativeFieldInfoPtr_maxFullFrameToneMapLuminance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HDRDisplayInformation>.NativeClassPtr, "maxFullFrameToneMapLuminance");
			NativeFieldInfoPtr_maxToneMapLuminance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HDRDisplayInformation>.NativeClassPtr, "maxToneMapLuminance");
			NativeFieldInfoPtr_minToneMapLuminance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HDRDisplayInformation>.NativeClassPtr, "minToneMapLuminance");
			NativeFieldInfoPtr_paperWhiteNits = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HDRDisplayInformation>.NativeClassPtr, "paperWhiteNits");
			NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HDRDisplayInformation>.NativeClassPtr, 100666759);
		}

		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1053142, RefRangeEnd = 1053145, XrefRangeStart = 1053142, XrefRangeEnd = 1053142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe HDRDisplayInformation(int maxFullFrameToneMapLuminance, int maxToneMapLuminance, int minToneMapLuminance, float hdrPaperWhiteNits)
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[4];
			*ptr = (nint)(&maxFullFrameToneMapLuminance);
			*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &maxToneMapLuminance;
			*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &minToneMapLuminance;
			*(float**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &hdrPaperWhiteNits;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_Single_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		public unsafe Il2CppSystem.Object BoxIl2CppObject()
		{
			return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<HDRDisplayInformation>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
		}
	}

	public static class ShaderKeywords : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_HDR_COLORSPACE_CONVERSION;

		private static readonly System.IntPtr NativeFieldInfoPtr_HDR_ENCODING;

		private static readonly System.IntPtr NativeFieldInfoPtr_HDR_COLORSPACE_CONVERSION_AND_ENCODING;

		private static readonly System.IntPtr NativeFieldInfoPtr_HDR_INPUT;

		private static readonly System.IntPtr NativeFieldInfoPtr_HDRColorSpaceConversion;

		private static readonly System.IntPtr NativeFieldInfoPtr_HDREncoding;

		private static readonly System.IntPtr NativeFieldInfoPtr_HDRColorSpaceConversionAndEncoding;

		private static readonly System.IntPtr NativeFieldInfoPtr_HDRInput;

		public unsafe static string HDR_COLORSPACE_CONVERSION
		{
			get
			{
				Unsafe.SkipInit(out System.IntPtr intPtr);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_HDR_COLORSPACE_CONVERSION, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_HDR_COLORSPACE_CONVERSION, (void*)IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		public unsafe static string HDR_ENCODING
		{
			get
			{
				Unsafe.SkipInit(out System.IntPtr intPtr);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_HDR_ENCODING, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_HDR_ENCODING, (void*)IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		public unsafe static string HDR_COLORSPACE_CONVERSION_AND_ENCODING
		{
			get
			{
				Unsafe.SkipInit(out System.IntPtr intPtr);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_HDR_COLORSPACE_CONVERSION_AND_ENCODING, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_HDR_COLORSPACE_CONVERSION_AND_ENCODING, (void*)IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		public unsafe static string HDR_INPUT
		{
			get
			{
				Unsafe.SkipInit(out System.IntPtr intPtr);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_HDR_INPUT, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_HDR_INPUT, (void*)IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		public unsafe static ShaderKeyword HDRColorSpaceConversion
		{
			get
			{
				System.IntPtr intPtr = (nint)stackalloc byte[(int)(uint)IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ShaderKeyword>.NativeClassPtr, ref *(uint*)null)];
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_HDRColorSpaceConversion, (void*)intPtr);
				return new ShaderKeyword(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ShaderKeyword>.NativeClassPtr, intPtr));
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_HDRColorSpaceConversion, (void*)IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)value)));
			}
		}

		public unsafe static ShaderKeyword HDREncoding
		{
			get
			{
				System.IntPtr intPtr = (nint)stackalloc byte[(int)(uint)IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ShaderKeyword>.NativeClassPtr, ref *(uint*)null)];
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_HDREncoding, (void*)intPtr);
				return new ShaderKeyword(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ShaderKeyword>.NativeClassPtr, intPtr));
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_HDREncoding, (void*)IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)value)));
			}
		}

		public unsafe static ShaderKeyword HDRColorSpaceConversionAndEncoding
		{
			get
			{
				System.IntPtr intPtr = (nint)stackalloc byte[(int)(uint)IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ShaderKeyword>.NativeClassPtr, ref *(uint*)null)];
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_HDRColorSpaceConversionAndEncoding, (void*)intPtr);
				return new ShaderKeyword(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ShaderKeyword>.NativeClassPtr, intPtr));
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_HDRColorSpaceConversionAndEncoding, (void*)IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)value)));
			}
		}

		public unsafe static ShaderKeyword HDRInput
		{
			get
			{
				System.IntPtr intPtr = (nint)stackalloc byte[(int)(uint)IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ShaderKeyword>.NativeClassPtr, ref *(uint*)null)];
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_HDRInput, (void*)intPtr);
				return new ShaderKeyword(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ShaderKeyword>.NativeClassPtr, intPtr));
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_HDRInput, (void*)IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)value)));
			}
		}

		static ShaderKeywords()
		{
			Il2CppClassPointerStore<ShaderKeywords>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<HDROutputUtils>.NativeClassPtr, "ShaderKeywords");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ShaderKeywords>.NativeClassPtr);
			NativeFieldInfoPtr_HDR_COLORSPACE_CONVERSION = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderKeywords>.NativeClassPtr, "HDR_COLORSPACE_CONVERSION");
			NativeFieldInfoPtr_HDR_ENCODING = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderKeywords>.NativeClassPtr, "HDR_ENCODING");
			NativeFieldInfoPtr_HDR_COLORSPACE_CONVERSION_AND_ENCODING = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderKeywords>.NativeClassPtr, "HDR_COLORSPACE_CONVERSION_AND_ENCODING");
			NativeFieldInfoPtr_HDR_INPUT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderKeywords>.NativeClassPtr, "HDR_INPUT");
			NativeFieldInfoPtr_HDRColorSpaceConversion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderKeywords>.NativeClassPtr, "HDRColorSpaceConversion");
			NativeFieldInfoPtr_HDREncoding = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderKeywords>.NativeClassPtr, "HDREncoding");
			NativeFieldInfoPtr_HDRColorSpaceConversionAndEncoding = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderKeywords>.NativeClassPtr, "HDRColorSpaceConversionAndEncoding");
			NativeFieldInfoPtr_HDRInput = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderKeywords>.NativeClassPtr, "HDRInput");
		}

		public ShaderKeywords(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	public static class ShaderPropertyId : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_hdrColorSpace;

		private static readonly System.IntPtr NativeFieldInfoPtr_hdrEncoding;

		public unsafe static int hdrColorSpace
		{
			get
			{
				Unsafe.SkipInit(out int result);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_hdrColorSpace, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_hdrColorSpace, (void*)(&value));
			}
		}

		public unsafe static int hdrEncoding
		{
			get
			{
				Unsafe.SkipInit(out int result);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_hdrEncoding, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_hdrEncoding, (void*)(&value));
			}
		}

		static ShaderPropertyId()
		{
			Il2CppClassPointerStore<ShaderPropertyId>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<HDROutputUtils>.NativeClassPtr, "ShaderPropertyId");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ShaderPropertyId>.NativeClassPtr);
			NativeFieldInfoPtr_hdrColorSpace = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderPropertyId>.NativeClassPtr, "hdrColorSpace");
			NativeFieldInfoPtr_hdrEncoding = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderPropertyId>.NativeClassPtr, "hdrEncoding");
		}

		public ShaderPropertyId(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	private static readonly System.IntPtr NativeMethodInfoPtr_GetColorSpaceForGamut_Public_Static_Boolean_ColorGamut_byref_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetColorEncodingForGamut_Public_Static_Boolean_ColorGamut_byref_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ConfigureHDROutput_Public_Static_Void_Material_ColorGamut_Operation_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ConfigureHDROutput_Public_Static_Void_MaterialPropertyBlock_ColorGamut_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ConfigureHDROutput_Public_Static_Void_Material_Operation_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ConfigureHDROutput_Public_Static_Void_ComputeShader_ColorGamut_Operation_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsShaderVariantValid_Public_Static_Boolean_ShaderKeywordSet_Boolean_0;

	static HDROutputUtils()
	{
		Il2CppClassPointerStore<HDROutputUtils>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Core.Runtime.dll", "UnityEngine.Rendering", "HDROutputUtils");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HDROutputUtils>.NativeClassPtr);
		NativeMethodInfoPtr_GetColorSpaceForGamut_Public_Static_Boolean_ColorGamut_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HDROutputUtils>.NativeClassPtr, 100666752);
		NativeMethodInfoPtr_GetColorEncodingForGamut_Public_Static_Boolean_ColorGamut_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HDROutputUtils>.NativeClassPtr, 100666753);
		NativeMethodInfoPtr_ConfigureHDROutput_Public_Static_Void_Material_ColorGamut_Operation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HDROutputUtils>.NativeClassPtr, 100666754);
		NativeMethodInfoPtr_ConfigureHDROutput_Public_Static_Void_MaterialPropertyBlock_ColorGamut_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HDROutputUtils>.NativeClassPtr, 100666755);
		NativeMethodInfoPtr_ConfigureHDROutput_Public_Static_Void_Material_Operation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HDROutputUtils>.NativeClassPtr, 100666756);
		NativeMethodInfoPtr_ConfigureHDROutput_Public_Static_Void_ComputeShader_ColorGamut_Operation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HDROutputUtils>.NativeClassPtr, 100666757);
		NativeMethodInfoPtr_IsShaderVariantValid_Public_Static_Boolean_ShaderKeywordSet_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HDROutputUtils>.NativeClassPtr, 100666758);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 1053162, RefRangeEnd = 1053165, XrefRangeStart = 1053145, XrefRangeEnd = 1053162, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool GetColorSpaceForGamut(ColorGamut gamut, out int colorspace)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&gamut);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref colorspace);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetColorSpaceForGamut_Public_Static_Boolean_ColorGamut_byref_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 1053170, RefRangeEnd = 1053174, XrefRangeStart = 1053165, XrefRangeEnd = 1053170, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool GetColorEncodingForGamut(ColorGamut gamut, out int encoding)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&gamut);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref encoding);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetColorEncodingForGamut_Public_Static_Boolean_ColorGamut_byref_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 1053213, RefRangeEnd = 1053218, XrefRangeStart = 1053174, XrefRangeEnd = 1053213, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void ConfigureHDROutput(Material material, ColorGamut gamut, Operation operations)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)material);
		*(ColorGamut**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &gamut;
		*(Operation**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &operations;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ConfigureHDROutput_Public_Static_Void_Material_ColorGamut_Operation_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1053227, RefRangeEnd = 1053228, XrefRangeStart = 1053218, XrefRangeEnd = 1053227, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void ConfigureHDROutput(MaterialPropertyBlock properties, ColorGamut gamut)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)properties);
		*(ColorGamut**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &gamut;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ConfigureHDROutput_Public_Static_Void_MaterialPropertyBlock_ColorGamut_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1053258, RefRangeEnd = 1053259, XrefRangeStart = 1053228, XrefRangeEnd = 1053258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void ConfigureHDROutput(Material material, Operation operations)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)material);
		*(Operation**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &operations;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ConfigureHDROutput_Public_Static_Void_Material_Operation_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1053259, XrefRangeEnd = 1053298, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void ConfigureHDROutput(ComputeShader computeShader, ColorGamut gamut, Operation operations)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)computeShader);
		*(ColorGamut**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &gamut;
		*(Operation**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &operations;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ConfigureHDROutput_Public_Static_Void_ComputeShader_ColorGamut_Operation_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1053298, XrefRangeEnd = 1053315, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool IsShaderVariantValid(ShaderKeywordSet shaderKeywordSet, bool isHDREnabled)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&shaderKeywordSet);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &isHDREnabled;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsShaderVariantValid_Public_Static_Boolean_ShaderKeywordSet_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	public HDROutputUtils(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
