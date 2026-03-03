using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem;

namespace UnityEngine.Rendering;

public static class FSRUtils : Il2CppSystem.Object
{
	public static class ShaderConstants : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr__FsrEasuConstants0;

		private static readonly System.IntPtr NativeFieldInfoPtr__FsrEasuConstants1;

		private static readonly System.IntPtr NativeFieldInfoPtr__FsrEasuConstants2;

		private static readonly System.IntPtr NativeFieldInfoPtr__FsrEasuConstants3;

		private static readonly System.IntPtr NativeFieldInfoPtr__FsrRcasConstants;

		public unsafe static int _FsrEasuConstants0
		{
			get
			{
				Unsafe.SkipInit(out int result);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr__FsrEasuConstants0, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr__FsrEasuConstants0, (void*)(&value));
			}
		}

		public unsafe static int _FsrEasuConstants1
		{
			get
			{
				Unsafe.SkipInit(out int result);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr__FsrEasuConstants1, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr__FsrEasuConstants1, (void*)(&value));
			}
		}

		public unsafe static int _FsrEasuConstants2
		{
			get
			{
				Unsafe.SkipInit(out int result);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr__FsrEasuConstants2, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr__FsrEasuConstants2, (void*)(&value));
			}
		}

		public unsafe static int _FsrEasuConstants3
		{
			get
			{
				Unsafe.SkipInit(out int result);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr__FsrEasuConstants3, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr__FsrEasuConstants3, (void*)(&value));
			}
		}

		public unsafe static int _FsrRcasConstants
		{
			get
			{
				Unsafe.SkipInit(out int result);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr__FsrRcasConstants, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr__FsrRcasConstants, (void*)(&value));
			}
		}

		static ShaderConstants()
		{
			Il2CppClassPointerStore<ShaderConstants>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<FSRUtils>.NativeClassPtr, "ShaderConstants");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ShaderConstants>.NativeClassPtr);
			NativeFieldInfoPtr__FsrEasuConstants0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderConstants>.NativeClassPtr, "_FsrEasuConstants0");
			NativeFieldInfoPtr__FsrEasuConstants1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderConstants>.NativeClassPtr, "_FsrEasuConstants1");
			NativeFieldInfoPtr__FsrEasuConstants2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderConstants>.NativeClassPtr, "_FsrEasuConstants2");
			NativeFieldInfoPtr__FsrEasuConstants3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderConstants>.NativeClassPtr, "_FsrEasuConstants3");
			NativeFieldInfoPtr__FsrRcasConstants = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderConstants>.NativeClassPtr, "_FsrRcasConstants");
		}

		public ShaderConstants(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	private static readonly System.IntPtr NativeFieldInfoPtr_kMaxSharpnessStops;

	private static readonly System.IntPtr NativeFieldInfoPtr_kDefaultSharpnessStops;

	private static readonly System.IntPtr NativeFieldInfoPtr_kDefaultSharpnessLinear;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetEasuConstants_Public_Static_Void_CommandBuffer_Vector2_Vector2_Vector2_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetEasuConstants_Public_Static_Void_BaseCommandBuffer_Vector2_Vector2_Vector2_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetRcasConstants_Public_Static_Void_CommandBuffer_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetRcasConstantsLinear_Public_Static_Void_CommandBuffer_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetRcasConstantsLinear_Public_Static_Void_RasterCommandBuffer_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsSupported_Public_Static_Boolean_0;

	public unsafe static float kMaxSharpnessStops
	{
		get
		{
			Unsafe.SkipInit(out float result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_kMaxSharpnessStops, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_kMaxSharpnessStops, (void*)(&value));
		}
	}

	public unsafe static float kDefaultSharpnessStops
	{
		get
		{
			Unsafe.SkipInit(out float result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_kDefaultSharpnessStops, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_kDefaultSharpnessStops, (void*)(&value));
		}
	}

	public unsafe static float kDefaultSharpnessLinear
	{
		get
		{
			Unsafe.SkipInit(out float result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_kDefaultSharpnessLinear, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_kDefaultSharpnessLinear, (void*)(&value));
		}
	}

	static FSRUtils()
	{
		Il2CppClassPointerStore<FSRUtils>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Core.Runtime.dll", "UnityEngine.Rendering", "FSRUtils");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FSRUtils>.NativeClassPtr);
		NativeFieldInfoPtr_kMaxSharpnessStops = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FSRUtils>.NativeClassPtr, "kMaxSharpnessStops");
		NativeFieldInfoPtr_kDefaultSharpnessStops = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FSRUtils>.NativeClassPtr, "kDefaultSharpnessStops");
		NativeFieldInfoPtr_kDefaultSharpnessLinear = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FSRUtils>.NativeClassPtr, "kDefaultSharpnessLinear");
		NativeMethodInfoPtr_SetEasuConstants_Public_Static_Void_CommandBuffer_Vector2_Vector2_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FSRUtils>.NativeClassPtr, 100666677);
		NativeMethodInfoPtr_SetEasuConstants_Public_Static_Void_BaseCommandBuffer_Vector2_Vector2_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FSRUtils>.NativeClassPtr, 100666678);
		NativeMethodInfoPtr_SetRcasConstants_Public_Static_Void_CommandBuffer_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FSRUtils>.NativeClassPtr, 100666679);
		NativeMethodInfoPtr_SetRcasConstantsLinear_Public_Static_Void_CommandBuffer_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FSRUtils>.NativeClassPtr, 100666680);
		NativeMethodInfoPtr_SetRcasConstantsLinear_Public_Static_Void_RasterCommandBuffer_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FSRUtils>.NativeClassPtr, 100666681);
		NativeMethodInfoPtr_IsSupported_Public_Static_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FSRUtils>.NativeClassPtr, 100666682);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1052732, RefRangeEnd = 1052734, XrefRangeStart = 1052721, XrefRangeEnd = 1052732, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SetEasuConstants(CommandBuffer cmd, Vector2 inputViewportSizeInPixels, Vector2 inputImageSizeInPixels, Vector2 outputImageSizeInPixels)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)cmd);
		*(Vector2**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &inputViewportSizeInPixels;
		*(Vector2**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &inputImageSizeInPixels;
		*(Vector2**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &outputImageSizeInPixels;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetEasuConstants_Public_Static_Void_CommandBuffer_Vector2_Vector2_Vector2_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1052736, RefRangeEnd = 1052737, XrefRangeStart = 1052734, XrefRangeEnd = 1052736, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SetEasuConstants(BaseCommandBuffer cmd, Vector2 inputViewportSizeInPixels, Vector2 inputImageSizeInPixels, Vector2 outputImageSizeInPixels)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)cmd);
		*(Vector2**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &inputViewportSizeInPixels;
		*(Vector2**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &inputImageSizeInPixels;
		*(Vector2**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &outputImageSizeInPixels;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetEasuConstants_Public_Static_Void_BaseCommandBuffer_Vector2_Vector2_Vector2_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1052737, XrefRangeEnd = 1052744, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SetRcasConstants(CommandBuffer cmd, float sharpnessStops = 0.2f)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)cmd);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &sharpnessStops;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetRcasConstants_Public_Static_Void_CommandBuffer_Single_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1052751, RefRangeEnd = 1052753, XrefRangeStart = 1052744, XrefRangeEnd = 1052751, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SetRcasConstantsLinear(CommandBuffer cmd, float sharpnessLinear = 0.92f)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)cmd);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &sharpnessLinear;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetRcasConstantsLinear_Public_Static_Void_CommandBuffer_Single_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1052760, RefRangeEnd = 1052761, XrefRangeStart = 1052753, XrefRangeEnd = 1052760, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SetRcasConstantsLinear(RasterCommandBuffer cmd, float sharpnessLinear = 0.92f)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)cmd);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &sharpnessLinear;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetRcasConstantsLinear_Public_Static_Void_RasterCommandBuffer_Single_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1052762, RefRangeEnd = 1052763, XrefRangeStart = 1052761, XrefRangeEnd = 1052762, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool IsSupported()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsSupported_Public_Static_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	public FSRUtils(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
