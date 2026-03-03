using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.Rendering;

public static class TextureXR : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_m_MaxViews;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_BlackUIntTexture2DArray;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_BlackUIntTexture;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_BlackUIntTexture2DArrayRTH;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_BlackUIntTextureRTH;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_ClearTexture2DArray;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_ClearTexture;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_ClearTexture2DArrayRTH;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_ClearTextureRTH;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_MagentaTexture2DArray;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_MagentaTexture;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_MagentaTexture2DArrayRTH;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_MagentaTextureRTH;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_BlackTexture;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_BlackTexture3D;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_BlackTexture2DArray;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_BlackTexture2DArrayRTH;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_BlackTextureRTH;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_BlackTexture3DRTH;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_WhiteTexture2DArray;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_WhiteTexture2DArrayRTH;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_WhiteTextureRTH;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_maxViews_Public_Static_set_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_slices_Public_Static_get_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_useTexArray_Public_Static_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_dimension_Public_Static_get_TextureDimension_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetBlackUIntTexture_Public_Static_RTHandle_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetClearTexture_Public_Static_RTHandle_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetMagentaTexture_Public_Static_RTHandle_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetBlackTexture_Public_Static_RTHandle_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetBlackTextureArray_Public_Static_RTHandle_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetBlackTexture3D_Public_Static_RTHandle_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetWhiteTexture_Public_Static_RTHandle_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Initialize_Public_Static_Void_CommandBuffer_ComputeShader_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CreateTexture2DArrayFromTexture2D_Private_Static_Texture2DArray_Texture2D_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CreateBlackUIntTextureArray_Private_Static_Texture_CommandBuffer_ComputeShader_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CreateBlackUintTexture_Private_Static_Texture_CommandBuffer_ComputeShader_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CreateBlackTexture3D_Private_Static_Texture3D_String_0;

	public unsafe static int m_MaxViews
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_m_MaxViews, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_m_MaxViews, (void*)(&value));
		}
	}

	public unsafe static Texture m_BlackUIntTexture2DArray
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_m_BlackUIntTexture2DArray, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Texture>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_m_BlackUIntTexture2DArray, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static Texture m_BlackUIntTexture
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_m_BlackUIntTexture, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Texture>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_m_BlackUIntTexture, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static RTHandle m_BlackUIntTexture2DArrayRTH
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_m_BlackUIntTexture2DArrayRTH, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<RTHandle>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_m_BlackUIntTexture2DArrayRTH, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static RTHandle m_BlackUIntTextureRTH
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_m_BlackUIntTextureRTH, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<RTHandle>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_m_BlackUIntTextureRTH, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static Texture2DArray m_ClearTexture2DArray
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_m_ClearTexture2DArray, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Texture2DArray>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_m_ClearTexture2DArray, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static Texture2D m_ClearTexture
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_m_ClearTexture, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Texture2D>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_m_ClearTexture, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static RTHandle m_ClearTexture2DArrayRTH
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_m_ClearTexture2DArrayRTH, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<RTHandle>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_m_ClearTexture2DArrayRTH, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static RTHandle m_ClearTextureRTH
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_m_ClearTextureRTH, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<RTHandle>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_m_ClearTextureRTH, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static Texture2DArray m_MagentaTexture2DArray
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_m_MagentaTexture2DArray, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Texture2DArray>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_m_MagentaTexture2DArray, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static Texture2D m_MagentaTexture
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_m_MagentaTexture, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Texture2D>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_m_MagentaTexture, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static RTHandle m_MagentaTexture2DArrayRTH
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_m_MagentaTexture2DArrayRTH, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<RTHandle>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_m_MagentaTexture2DArrayRTH, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static RTHandle m_MagentaTextureRTH
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_m_MagentaTextureRTH, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<RTHandle>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_m_MagentaTextureRTH, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static Texture2D m_BlackTexture
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_m_BlackTexture, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Texture2D>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_m_BlackTexture, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static Texture3D m_BlackTexture3D
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_m_BlackTexture3D, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Texture3D>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_m_BlackTexture3D, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static Texture2DArray m_BlackTexture2DArray
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_m_BlackTexture2DArray, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Texture2DArray>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_m_BlackTexture2DArray, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static RTHandle m_BlackTexture2DArrayRTH
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_m_BlackTexture2DArrayRTH, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<RTHandle>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_m_BlackTexture2DArrayRTH, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static RTHandle m_BlackTextureRTH
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_m_BlackTextureRTH, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<RTHandle>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_m_BlackTextureRTH, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static RTHandle m_BlackTexture3DRTH
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_m_BlackTexture3DRTH, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<RTHandle>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_m_BlackTexture3DRTH, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static Texture2DArray m_WhiteTexture2DArray
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_m_WhiteTexture2DArray, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Texture2DArray>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_m_WhiteTexture2DArray, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static RTHandle m_WhiteTexture2DArrayRTH
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_m_WhiteTexture2DArrayRTH, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<RTHandle>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_m_WhiteTexture2DArrayRTH, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static RTHandle m_WhiteTextureRTH
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_m_WhiteTextureRTH, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<RTHandle>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_m_WhiteTextureRTH, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static int maxViews
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1049500, XrefRangeEnd = 1049504, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_maxViews_Public_Static_set_Void_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe static int slices
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1049504, XrefRangeEnd = 1049508, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_slices_Public_Static_get_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe static bool useTexArray
	{
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1049509, RefRangeEnd = 1049512, XrefRangeStart = 1049508, XrefRangeEnd = 1049509, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_useTexArray_Public_Static_get_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe static TextureDimension dimension
	{
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1049516, RefRangeEnd = 1049519, XrefRangeStart = 1049512, XrefRangeEnd = 1049516, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_dimension_Public_Static_get_TextureDimension_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(TextureDimension*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	static TextureXR()
	{
		Il2CppClassPointerStore<TextureXR>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Core.Runtime.dll", "UnityEngine.Rendering", "TextureXR");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TextureXR>.NativeClassPtr);
		NativeFieldInfoPtr_m_MaxViews = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextureXR>.NativeClassPtr, "m_MaxViews");
		NativeFieldInfoPtr_m_BlackUIntTexture2DArray = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextureXR>.NativeClassPtr, "m_BlackUIntTexture2DArray");
		NativeFieldInfoPtr_m_BlackUIntTexture = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextureXR>.NativeClassPtr, "m_BlackUIntTexture");
		NativeFieldInfoPtr_m_BlackUIntTexture2DArrayRTH = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextureXR>.NativeClassPtr, "m_BlackUIntTexture2DArrayRTH");
		NativeFieldInfoPtr_m_BlackUIntTextureRTH = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextureXR>.NativeClassPtr, "m_BlackUIntTextureRTH");
		NativeFieldInfoPtr_m_ClearTexture2DArray = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextureXR>.NativeClassPtr, "m_ClearTexture2DArray");
		NativeFieldInfoPtr_m_ClearTexture = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextureXR>.NativeClassPtr, "m_ClearTexture");
		NativeFieldInfoPtr_m_ClearTexture2DArrayRTH = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextureXR>.NativeClassPtr, "m_ClearTexture2DArrayRTH");
		NativeFieldInfoPtr_m_ClearTextureRTH = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextureXR>.NativeClassPtr, "m_ClearTextureRTH");
		NativeFieldInfoPtr_m_MagentaTexture2DArray = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextureXR>.NativeClassPtr, "m_MagentaTexture2DArray");
		NativeFieldInfoPtr_m_MagentaTexture = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextureXR>.NativeClassPtr, "m_MagentaTexture");
		NativeFieldInfoPtr_m_MagentaTexture2DArrayRTH = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextureXR>.NativeClassPtr, "m_MagentaTexture2DArrayRTH");
		NativeFieldInfoPtr_m_MagentaTextureRTH = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextureXR>.NativeClassPtr, "m_MagentaTextureRTH");
		NativeFieldInfoPtr_m_BlackTexture = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextureXR>.NativeClassPtr, "m_BlackTexture");
		NativeFieldInfoPtr_m_BlackTexture3D = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextureXR>.NativeClassPtr, "m_BlackTexture3D");
		NativeFieldInfoPtr_m_BlackTexture2DArray = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextureXR>.NativeClassPtr, "m_BlackTexture2DArray");
		NativeFieldInfoPtr_m_BlackTexture2DArrayRTH = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextureXR>.NativeClassPtr, "m_BlackTexture2DArrayRTH");
		NativeFieldInfoPtr_m_BlackTextureRTH = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextureXR>.NativeClassPtr, "m_BlackTextureRTH");
		NativeFieldInfoPtr_m_BlackTexture3DRTH = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextureXR>.NativeClassPtr, "m_BlackTexture3DRTH");
		NativeFieldInfoPtr_m_WhiteTexture2DArray = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextureXR>.NativeClassPtr, "m_WhiteTexture2DArray");
		NativeFieldInfoPtr_m_WhiteTexture2DArrayRTH = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextureXR>.NativeClassPtr, "m_WhiteTexture2DArrayRTH");
		NativeFieldInfoPtr_m_WhiteTextureRTH = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextureXR>.NativeClassPtr, "m_WhiteTextureRTH");
		NativeMethodInfoPtr_set_maxViews_Public_Static_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextureXR>.NativeClassPtr, 100666328);
		NativeMethodInfoPtr_get_slices_Public_Static_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextureXR>.NativeClassPtr, 100666329);
		NativeMethodInfoPtr_get_useTexArray_Public_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextureXR>.NativeClassPtr, 100666330);
		NativeMethodInfoPtr_get_dimension_Public_Static_get_TextureDimension_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextureXR>.NativeClassPtr, 100666331);
		NativeMethodInfoPtr_GetBlackUIntTexture_Public_Static_RTHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextureXR>.NativeClassPtr, 100666332);
		NativeMethodInfoPtr_GetClearTexture_Public_Static_RTHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextureXR>.NativeClassPtr, 100666333);
		NativeMethodInfoPtr_GetMagentaTexture_Public_Static_RTHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextureXR>.NativeClassPtr, 100666334);
		NativeMethodInfoPtr_GetBlackTexture_Public_Static_RTHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextureXR>.NativeClassPtr, 100666335);
		NativeMethodInfoPtr_GetBlackTextureArray_Public_Static_RTHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextureXR>.NativeClassPtr, 100666336);
		NativeMethodInfoPtr_GetBlackTexture3D_Public_Static_RTHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextureXR>.NativeClassPtr, 100666337);
		NativeMethodInfoPtr_GetWhiteTexture_Public_Static_RTHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextureXR>.NativeClassPtr, 100666338);
		NativeMethodInfoPtr_Initialize_Public_Static_Void_CommandBuffer_ComputeShader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextureXR>.NativeClassPtr, 100666339);
		NativeMethodInfoPtr_CreateTexture2DArrayFromTexture2D_Private_Static_Texture2DArray_Texture2D_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextureXR>.NativeClassPtr, 100666340);
		NativeMethodInfoPtr_CreateBlackUIntTextureArray_Private_Static_Texture_CommandBuffer_ComputeShader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextureXR>.NativeClassPtr, 100666341);
		NativeMethodInfoPtr_CreateBlackUintTexture_Private_Static_Texture_CommandBuffer_ComputeShader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextureXR>.NativeClassPtr, 100666342);
		NativeMethodInfoPtr_CreateBlackTexture3D_Private_Static_Texture3D_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextureXR>.NativeClassPtr, 100666343);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1049526, RefRangeEnd = 1049527, XrefRangeStart = 1049519, XrefRangeEnd = 1049526, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static RTHandle GetBlackUIntTexture()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetBlackUIntTexture_Public_Static_RTHandle_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<RTHandle>(intPtr2) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1049534, RefRangeEnd = 1049535, XrefRangeStart = 1049527, XrefRangeEnd = 1049534, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static RTHandle GetClearTexture()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetClearTexture_Public_Static_RTHandle_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<RTHandle>(intPtr2) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1049542, RefRangeEnd = 1049543, XrefRangeStart = 1049535, XrefRangeEnd = 1049542, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static RTHandle GetMagentaTexture()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetMagentaTexture_Public_Static_RTHandle_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<RTHandle>(intPtr2) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1049550, RefRangeEnd = 1049551, XrefRangeStart = 1049543, XrefRangeEnd = 1049550, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static RTHandle GetBlackTexture()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetBlackTexture_Public_Static_RTHandle_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<RTHandle>(intPtr2) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1049551, XrefRangeEnd = 1049555, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static RTHandle GetBlackTextureArray()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetBlackTextureArray_Public_Static_RTHandle_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<RTHandle>(intPtr2) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1049555, XrefRangeEnd = 1049559, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static RTHandle GetBlackTexture3D()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetBlackTexture3D_Public_Static_RTHandle_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<RTHandle>(intPtr2) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1049566, RefRangeEnd = 1049567, XrefRangeStart = 1049559, XrefRangeEnd = 1049566, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static RTHandle GetWhiteTexture()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetWhiteTexture_Public_Static_RTHandle_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<RTHandle>(intPtr2) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1049567, XrefRangeEnd = 1049804, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void Initialize(CommandBuffer cmd, ComputeShader clearR32_UIntShader)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)cmd);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)clearR32_UIntShader);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Initialize_Public_Static_Void_CommandBuffer_ComputeShader_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 1049828, RefRangeEnd = 1049832, XrefRangeStart = 1049804, XrefRangeEnd = 1049828, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Texture2DArray CreateTexture2DArrayFromTexture2D(Texture2D source, string name)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)source);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(name);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CreateTexture2DArrayFromTexture2D_Private_Static_Texture2DArray_Texture2D_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Texture2DArray>(intPtr2) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1049863, RefRangeEnd = 1049864, XrefRangeStart = 1049832, XrefRangeEnd = 1049863, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Texture CreateBlackUIntTextureArray(CommandBuffer cmd, ComputeShader clearR32_UIntShader)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)cmd);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)clearR32_UIntShader);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CreateBlackUIntTextureArray_Private_Static_Texture_CommandBuffer_ComputeShader_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Texture>(intPtr2) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1049864, XrefRangeEnd = 1049884, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Texture CreateBlackUintTexture(CommandBuffer cmd, ComputeShader clearR32_UIntShader)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)cmd);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)clearR32_UIntShader);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CreateBlackUintTexture_Private_Static_Texture_CommandBuffer_ComputeShader_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Texture>(intPtr2) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1049884, XrefRangeEnd = 1049891, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Texture3D CreateBlackTexture3D(string name)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CreateBlackTexture3D_Private_Static_Texture3D_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Texture3D>(intPtr2) : null;
	}

	public TextureXR(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
