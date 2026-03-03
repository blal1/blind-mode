using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.Rendering;

public static class MaterialQualityUtilities : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_KeywordNames;

	private static readonly System.IntPtr NativeFieldInfoPtr_EnumNames;

	private static readonly System.IntPtr NativeFieldInfoPtr_Keywords;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetHighestQuality_Public_Static_MaterialQuality_MaterialQuality_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetClosestQuality_Public_Static_MaterialQuality_MaterialQuality_MaterialQuality_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetGlobalShaderKeywords_Public_Static_Void_MaterialQuality_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetGlobalShaderKeywords_Public_Static_Void_MaterialQuality_CommandBuffer_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ToFirstIndex_Public_Static_Int32_MaterialQuality_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FromIndex_Public_Static_MaterialQuality_Int32_0;

	public unsafe static Il2CppStringArray KeywordNames
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_KeywordNames, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_KeywordNames, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static Il2CppStringArray EnumNames
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_EnumNames, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_EnumNames, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static Il2CppReferenceArray<ShaderKeyword> Keywords
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_Keywords, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<ShaderKeyword>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_Keywords, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	static MaterialQualityUtilities()
	{
		Il2CppClassPointerStore<MaterialQualityUtilities>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Core.Runtime.dll", "UnityEngine.Rendering", "MaterialQualityUtilities");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MaterialQualityUtilities>.NativeClassPtr);
		NativeFieldInfoPtr_KeywordNames = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaterialQualityUtilities>.NativeClassPtr, "KeywordNames");
		NativeFieldInfoPtr_EnumNames = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaterialQualityUtilities>.NativeClassPtr, "EnumNames");
		NativeFieldInfoPtr_Keywords = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaterialQualityUtilities>.NativeClassPtr, "Keywords");
		NativeMethodInfoPtr_GetHighestQuality_Public_Static_MaterialQuality_MaterialQuality_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialQualityUtilities>.NativeClassPtr, 100666786);
		NativeMethodInfoPtr_GetClosestQuality_Public_Static_MaterialQuality_MaterialQuality_MaterialQuality_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialQualityUtilities>.NativeClassPtr, 100666787);
		NativeMethodInfoPtr_SetGlobalShaderKeywords_Public_Static_Void_MaterialQuality_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialQualityUtilities>.NativeClassPtr, 100666788);
		NativeMethodInfoPtr_SetGlobalShaderKeywords_Public_Static_Void_MaterialQuality_CommandBuffer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialQualityUtilities>.NativeClassPtr, 100666789);
		NativeMethodInfoPtr_ToFirstIndex_Public_Static_Int32_MaterialQuality_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialQualityUtilities>.NativeClassPtr, 100666790);
		NativeMethodInfoPtr_FromIndex_Public_Static_MaterialQuality_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialQualityUtilities>.NativeClassPtr, 100666791);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1053383, XrefRangeEnd = 1053387, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static MaterialQuality GetHighestQuality(this MaterialQuality levels)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&levels);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetHighestQuality_Public_Static_MaterialQuality_MaterialQuality_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(MaterialQuality*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1053387, XrefRangeEnd = 1053400, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static MaterialQuality GetClosestQuality(this MaterialQuality availableLevels, MaterialQuality requestedLevel)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&availableLevels);
		*(MaterialQuality**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &requestedLevel;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetClosestQuality_Public_Static_MaterialQuality_MaterialQuality_MaterialQuality_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(MaterialQuality*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1053400, XrefRangeEnd = 1053412, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SetGlobalShaderKeywords(this MaterialQuality level)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&level);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetGlobalShaderKeywords_Public_Static_Void_MaterialQuality_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1053412, XrefRangeEnd = 1053424, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SetGlobalShaderKeywords(this MaterialQuality level, CommandBuffer cmd)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&level);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)cmd);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetGlobalShaderKeywords_Public_Static_Void_MaterialQuality_CommandBuffer_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1053424, XrefRangeEnd = 1053429, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int ToFirstIndex(this MaterialQuality level)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&level);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ToFirstIndex_Public_Static_Int32_MaterialQuality_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	public unsafe static MaterialQuality FromIndex(int index)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&index);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FromIndex_Public_Static_MaterialQuality_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(MaterialQuality*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	public MaterialQualityUtilities(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
