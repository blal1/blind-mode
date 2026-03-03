using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine.Bindings;
using UnityEngine.Rendering;

namespace UnityEngine.Experimental.Rendering;

public class GraphicsFormatUtility : Il2CppSystem.Object
{
	private delegate TextureFormat GetTextureFormat_Native_GraphicsFormatDelegate(GraphicsFormat format);

	private delegate bool IsSwizzleFormatDelegate(GraphicsFormat format);

	private delegate uint GetColorComponentCountDelegate(GraphicsFormat format);

	private delegate bool IsCompressedFormatDelegate(GraphicsFormat format);

	private delegate bool IsPackedFormatDelegate(GraphicsFormat format);

	private delegate bool Is16BitPackedFormatDelegate(GraphicsFormat format);

	private delegate GraphicsFormat ConvertToAlphaFormatDelegate(GraphicsFormat format);

	private delegate TextureFormat ConvertToAlphaFormat_Native_TextureFormatDelegate(TextureFormat format);

	private delegate bool IsAlphaOnlyFormat_Native_TextureFormatDelegate(TextureFormat format);

	private delegate bool IsAlphaTestFormatDelegate(GraphicsFormat format);

	private delegate bool HasAlphaChannel_Native_TextureFormatDelegate(TextureFormat format);

	private delegate bool IsIEEE754FormatDelegate(GraphicsFormat format);

	private delegate bool IsUnsignedFormatDelegate(GraphicsFormat format);

	private delegate bool IsSignedFormatDelegate(GraphicsFormat format);

	private delegate bool IsNormFormatDelegate(GraphicsFormat format);

	private delegate bool IsUNormFormatDelegate(GraphicsFormat format);

	private delegate bool IsSNormFormatDelegate(GraphicsFormat format);

	private delegate bool IsIntegerFormatDelegate(GraphicsFormat format);

	private delegate bool IsUIntFormatDelegate(GraphicsFormat format);

	private delegate bool IsSIntFormatDelegate(GraphicsFormat format);

	private delegate bool IsXRFormatDelegate(GraphicsFormat format);

	private delegate bool IsDXTCFormatDelegate(GraphicsFormat format);

	private delegate bool IsRGTCFormatDelegate(GraphicsFormat format);

	private delegate bool IsBPTCFormatDelegate(GraphicsFormat format);

	private delegate bool IsBCFormatDelegate(GraphicsFormat format);

	private delegate bool IsETCFormatDelegate(GraphicsFormat format);

	private delegate bool IsEACFormatDelegate(GraphicsFormat format);

	private delegate bool IsASTCFormatDelegate(GraphicsFormat format);

	private delegate bool IsHDRFormatDelegate(GraphicsFormat format);

	private delegate bool IsHDRFormat_Native_TextureFormatDelegate(TextureFormat format);

	private delegate uint GetBlockWidthDelegate(GraphicsFormat format);

	private delegate uint GetBlockHeightDelegate(GraphicsFormat format);

	private delegate uint ComputeMipChainSize_Native_2DDelegate(int width, int height, GraphicsFormat format, int mipCount);

	private delegate uint ComputeMipChainSize_Native_3DDelegate(int width, int height, int depth, GraphicsFormat format, int mipCount);

	private delegate void GetFormatString_Native_TextureFormat_InjectedDelegate(TextureFormat format, [Out] System.IntPtr ret);

	private static readonly System.IntPtr NativeFieldInfoPtr_tableNoStencil;

	private static readonly System.IntPtr NativeFieldInfoPtr_tableStencil;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetFormat_Internal_Static_GraphicsFormat_Texture_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetGraphicsFormat_Public_Static_GraphicsFormat_TextureFormat_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetGraphicsFormat_Native_TextureFormat_Private_Static_GraphicsFormat_TextureFormat_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetGraphicsFormat_Public_Static_GraphicsFormat_RenderTextureFormat_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetGraphicsFormat_Native_RenderTextureFormat_Private_Static_GraphicsFormat_RenderTextureFormat_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetGraphicsFormat_Public_Static_GraphicsFormat_RenderTextureFormat_RenderTextureReadWrite_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetDepthStencilFormatFromBitsLegacy_Native_Private_Static_GraphicsFormat_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetDepthStencilFormat_Public_Static_GraphicsFormat_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetDepthBits_Public_Static_Int32_GraphicsFormat_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetDepthStencilFormat_Public_Static_GraphicsFormat_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsSRGBFormat_Public_Static_Boolean_GraphicsFormat_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetSRGBFormat_Public_Static_GraphicsFormat_GraphicsFormat_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetLinearFormat_Public_Static_GraphicsFormat_GraphicsFormat_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetRenderTextureFormat_Public_Static_RenderTextureFormat_GraphicsFormat_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetAlphaComponentCount_Public_Static_UInt32_GraphicsFormat_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetComponentCount_Public_Static_UInt32_GraphicsFormat_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetFormatString_Public_Static_String_GraphicsFormat_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsCompressedFormat_Native_TextureFormat_Private_Static_Boolean_TextureFormat_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsCompressedFormat_Public_Static_Boolean_TextureFormat_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CanDecompressFormat_Private_Static_Boolean_GraphicsFormat_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CanDecompressFormat_Internal_Static_Boolean_GraphicsFormat_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsAlphaOnlyFormat_Public_Static_Boolean_GraphicsFormat_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_HasAlphaChannel_Public_Static_Boolean_GraphicsFormat_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsDepthFormat_Public_Static_Boolean_GraphicsFormat_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsStencilFormat_Public_Static_Boolean_GraphicsFormat_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsDepthStencilFormat_Public_Static_Boolean_GraphicsFormat_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsFloatFormat_Public_Static_Boolean_GraphicsFormat_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsHalfFormat_Public_Static_Boolean_GraphicsFormat_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsPVRTCFormat_Public_Static_Boolean_GraphicsFormat_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsCrunchFormat_Public_Static_Boolean_TextureFormat_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetSwizzleR_Public_Static_FormatSwizzle_GraphicsFormat_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetSwizzleG_Public_Static_FormatSwizzle_GraphicsFormat_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetSwizzleB_Public_Static_FormatSwizzle_GraphicsFormat_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetSwizzleA_Public_Static_FormatSwizzle_GraphicsFormat_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetBlockSize_Public_Static_UInt32_GraphicsFormat_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetFormat_Injected_Private_Static_GraphicsFormat_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetFormatString_Injected_Private_Static_Void_GraphicsFormat_byref_ManagedSpanWrapper_0;

