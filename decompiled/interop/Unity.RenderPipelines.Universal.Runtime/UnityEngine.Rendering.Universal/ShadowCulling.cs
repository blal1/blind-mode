using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Unity.Collections;

namespace UnityEngine.Rendering.Universal;

public static class ShadowCulling : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_computeShadowCasterCullingInfosMarker;

	private static readonly System.IntPtr NativeMethodInfoPtr_CullShadowCasters_Public_Static_NativeArray_1_URPLightShadowCullingInfos_byref_ScriptableRenderContext_UniversalShadowData_byref_AdditionalLightsShadowAtlasLayout_byref_CullingResults_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ComputeShadowCasterCullingInfos_Private_Static_Void_UniversalShadowData_byref_AdditionalLightsShadowAtlasLayout_byref_CullingResults_byref_ShadowCastersCullingInfos_byref_NativeArray_1_URPLightShadowCullingInfos_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetCullingProjectionType_Private_Static_BatchCullingProjectionType_LightType_0;

	public unsafe static ProfilingSampler computeShadowCasterCullingInfosMarker
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_computeShadowCasterCullingInfosMarker, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<ProfilingSampler>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_computeShadowCasterCullingInfosMarker, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	static ShadowCulling()
	{
		Il2CppClassPointerStore<ShadowCulling>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Universal.Runtime.dll", "UnityEngine.Rendering.Universal", "ShadowCulling");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ShadowCulling>.NativeClassPtr);
		NativeFieldInfoPtr_computeShadowCasterCullingInfosMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShadowCulling>.NativeClassPtr, "computeShadowCasterCullingInfosMarker");
		NativeMethodInfoPtr_CullShadowCasters_Public_Static_NativeArray_1_URPLightShadowCullingInfos_byref_ScriptableRenderContext_UniversalShadowData_byref_AdditionalLightsShadowAtlasLayout_byref_CullingResults_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShadowCulling>.NativeClassPtr, 100665516);
		NativeMethodInfoPtr_ComputeShadowCasterCullingInfos_Private_Static_Void_UniversalShadowData_byref_AdditionalLightsShadowAtlasLayout_byref_CullingResults_byref_ShadowCastersCullingInfos_byref_NativeArray_1_URPLightShadowCullingInfos_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShadowCulling>.NativeClassPtr, 100665517);
		NativeMethodInfoPtr_GetCullingProjectionType_Private_Static_BatchCullingProjectionType_LightType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShadowCulling>.NativeClassPtr, 100665518);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1099580, RefRangeEnd = 1099582, XrefRangeStart = 1099572, XrefRangeEnd = 1099580, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static NativeArray<URPLightShadowCullingInfos> CullShadowCasters(ref ScriptableRenderContext context, UniversalShadowData shadowData, ref AdditionalLightsShadowAtlasLayout shadowAtlasLayout, ref CullingResults cullResults)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = (nint)Unsafe.AsPointer(ref context);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)shadowData);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)shadowAtlasLayout);
		*(void**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref cullResults);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CullShadowCasters_Public_Static_NativeArray_1_URPLightShadowCullingInfos_byref_ScriptableRenderContext_UniversalShadowData_byref_AdditionalLightsShadowAtlasLayout_byref_CullingResults_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return new NativeArray<URPLightShadowCullingInfos>(pointer);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1099654, RefRangeEnd = 1099655, XrefRangeStart = 1099582, XrefRangeEnd = 1099654, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void ComputeShadowCasterCullingInfos(UniversalShadowData shadowData, ref AdditionalLightsShadowAtlasLayout shadowAtlasLayout, ref CullingResults cullingResults, out ShadowCastersCullingInfos shadowCullingInfos, out NativeArray<URPLightShadowCullingInfos> urpVisibleLightsShadowCullingInfos)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)shadowData);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)shadowAtlasLayout);
		*(void**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref cullingResults);
		byte* num = (byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)));
		nint num2 = 0;
		*(nint**)num = &num2;
		byte* num3 = (byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)));
		nint num4 = 0;
		*(nint**)num3 = &num4;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ComputeShadowCasterCullingInfos_Private_Static_Void_UniversalShadowData_byref_AdditionalLightsShadowAtlasLayout_byref_CullingResults_byref_ShadowCastersCullingInfos_byref_NativeArray_1_URPLightShadowCullingInfos_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		nint num5 = num2;
		shadowCullingInfos = ((num5 == 0) ? null : new ShadowCastersCullingInfos(num5));
		nint num6 = num4;
		urpVisibleLightsShadowCullingInfos = ((num6 == 0) ? null : new NativeArray<URPLightShadowCullingInfos>(num6));
	}

	[CallerCount(0)]
	public unsafe static BatchCullingProjectionType GetCullingProjectionType(LightType type)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&type);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetCullingProjectionType_Private_Static_BatchCullingProjectionType_LightType_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(BatchCullingProjectionType*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	public ShadowCulling(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
