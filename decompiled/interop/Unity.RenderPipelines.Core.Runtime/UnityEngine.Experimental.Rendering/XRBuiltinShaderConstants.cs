using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine.Rendering;

namespace UnityEngine.Experimental.Rendering;

public static class XRBuiltinShaderConstants : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_unity_StereoCameraProjection;

	private static readonly System.IntPtr NativeFieldInfoPtr_unity_StereoCameraInvProjection;

	private static readonly System.IntPtr NativeFieldInfoPtr_unity_StereoMatrixV;

	private static readonly System.IntPtr NativeFieldInfoPtr_unity_StereoMatrixInvV;

	private static readonly System.IntPtr NativeFieldInfoPtr_unity_StereoMatrixP;

	private static readonly System.IntPtr NativeFieldInfoPtr_unity_StereoMatrixInvP;

	private static readonly System.IntPtr NativeFieldInfoPtr_unity_StereoMatrixVP;

	private static readonly System.IntPtr NativeFieldInfoPtr_unity_StereoMatrixInvVP;

	private static readonly System.IntPtr NativeFieldInfoPtr_unity_StereoWorldSpaceCameraPos;

	private static readonly System.IntPtr NativeFieldInfoPtr_s_cameraProjMatrix;

	private static readonly System.IntPtr NativeFieldInfoPtr_s_invCameraProjMatrix;

	private static readonly System.IntPtr NativeFieldInfoPtr_s_viewMatrix;

	private static readonly System.IntPtr NativeFieldInfoPtr_s_invViewMatrix;

	private static readonly System.IntPtr NativeFieldInfoPtr_s_projMatrix;

	private static readonly System.IntPtr NativeFieldInfoPtr_s_invProjMatrix;

	private static readonly System.IntPtr NativeFieldInfoPtr_s_viewProjMatrix;

	private static readonly System.IntPtr NativeFieldInfoPtr_s_invViewProjMatrix;

	private static readonly System.IntPtr NativeFieldInfoPtr_s_worldSpaceCameraPos;

	private static readonly System.IntPtr NativeMethodInfoPtr_UpdateBuiltinShaderConstants_Public_Static_Void_Matrix4x4_Matrix4x4_Boolean_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetBuiltinShaderConstants_Public_Static_Void_CommandBuffer_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetBuiltinShaderConstants_Public_Static_Void_RasterCommandBuffer_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Update_Public_Static_Void_XRPass_CommandBuffer_Boolean_0;

	public unsafe static int unity_StereoCameraProjection
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_unity_StereoCameraProjection, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_unity_StereoCameraProjection, (void*)(&value));
		}
	}

	public unsafe static int unity_StereoCameraInvProjection
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_unity_StereoCameraInvProjection, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_unity_StereoCameraInvProjection, (void*)(&value));
		}
	}

	public unsafe static int unity_StereoMatrixV
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_unity_StereoMatrixV, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_unity_StereoMatrixV, (void*)(&value));
		}
	}

	public unsafe static int unity_StereoMatrixInvV
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_unity_StereoMatrixInvV, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_unity_StereoMatrixInvV, (void*)(&value));
		}
	}

	public unsafe static int unity_StereoMatrixP
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_unity_StereoMatrixP, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_unity_StereoMatrixP, (void*)(&value));
		}
	}

	public unsafe static int unity_StereoMatrixInvP
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_unity_StereoMatrixInvP, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_unity_StereoMatrixInvP, (void*)(&value));
		}
	}

	public unsafe static int unity_StereoMatrixVP
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_unity_StereoMatrixVP, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_unity_StereoMatrixVP, (void*)(&value));
		}
	}

	public unsafe static int unity_StereoMatrixInvVP
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_unity_StereoMatrixInvVP, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_unity_StereoMatrixInvVP, (void*)(&value));
		}
	}

	public unsafe static int unity_StereoWorldSpaceCameraPos
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_unity_StereoWorldSpaceCameraPos, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_unity_StereoWorldSpaceCameraPos, (void*)(&value));
		}
	}

	public unsafe static Il2CppStructArray<Matrix4x4> s_cameraProjMatrix
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_s_cameraProjMatrix, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<Matrix4x4>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_s_cameraProjMatrix, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static Il2CppStructArray<Matrix4x4> s_invCameraProjMatrix
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_s_invCameraProjMatrix, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<Matrix4x4>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_s_invCameraProjMatrix, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static Il2CppStructArray<Matrix4x4> s_viewMatrix
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_s_viewMatrix, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<Matrix4x4>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_s_viewMatrix, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static Il2CppStructArray<Matrix4x4> s_invViewMatrix
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_s_invViewMatrix, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<Matrix4x4>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_s_invViewMatrix, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static Il2CppStructArray<Matrix4x4> s_projMatrix
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_s_projMatrix, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<Matrix4x4>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_s_projMatrix, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static Il2CppStructArray<Matrix4x4> s_invProjMatrix
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_s_invProjMatrix, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<Matrix4x4>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_s_invProjMatrix, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static Il2CppStructArray<Matrix4x4> s_viewProjMatrix
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_s_viewProjMatrix, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<Matrix4x4>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_s_viewProjMatrix, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static Il2CppStructArray<Matrix4x4> s_invViewProjMatrix
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_s_invViewProjMatrix, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<Matrix4x4>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_s_invViewProjMatrix, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static Il2CppStructArray<Vector4> s_worldSpaceCameraPos
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_s_worldSpaceCameraPos, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<Vector4>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_s_worldSpaceCameraPos, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	static XRBuiltinShaderConstants()
	{
		Il2CppClassPointerStore<XRBuiltinShaderConstants>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Core.Runtime.dll", "UnityEngine.Experimental.Rendering", "XRBuiltinShaderConstants");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XRBuiltinShaderConstants>.NativeClassPtr);
		NativeFieldInfoPtr_unity_StereoCameraProjection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XRBuiltinShaderConstants>.NativeClassPtr, "unity_StereoCameraProjection");
		NativeFieldInfoPtr_unity_StereoCameraInvProjection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XRBuiltinShaderConstants>.NativeClassPtr, "unity_StereoCameraInvProjection");
		NativeFieldInfoPtr_unity_StereoMatrixV = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XRBuiltinShaderConstants>.NativeClassPtr, "unity_StereoMatrixV");
		NativeFieldInfoPtr_unity_StereoMatrixInvV = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XRBuiltinShaderConstants>.NativeClassPtr, "unity_StereoMatrixInvV");
		NativeFieldInfoPtr_unity_StereoMatrixP = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XRBuiltinShaderConstants>.NativeClassPtr, "unity_StereoMatrixP");
		NativeFieldInfoPtr_unity_StereoMatrixInvP = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XRBuiltinShaderConstants>.NativeClassPtr, "unity_StereoMatrixInvP");
		NativeFieldInfoPtr_unity_StereoMatrixVP = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XRBuiltinShaderConstants>.NativeClassPtr, "unity_StereoMatrixVP");
		NativeFieldInfoPtr_unity_StereoMatrixInvVP = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XRBuiltinShaderConstants>.NativeClassPtr, "unity_StereoMatrixInvVP");
		NativeFieldInfoPtr_unity_StereoWorldSpaceCameraPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XRBuiltinShaderConstants>.NativeClassPtr, "unity_StereoWorldSpaceCameraPos");
		NativeFieldInfoPtr_s_cameraProjMatrix = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XRBuiltinShaderConstants>.NativeClassPtr, "s_cameraProjMatrix");
		NativeFieldInfoPtr_s_invCameraProjMatrix = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XRBuiltinShaderConstants>.NativeClassPtr, "s_invCameraProjMatrix");
		NativeFieldInfoPtr_s_viewMatrix = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XRBuiltinShaderConstants>.NativeClassPtr, "s_viewMatrix");
		NativeFieldInfoPtr_s_invViewMatrix = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XRBuiltinShaderConstants>.NativeClassPtr, "s_invViewMatrix");
		NativeFieldInfoPtr_s_projMatrix = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XRBuiltinShaderConstants>.NativeClassPtr, "s_projMatrix");
		NativeFieldInfoPtr_s_invProjMatrix = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XRBuiltinShaderConstants>.NativeClassPtr, "s_invProjMatrix");
		NativeFieldInfoPtr_s_viewProjMatrix = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XRBuiltinShaderConstants>.NativeClassPtr, "s_viewProjMatrix");
		NativeFieldInfoPtr_s_invViewProjMatrix = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XRBuiltinShaderConstants>.NativeClassPtr, "s_invViewProjMatrix");
		NativeFieldInfoPtr_s_worldSpaceCameraPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XRBuiltinShaderConstants>.NativeClassPtr, "s_worldSpaceCameraPos");
		NativeMethodInfoPtr_UpdateBuiltinShaderConstants_Public_Static_Void_Matrix4x4_Matrix4x4_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XRBuiltinShaderConstants>.NativeClassPtr, 100663334);
		NativeMethodInfoPtr_SetBuiltinShaderConstants_Public_Static_Void_CommandBuffer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XRBuiltinShaderConstants>.NativeClassPtr, 100663335);
		NativeMethodInfoPtr_SetBuiltinShaderConstants_Public_Static_Void_RasterCommandBuffer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XRBuiltinShaderConstants>.NativeClassPtr, 100663336);
		NativeMethodInfoPtr_Update_Public_Static_Void_XRPass_CommandBuffer_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XRBuiltinShaderConstants>.NativeClassPtr, 100663337);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1024680, RefRangeEnd = 1024682, XrefRangeStart = 1024661, XrefRangeEnd = 1024680, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void UpdateBuiltinShaderConstants(Matrix4x4 viewMatrix, Matrix4x4 projMatrix, bool renderIntoTexture, int viewIndex)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = (nint)(&viewMatrix);
		*(Matrix4x4**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &projMatrix;
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &renderIntoTexture;
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &viewIndex;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UpdateBuiltinShaderConstants_Public_Static_Void_Matrix4x4_Matrix4x4_Boolean_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1024682, XrefRangeEnd = 1024704, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SetBuiltinShaderConstants(CommandBuffer cmd)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)cmd);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetBuiltinShaderConstants_Public_Static_Void_CommandBuffer_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1024730, RefRangeEnd = 1024731, XrefRangeStart = 1024704, XrefRangeEnd = 1024730, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SetBuiltinShaderConstants(RasterCommandBuffer cmd)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)cmd);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetBuiltinShaderConstants_Public_Static_Void_RasterCommandBuffer_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1024731, XrefRangeEnd = 1024785, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void Update(XRPass xrPass, CommandBuffer cmd, bool renderIntoTexture)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)xrPass);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)cmd);
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &renderIntoTexture;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Update_Public_Static_Void_XRPass_CommandBuffer_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public XRBuiltinShaderConstants(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