	private static readonly GetTextureFormat_Native_GraphicsFormatDelegate GetTextureFormat_Native_GraphicsFormatDelegateField;

	private static readonly IsSwizzleFormatDelegate IsSwizzleFormatDelegateField;

	private static readonly GetColorComponentCountDelegate GetColorComponentCountDelegateField;

	private static readonly IsCompressedFormatDelegate IsCompressedFormatDelegateField;

	private static readonly IsPackedFormatDelegate IsPackedFormatDelegateField;

	private static readonly Is16BitPackedFormatDelegate Is16BitPackedFormatDelegateField;

	private static readonly ConvertToAlphaFormatDelegate ConvertToAlphaFormatDelegateField;

	private static readonly ConvertToAlphaFormat_Native_TextureFormatDelegate ConvertToAlphaFormat_Native_TextureFormatDelegateField;

	private static readonly IsAlphaOnlyFormat_Native_TextureFormatDelegate IsAlphaOnlyFormat_Native_TextureFormatDelegateField;

	private static readonly IsAlphaTestFormatDelegate IsAlphaTestFormatDelegateField;

	private static readonly HasAlphaChannel_Native_TextureFormatDelegate HasAlphaChannel_Native_TextureFormatDelegateField;

	private static readonly IsIEEE754FormatDelegate IsIEEE754FormatDelegateField;

	private static readonly IsUnsignedFormatDelegate IsUnsignedFormatDelegateField;

	private static readonly IsSignedFormatDelegate IsSignedFormatDelegateField;

	private static readonly IsNormFormatDelegate IsNormFormatDelegateField;

	private static readonly IsUNormFormatDelegate IsUNormFormatDelegateField;

	private static readonly IsSNormFormatDelegate IsSNormFormatDelegateField;

	private static readonly IsIntegerFormatDelegate IsIntegerFormatDelegateField;

	private static readonly IsUIntFormatDelegate IsUIntFormatDelegateField;

	private static readonly IsSIntFormatDelegate IsSIntFormatDelegateField;

	private static readonly IsXRFormatDelegate IsXRFormatDelegateField;

	private static readonly IsDXTCFormatDelegate IsDXTCFormatDelegateField;

	private static readonly IsRGTCFormatDelegate IsRGTCFormatDelegateField;

	private static readonly IsBPTCFormatDelegate IsBPTCFormatDelegateField;

	private static readonly IsBCFormatDelegate IsBCFormatDelegateField;

	private static readonly IsETCFormatDelegate IsETCFormatDelegateField;

	private static readonly IsEACFormatDelegate IsEACFormatDelegateField;

	private static readonly IsASTCFormatDelegate IsASTCFormatDelegateField;

	private static readonly IsHDRFormatDelegate IsHDRFormatDelegateField;

	private static readonly IsHDRFormat_Native_TextureFormatDelegate IsHDRFormat_Native_TextureFormatDelegateField;

	private static readonly GetBlockWidthDelegate GetBlockWidthDelegateField;

	private static readonly GetBlockHeightDelegate GetBlockHeightDelegateField;

	private static readonly ComputeMipChainSize_Native_2DDelegate ComputeMipChainSize_Native_2DDelegateField;

	private static readonly ComputeMipChainSize_Native_3DDelegate ComputeMipChainSize_Native_3DDelegateField;

	private static readonly GetFormatString_Native_TextureFormat_InjectedDelegate GetFormatString_Native_TextureFormat_InjectedDelegateField;

