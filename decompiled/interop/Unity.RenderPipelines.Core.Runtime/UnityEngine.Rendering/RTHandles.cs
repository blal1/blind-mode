using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine.Experimental.Rendering;

namespace UnityEngine.Rendering;

public static class RTHandles : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_s_DefaultInstance;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_maxWidth_Public_Static_get_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_maxHeight_Public_Static_get_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_rtHandleProperties_Public_Static_get_RTHandleProperties_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CalculateDimensions_Public_Static_Vector2Int_Vector2_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CalculateDimensions_Public_Static_Vector2Int_ScaleFunc_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Alloc_Public_Static_RTHandle_Int32_Int32_Int32_DepthBits_GraphicsFormat_FilterMode_TextureWrapMode_TextureDimension_Boolean_Boolean_Boolean_Boolean_Int32_Single_MSAASamples_Boolean_Boolean_Boolean_RenderTextureMemoryless_VRTextureUsage_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Alloc_Public_Static_RTHandle_Int32_Int32_GraphicsFormat_Int32_FilterMode_TextureWrapMode_TextureDimension_Boolean_Boolean_Boolean_Boolean_Int32_Single_MSAASamples_Boolean_Boolean_Boolean_RenderTextureMemoryless_VRTextureUsage_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Alloc_Public_Static_RTHandle_Int32_Int32_TextureWrapMode_TextureWrapMode_TextureWrapMode_Int32_DepthBits_GraphicsFormat_FilterMode_TextureDimension_Boolean_Boolean_Boolean_Boolean_Int32_Single_MSAASamples_Boolean_Boolean_Boolean_RenderTextureMemoryless_VRTextureUsage_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Alloc_Public_Static_RTHandle_Int32_Int32_RTHandleAllocInfo_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Alloc_Public_Static_RTHandle_byref_RenderTextureDescriptor_FilterMode_TextureWrapMode_Boolean_Int32_Single_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetFormat_Internal_Static_GraphicsFormat_GraphicsFormat_GraphicsFormat_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Alloc_Public_Static_RTHandle_Vector2_Int32_DepthBits_GraphicsFormat_FilterMode_TextureWrapMode_TextureDimension_Boolean_Boolean_Boolean_Boolean_Int32_Single_MSAASamples_Boolean_Boolean_Boolean_RenderTextureMemoryless_VRTextureUsage_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Alloc_Public_Static_RTHandle_Vector2_GraphicsFormat_Int32_FilterMode_TextureWrapMode_TextureDimension_Boolean_Boolean_Boolean_Boolean_Int32_Single_MSAASamples_Boolean_Boolean_Boolean_RenderTextureMemoryless_VRTextureUsage_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Alloc_Public_Static_RTHandle_Vector2_byref_RenderTextureDescriptor_FilterMode_TextureWrapMode_Boolean_Int32_Single_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Alloc_Public_Static_RTHandle_Vector2_RTHandleAllocInfo_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Alloc_Public_Static_RTHandle_ScaleFunc_Int32_DepthBits_GraphicsFormat_FilterMode_TextureWrapMode_TextureDimension_Boolean_Boolean_Boolean_Boolean_Int32_Single_MSAASamples_Boolean_Boolean_Boolean_RenderTextureMemoryless_VRTextureUsage_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Alloc_Public_Static_RTHandle_ScaleFunc_GraphicsFormat_Int32_FilterMode_TextureWrapMode_TextureDimension_Boolean_Boolean_Boolean_Boolean_Int32_Single_MSAASamples_Boolean_Boolean_Boolean_RenderTextureMemoryless_VRTextureUsage_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Alloc_Public_Static_RTHandle_ScaleFunc_byref_RenderTextureDescriptor_FilterMode_TextureWrapMode_Boolean_Int32_Single_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Alloc_Public_Static_RTHandle_ScaleFunc_RTHandleAllocInfo_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Alloc_Public_Static_RTHandle_Texture_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Alloc_Public_Static_RTHandle_RenderTexture_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Alloc_Public_Static_RTHandle_RenderTargetIdentifier_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Alloc_Public_Static_RTHandle_RenderTargetIdentifier_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Alloc_Private_Static_RTHandle_RTHandle_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Initialize_Public_Static_Void_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Initialize_Public_Static_Void_Int32_Int32_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Release_Public_Static_Void_RTHandle_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetHardwareDynamicResolutionState_Public_Static_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetReferenceSize_Public_Static_Void_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ResetReferenceSize_Public_Static_Void_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CalculateRatioAgainstMaxSize_Public_Static_Vector2_Int32_Int32_0;

	public unsafe static RTHandleSystem s_DefaultInstance
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_s_DefaultInstance, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<RTHandleSystem>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_s_DefaultInstance, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static int maxWidth
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1048337, XrefRangeEnd = 1048341, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_maxWidth_Public_Static_get_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe static int maxHeight
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1048341, XrefRangeEnd = 1048345, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_maxHeight_Public_Static_get_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe static RTHandleProperties rtHandleProperties
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1048345, XrefRangeEnd = 1048349, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_rtHandleProperties_Public_Static_get_RTHandleProperties_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(RTHandleProperties*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	static RTHandles()
	{
		Il2CppClassPointerStore<RTHandles>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Core.Runtime.dll", "UnityEngine.Rendering", "RTHandles");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RTHandles>.NativeClassPtr);
		NativeFieldInfoPtr_s_DefaultInstance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTHandles>.NativeClassPtr, "s_DefaultInstance");
		NativeMethodInfoPtr_get_maxWidth_Public_Static_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTHandles>.NativeClassPtr, 100666171);
		NativeMethodInfoPtr_get_maxHeight_Public_Static_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTHandles>.NativeClassPtr, 100666172);
		NativeMethodInfoPtr_get_rtHandleProperties_Public_Static_get_RTHandleProperties_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTHandles>.NativeClassPtr, 100666173);
		NativeMethodInfoPtr_CalculateDimensions_Public_Static_Vector2Int_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTHandles>.NativeClassPtr, 100666174);
		NativeMethodInfoPtr_CalculateDimensions_Public_Static_Vector2Int_ScaleFunc_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTHandles>.NativeClassPtr, 100666175);
		NativeMethodInfoPtr_Alloc_Public_Static_RTHandle_Int32_Int32_Int32_DepthBits_GraphicsFormat_FilterMode_TextureWrapMode_TextureDimension_Boolean_Boolean_Boolean_Boolean_Int32_Single_MSAASamples_Boolean_Boolean_Boolean_RenderTextureMemoryless_VRTextureUsage_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTHandles>.NativeClassPtr, 100666176);
		NativeMethodInfoPtr_Alloc_Public_Static_RTHandle_Int32_Int32_GraphicsFormat_Int32_FilterMode_TextureWrapMode_TextureDimension_Boolean_Boolean_Boolean_Boolean_Int32_Single_MSAASamples_Boolean_Boolean_Boolean_RenderTextureMemoryless_VRTextureUsage_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTHandles>.NativeClassPtr, 100666177);
		NativeMethodInfoPtr_Alloc_Public_Static_RTHandle_Int32_Int32_TextureWrapMode_TextureWrapMode_TextureWrapMode_Int32_DepthBits_GraphicsFormat_FilterMode_TextureDimension_Boolean_Boolean_Boolean_Boolean_Int32_Single_MSAASamples_Boolean_Boolean_Boolean_RenderTextureMemoryless_VRTextureUsage_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTHandles>.NativeClassPtr, 100666178);
		NativeMethodInfoPtr_Alloc_Public_Static_RTHandle_Int32_Int32_RTHandleAllocInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTHandles>.NativeClassPtr, 100666179);
		NativeMethodInfoPtr_Alloc_Public_Static_RTHandle_byref_RenderTextureDescriptor_FilterMode_TextureWrapMode_Boolean_Int32_Single_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTHandles>.NativeClassPtr, 100666180);
		NativeMethodInfoPtr_GetFormat_Internal_Static_GraphicsFormat_GraphicsFormat_GraphicsFormat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTHandles>.NativeClassPtr, 100666181);
		NativeMethodInfoPtr_Alloc_Public_Static_RTHandle_Vector2_Int32_DepthBits_GraphicsFormat_FilterMode_TextureWrapMode_TextureDimension_Boolean_Boolean_Boolean_Boolean_Int32_Single_MSAASamples_Boolean_Boolean_Boolean_RenderTextureMemoryless_VRTextureUsage_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTHandles>.NativeClassPtr, 100666182);
		NativeMethodInfoPtr_Alloc_Public_Static_RTHandle_Vector2_GraphicsFormat_Int32_FilterMode_TextureWrapMode_TextureDimension_Boolean_Boolean_Boolean_Boolean_Int32_Single_MSAASamples_Boolean_Boolean_Boolean_RenderTextureMemoryless_VRTextureUsage_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTHandles>.NativeClassPtr, 100666183);
		NativeMethodInfoPtr_Alloc_Public_Static_RTHandle_Vector2_byref_RenderTextureDescriptor_FilterMode_TextureWrapMode_Boolean_Int32_Single_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTHandles>.NativeClassPtr, 100666184);
		NativeMethodInfoPtr_Alloc_Public_Static_RTHandle_Vector2_RTHandleAllocInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTHandles>.NativeClassPtr, 100666185);
		NativeMethodInfoPtr_Alloc_Public_Static_RTHandle_ScaleFunc_Int32_DepthBits_GraphicsFormat_FilterMode_TextureWrapMode_TextureDimension_Boolean_Boolean_Boolean_Boolean_Int32_Single_MSAASamples_Boolean_Boolean_Boolean_RenderTextureMemoryless_VRTextureUsage_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTHandles>.NativeClassPtr, 100666186);
		NativeMethodInfoPtr_Alloc_Public_Static_RTHandle_ScaleFunc_GraphicsFormat_Int32_FilterMode_TextureWrapMode_TextureDimension_Boolean_Boolean_Boolean_Boolean_Int32_Single_MSAASamples_Boolean_Boolean_Boolean_RenderTextureMemoryless_VRTextureUsage_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTHandles>.NativeClassPtr, 100666187);
		NativeMethodInfoPtr_Alloc_Public_Static_RTHandle_ScaleFunc_byref_RenderTextureDescriptor_FilterMode_TextureWrapMode_Boolean_Int32_Single_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTHandles>.NativeClassPtr, 100666188);
		NativeMethodInfoPtr_Alloc_Public_Static_RTHandle_ScaleFunc_RTHandleAllocInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTHandles>.NativeClassPtr, 100666189);
		NativeMethodInfoPtr_Alloc_Public_Static_RTHandle_Texture_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTHandles>.NativeClassPtr, 100666190);
		NativeMethodInfoPtr_Alloc_Public_Static_RTHandle_RenderTexture_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTHandles>.NativeClassPtr, 100666191);
		NativeMethodInfoPtr_Alloc_Public_Static_RTHandle_RenderTargetIdentifier_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTHandles>.NativeClassPtr, 100666192);
		NativeMethodInfoPtr_Alloc_Public_Static_RTHandle_RenderTargetIdentifier_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTHandles>.NativeClassPtr, 100666193);
		NativeMethodInfoPtr_Alloc_Private_Static_RTHandle_RTHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTHandles>.NativeClassPtr, 100666194);
		NativeMethodInfoPtr_Initialize_Public_Static_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTHandles>.NativeClassPtr, 100666195);
		NativeMethodInfoPtr_Initialize_Public_Static_Void_Int32_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTHandles>.NativeClassPtr, 100666196);
		NativeMethodInfoPtr_Release_Public_Static_Void_RTHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTHandles>.NativeClassPtr, 100666197);
		NativeMethodInfoPtr_SetHardwareDynamicResolutionState_Public_Static_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTHandles>.NativeClassPtr, 100666198);
		NativeMethodInfoPtr_SetReferenceSize_Public_Static_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTHandles>.NativeClassPtr, 100666199);
		NativeMethodInfoPtr_ResetReferenceSize_Public_Static_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTHandles>.NativeClassPtr, 100666200);
		NativeMethodInfoPtr_CalculateRatioAgainstMaxSize_Public_Static_Vector2_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTHandles>.NativeClassPtr, 100666201);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1048355, RefRangeEnd = 1048356, XrefRangeStart = 1048349, XrefRangeEnd = 1048355, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Vector2Int CalculateDimensions(Vector2 scaleFactor)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&scaleFactor);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CalculateDimensions_Public_Static_Vector2Int_Vector2_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(Vector2Int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1048360, RefRangeEnd = 1048361, XrefRangeStart = 1048356, XrefRangeEnd = 1048360, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Vector2Int CalculateDimensions(ScaleFunc scaleFunc)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)scaleFunc);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CalculateDimensions_Public_Static_Vector2Int_ScaleFunc_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(Vector2Int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1048361, XrefRangeEnd = 1048371, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static RTHandle Alloc(int width, int height, int slices = 1, DepthBits depthBufferBits = DepthBits.None, GraphicsFormat colorFormat = GraphicsFormat.R8G8B8A8_SRGB, FilterMode filterMode = FilterMode.Point, TextureWrapMode wrapMode = TextureWrapMode.Repeat, TextureDimension dimension = TextureDimension.Tex2D, bool enableRandomWrite = false, bool useMipMap = false, bool autoGenerateMips = true, bool isShadowMap = false, int anisoLevel = 1, float mipMapBias = 0f, MSAASamples msaaSamples = MSAASamples.None, bool bindTextureMS = false, bool useDynamicScale = false, bool useDynamicScaleExplicit = false, RenderTextureMemoryless memoryless = RenderTextureMemoryless.None, VRTextureUsage vrUsage = VRTextureUsage.None, string name = "")
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[21];
		*ptr = (nint)(&width);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &height;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &slices;
		*(DepthBits**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &depthBufferBits;
		*(GraphicsFormat**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &colorFormat;
		*(FilterMode**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = &filterMode;
		*(TextureWrapMode**)((byte*)ptr + checked((nuint)6u * unchecked((nuint)sizeof(System.IntPtr)))) = &wrapMode;
		*(TextureDimension**)((byte*)ptr + checked((nuint)7u * unchecked((nuint)sizeof(System.IntPtr)))) = &dimension;
		*(bool**)((byte*)ptr + checked((nuint)8u * unchecked((nuint)sizeof(System.IntPtr)))) = &enableRandomWrite;
		*(bool**)((byte*)ptr + checked((nuint)9u * unchecked((nuint)sizeof(System.IntPtr)))) = &useMipMap;
		*(bool**)((byte*)ptr + checked((nuint)10u * unchecked((nuint)sizeof(System.IntPtr)))) = &autoGenerateMips;
		*(bool**)((byte*)ptr + checked((nuint)11u * unchecked((nuint)sizeof(System.IntPtr)))) = &isShadowMap;
		*(int**)((byte*)ptr + checked((nuint)12u * unchecked((nuint)sizeof(System.IntPtr)))) = &anisoLevel;
		*(float**)((byte*)ptr + checked((nuint)13u * unchecked((nuint)sizeof(System.IntPtr)))) = &mipMapBias;
		*(MSAASamples**)((byte*)ptr + checked((nuint)14u * unchecked((nuint)sizeof(System.IntPtr)))) = &msaaSamples;
		*(bool**)((byte*)ptr + checked((nuint)15u * unchecked((nuint)sizeof(System.IntPtr)))) = &bindTextureMS;
		*(bool**)((byte*)ptr + checked((nuint)16u * unchecked((nuint)sizeof(System.IntPtr)))) = &useDynamicScale;
		*(bool**)((byte*)ptr + checked((nuint)17u * unchecked((nuint)sizeof(System.IntPtr)))) = &useDynamicScaleExplicit;
		*(RenderTextureMemoryless**)((byte*)ptr + checked((nuint)18u * unchecked((nuint)sizeof(System.IntPtr)))) = &memoryless;
		*(VRTextureUsage**)((byte*)ptr + checked((nuint)19u * unchecked((nuint)sizeof(System.IntPtr)))) = &vrUsage;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)20u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(name);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Alloc_Public_Static_RTHandle_Int32_Int32_Int32_DepthBits_GraphicsFormat_FilterMode_TextureWrapMode_TextureDimension_Boolean_Boolean_Boolean_Boolean_Int32_Single_MSAASamples_Boolean_Boolean_Boolean_RenderTextureMemoryless_VRTextureUsage_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<RTHandle>(intPtr2) : null;
	}

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 1048376, RefRangeEnd = 1048381, XrefRangeStart = 1048371, XrefRangeEnd = 1048376, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static RTHandle Alloc(int width, int height, GraphicsFormat format, int slices = 1, FilterMode filterMode = FilterMode.Point, TextureWrapMode wrapMode = TextureWrapMode.Repeat, TextureDimension dimension = TextureDimension.Tex2D, bool enableRandomWrite = false, bool useMipMap = false, bool autoGenerateMips = true, bool isShadowMap = false, int anisoLevel = 1, float mipMapBias = 0f, MSAASamples msaaSamples = MSAASamples.None, bool bindTextureMS = false, bool useDynamicScale = false, bool useDynamicScaleExplicit = false, RenderTextureMemoryless memoryless = RenderTextureMemoryless.None, VRTextureUsage vrUsage = VRTextureUsage.None, string name = "")
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[20];
		*ptr = (nint)(&width);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &height;
		*(GraphicsFormat**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &format;
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &slices;
		*(FilterMode**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &filterMode;
		*(TextureWrapMode**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = &wrapMode;
		*(TextureDimension**)((byte*)ptr + checked((nuint)6u * unchecked((nuint)sizeof(System.IntPtr)))) = &dimension;
		*(bool**)((byte*)ptr + checked((nuint)7u * unchecked((nuint)sizeof(System.IntPtr)))) = &enableRandomWrite;
		*(bool**)((byte*)ptr + checked((nuint)8u * unchecked((nuint)sizeof(System.IntPtr)))) = &useMipMap;
		*(bool**)((byte*)ptr + checked((nuint)9u * unchecked((nuint)sizeof(System.IntPtr)))) = &autoGenerateMips;
		*(bool**)((byte*)ptr + checked((nuint)10u * unchecked((nuint)sizeof(System.IntPtr)))) = &isShadowMap;
		*(int**)((byte*)ptr + checked((nuint)11u * unchecked((nuint)sizeof(System.IntPtr)))) = &anisoLevel;
		*(float**)((byte*)ptr + checked((nuint)12u * unchecked((nuint)sizeof(System.IntPtr)))) = &mipMapBias;
		*(MSAASamples**)((byte*)ptr + checked((nuint)13u * unchecked((nuint)sizeof(System.IntPtr)))) = &msaaSamples;
		*(bool**)((byte*)ptr + checked((nuint)14u * unchecked((nuint)sizeof(System.IntPtr)))) = &bindTextureMS;
		*(bool**)((byte*)ptr + checked((nuint)15u * unchecked((nuint)sizeof(System.IntPtr)))) = &useDynamicScale;
		*(bool**)((byte*)ptr + checked((nuint)16u * unchecked((nuint)sizeof(System.IntPtr)))) = &useDynamicScaleExplicit;
		*(RenderTextureMemoryless**)((byte*)ptr + checked((nuint)17u * unchecked((nuint)sizeof(System.IntPtr)))) = &memoryless;
		*(VRTextureUsage**)((byte*)ptr + checked((nuint)18u * unchecked((nuint)sizeof(System.IntPtr)))) = &vrUsage;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)19u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(name);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Alloc_Public_Static_RTHandle_Int32_Int32_GraphicsFormat_Int32_FilterMode_TextureWrapMode_TextureDimension_Boolean_Boolean_Boolean_Boolean_Int32_Single_MSAASamples_Boolean_Boolean_Boolean_RenderTextureMemoryless_VRTextureUsage_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<RTHandle>(intPtr2) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1048381, XrefRangeEnd = 1048392, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static RTHandle Alloc(int width, int height, TextureWrapMode wrapModeU, TextureWrapMode wrapModeV, TextureWrapMode wrapModeW = TextureWrapMode.Repeat, int slices = 1, DepthBits depthBufferBits = DepthBits.None, GraphicsFormat colorFormat = GraphicsFormat.R8G8B8A8_SRGB, FilterMode filterMode = FilterMode.Point, TextureDimension dimension = TextureDimension.Tex2D, bool enableRandomWrite = false, bool useMipMap = false, bool autoGenerateMips = true, bool isShadowMap = false, int anisoLevel = 1, float mipMapBias = 0f, MSAASamples msaaSamples = MSAASamples.None, bool bindTextureMS = false, bool useDynamicScale = false, bool useDynamicScaleExplicit = false, RenderTextureMemoryless memoryless = RenderTextureMemoryless.None, VRTextureUsage vrUsage = VRTextureUsage.None, string name = "")
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[23];
		*ptr = (nint)(&width);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &height;
		*(TextureWrapMode**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &wrapModeU;
		*(TextureWrapMode**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &wrapModeV;
		*(TextureWrapMode**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &wrapModeW;
		*(int**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = &slices;
		*(DepthBits**)((byte*)ptr + checked((nuint)6u * unchecked((nuint)sizeof(System.IntPtr)))) = &depthBufferBits;
		*(GraphicsFormat**)((byte*)ptr + checked((nuint)7u * unchecked((nuint)sizeof(System.IntPtr)))) = &colorFormat;
		*(FilterMode**)((byte*)ptr + checked((nuint)8u * unchecked((nuint)sizeof(System.IntPtr)))) = &filterMode;
		*(TextureDimension**)((byte*)ptr + checked((nuint)9u * unchecked((nuint)sizeof(System.IntPtr)))) = &dimension;
		*(bool**)((byte*)ptr + checked((nuint)10u * unchecked((nuint)sizeof(System.IntPtr)))) = &enableRandomWrite;
		*(bool**)((byte*)ptr + checked((nuint)11u * unchecked((nuint)sizeof(System.IntPtr)))) = &useMipMap;
		*(bool**)((byte*)ptr + checked((nuint)12u * unchecked((nuint)sizeof(System.IntPtr)))) = &autoGenerateMips;
		*(bool**)((byte*)ptr + checked((nuint)13u * unchecked((nuint)sizeof(System.IntPtr)))) = &isShadowMap;
		*(int**)((byte*)ptr + checked((nuint)14u * unchecked((nuint)sizeof(System.IntPtr)))) = &anisoLevel;
		*(float**)((byte*)ptr + checked((nuint)15u * unchecked((nuint)sizeof(System.IntPtr)))) = &mipMapBias;
		*(MSAASamples**)((byte*)ptr + checked((nuint)16u * unchecked((nuint)sizeof(System.IntPtr)))) = &msaaSamples;
		*(bool**)((byte*)ptr + checked((nuint)17u * unchecked((nuint)sizeof(System.IntPtr)))) = &bindTextureMS;
		*(bool**)((byte*)ptr + checked((nuint)18u * unchecked((nuint)sizeof(System.IntPtr)))) = &useDynamicScale;
		*(bool**)((byte*)ptr + checked((nuint)19u * unchecked((nuint)sizeof(System.IntPtr)))) = &useDynamicScaleExplicit;
		*(RenderTextureMemoryless**)((byte*)ptr + checked((nuint)20u * unchecked((nuint)sizeof(System.IntPtr)))) = &memoryless;
		*(VRTextureUsage**)((byte*)ptr + checked((nuint)21u * unchecked((nuint)sizeof(System.IntPtr)))) = &vrUsage;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)22u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(name);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Alloc_Public_Static_RTHandle_Int32_Int32_TextureWrapMode_TextureWrapMode_TextureWrapMode_Int32_DepthBits_GraphicsFormat_FilterMode_TextureDimension_Boolean_Boolean_Boolean_Boolean_Int32_Single_MSAASamples_Boolean_Boolean_Boolean_RenderTextureMemoryless_VRTextureUsage_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<RTHandle>(intPtr2) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1048404, RefRangeEnd = 1048405, XrefRangeStart = 1048392, XrefRangeEnd = 1048404, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static RTHandle Alloc(int width, int height, RTHandleAllocInfo info)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&width);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &height;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)info));
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Alloc_Public_Static_RTHandle_Int32_Int32_RTHandleAllocInfo_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<RTHandle>(intPtr2) : null;
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 1048417, RefRangeEnd = 1048420, XrefRangeStart = 1048405, XrefRangeEnd = 1048417, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static RTHandle Alloc([In] ref RenderTextureDescriptor descriptor, FilterMode filterMode = FilterMode.Point, TextureWrapMode wrapMode = TextureWrapMode.Repeat, bool isShadowMap = false, int anisoLevel = 1, float mipMapBias = 0f, string name = "")
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[7];
		*ptr = (nint)Unsafe.AsPointer(ref descriptor);
		*(FilterMode**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &filterMode;
		*(TextureWrapMode**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &wrapMode;
		*(bool**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &isShadowMap;
		*(int**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &anisoLevel;
		*(float**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = &mipMapBias;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)6u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(name);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Alloc_Public_Static_RTHandle_byref_RenderTextureDescriptor_FilterMode_TextureWrapMode_Boolean_Int32_Single_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<RTHandle>(intPtr2) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1048420, RefRangeEnd = 1048421, XrefRangeStart = 1048420, XrefRangeEnd = 1048420, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static GraphicsFormat GetFormat(GraphicsFormat colorFormat, GraphicsFormat depthStencilFormat)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&colorFormat);
		*(GraphicsFormat**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &depthStencilFormat;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetFormat_Internal_Static_GraphicsFormat_GraphicsFormat_GraphicsFormat_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(GraphicsFormat*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1048421, XrefRangeEnd = 1048431, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static RTHandle Alloc(Vector2 scaleFactor, int slices = 1, DepthBits depthBufferBits = DepthBits.None, GraphicsFormat colorFormat = GraphicsFormat.R8G8B8A8_SRGB, FilterMode filterMode = FilterMode.Point, TextureWrapMode wrapMode = TextureWrapMode.Repeat, TextureDimension dimension = TextureDimension.Tex2D, bool enableRandomWrite = false, bool useMipMap = false, bool autoGenerateMips = true, bool isShadowMap = false, int anisoLevel = 1, float mipMapBias = 0f, MSAASamples msaaSamples = MSAASamples.None, bool bindTextureMS = false, bool useDynamicScale = false, bool useDynamicScaleExplicit = false, RenderTextureMemoryless memoryless = RenderTextureMemoryless.None, VRTextureUsage vrUsage = VRTextureUsage.None, string name = "")
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[20];
		*ptr = (nint)(&scaleFactor);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &slices;
		*(DepthBits**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &depthBufferBits;
		*(GraphicsFormat**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &colorFormat;
		*(FilterMode**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &filterMode;
		*(TextureWrapMode**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = &wrapMode;
		*(TextureDimension**)((byte*)ptr + checked((nuint)6u * unchecked((nuint)sizeof(System.IntPtr)))) = &dimension;
		*(bool**)((byte*)ptr + checked((nuint)7u * unchecked((nuint)sizeof(System.IntPtr)))) = &enableRandomWrite;
		*(bool**)((byte*)ptr + checked((nuint)8u * unchecked((nuint)sizeof(System.IntPtr)))) = &useMipMap;
		*(bool**)((byte*)ptr + checked((nuint)9u * unchecked((nuint)sizeof(System.IntPtr)))) = &autoGenerateMips;
		*(bool**)((byte*)ptr + checked((nuint)10u * unchecked((nuint)sizeof(System.IntPtr)))) = &isShadowMap;
		*(int**)((byte*)ptr + checked((nuint)11u * unchecked((nuint)sizeof(System.IntPtr)))) = &anisoLevel;
		*(float**)((byte*)ptr + checked((nuint)12u * unchecked((nuint)sizeof(System.IntPtr)))) = &mipMapBias;
		*(MSAASamples**)((byte*)ptr + checked((nuint)13u * unchecked((nuint)sizeof(System.IntPtr)))) = &msaaSamples;
		*(bool**)((byte*)ptr + checked((nuint)14u * unchecked((nuint)sizeof(System.IntPtr)))) = &bindTextureMS;
		*(bool**)((byte*)ptr + checked((nuint)15u * unchecked((nuint)sizeof(System.IntPtr)))) = &useDynamicScale;
		*(bool**)((byte*)ptr + checked((nuint)16u * unchecked((nuint)sizeof(System.IntPtr)))) = &useDynamicScaleExplicit;
		*(RenderTextureMemoryless**)((byte*)ptr + checked((nuint)17u * unchecked((nuint)sizeof(System.IntPtr)))) = &memoryless;
		*(VRTextureUsage**)((byte*)ptr + checked((nuint)18u * unchecked((nuint)sizeof(System.IntPtr)))) = &vrUsage;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)19u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(name);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Alloc_Public_Static_RTHandle_Vector2_Int32_DepthBits_GraphicsFormat_FilterMode_TextureWrapMode_TextureDimension_Boolean_Boolean_Boolean_Boolean_Int32_Single_MSAASamples_Boolean_Boolean_Boolean_RenderTextureMemoryless_VRTextureUsage_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<RTHandle>(intPtr2) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1048436, RefRangeEnd = 1048437, XrefRangeStart = 1048431, XrefRangeEnd = 1048436, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static RTHandle Alloc(Vector2 scaleFactor, GraphicsFormat format, int slices = 1, FilterMode filterMode = FilterMode.Point, TextureWrapMode wrapMode = TextureWrapMode.Repeat, TextureDimension dimension = TextureDimension.Tex2D, bool enableRandomWrite = false, bool useMipMap = false, bool autoGenerateMips = true, bool isShadowMap = false, int anisoLevel = 1, float mipMapBias = 0f, MSAASamples msaaSamples = MSAASamples.None, bool bindTextureMS = false, bool useDynamicScale = false, bool useDynamicScaleExplicit = false, RenderTextureMemoryless memoryless = RenderTextureMemoryless.None, VRTextureUsage vrUsage = VRTextureUsage.None, string name = "")
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[19];
		*ptr = (nint)(&scaleFactor);
		*(GraphicsFormat**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &format;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &slices;
		*(FilterMode**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &filterMode;
		*(TextureWrapMode**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &wrapMode;
		*(TextureDimension**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = &dimension;
		*(bool**)((byte*)ptr + checked((nuint)6u * unchecked((nuint)sizeof(System.IntPtr)))) = &enableRandomWrite;
		*(bool**)((byte*)ptr + checked((nuint)7u * unchecked((nuint)sizeof(System.IntPtr)))) = &useMipMap;
		*(bool**)((byte*)ptr + checked((nuint)8u * unchecked((nuint)sizeof(System.IntPtr)))) = &autoGenerateMips;
		*(bool**)((byte*)ptr + checked((nuint)9u * unchecked((nuint)sizeof(System.IntPtr)))) = &isShadowMap;
		*(int**)((byte*)ptr + checked((nuint)10u * unchecked((nuint)sizeof(System.IntPtr)))) = &anisoLevel;
		*(float**)((byte*)ptr + checked((nuint)11u * unchecked((nuint)sizeof(System.IntPtr)))) = &mipMapBias;
		*(MSAASamples**)((byte*)ptr + checked((nuint)12u * unchecked((nuint)sizeof(System.IntPtr)))) = &msaaSamples;
		*(bool**)((byte*)ptr + checked((nuint)13u * unchecked((nuint)sizeof(System.IntPtr)))) = &bindTextureMS;
		*(bool**)((byte*)ptr + checked((nuint)14u * unchecked((nuint)sizeof(System.IntPtr)))) = &useDynamicScale;
		*(bool**)((byte*)ptr + checked((nuint)15u * unchecked((nuint)sizeof(System.IntPtr)))) = &useDynamicScaleExplicit;
		*(RenderTextureMemoryless**)((byte*)ptr + checked((nuint)16u * unchecked((nuint)sizeof(System.IntPtr)))) = &memoryless;
		*(VRTextureUsage**)((byte*)ptr + checked((nuint)17u * unchecked((nuint)sizeof(System.IntPtr)))) = &vrUsage;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)18u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(name);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Alloc_Public_Static_RTHandle_Vector2_GraphicsFormat_Int32_FilterMode_TextureWrapMode_TextureDimension_Boolean_Boolean_Boolean_Boolean_Int32_Single_MSAASamples_Boolean_Boolean_Boolean_RenderTextureMemoryless_VRTextureUsage_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<RTHandle>(intPtr2) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1048449, RefRangeEnd = 1048450, XrefRangeStart = 1048437, XrefRangeEnd = 1048449, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static RTHandle Alloc(Vector2 scaleFactor, [In] ref RenderTextureDescriptor descriptor, FilterMode filterMode = FilterMode.Point, TextureWrapMode wrapMode = TextureWrapMode.Repeat, bool isShadowMap = false, int anisoLevel = 1, float mipMapBias = 0f, string name = "")
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[8];
		*ptr = (nint)(&scaleFactor);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref descriptor);
		*(FilterMode**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &filterMode;
		*(TextureWrapMode**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &wrapMode;
		*(bool**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &isShadowMap;
		*(int**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = &anisoLevel;
		*(float**)((byte*)ptr + checked((nuint)6u * unchecked((nuint)sizeof(System.IntPtr)))) = &mipMapBias;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)7u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(name);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Alloc_Public_Static_RTHandle_Vector2_byref_RenderTextureDescriptor_FilterMode_TextureWrapMode_Boolean_Int32_Single_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<RTHandle>(intPtr2) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1048457, RefRangeEnd = 1048458, XrefRangeStart = 1048450, XrefRangeEnd = 1048457, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static RTHandle Alloc(Vector2 scaleFactor, RTHandleAllocInfo info)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&scaleFactor);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)info));
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Alloc_Public_Static_RTHandle_Vector2_RTHandleAllocInfo_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<RTHandle>(intPtr2) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1048458, XrefRangeEnd = 1048468, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static RTHandle Alloc(ScaleFunc scaleFunc, int slices = 1, DepthBits depthBufferBits = DepthBits.None, GraphicsFormat colorFormat = GraphicsFormat.R8G8B8A8_SRGB, FilterMode filterMode = FilterMode.Point, TextureWrapMode wrapMode = TextureWrapMode.Repeat, TextureDimension dimension = TextureDimension.Tex2D, bool enableRandomWrite = false, bool useMipMap = false, bool autoGenerateMips = true, bool isShadowMap = false, int anisoLevel = 1, float mipMapBias = 0f, MSAASamples msaaSamples = MSAASamples.None, bool bindTextureMS = false, bool useDynamicScale = false, bool useDynamicScaleExplicit = false, RenderTextureMemoryless memoryless = RenderTextureMemoryless.None, VRTextureUsage vrUsage = VRTextureUsage.None, string name = "")
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[20];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)scaleFunc);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &slices;
		*(DepthBits**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &depthBufferBits;
		*(GraphicsFormat**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &colorFormat;
		*(FilterMode**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &filterMode;
		*(TextureWrapMode**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = &wrapMode;
		*(TextureDimension**)((byte*)ptr + checked((nuint)6u * unchecked((nuint)sizeof(System.IntPtr)))) = &dimension;
		*(bool**)((byte*)ptr + checked((nuint)7u * unchecked((nuint)sizeof(System.IntPtr)))) = &enableRandomWrite;
		*(bool**)((byte*)ptr + checked((nuint)8u * unchecked((nuint)sizeof(System.IntPtr)))) = &useMipMap;
		*(bool**)((byte*)ptr + checked((nuint)9u * unchecked((nuint)sizeof(System.IntPtr)))) = &autoGenerateMips;
		*(bool**)((byte*)ptr + checked((nuint)10u * unchecked((nuint)sizeof(System.IntPtr)))) = &isShadowMap;
		*(int**)((byte*)ptr + checked((nuint)11u * unchecked((nuint)sizeof(System.IntPtr)))) = &anisoLevel;
		*(float**)((byte*)ptr + checked((nuint)12u * unchecked((nuint)sizeof(System.IntPtr)))) = &mipMapBias;
		*(MSAASamples**)((byte*)ptr + checked((nuint)13u * unchecked((nuint)sizeof(System.IntPtr)))) = &msaaSamples;
		*(bool**)((byte*)ptr + checked((nuint)14u * unchecked((nuint)sizeof(System.IntPtr)))) = &bindTextureMS;
		*(bool**)((byte*)ptr + checked((nuint)15u * unchecked((nuint)sizeof(System.IntPtr)))) = &useDynamicScale;
		*(bool**)((byte*)ptr + checked((nuint)16u * unchecked((nuint)sizeof(System.IntPtr)))) = &useDynamicScaleExplicit;
		*(RenderTextureMemoryless**)((byte*)ptr + checked((nuint)17u * unchecked((nuint)sizeof(System.IntPtr)))) = &memoryless;
		*(VRTextureUsage**)((byte*)ptr + checked((nuint)18u * unchecked((nuint)sizeof(System.IntPtr)))) = &vrUsage;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)19u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(name);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Alloc_Public_Static_RTHandle_ScaleFunc_Int32_DepthBits_GraphicsFormat_FilterMode_TextureWrapMode_TextureDimension_Boolean_Boolean_Boolean_Boolean_Int32_Single_MSAASamples_Boolean_Boolean_Boolean_RenderTextureMemoryless_VRTextureUsage_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<RTHandle>(intPtr2) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1048473, RefRangeEnd = 1048474, XrefRangeStart = 1048468, XrefRangeEnd = 1048473, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static RTHandle Alloc(ScaleFunc scaleFunc, GraphicsFormat format, int slices = 1, FilterMode filterMode = FilterMode.Point, TextureWrapMode wrapMode = TextureWrapMode.Repeat, TextureDimension dimension = TextureDimension.Tex2D, bool enableRandomWrite = false, bool useMipMap = false, bool autoGenerateMips = true, bool isShadowMap = false, int anisoLevel = 1, float mipMapBias = 0f, MSAASamples msaaSamples = MSAASamples.None, bool bindTextureMS = false, bool useDynamicScale = false, bool useDynamicScaleExplicit = false, RenderTextureMemoryless memoryless = RenderTextureMemoryless.None, VRTextureUsage vrUsage = VRTextureUsage.None, string name = "")
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[19];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)scaleFunc);
		*(GraphicsFormat**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &format;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &slices;
		*(FilterMode**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &filterMode;
		*(TextureWrapMode**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &wrapMode;
		*(TextureDimension**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = &dimension;
		*(bool**)((byte*)ptr + checked((nuint)6u * unchecked((nuint)sizeof(System.IntPtr)))) = &enableRandomWrite;
		*(bool**)((byte*)ptr + checked((nuint)7u * unchecked((nuint)sizeof(System.IntPtr)))) = &useMipMap;
		*(bool**)((byte*)ptr + checked((nuint)8u * unchecked((nuint)sizeof(System.IntPtr)))) = &autoGenerateMips;
		*(bool**)((byte*)ptr + checked((nuint)9u * unchecked((nuint)sizeof(System.IntPtr)))) = &isShadowMap;
		*(int**)((byte*)ptr + checked((nuint)10u * unchecked((nuint)sizeof(System.IntPtr)))) = &anisoLevel;
		*(float**)((byte*)ptr + checked((nuint)11u * unchecked((nuint)sizeof(System.IntPtr)))) = &mipMapBias;
		*(MSAASamples**)((byte*)ptr + checked((nuint)12u * unchecked((nuint)sizeof(System.IntPtr)))) = &msaaSamples;
		*(bool**)((byte*)ptr + checked((nuint)13u * unchecked((nuint)sizeof(System.IntPtr)))) = &bindTextureMS;
		*(bool**)((byte*)ptr + checked((nuint)14u * unchecked((nuint)sizeof(System.IntPtr)))) = &useDynamicScale;
		*(bool**)((byte*)ptr + checked((nuint)15u * unchecked((nuint)sizeof(System.IntPtr)))) = &useDynamicScaleExplicit;
		*(RenderTextureMemoryless**)((byte*)ptr + checked((nuint)16u * unchecked((nuint)sizeof(System.IntPtr)))) = &memoryless;
		*(VRTextureUsage**)((byte*)ptr + checked((nuint)17u * unchecked((nuint)sizeof(System.IntPtr)))) = &vrUsage;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)18u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(name);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Alloc_Public_Static_RTHandle_ScaleFunc_GraphicsFormat_Int32_FilterMode_TextureWrapMode_TextureDimension_Boolean_Boolean_Boolean_Boolean_Int32_Single_MSAASamples_Boolean_Boolean_Boolean_RenderTextureMemoryless_VRTextureUsage_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<RTHandle>(intPtr2) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1048486, RefRangeEnd = 1048487, XrefRangeStart = 1048474, XrefRangeEnd = 1048486, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static RTHandle Alloc(ScaleFunc scaleFunc, [In] ref RenderTextureDescriptor descriptor, FilterMode filterMode = FilterMode.Point, TextureWrapMode wrapMode = TextureWrapMode.Repeat, bool isShadowMap = false, int anisoLevel = 1, float mipMapBias = 0f, string name = "")
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[8];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)scaleFunc);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref descriptor);
		*(FilterMode**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &filterMode;
		*(TextureWrapMode**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &wrapMode;
		*(bool**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &isShadowMap;
		*(int**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = &anisoLevel;
		*(float**)((byte*)ptr + checked((nuint)6u * unchecked((nuint)sizeof(System.IntPtr)))) = &mipMapBias;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)7u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(name);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Alloc_Public_Static_RTHandle_ScaleFunc_byref_RenderTextureDescriptor_FilterMode_TextureWrapMode_Boolean_Int32_Single_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<RTHandle>(intPtr2) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1048493, RefRangeEnd = 1048494, XrefRangeStart = 1048487, XrefRangeEnd = 1048493, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static RTHandle Alloc(ScaleFunc scaleFunc, RTHandleAllocInfo info)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)scaleFunc);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)info));
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Alloc_Public_Static_RTHandle_ScaleFunc_RTHandleAllocInfo_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<RTHandle>(intPtr2) : null;
	}

	[CallerCount(15)]
	[CachedScanResults(RefRangeStart = 1048508, RefRangeEnd = 1048523, XrefRangeStart = 1048494, XrefRangeEnd = 1048508, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static RTHandle Alloc(Texture tex)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)tex);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Alloc_Public_Static_RTHandle_Texture_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<RTHandle>(intPtr2) : null;
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1048535, RefRangeEnd = 1048537, XrefRangeStart = 1048523, XrefRangeEnd = 1048535, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static RTHandle Alloc(RenderTexture tex, bool transferOwnership = false)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)tex);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &transferOwnership;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Alloc_Public_Static_RTHandle_RenderTexture_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<RTHandle>(intPtr2) : null;
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1048544, RefRangeEnd = 1048546, XrefRangeStart = 1048537, XrefRangeEnd = 1048544, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static RTHandle Alloc(RenderTargetIdentifier tex)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&tex);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Alloc_Public_Static_RTHandle_RenderTargetIdentifier_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<RTHandle>(intPtr2) : null;
	}

	[CallerCount(6)]
	[CachedScanResults(RefRangeStart = 1048551, RefRangeEnd = 1048557, XrefRangeStart = 1048546, XrefRangeEnd = 1048551, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static RTHandle Alloc(RenderTargetIdentifier tex, string name)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&tex);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(name);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Alloc_Public_Static_RTHandle_RenderTargetIdentifier_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<RTHandle>(intPtr2) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1048557, XrefRangeEnd = 1048563, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static RTHandle Alloc(RTHandle tex)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)tex);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Alloc_Private_Static_RTHandle_RTHandle_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<RTHandle>(intPtr2) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1048569, RefRangeEnd = 1048570, XrefRangeStart = 1048563, XrefRangeEnd = 1048569, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void Initialize(int width, int height)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&width);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &height;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Initialize_Public_Static_Void_Int32_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1048570, XrefRangeEnd = 1048575, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void Initialize(int width, int height, bool useLegacyDynamicResControl = false)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&width);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &height;
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &useLegacyDynamicResControl;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Initialize_Public_Static_Void_Int32_Int32_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 1048581, RefRangeEnd = 1048586, XrefRangeStart = 1048575, XrefRangeEnd = 1048581, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void Release(RTHandle rth)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)rth);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Release_Public_Static_Void_RTHandle_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1048605, RefRangeEnd = 1048606, XrefRangeStart = 1048586, XrefRangeEnd = 1048605, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SetHardwareDynamicResolutionState(bool hwDynamicResRequested)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&hwDynamicResRequested);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetHardwareDynamicResolutionState_Public_Static_Void_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1048611, RefRangeEnd = 1048612, XrefRangeStart = 1048606, XrefRangeEnd = 1048611, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SetReferenceSize(int width, int height)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&width);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &height;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetReferenceSize_Public_Static_Void_Int32_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1048612, XrefRangeEnd = 1048617, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void ResetReferenceSize(int width, int height)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&width);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &height;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ResetReferenceSize_Public_Static_Void_Int32_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1048617, XrefRangeEnd = 1048622, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Vector2 CalculateRatioAgainstMaxSize(int width, int height)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&width);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &height;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CalculateRatioAgainstMaxSize_Public_Static_Vector2_Int32_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(Vector2*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	public RTHandles(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
