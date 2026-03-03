using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine.Rendering;
using UnityEngine.XR;

namespace UnityEngine.Experimental.Rendering;

public static class XRMirrorView : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_s_MirrorViewMaterialProperty;

	private static readonly System.IntPtr NativeFieldInfoPtr_k_MirrorViewProfilingSampler;

	private static readonly System.IntPtr NativeFieldInfoPtr_k_SourceTex;

	private static readonly System.IntPtr NativeFieldInfoPtr_k_SourceTexArraySlice;

	private static readonly System.IntPtr NativeFieldInfoPtr_k_ScaleBias;

	private static readonly System.IntPtr NativeFieldInfoPtr_k_ScaleBiasRt;

	private static readonly System.IntPtr NativeFieldInfoPtr_k_SRGBRead;

	private static readonly System.IntPtr NativeFieldInfoPtr_k_SRGBWrite;

	private static readonly System.IntPtr NativeFieldInfoPtr_k_MaxNits;

	private static readonly System.IntPtr NativeFieldInfoPtr_k_SourceMaxNits;

	private static readonly System.IntPtr NativeFieldInfoPtr_k_SourceHDREncoding;

	private static readonly System.IntPtr NativeFieldInfoPtr_k_ColorTransform;

	private static readonly System.IntPtr NativeMethodInfoPtr_RenderMirrorView_Internal_Static_Void_CommandBuffer_Camera_Material_XRDisplaySubsystem_0;

	public unsafe static MaterialPropertyBlock s_MirrorViewMaterialProperty
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_s_MirrorViewMaterialProperty, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<MaterialPropertyBlock>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_s_MirrorViewMaterialProperty, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static ProfilingSampler k_MirrorViewProfilingSampler
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_k_MirrorViewProfilingSampler, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<ProfilingSampler>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_k_MirrorViewProfilingSampler, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static int k_SourceTex
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_k_SourceTex, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_k_SourceTex, (void*)(&value));
		}
	}

	public unsafe static int k_SourceTexArraySlice
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_k_SourceTexArraySlice, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_k_SourceTexArraySlice, (void*)(&value));
		}
	}

	public unsafe static int k_ScaleBias
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_k_ScaleBias, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_k_ScaleBias, (void*)(&value));
		}
	}

	public unsafe static int k_ScaleBiasRt
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_k_ScaleBiasRt, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_k_ScaleBiasRt, (void*)(&value));
		}
	}

	public unsafe static int k_SRGBRead
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_k_SRGBRead, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_k_SRGBRead, (void*)(&value));
		}
	}

	public unsafe static int k_SRGBWrite
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_k_SRGBWrite, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_k_SRGBWrite, (void*)(&value));
		}
	}

	public unsafe static int k_MaxNits
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_k_MaxNits, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_k_MaxNits, (void*)(&value));
		}
	}

	public unsafe static int k_SourceMaxNits
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_k_SourceMaxNits, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_k_SourceMaxNits, (void*)(&value));
		}
	}

	public unsafe static int k_SourceHDREncoding
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_k_SourceHDREncoding, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_k_SourceHDREncoding, (void*)(&value));
		}
	}

	public unsafe static int k_ColorTransform
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_k_ColorTransform, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_k_ColorTransform, (void*)(&value));
		}
	}

	static XRMirrorView()
	{
		Il2CppClassPointerStore<XRMirrorView>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Core.Runtime.dll", "UnityEngine.Experimental.Rendering", "XRMirrorView");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XRMirrorView>.NativeClassPtr);
		NativeFieldInfoPtr_s_MirrorViewMaterialProperty = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XRMirrorView>.NativeClassPtr, "s_MirrorViewMaterialProperty");
		NativeFieldInfoPtr_k_MirrorViewProfilingSampler = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XRMirrorView>.NativeClassPtr, "k_MirrorViewProfilingSampler");
		NativeFieldInfoPtr_k_SourceTex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XRMirrorView>.NativeClassPtr, "k_SourceTex");
		NativeFieldInfoPtr_k_SourceTexArraySlice = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XRMirrorView>.NativeClassPtr, "k_SourceTexArraySlice");
		NativeFieldInfoPtr_k_ScaleBias = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XRMirrorView>.NativeClassPtr, "k_ScaleBias");
		NativeFieldInfoPtr_k_ScaleBiasRt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XRMirrorView>.NativeClassPtr, "k_ScaleBiasRt");
		NativeFieldInfoPtr_k_SRGBRead = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XRMirrorView>.NativeClassPtr, "k_SRGBRead");
		NativeFieldInfoPtr_k_SRGBWrite = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XRMirrorView>.NativeClassPtr, "k_SRGBWrite");
		NativeFieldInfoPtr_k_MaxNits = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XRMirrorView>.NativeClassPtr, "k_MaxNits");
		NativeFieldInfoPtr_k_SourceMaxNits = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XRMirrorView>.NativeClassPtr, "k_SourceMaxNits");
		NativeFieldInfoPtr_k_SourceHDREncoding = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XRMirrorView>.NativeClassPtr, "k_SourceHDREncoding");
		NativeFieldInfoPtr_k_ColorTransform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XRMirrorView>.NativeClassPtr, "k_ColorTransform");
		NativeMethodInfoPtr_RenderMirrorView_Internal_Static_Void_CommandBuffer_Camera_Material_XRDisplaySubsystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XRMirrorView>.NativeClassPtr, 100663351);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1025101, RefRangeEnd = 1025102, XrefRangeStart = 1024949, XrefRangeEnd = 1025101, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void RenderMirrorView(CommandBuffer cmd, Camera camera, Material mat, XRDisplaySubsystem display)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)cmd);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)camera);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)mat);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)display);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RenderMirrorView_Internal_Static_Void_CommandBuffer_Camera_Material_XRDisplaySubsystem_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public XRMirrorView(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