	public unsafe static Il2CppStructArray<GraphicsFormat> tableNoStencil
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_tableNoStencil, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<GraphicsFormat>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_tableNoStencil, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static Il2CppStructArray<GraphicsFormat> tableStencil
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_tableStencil, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<GraphicsFormat>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_tableStencil, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	static GraphicsFormatUtility()
	{
		Il2CppClassPointerStore<GraphicsFormatUtility>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Experimental.Rendering", "GraphicsFormatUtility");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GraphicsFormatUtility>.NativeClassPtr);
		NativeFieldInfoPtr_tableNoStencil = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GraphicsFormatUtility>.NativeClassPtr, "tableNoStencil");
		NativeFieldInfoPtr_tableStencil = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GraphicsFormatUtility>.NativeClassPtr, "tableStencil");
		NativeMethodInfoPtr_GetFormat_Internal_Static_GraphicsFormat_Texture_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphicsFormatUtility>.NativeClassPtr, 100668953);
		NativeMethodInfoPtr_GetGraphicsFormat_Public_Static_GraphicsFormat_TextureFormat_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphicsFormatUtility>.NativeClassPtr, 100668954);
		NativeMethodInfoPtr_GetGraphicsFormat_Native_TextureFormat_Private_Static_GraphicsFormat_TextureFormat_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphicsFormatUtility>.NativeClassPtr, 100668955);
		NativeMethodInfoPtr_GetGraphicsFormat_Public_Static_GraphicsFormat_RenderTextureFormat_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphicsFormatUtility>.NativeClassPtr, 100668956);
		NativeMethodInfoPtr_GetGraphicsFormat_Native_RenderTextureFormat_Private_Static_GraphicsFormat_RenderTextureFormat_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphicsFormatUtility>.NativeClassPtr, 100668957);
		NativeMethodInfoPtr_GetGraphicsFormat_Public_Static_GraphicsFormat_RenderTextureFormat_RenderTextureReadWrite_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphicsFormatUtility>.NativeClassPtr, 100668958);
		NativeMethodInfoPtr_GetDepthStencilFormatFromBitsLegacy_Native_Private_Static_GraphicsFormat_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphicsFormatUtility>.NativeClassPtr, 100668959);
		NativeMethodInfoPtr_GetDepthStencilFormat_Public_Static_GraphicsFormat_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphicsFormatUtility>.NativeClassPtr, 100668960);
		NativeMethodInfoPtr_GetDepthBits_Public_Static_Int32_GraphicsFormat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphicsFormatUtility>.NativeClassPtr, 100668961);
		NativeMethodInfoPtr_GetDepthStencilFormat_Public_Static_GraphicsFormat_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphicsFormatUtility>.NativeClassPtr, 100668962);
		NativeMethodInfoPtr_IsSRGBFormat_Public_Static_Boolean_GraphicsFormat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphicsFormatUtility>.NativeClassPtr, 100668963);
		NativeMethodInfoPtr_GetSRGBFormat_Public_Static_GraphicsFormat_GraphicsFormat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphicsFormatUtility>.NativeClassPtr, 100668964);
		NativeMethodInfoPtr_GetLinearFormat_Public_Static_GraphicsFormat_GraphicsFormat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphicsFormatUtility>.NativeClassPtr, 100668965);
		NativeMethodInfoPtr_GetRenderTextureFormat_Public_Static_RenderTextureFormat_GraphicsFormat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphicsFormatUtility>.NativeClassPtr, 100668966);
		NativeMethodInfoPtr_GetAlphaComponentCount_Public_Static_UInt32_GraphicsFormat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphicsFormatUtility>.NativeClassPtr, 100668967);
		NativeMethodInfoPtr_GetComponentCount_Public_Static_UInt32_GraphicsFormat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphicsFormatUtility>.NativeClassPtr, 100668968);
		NativeMethodInfoPtr_GetFormatString_Public_Static_String_GraphicsFormat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphicsFormatUtility>.NativeClassPtr, 100668969);
		NativeMethodInfoPtr_IsCompressedFormat_Native_TextureFormat_Private_Static_Boolean_TextureFormat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphicsFormatUtility>.NativeClassPtr, 100668970);
		NativeMethodInfoPtr_IsCompressedFormat_Public_Static_Boolean_TextureFormat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphicsFormatUtility>.NativeClassPtr, 100668971);
		NativeMethodInfoPtr_CanDecompressFormat_Private_Static_Boolean_GraphicsFormat_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphicsFormatUtility>.NativeClassPtr, 100668972);
		NativeMethodInfoPtr_CanDecompressFormat_Internal_Static_Boolean_GraphicsFormat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphicsFormatUtility>.NativeClassPtr, 100668973);
		NativeMethodInfoPtr_IsAlphaOnlyFormat_Public_Static_Boolean_GraphicsFormat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphicsFormatUtility>.NativeClassPtr, 100668974);
		NativeMethodInfoPtr_HasAlphaChannel_Public_Static_Boolean_GraphicsFormat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphicsFormatUtility>.NativeClassPtr, 100668975);
		NativeMethodInfoPtr_IsDepthFormat_Public_Static_Boolean_GraphicsFormat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphicsFormatUtility>.NativeClassPtr, 100668976);
		NativeMethodInfoPtr_IsStencilFormat_Public_Static_Boolean_GraphicsFormat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphicsFormatUtility>.NativeClassPtr, 100668977);
		NativeMethodInfoPtr_IsDepthStencilFormat_Public_Static_Boolean_GraphicsFormat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphicsFormatUtility>.NativeClassPtr, 100668978);
		NativeMethodInfoPtr_IsFloatFormat_Public_Static_Boolean_GraphicsFormat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphicsFormatUtility>.NativeClassPtr, 100668979);
		NativeMethodInfoPtr_IsHalfFormat_Public_Static_Boolean_GraphicsFormat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphicsFormatUtility>.NativeClassPtr, 100668980);
		NativeMethodInfoPtr_IsPVRTCFormat_Public_Static_Boolean_GraphicsFormat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphicsFormatUtility>.NativeClassPtr, 100668981);
		NativeMethodInfoPtr_IsCrunchFormat_Public_Static_Boolean_TextureFormat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphicsFormatUtility>.NativeClassPtr, 100668982);
		NativeMethodInfoPtr_GetSwizzleR_Public_Static_FormatSwizzle_GraphicsFormat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphicsFormatUtility>.NativeClassPtr, 100668983);
		NativeMethodInfoPtr_GetSwizzleG_Public_Static_FormatSwizzle_GraphicsFormat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphicsFormatUtility>.NativeClassPtr, 100668984);
		NativeMethodInfoPtr_GetSwizzleB_Public_Static_FormatSwizzle_GraphicsFormat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphicsFormatUtility>.NativeClassPtr, 100668985);
		NativeMethodInfoPtr_GetSwizzleA_Public_Static_FormatSwizzle_GraphicsFormat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphicsFormatUtility>.NativeClassPtr, 100668986);
		NativeMethodInfoPtr_GetBlockSize_Public_Static_UInt32_GraphicsFormat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphicsFormatUtility>.NativeClassPtr, 100668987);
		NativeMethodInfoPtr_GetFormat_Injected_Private_Static_GraphicsFormat_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphicsFormatUtility>.NativeClassPtr, 100668989);
		NativeMethodInfoPtr_GetFormatString_Injected_Private_Static_Void_GraphicsFormat_byref_ManagedSpanWrapper_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphicsFormatUtility>.NativeClassPtr, 100668990);
		GetTextureFormat_Native_GraphicsFormatDelegateField = IL2CPP.ResolveICall<GetTextureFormat_Native_GraphicsFormatDelegate>("UnityEngine.Experimental.Rendering.GraphicsFormatUtility::GetTextureFormat_Native_GraphicsFormat");
		IsSwizzleFormatDelegateField = IL2CPP.ResolveICall<IsSwizzleFormatDelegate>("UnityEngine.Experimental.Rendering.GraphicsFormatUtility::IsSwizzleFormat");
		GetColorComponentCountDelegateField = IL2CPP.ResolveICall<GetColorComponentCountDelegate>("UnityEngine.Experimental.Rendering.GraphicsFormatUtility::GetColorComponentCount");
		IsCompressedFormatDelegateField = IL2CPP.ResolveICall<IsCompressedFormatDelegate>("UnityEngine.Experimental.Rendering.GraphicsFormatUtility::IsCompressedFormat");
		IsPackedFormatDelegateField = IL2CPP.ResolveICall<IsPackedFormatDelegate>("UnityEngine.Experimental.Rendering.GraphicsFormatUtility::IsPackedFormat");
		Is16BitPackedFormatDelegateField = IL2CPP.ResolveICall<Is16BitPackedFormatDelegate>("UnityEngine.Experimental.Rendering.GraphicsFormatUtility::Is16BitPackedFormat");
		ConvertToAlphaFormatDelegateField = IL2CPP.ResolveICall<ConvertToAlphaFormatDelegate>("UnityEngine.Experimental.Rendering.GraphicsFormatUtility::ConvertToAlphaFormat");
		ConvertToAlphaFormat_Native_TextureFormatDelegateField = IL2CPP.ResolveICall<ConvertToAlphaFormat_Native_TextureFormatDelegate>("UnityEngine.Experimental.Rendering.GraphicsFormatUtility::ConvertToAlphaFormat_Native_TextureFormat");
		IsAlphaOnlyFormat_Native_TextureFormatDelegateField = IL2CPP.ResolveICall<IsAlphaOnlyFormat_Native_TextureFormatDelegate>("UnityEngine.Experimental.Rendering.GraphicsFormatUtility::IsAlphaOnlyFormat_Native_TextureFormat");
		IsAlphaTestFormatDelegateField = IL2CPP.ResolveICall<IsAlphaTestFormatDelegate>("UnityEngine.Experimental.Rendering.GraphicsFormatUtility::IsAlphaTestFormat");
		HasAlphaChannel_Native_TextureFormatDelegateField = IL2CPP.ResolveICall<HasAlphaChannel_Native_TextureFormatDelegate>("UnityEngine.Experimental.Rendering.GraphicsFormatUtility::HasAlphaChannel_Native_TextureFormat");
		IsIEEE754FormatDelegateField = IL2CPP.ResolveICall<IsIEEE754FormatDelegate>("UnityEngine.Experimental.Rendering.GraphicsFormatUtility::IsIEEE754Format");
		IsUnsignedFormatDelegateField = IL2CPP.ResolveICall<IsUnsignedFormatDelegate>("UnityEngine.Experimental.Rendering.GraphicsFormatUtility::IsUnsignedFormat");
		IsSignedFormatDelegateField = IL2CPP.ResolveICall<IsSignedFormatDelegate>("UnityEngine.Experimental.Rendering.GraphicsFormatUtility::IsSignedFormat");
		IsNormFormatDelegateField = IL2CPP.ResolveICall<IsNormFormatDelegate>("UnityEngine.Experimental.Rendering.GraphicsFormatUtility::IsNormFormat");
		IsUNormFormatDelegateField = IL2CPP.ResolveICall<IsUNormFormatDelegate>("UnityEngine.Experimental.Rendering.GraphicsFormatUtility::IsUNormFormat");
		IsSNormFormatDelegateField = IL2CPP.ResolveICall<IsSNormFormatDelegate>("UnityEngine.Experimental.Rendering.GraphicsFormatUtility::IsSNormFormat");
		IsIntegerFormatDelegateField = IL2CPP.ResolveICall<IsIntegerFormatDelegate>("UnityEngine.Experimental.Rendering.GraphicsFormatUtility::IsIntegerFormat");
		IsUIntFormatDelegateField = IL2CPP.ResolveICall<IsUIntFormatDelegate>("UnityEngine.Experimental.Rendering.GraphicsFormatUtility::IsUIntFormat");
		IsSIntFormatDelegateField = IL2CPP.ResolveICall<IsSIntFormatDelegate>("UnityEngine.Experimental.Rendering.GraphicsFormatUtility::IsSIntFormat");
		IsXRFormatDelegateField = IL2CPP.ResolveICall<IsXRFormatDelegate>("UnityEngine.Experimental.Rendering.GraphicsFormatUtility::IsXRFormat");
		IsDXTCFormatDelegateField = IL2CPP.ResolveICall<IsDXTCFormatDelegate>("UnityEngine.Experimental.Rendering.GraphicsFormatUtility::IsDXTCFormat");
		IsRGTCFormatDelegateField = IL2CPP.ResolveICall<IsRGTCFormatDelegate>("UnityEngine.Experimental.Rendering.GraphicsFormatUtility::IsRGTCFormat");
		IsBPTCFormatDelegateField = IL2CPP.ResolveICall<IsBPTCFormatDelegate>("UnityEngine.Experimental.Rendering.GraphicsFormatUtility::IsBPTCFormat");
		IsBCFormatDelegateField = IL2CPP.ResolveICall<IsBCFormatDelegate>("UnityEngine.Experimental.Rendering.GraphicsFormatUtility::IsBCFormat");
		IsETCFormatDelegateField = IL2CPP.ResolveICall<IsETCFormatDelegate>("UnityEngine.Experimental.Rendering.GraphicsFormatUtility::IsETCFormat");
		IsEACFormatDelegateField = IL2CPP.ResolveICall<IsEACFormatDelegate>("UnityEngine.Experimental.Rendering.GraphicsFormatUtility::IsEACFormat");
		IsASTCFormatDelegateField = IL2CPP.ResolveICall<IsASTCFormatDelegate>("UnityEngine.Experimental.Rendering.GraphicsFormatUtility::IsASTCFormat");
		IsHDRFormatDelegateField = IL2CPP.ResolveICall<IsHDRFormatDelegate>("UnityEngine.Experimental.Rendering.GraphicsFormatUtility::IsHDRFormat");
		IsHDRFormat_Native_TextureFormatDelegateField = IL2CPP.ResolveICall<IsHDRFormat_Native_TextureFormatDelegate>("UnityEngine.Experimental.Rendering.GraphicsFormatUtility::IsHDRFormat_Native_TextureFormat");
		GetBlockWidthDelegateField = IL2CPP.ResolveICall<GetBlockWidthDelegate>("UnityEngine.Experimental.Rendering.GraphicsFormatUtility::GetBlockWidth");
		GetBlockHeightDelegateField = IL2CPP.ResolveICall<GetBlockHeightDelegate>("UnityEngine.Experimental.Rendering.GraphicsFormatUtility::GetBlockHeight");
		ComputeMipChainSize_Native_2DDelegateField = IL2CPP.ResolveICall<ComputeMipChainSize_Native_2DDelegate>("UnityEngine.Experimental.Rendering.GraphicsFormatUtility::ComputeMipChainSize_Native_2D");
		ComputeMipChainSize_Native_3DDelegateField = IL2CPP.ResolveICall<ComputeMipChainSize_Native_3DDelegate>("UnityEngine.Experimental.Rendering.GraphicsFormatUtility::ComputeMipChainSize_Native_3D");
		GetFormatString_Native_TextureFormat_InjectedDelegateField = IL2CPP.ResolveICall<GetFormatString_Native_TextureFormat_InjectedDelegate>("UnityEngine.Experimental.Rendering.GraphicsFormatUtility::GetFormatString_Native_TextureFormat_Injected");
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1241116, RefRangeEnd = 1241117, XrefRangeStart = 1241104, XrefRangeEnd = 1241116, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static GraphicsFormat GetFormat(Texture texture)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)texture);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetFormat_Internal_Static_GraphicsFormat_Texture_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(GraphicsFormat*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(9)]
	[CachedScanResults(RefRangeStart = 1241122, RefRangeEnd = 1241131, XrefRangeStart = 1241117, XrefRangeEnd = 1241122, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static GraphicsFormat GetGraphicsFormat(TextureFormat format, bool isSRGB)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&format);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &isSRGB;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetGraphicsFormat_Public_Static_GraphicsFormat_TextureFormat_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(GraphicsFormat*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1241131, XrefRangeEnd = 1241133, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static GraphicsFormat GetGraphicsFormat_Native_TextureFormat(TextureFormat format, bool isSRGB)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&format);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &isSRGB;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetGraphicsFormat_Native_TextureFormat_Private_Static_GraphicsFormat_TextureFormat_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(GraphicsFormat*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1241138, RefRangeEnd = 1241139, XrefRangeStart = 1241133, XrefRangeEnd = 1241138, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static GraphicsFormat GetGraphicsFormat(RenderTextureFormat format, bool isSRGB)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&format);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &isSRGB;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetGraphicsFormat_Public_Static_GraphicsFormat_RenderTextureFormat_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(GraphicsFormat*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1241139, XrefRangeEnd = 1241141, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static GraphicsFormat GetGraphicsFormat_Native_RenderTextureFormat(RenderTextureFormat format, bool isSRGB)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&format);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &isSRGB;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetGraphicsFormat_Native_RenderTextureFormat_Private_Static_GraphicsFormat_RenderTextureFormat_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(GraphicsFormat*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1241151, RefRangeEnd = 1241152, XrefRangeStart = 1241141, XrefRangeEnd = 1241151, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static GraphicsFormat GetGraphicsFormat(RenderTextureFormat format, RenderTextureReadWrite readWrite)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&format);
		*(RenderTextureReadWrite**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &readWrite;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetGraphicsFormat_Public_Static_GraphicsFormat_RenderTextureFormat_RenderTextureReadWrite_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(GraphicsFormat*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1241152, XrefRangeEnd = 1241154, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static GraphicsFormat GetDepthStencilFormatFromBitsLegacy_Native(int minimumDepthBits)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&minimumDepthBits);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetDepthStencilFormatFromBitsLegacy_Native_Private_Static_GraphicsFormat_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(GraphicsFormat*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(12)]
	[CachedScanResults(RefRangeStart = 1241159, RefRangeEnd = 1241171, XrefRangeStart = 1241154, XrefRangeEnd = 1241159, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static GraphicsFormat GetDepthStencilFormat(int depthBits)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&depthBits);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetDepthStencilFormat_Public_Static_GraphicsFormat_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(GraphicsFormat*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 1241173, RefRangeEnd = 1241177, XrefRangeStart = 1241171, XrefRangeEnd = 1241173, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int GetDepthBits(GraphicsFormat format)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&format);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetDepthBits_Public_Static_Int32_GraphicsFormat_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 1241196, RefRangeEnd = 1241199, XrefRangeStart = 1241177, XrefRangeEnd = 1241196, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static GraphicsFormat GetDepthStencilFormat(int minimumDepthBits, int minimumStencilBits)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&minimumDepthBits);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &minimumStencilBits;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetDepthStencilFormat_Public_Static_GraphicsFormat_Int32_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(GraphicsFormat*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(26)]
	[CachedScanResults(RefRangeStart = 1241201, RefRangeEnd = 1241227, XrefRangeStart = 1241199, XrefRangeEnd = 1241201, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool IsSRGBFormat(GraphicsFormat format)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&format);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsSRGBFormat_Public_Static_Boolean_GraphicsFormat_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1241229, RefRangeEnd = 1241230, XrefRangeStart = 1241227, XrefRangeEnd = 1241229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static GraphicsFormat GetSRGBFormat(GraphicsFormat format)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&format);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetSRGBFormat_Public_Static_GraphicsFormat_GraphicsFormat_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(GraphicsFormat*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1241232, RefRangeEnd = 1241234, XrefRangeStart = 1241230, XrefRangeEnd = 1241232, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static GraphicsFormat GetLinearFormat(GraphicsFormat format)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&format);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetLinearFormat_Public_Static_GraphicsFormat_GraphicsFormat_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(GraphicsFormat*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1241236, RefRangeEnd = 1241237, XrefRangeStart = 1241234, XrefRangeEnd = 1241236, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static RenderTextureFormat GetRenderTextureFormat(GraphicsFormat format)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&format);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetRenderTextureFormat_Public_Static_RenderTextureFormat_GraphicsFormat_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(RenderTextureFormat*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1241239, RefRangeEnd = 1241240, XrefRangeStart = 1241237, XrefRangeEnd = 1241239, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static uint GetAlphaComponentCount(GraphicsFormat format)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&format);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetAlphaComponentCount_Public_Static_UInt32_GraphicsFormat_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(uint*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 1241242, RefRangeEnd = 1241247, XrefRangeStart = 1241240, XrefRangeEnd = 1241242, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static uint GetComponentCount(GraphicsFormat format)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&format);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetComponentCount_Public_Static_UInt32_GraphicsFormat_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(uint*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1241255, RefRangeEnd = 1241256, XrefRangeStart = 1241247, XrefRangeEnd = 1241255, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string GetFormatString(GraphicsFormat format)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&format);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetFormatString_Public_Static_String_GraphicsFormat_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return IL2CPP.Il2CppStringToManaged(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1241256, XrefRangeEnd = 1241258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool IsCompressedFormat_Native_TextureFormat(TextureFormat format)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&format);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsCompressedFormat_Native_TextureFormat_Private_Static_Boolean_TextureFormat_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1241263, RefRangeEnd = 1241264, XrefRangeStart = 1241258, XrefRangeEnd = 1241263, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool IsCompressedFormat(TextureFormat format)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&format);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsCompressedFormat_Public_Static_Boolean_TextureFormat_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1241264, XrefRangeEnd = 1241266, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool CanDecompressFormat(GraphicsFormat format, bool wholeImage)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&format);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &wholeImage;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CanDecompressFormat_Private_Static_Boolean_GraphicsFormat_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1241271, RefRangeEnd = 1241272, XrefRangeStart = 1241266, XrefRangeEnd = 1241271, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool CanDecompressFormat(GraphicsFormat format)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&format);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CanDecompressFormat_Internal_Static_Boolean_GraphicsFormat_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1241274, RefRangeEnd = 1241276, XrefRangeStart = 1241272, XrefRangeEnd = 1241274, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool IsAlphaOnlyFormat(GraphicsFormat format)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&format);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsAlphaOnlyFormat_Public_Static_Boolean_GraphicsFormat_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 1241278, RefRangeEnd = 1241281, XrefRangeStart = 1241276, XrefRangeEnd = 1241278, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool HasAlphaChannel(GraphicsFormat format)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&format);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_HasAlphaChannel_Public_Static_Boolean_GraphicsFormat_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1241283, RefRangeEnd = 1241285, XrefRangeStart = 1241281, XrefRangeEnd = 1241283, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool IsDepthFormat(GraphicsFormat format)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&format);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsDepthFormat_Public_Static_Boolean_GraphicsFormat_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 1241305, RefRangeEnd = 1241308, XrefRangeStart = 1241285, XrefRangeEnd = 1241305, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool IsStencilFormat(GraphicsFormat format)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&format);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsStencilFormat_Public_Static_Boolean_GraphicsFormat_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(6)]
	[CachedScanResults(RefRangeStart = 1241310, RefRangeEnd = 1241316, XrefRangeStart = 1241308, XrefRangeEnd = 1241310, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool IsDepthStencilFormat(GraphicsFormat format)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&format);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsDepthStencilFormat_Public_Static_Boolean_GraphicsFormat_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1241318, RefRangeEnd = 1241320, XrefRangeStart = 1241316, XrefRangeEnd = 1241318, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool IsFloatFormat(GraphicsFormat format)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&format);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsFloatFormat_Public_Static_Boolean_GraphicsFormat_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1241322, RefRangeEnd = 1241324, XrefRangeStart = 1241320, XrefRangeEnd = 1241322, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool IsHalfFormat(GraphicsFormat format)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&format);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsHalfFormat_Public_Static_Boolean_GraphicsFormat_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(6)]
	[CachedScanResults(RefRangeStart = 1241326, RefRangeEnd = 1241332, XrefRangeStart = 1241324, XrefRangeEnd = 1241326, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool IsPVRTCFormat(GraphicsFormat format)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&format);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsPVRTCFormat_Public_Static_Boolean_GraphicsFormat_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(9)]
	[CachedScanResults(RefRangeStart = 1241334, RefRangeEnd = 1241343, XrefRangeStart = 1241332, XrefRangeEnd = 1241334, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool IsCrunchFormat(TextureFormat format)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&format);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsCrunchFormat_Public_Static_Boolean_TextureFormat_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 1241345, RefRangeEnd = 1241349, XrefRangeStart = 1241343, XrefRangeEnd = 1241345, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static FormatSwizzle GetSwizzleR(GraphicsFormat format)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&format);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetSwizzleR_Public_Static_FormatSwizzle_GraphicsFormat_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(FormatSwizzle*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1241351, RefRangeEnd = 1241353, XrefRangeStart = 1241349, XrefRangeEnd = 1241351, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static FormatSwizzle GetSwizzleG(GraphicsFormat format)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&format);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetSwizzleG_Public_Static_FormatSwizzle_GraphicsFormat_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(FormatSwizzle*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1241355, RefRangeEnd = 1241357, XrefRangeStart = 1241353, XrefRangeEnd = 1241355, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static FormatSwizzle GetSwizzleB(GraphicsFormat format)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&format);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetSwizzleB_Public_Static_FormatSwizzle_GraphicsFormat_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(FormatSwizzle*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1241359, RefRangeEnd = 1241361, XrefRangeStart = 1241357, XrefRangeEnd = 1241359, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static FormatSwizzle GetSwizzleA(GraphicsFormat format)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&format);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetSwizzleA_Public_Static_FormatSwizzle_GraphicsFormat_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(FormatSwizzle*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 1241363, RefRangeEnd = 1241366, XrefRangeStart = 1241361, XrefRangeEnd = 1241363, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static uint GetBlockSize(GraphicsFormat format)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&format);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetBlockSize_Public_Static_UInt32_GraphicsFormat_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(uint*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1241366, XrefRangeEnd = 1241368, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static GraphicsFormat GetFormat_Injected(System.IntPtr texture)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&texture);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetFormat_Injected_Private_Static_GraphicsFormat_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(GraphicsFormat*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1241368, XrefRangeEnd = 1241370, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void GetFormatString_Injected(GraphicsFormat format, out ManagedSpanWrapper ret)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&format);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref ret);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetFormatString_Injected_Private_Static_Void_GraphicsFormat_byref_ManagedSpanWrapper_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public GraphicsFormatUtility(System.IntPtr pointer)
		: base(pointer)
	{
	}

	public static TextureFormat GetTextureFormat(GraphicsFormat format)
	{
		return GetTextureFormat_Native_GraphicsFormat(format);
	}

	public static TextureFormat GetTextureFormat_Native_GraphicsFormat(GraphicsFormat format)
	{
		return GetTextureFormat_Native_GraphicsFormatDelegateField(format);
	}

	public static bool IsSwizzleFormat(GraphicsFormat format)
	{
		return IsSwizzleFormatDelegateField(format);
	}

	public static bool IsSwizzleFormat(TextureFormat format)
	{
		return IsSwizzleFormat(GetGraphicsFormat(format, isSRGB: false));
	}

	public static uint GetColorComponentCount(GraphicsFormat format)
	{
		return GetColorComponentCountDelegateField(format);
	}

	public static uint GetColorComponentCount(TextureFormat format)
	{
		return GetColorComponentCount(GetGraphicsFormat(format, isSRGB: false));
	}

	public static uint GetAlphaComponentCount(TextureFormat format)
	{
		return GetAlphaComponentCount(GetGraphicsFormat(format, isSRGB: false));
	}

	public static uint GetComponentCount(TextureFormat format)
	{
		return GetComponentCount(GetGraphicsFormat(format, isSRGB: false));
	}

	public static string GetFormatString_Native_TextureFormat(TextureFormat format)
	{
		Unsafe.SkipInit(out ManagedSpanWrapper ret);
		string stringAndDispose;
		try
		{
			GetFormatString_Native_TextureFormat_Injected(format, out ret);
		}
		finally
		{
			stringAndDispose = OutStringMarshaller.GetStringAndDispose(ret);
		}
		return stringAndDispose;
	}

	public static string GetFormatString(TextureFormat format)
	{
		return GetFormatString_Native_TextureFormat(format);
	}

	public static bool IsCompressedFormat(GraphicsFormat format)
	{
		return IsCompressedFormatDelegateField(format);
	}

	public static bool IsCompressedTextureFormat(TextureFormat format)
	{
		return IsCompressedFormat(format);
	}

	public static bool IsPackedFormat(GraphicsFormat format)
	{
		return IsPackedFormatDelegateField(format);
	}

	public static bool IsPackedFormat(TextureFormat format)
	{
		return IsPackedFormat(GetGraphicsFormat(format, isSRGB: false));
	}

	public static bool Is16BitPackedFormat(GraphicsFormat format)
	{
		return Is16BitPackedFormatDelegateField(format);
	}

	public static bool Is16BitPackedFormat(TextureFormat format)
	{
		return Is16BitPackedFormat(GetGraphicsFormat(format, isSRGB: false));
	}

	public static GraphicsFormat ConvertToAlphaFormat(GraphicsFormat format)
	{
		return ConvertToAlphaFormatDelegateField(format);
	}

	public static TextureFormat ConvertToAlphaFormat_Native_TextureFormat(TextureFormat format)
	{
		return ConvertToAlphaFormat_Native_TextureFormatDelegateField(format);
	}

	public static TextureFormat ConvertToAlphaFormat(TextureFormat format)
	{
		return ConvertToAlphaFormat_Native_TextureFormat(format);
	}

	public static bool IsAlphaOnlyFormat_Native_TextureFormat(TextureFormat format)
	{
		return IsAlphaOnlyFormat_Native_TextureFormatDelegateField(format);
	}

	public static bool IsAlphaOnlyFormat(TextureFormat format)
	{
		return IsAlphaOnlyFormat_Native_TextureFormat(format);
	}

	public static bool IsAlphaTestFormat(GraphicsFormat format)
	{
		return IsAlphaTestFormatDelegateField(format);
	}

	public static bool IsAlphaTestFormat(TextureFormat format)
	{
		return IsAlphaTestFormat(GetGraphicsFormat(format, isSRGB: false));
	}

	public static bool HasAlphaChannel_Native_TextureFormat(TextureFormat format)
	{
		return HasAlphaChannel_Native_TextureFormatDelegateField(format);
	}

	public static bool HasAlphaChannel(TextureFormat format)
	{
		return HasAlphaChannel_Native_TextureFormat(format);
	}

	public static bool IsIEEE754Format(GraphicsFormat format)
	{
		return IsIEEE754FormatDelegateField(format);
	}

	public static bool IsUnsignedFormat(GraphicsFormat format)
	{
		return IsUnsignedFormatDelegateField(format);
	}

	public static bool IsUnsignedFormat(TextureFormat format)
	{
		return IsUnsignedFormat(GetGraphicsFormat(format, isSRGB: false));
	}

	public static bool IsSignedFormat(GraphicsFormat format)
	{
		return IsSignedFormatDelegateField(format);
	}

	public static bool IsSignedFormat(TextureFormat format)
	{
		return IsSignedFormat(GetGraphicsFormat(format, isSRGB: false));
	}

	public static bool IsNormFormat(GraphicsFormat format)
	{
		return IsNormFormatDelegateField(format);
	}

	public static bool IsUNormFormat(GraphicsFormat format)
	{
		return IsUNormFormatDelegateField(format);
	}

	public static bool IsSNormFormat(GraphicsFormat format)
	{
		return IsSNormFormatDelegateField(format);
	}

	public static bool IsIntegerFormat(GraphicsFormat format)
	{
		return IsIntegerFormatDelegateField(format);
	}

	public static bool IsUIntFormat(GraphicsFormat format)
	{
		return IsUIntFormatDelegateField(format);
	}

	public static bool IsSIntFormat(GraphicsFormat format)
	{
		return IsSIntFormatDelegateField(format);
	}

	public static bool IsXRFormat(GraphicsFormat format)
	{
		return IsXRFormatDelegateField(format);
	}

	public static bool IsDXTCFormat(GraphicsFormat format)
	{
		return IsDXTCFormatDelegateField(format);
	}

	public static bool IsDXTCFormat(TextureFormat format)
	{
		return IsDXTCFormat(GetGraphicsFormat(format, isSRGB: false));
	}

	public static bool IsRGTCFormat(GraphicsFormat format)
	{
		return IsRGTCFormatDelegateField(format);
	}

	public static bool IsRGTCFormat(TextureFormat format)
	{
		return IsRGTCFormat(GetGraphicsFormat(format, isSRGB: false));
	}

	public static bool IsBPTCFormat(GraphicsFormat format)
	{
		return IsBPTCFormatDelegateField(format);
	}

	public static bool IsBPTCFormat(TextureFormat format)
	{
		return IsBPTCFormat(GetGraphicsFormat(format, isSRGB: false));
	}

	public static bool IsBCFormat(GraphicsFormat format)
	{
		return IsBCFormatDelegateField(format);
	}

	public static bool IsBCFormat(TextureFormat format)
	{
		return IsBCFormat(GetGraphicsFormat(format, isSRGB: false));
	}

	public static bool IsPVRTCFormat(TextureFormat format)
	{
		return IsPVRTCFormat(GetGraphicsFormat(format, isSRGB: false));
	}

	public static bool IsETCFormat(GraphicsFormat format)
	{
		return IsETCFormatDelegateField(format);
	}

	public static bool IsETCFormat(TextureFormat format)
	{
		return IsETCFormat(GetGraphicsFormat(format, isSRGB: false));
	}

	public static bool IsEACFormat(GraphicsFormat format)
	{
		return IsEACFormatDelegateField(format);
	}

	public static bool IsEACFormat(TextureFormat format)
	{
		return IsEACFormat(GetGraphicsFormat(format, isSRGB: false));
	}

	public static bool IsASTCFormat(GraphicsFormat format)
	{
		return IsASTCFormatDelegateField(format);
	}

	public static bool IsASTCFormat(TextureFormat format)
	{
		return IsASTCFormat(GetGraphicsFormat(format, isSRGB: false));
	}

	public static bool IsHDRFormat(GraphicsFormat format)
	{
		return IsHDRFormatDelegateField(format);
	}

	public static bool IsHDRFormat_Native_TextureFormat(TextureFormat format)
	{
		return IsHDRFormat_Native_TextureFormatDelegateField(format);
	}

	public static bool IsHDRFormat(TextureFormat format)
	{
		return IsHDRFormat_Native_TextureFormat(format);
	}

	public static FormatSwizzle GetSwizzleR(TextureFormat format)
	{
		return GetSwizzleR(GetGraphicsFormat(format, isSRGB: false));
	}

	public static FormatSwizzle GetSwizzleG(TextureFormat format)
	{
		return GetSwizzleG(GetGraphicsFormat(format, isSRGB: false));
	}

	public static FormatSwizzle GetSwizzleB(TextureFormat format)
	{
		return GetSwizzleB(GetGraphicsFormat(format, isSRGB: false));
	}

	public static FormatSwizzle GetSwizzleA(TextureFormat format)
	{
		return GetSwizzleA(GetGraphicsFormat(format, isSRGB: false));
	}

	public static uint GetBlockSize(TextureFormat format)
	{
		return GetBlockSize(GetGraphicsFormat(format, isSRGB: false));
	}

	public static uint GetBlockWidth(GraphicsFormat format)
	{
		return GetBlockWidthDelegateField(format);
	}

	public static uint GetBlockWidth(TextureFormat format)
	{
		return GetBlockWidth(GetGraphicsFormat(format, isSRGB: false));
	}

	public static uint GetBlockHeight(GraphicsFormat format)
	{
		return GetBlockHeightDelegateField(format);
	}

	public static uint GetBlockHeight(TextureFormat format)
	{
		return GetBlockHeight(GetGraphicsFormat(format, isSRGB: false));
	}

	public static uint ComputeMipmapSize(int width, int height, GraphicsFormat format)
	{
		return ComputeMipChainSize_Native_2D(width, height, format, 1);
	}

	public static uint ComputeMipmapSize(int width, int height, TextureFormat format)
	{
		return ComputeMipmapSize(width, height, GetGraphicsFormat(format, isSRGB: false));
	}

	public static uint ComputeMipChainSize_Native_2D(int width, int height, GraphicsFormat format, int mipCount)
	{
		return ComputeMipChainSize_Native_2DDelegateField(width, height, format, mipCount);
	}

	public static uint ComputeMipChainSize(int width, int height, GraphicsFormat format, [Optional] int mipCount)
	{
		return ComputeMipChainSize_Native_2D(width, height, format, mipCount);
	}

	public static uint ComputeMipChainSize(int width, int height, TextureFormat format, [Optional] int mipCount)
	{
		return ComputeMipChainSize_Native_2D(width, height, GetGraphicsFormat(format, isSRGB: false), mipCount);
	}

	public static uint ComputeMipmapSize(int width, int height, int depth, GraphicsFormat format)
	{
		return ComputeMipChainSize_Native_3D(width, height, depth, format, 1);
	}

	public static uint ComputeMipmapSize(int width, int height, int depth, TextureFormat format)
	{
		return ComputeMipmapSize(width, height, depth, GetGraphicsFormat(format, isSRGB: false));
	}

	public static uint ComputeMipChainSize_Native_3D(int width, int height, int depth, GraphicsFormat format, int mipCount)
	{
		return ComputeMipChainSize_Native_3DDelegateField(width, height, depth, format, mipCount);
	}

	public static uint ComputeMipChainSize(int width, int height, int depth, GraphicsFormat format, [Optional] int mipCount)
	{
		return ComputeMipChainSize_Native_3D(width, height, depth, format, mipCount);
	}

	public static uint ComputeMipChainSize(int width, int height, int depth, TextureFormat format, [Optional] int mipCount)
	{
		return ComputeMipChainSize_Native_3D(width, height, depth, GetGraphicsFormat(format, isSRGB: false), mipCount);
	}

	public unsafe static void GetFormatString_Native_TextureFormat_Injected(TextureFormat format, out ManagedSpanWrapper ret)
	{
		GetFormatString_Native_TextureFormat_InjectedDelegateField(format, (nint)Unsafe.AsPointer(ref ret));
	}
}
