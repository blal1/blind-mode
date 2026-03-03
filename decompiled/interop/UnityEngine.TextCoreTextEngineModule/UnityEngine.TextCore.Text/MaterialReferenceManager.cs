using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace UnityEngine.TextCore.Text;

public class MaterialReferenceManager : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_s_Instance;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_FontMaterialReferenceLookup;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_FontAssetReferenceLookup;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_SpriteAssetReferenceLookup;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_ColorGradientReferenceLookup;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_instance_Public_Static_get_MaterialReferenceManager_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AddFontAsset_Public_Static_Void_FontAsset_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AddFontAssetInternal_Private_Void_FontAsset_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AddSpriteAsset_Public_Static_Void_Int32_SpriteAsset_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AddSpriteAssetInternal_Private_Void_Int32_SpriteAsset_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AddFontMaterial_Public_Static_Void_Int32_Material_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AddFontMaterialInternal_Private_Void_Int32_Material_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AddColorGradientPreset_Public_Static_Void_Int32_TextColorGradient_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AddColorGradientPreset_Internal_Private_Void_Int32_TextColorGradient_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_TryGetFontAsset_Public_Static_Boolean_Int32_byref_FontAsset_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_TryGetFontAssetInternal_Private_Boolean_Int32_byref_FontAsset_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_TryGetSpriteAsset_Public_Static_Boolean_Int32_byref_SpriteAsset_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_TryGetSpriteAssetInternal_Private_Boolean_Int32_byref_SpriteAsset_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_TryGetColorGradientPreset_Public_Static_Boolean_Int32_byref_TextColorGradient_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_TryGetColorGradientPresetInternal_Private_Boolean_Int32_byref_TextColorGradient_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_TryGetMaterial_Public_Static_Boolean_Int32_byref_Material_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_TryGetMaterialInternal_Private_Boolean_Int32_byref_Material_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe static MaterialReferenceManager s_Instance
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_s_Instance, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<MaterialReferenceManager>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_s_Instance, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe Dictionary<int, Material> m_FontMaterialReferenceLookup
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_FontMaterialReferenceLookup);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<int, Material>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_FontMaterialReferenceLookup)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe Dictionary<int, FontAsset> m_FontAssetReferenceLookup
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_FontAssetReferenceLookup);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<int, FontAsset>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_FontAssetReferenceLookup)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe Dictionary<int, SpriteAsset> m_SpriteAssetReferenceLookup
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_SpriteAssetReferenceLookup);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<int, SpriteAsset>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_SpriteAssetReferenceLookup)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe Dictionary<int, TextColorGradient> m_ColorGradientReferenceLookup
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_ColorGradientReferenceLookup);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<int, TextColorGradient>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_ColorGradientReferenceLookup)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static MaterialReferenceManager instance
	{
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 1275133, RefRangeEnd = 1275141, XrefRangeStart = 1275097, XrefRangeEnd = 1275133, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_instance_Public_Static_get_MaterialReferenceManager_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<MaterialReferenceManager>(intPtr2) : null;
		}
	}

	static MaterialReferenceManager()
	{
		Il2CppClassPointerStore<MaterialReferenceManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.TextCoreTextEngineModule.dll", "UnityEngine.TextCore.Text", "MaterialReferenceManager");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MaterialReferenceManager>.NativeClassPtr);
		NativeFieldInfoPtr_s_Instance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaterialReferenceManager>.NativeClassPtr, "s_Instance");
		NativeFieldInfoPtr_m_FontMaterialReferenceLookup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaterialReferenceManager>.NativeClassPtr, "m_FontMaterialReferenceLookup");
		NativeFieldInfoPtr_m_FontAssetReferenceLookup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaterialReferenceManager>.NativeClassPtr, "m_FontAssetReferenceLookup");
		NativeFieldInfoPtr_m_SpriteAssetReferenceLookup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaterialReferenceManager>.NativeClassPtr, "m_SpriteAssetReferenceLookup");
		NativeFieldInfoPtr_m_ColorGradientReferenceLookup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaterialReferenceManager>.NativeClassPtr, "m_ColorGradientReferenceLookup");
		NativeMethodInfoPtr_get_instance_Public_Static_get_MaterialReferenceManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialReferenceManager>.NativeClassPtr, 100663379);
		NativeMethodInfoPtr_AddFontAsset_Public_Static_Void_FontAsset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialReferenceManager>.NativeClassPtr, 100663380);
		NativeMethodInfoPtr_AddFontAssetInternal_Private_Void_FontAsset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialReferenceManager>.NativeClassPtr, 100663381);
		NativeMethodInfoPtr_AddSpriteAsset_Public_Static_Void_Int32_SpriteAsset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialReferenceManager>.NativeClassPtr, 100663382);
		NativeMethodInfoPtr_AddSpriteAssetInternal_Private_Void_Int32_SpriteAsset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialReferenceManager>.NativeClassPtr, 100663383);
		NativeMethodInfoPtr_AddFontMaterial_Public_Static_Void_Int32_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialReferenceManager>.NativeClassPtr, 100663384);
		NativeMethodInfoPtr_AddFontMaterialInternal_Private_Void_Int32_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialReferenceManager>.NativeClassPtr, 100663385);
		NativeMethodInfoPtr_AddColorGradientPreset_Public_Static_Void_Int32_TextColorGradient_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialReferenceManager>.NativeClassPtr, 100663386);
		NativeMethodInfoPtr_AddColorGradientPreset_Internal_Private_Void_Int32_TextColorGradient_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialReferenceManager>.NativeClassPtr, 100663387);
		NativeMethodInfoPtr_TryGetFontAsset_Public_Static_Boolean_Int32_byref_FontAsset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialReferenceManager>.NativeClassPtr, 100663388);
		NativeMethodInfoPtr_TryGetFontAssetInternal_Private_Boolean_Int32_byref_FontAsset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialReferenceManager>.NativeClassPtr, 100663389);
		NativeMethodInfoPtr_TryGetSpriteAsset_Public_Static_Boolean_Int32_byref_SpriteAsset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialReferenceManager>.NativeClassPtr, 100663390);
		NativeMethodInfoPtr_TryGetSpriteAssetInternal_Private_Boolean_Int32_byref_SpriteAsset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialReferenceManager>.NativeClassPtr, 100663391);
		NativeMethodInfoPtr_TryGetColorGradientPreset_Public_Static_Boolean_Int32_byref_TextColorGradient_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialReferenceManager>.NativeClassPtr, 100663392);
		NativeMethodInfoPtr_TryGetColorGradientPresetInternal_Private_Boolean_Int32_byref_TextColorGradient_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialReferenceManager>.NativeClassPtr, 100663393);
		NativeMethodInfoPtr_TryGetMaterial_Public_Static_Boolean_Int32_byref_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialReferenceManager>.NativeClassPtr, 100663394);
		NativeMethodInfoPtr_TryGetMaterialInternal_Private_Boolean_Int32_byref_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialReferenceManager>.NativeClassPtr, 100663395);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialReferenceManager>.NativeClassPtr, 100663396);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1275141, XrefRangeEnd = 1275154, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void AddFontAsset(FontAsset fontAsset)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)fontAsset);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AddFontAsset_Public_Static_Void_FontAsset_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1275154, XrefRangeEnd = 1275166, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void AddFontAssetInternal(FontAsset fontAsset)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)fontAsset);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AddFontAssetInternal_Private_Void_FontAsset_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1275166, XrefRangeEnd = 1275177, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void AddSpriteAsset(int hashCode, SpriteAsset spriteAsset)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&hashCode);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)spriteAsset);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AddSpriteAsset_Public_Static_Void_Int32_SpriteAsset_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1275177, XrefRangeEnd = 1275187, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void AddSpriteAssetInternal(int hashCode, SpriteAsset spriteAsset)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&hashCode);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)spriteAsset);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AddSpriteAssetInternal_Private_Void_Int32_SpriteAsset_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1275187, XrefRangeEnd = 1275192, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void AddFontMaterial(int hashCode, Material material)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&hashCode);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)material);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AddFontMaterial_Public_Static_Void_Int32_Material_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1275192, XrefRangeEnd = 1275196, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void AddFontMaterialInternal(int hashCode, Material material)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&hashCode);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)material);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AddFontMaterialInternal_Private_Void_Int32_Material_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1275196, XrefRangeEnd = 1275203, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void AddColorGradientPreset(int hashCode, TextColorGradient spriteAsset)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&hashCode);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)spriteAsset);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AddColorGradientPreset_Public_Static_Void_Int32_TextColorGradient_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1275203, XrefRangeEnd = 1275209, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void AddColorGradientPreset_Internal(int hashCode, TextColorGradient spriteAsset)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&hashCode);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)spriteAsset);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AddColorGradientPreset_Internal_Private_Void_Int32_TextColorGradient_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1275209, XrefRangeEnd = 1275215, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool TryGetFontAsset(int hashCode, out FontAsset fontAsset)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&hashCode);
		byte* num = (byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)));
		nint num2 = 0;
		*(nint**)num = &num2;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_TryGetFontAsset_Public_Static_Boolean_Int32_byref_FontAsset_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		nint num3 = num2;
		fontAsset = ((num3 == 0) ? null : new FontAsset(num3));
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1275215, XrefRangeEnd = 1275220, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool TryGetFontAssetInternal(int hashCode, out FontAsset fontAsset)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&hashCode);
		byte* num = (byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)));
		nint num2 = 0;
		*(nint**)num = &num2;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_TryGetFontAssetInternal_Private_Boolean_Int32_byref_FontAsset_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		nint num3 = num2;
		fontAsset = ((num3 == 0) ? null : new FontAsset(num3));
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1275220, XrefRangeEnd = 1275226, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool TryGetSpriteAsset(int hashCode, out SpriteAsset spriteAsset)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&hashCode);
		byte* num = (byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)));
		nint num2 = 0;
		*(nint**)num = &num2;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_TryGetSpriteAsset_Public_Static_Boolean_Int32_byref_SpriteAsset_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		nint num3 = num2;
		spriteAsset = ((num3 == 0) ? null : new SpriteAsset(num3));
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1275226, XrefRangeEnd = 1275231, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool TryGetSpriteAssetInternal(int hashCode, out SpriteAsset spriteAsset)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&hashCode);
		byte* num = (byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)));
		nint num2 = 0;
		*(nint**)num = &num2;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_TryGetSpriteAssetInternal_Private_Boolean_Int32_byref_SpriteAsset_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		nint num3 = num2;
		spriteAsset = ((num3 == 0) ? null : new SpriteAsset(num3));
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1275231, XrefRangeEnd = 1275237, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool TryGetColorGradientPreset(int hashCode, out TextColorGradient gradientPreset)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&hashCode);
		byte* num = (byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)));
		nint num2 = 0;
		*(nint**)num = &num2;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_TryGetColorGradientPreset_Public_Static_Boolean_Int32_byref_TextColorGradient_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		nint num3 = num2;
		gradientPreset = ((num3 == 0) ? null : new TextColorGradient(num3));
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1275237, XrefRangeEnd = 1275242, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool TryGetColorGradientPresetInternal(int hashCode, out TextColorGradient gradientPreset)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&hashCode);
		byte* num = (byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)));
		nint num2 = 0;
		*(nint**)num = &num2;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_TryGetColorGradientPresetInternal_Private_Boolean_Int32_byref_TextColorGradient_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		nint num3 = num2;
		gradientPreset = ((num3 == 0) ? null : new TextColorGradient(num3));
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1275242, XrefRangeEnd = 1275248, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool TryGetMaterial(int hashCode, out Material material)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&hashCode);
		byte* num = (byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)));
		nint num2 = 0;
		*(nint**)num = &num2;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_TryGetMaterial_Public_Static_Boolean_Int32_byref_Material_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		nint num3 = num2;
		material = ((num3 == 0) ? null : new Material(num3));
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1275248, XrefRangeEnd = 1275253, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool TryGetMaterialInternal(int hashCode, out Material material)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&hashCode);
		byte* num = (byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)));
		nint num2 = 0;
		*(nint**)num = &num2;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_TryGetMaterialInternal_Private_Boolean_Int32_byref_Material_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		nint num3 = num2;
		material = ((num3 == 0) ? null : new Material(num3));
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1275253, XrefRangeEnd = 1275282, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe MaterialReferenceManager()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MaterialReferenceManager>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public MaterialReferenceManager(System.IntPtr pointer)
		: base(pointer)
	{
	}

	public static void AddSpriteAsset(SpriteAsset spriteAsset)
	{
		instance.AddSpriteAssetInternal(spriteAsset);
	}

	public void AddSpriteAssetInternal(SpriteAsset spriteAsset)
	{
		if (!m_SpriteAssetReferenceLookup.ContainsKey(spriteAsset.hashCode))
		{
			m_SpriteAssetReferenceLookup.Add(spriteAsset.hashCode, spriteAsset);
			m_FontMaterialReferenceLookup.Add(spriteAsset.hashCode, spriteAsset.material);
		}
	}

	public bool Contains(FontAsset font)
	{
		return m_FontAssetReferenceLookup.ContainsKey(font.hashCode);
	}

	public bool Contains(SpriteAsset sprite)
	{
		return m_FontAssetReferenceLookup.ContainsKey(sprite.hashCode);
	}
}
