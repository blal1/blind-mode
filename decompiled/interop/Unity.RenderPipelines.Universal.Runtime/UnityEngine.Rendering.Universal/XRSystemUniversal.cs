using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.Rendering.Universal;

public static class XRSystemUniversal : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_s_projMatrix;

	private static readonly System.IntPtr NativeMethodInfoPtr_BeginLateLatching_Internal_Static_Void_Camera_XRPassUniversal_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_EndLateLatching_Internal_Static_Void_Camera_XRPassUniversal_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UnmarkShaderProperties_Internal_Static_Void_RasterCommandBuffer_XRPassUniversal_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_MarkShaderProperties_Internal_Static_Void_RasterCommandBuffer_XRPassUniversal_Boolean_0;

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

	static XRSystemUniversal()
	{
		Il2CppClassPointerStore<XRSystemUniversal>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Universal.Runtime.dll", "UnityEngine.Rendering.Universal", "XRSystemUniversal");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XRSystemUniversal>.NativeClassPtr);
		NativeFieldInfoPtr_s_projMatrix = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XRSystemUniversal>.NativeClassPtr, "s_projMatrix");
		NativeMethodInfoPtr_BeginLateLatching_Internal_Static_Void_Camera_XRPassUniversal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XRSystemUniversal>.NativeClassPtr, 100666140);
		NativeMethodInfoPtr_EndLateLatching_Internal_Static_Void_Camera_XRPassUniversal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XRSystemUniversal>.NativeClassPtr, 100666141);
		NativeMethodInfoPtr_UnmarkShaderProperties_Internal_Static_Void_RasterCommandBuffer_XRPassUniversal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XRSystemUniversal>.NativeClassPtr, 100666142);
		NativeMethodInfoPtr_MarkShaderProperties_Internal_Static_Void_RasterCommandBuffer_XRPassUniversal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XRSystemUniversal>.NativeClassPtr, 100666143);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1108253, RefRangeEnd = 1108254, XrefRangeStart = 1108244, XrefRangeEnd = 1108253, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void BeginLateLatching(Camera camera, XRPassUniversal xrPass)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)camera);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)xrPass);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_BeginLateLatching_Internal_Static_Void_Camera_XRPassUniversal_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1108262, RefRangeEnd = 1108263, XrefRangeStart = 1108254, XrefRangeEnd = 1108262, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void EndLateLatching(Camera camera, XRPassUniversal xrPass)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)camera);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)xrPass);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_EndLateLatching_Internal_Static_Void_Camera_XRPassUniversal_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1108267, RefRangeEnd = 1108268, XrefRangeStart = 1108263, XrefRangeEnd = 1108267, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void UnmarkShaderProperties(RasterCommandBuffer cmd, XRPassUniversal xrPass)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)cmd);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)xrPass);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UnmarkShaderProperties_Internal_Static_Void_RasterCommandBuffer_XRPassUniversal_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1108289, RefRangeEnd = 1108290, XrefRangeStart = 1108268, XrefRangeEnd = 1108289, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void MarkShaderProperties(RasterCommandBuffer cmd, XRPassUniversal xrPass, bool renderIntoTexture)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)cmd);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)xrPass);
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &renderIntoTexture;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_MarkShaderProperties_Internal_Static_Void_RasterCommandBuffer_XRPassUniversal_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public XRSystemUniversal(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
