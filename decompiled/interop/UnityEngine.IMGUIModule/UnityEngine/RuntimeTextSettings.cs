using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using UnityEngine.TextCore.Text;

namespace UnityEngine;

public class RuntimeTextSettings : TextSettings
{
	private static readonly IntPtr NativeFieldInfoPtr_s_DefaultTextSettings;

	private static readonly IntPtr NativeFieldInfoPtr_s_FallbackOSFontAssetIMGUIInternal;

	private static readonly IntPtr NativeMethodInfoPtr_get_defaultTextSettings_Internal_Static_get_RuntimeTextSettings_0;

	private static readonly IntPtr NativeMethodInfoPtr_GetStaticFallbackOSFontAsset_Internal_Virtual_List_1_FontAsset_0;

	private static readonly IntPtr NativeMethodInfoPtr_SetStaticFallbackOSFontAsset_Internal_Virtual_Void_List_1_FontAsset_0;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe static RuntimeTextSettings s_DefaultTextSettings
	{
		get
		{
			Unsafe.SkipInit(out IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_s_DefaultTextSettings, (void*)(&intPtr));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != (IntPtr)0) ? Il2CppObjectPool.Get<RuntimeTextSettings>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_s_DefaultTextSettings, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static List<FontAsset> s_FallbackOSFontAssetIMGUIInternal
	{
		get
		{
			Unsafe.SkipInit(out IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_s_FallbackOSFontAssetIMGUIInternal, (void*)(&intPtr));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != (IntPtr)0) ? Il2CppObjectPool.Get<List<FontAsset>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_s_FallbackOSFontAssetIMGUIInternal, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static RuntimeTextSettings defaultTextSettings
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1249184, RefRangeEnd = 1249185, XrefRangeStart = 1249171, XrefRangeEnd = 1249184, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr);
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_defaultTextSettings_Internal_Static_get_RuntimeTextSettings_0, (IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (IntPtr)0) ? Il2CppObjectPool.Get<RuntimeTextSettings>(intPtr2) : null;
		}
	}

	static RuntimeTextSettings()
	{
		Il2CppClassPointerStore<RuntimeTextSettings>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.IMGUIModule.dll", "UnityEngine", "RuntimeTextSettings");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RuntimeTextSettings>.NativeClassPtr);
		NativeFieldInfoPtr_s_DefaultTextSettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RuntimeTextSettings>.NativeClassPtr, "s_DefaultTextSettings");
		NativeFieldInfoPtr_s_FallbackOSFontAssetIMGUIInternal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RuntimeTextSettings>.NativeClassPtr, "s_FallbackOSFontAssetIMGUIInternal");
		NativeMethodInfoPtr_get_defaultTextSettings_Internal_Static_get_RuntimeTextSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeTextSettings>.NativeClassPtr, 100663812);
		NativeMethodInfoPtr_GetStaticFallbackOSFontAsset_Internal_Virtual_List_1_FontAsset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeTextSettings>.NativeClassPtr, 100663813);
		NativeMethodInfoPtr_SetStaticFallbackOSFontAsset_Internal_Virtual_Void_List_1_FontAsset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeTextSettings>.NativeClassPtr, 100663814);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeTextSettings>.NativeClassPtr, 100663815);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1249185, XrefRangeEnd = 1249187, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override List<FontAsset> GetStaticFallbackOSFontAsset()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_GetStaticFallbackOSFontAsset_Internal_Virtual_List_1_FontAsset_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (IntPtr)0) ? Il2CppObjectPool.Get<List<FontAsset>>(intPtr2) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1249187, XrefRangeEnd = 1249191, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override void SetStaticFallbackOSFontAsset(List<FontAsset> fontAssets)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)fontAssets);
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_SetStaticFallbackOSFontAsset_Internal_Virtual_Void_List_1_FontAsset_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1249191, XrefRangeEnd = 1249192, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe RuntimeTextSettings()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RuntimeTextSettings>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public RuntimeTextSettings(IntPtr pointer)
		: base(pointer)
	{
	}
}
