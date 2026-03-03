using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace Il2CppTMPro;

public static class TMPro_EventManager : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_COMPUTE_DT_EVENT;

	private static readonly System.IntPtr NativeFieldInfoPtr_MATERIAL_PROPERTY_EVENT;

	private static readonly System.IntPtr NativeFieldInfoPtr_FONT_PROPERTY_EVENT;

	private static readonly System.IntPtr NativeFieldInfoPtr_SPRITE_ASSET_PROPERTY_EVENT;

	private static readonly System.IntPtr NativeFieldInfoPtr_TEXTMESHPRO_PROPERTY_EVENT;

	private static readonly System.IntPtr NativeFieldInfoPtr_DRAG_AND_DROP_MATERIAL_EVENT;

	private static readonly System.IntPtr NativeFieldInfoPtr_TEXT_STYLE_PROPERTY_EVENT;

	private static readonly System.IntPtr NativeFieldInfoPtr_COLOR_GRADIENT_PROPERTY_EVENT;

	private static readonly System.IntPtr NativeFieldInfoPtr_TMP_SETTINGS_PROPERTY_EVENT;

	private static readonly System.IntPtr NativeFieldInfoPtr_RESOURCE_LOAD_EVENT;

	private static readonly System.IntPtr NativeFieldInfoPtr_TEXTMESHPRO_UGUI_PROPERTY_EVENT;

	private static readonly System.IntPtr NativeFieldInfoPtr_TEXT_CHANGED_EVENT;

	private static readonly System.IntPtr NativeMethodInfoPtr_ON_MATERIAL_PROPERTY_CHANGED_Public_Static_Void_Boolean_Material_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ON_FONT_PROPERTY_CHANGED_Public_Static_Void_Boolean_Object_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ON_SPRITE_ASSET_PROPERTY_CHANGED_Public_Static_Void_Boolean_Object_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ON_TEXTMESHPRO_PROPERTY_CHANGED_Public_Static_Void_Boolean_Object_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ON_DRAG_AND_DROP_MATERIAL_CHANGED_Public_Static_Void_GameObject_Material_Material_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ON_TEXT_STYLE_PROPERTY_CHANGED_Public_Static_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ON_COLOR_GRADIENT_PROPERTY_CHANGED_Public_Static_Void_Object_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ON_TEXT_CHANGED_Public_Static_Void_Object_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ON_TMP_SETTINGS_CHANGED_Public_Static_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ON_RESOURCES_LOADED_Public_Static_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ON_TEXTMESHPRO_UGUI_PROPERTY_CHANGED_Public_Static_Void_Boolean_Object_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ON_COMPUTE_DT_EVENT_Public_Static_Void_Object_Compute_DT_EventArgs_0;

	public unsafe static FastAction<Il2CppSystem.Object, Compute_DT_EventArgs> COMPUTE_DT_EVENT
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_COMPUTE_DT_EVENT, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<FastAction<Il2CppSystem.Object, Compute_DT_EventArgs>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_COMPUTE_DT_EVENT, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static FastAction<bool, Material> MATERIAL_PROPERTY_EVENT
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_MATERIAL_PROPERTY_EVENT, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<FastAction<bool, Material>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_MATERIAL_PROPERTY_EVENT, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static FastAction<bool, UnityEngine.Object> FONT_PROPERTY_EVENT
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_FONT_PROPERTY_EVENT, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<FastAction<bool, UnityEngine.Object>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_FONT_PROPERTY_EVENT, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static FastAction<bool, UnityEngine.Object> SPRITE_ASSET_PROPERTY_EVENT
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_SPRITE_ASSET_PROPERTY_EVENT, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<FastAction<bool, UnityEngine.Object>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_SPRITE_ASSET_PROPERTY_EVENT, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static FastAction<bool, UnityEngine.Object> TEXTMESHPRO_PROPERTY_EVENT
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_TEXTMESHPRO_PROPERTY_EVENT, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<FastAction<bool, UnityEngine.Object>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_TEXTMESHPRO_PROPERTY_EVENT, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static FastAction<GameObject, Material, Material> DRAG_AND_DROP_MATERIAL_EVENT
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_DRAG_AND_DROP_MATERIAL_EVENT, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<FastAction<GameObject, Material, Material>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_DRAG_AND_DROP_MATERIAL_EVENT, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static FastAction<bool> TEXT_STYLE_PROPERTY_EVENT
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_TEXT_STYLE_PROPERTY_EVENT, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<FastAction<bool>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_TEXT_STYLE_PROPERTY_EVENT, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static FastAction<UnityEngine.Object> COLOR_GRADIENT_PROPERTY_EVENT
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_COLOR_GRADIENT_PROPERTY_EVENT, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<FastAction<UnityEngine.Object>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_COLOR_GRADIENT_PROPERTY_EVENT, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static FastAction TMP_SETTINGS_PROPERTY_EVENT
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_TMP_SETTINGS_PROPERTY_EVENT, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<FastAction>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_TMP_SETTINGS_PROPERTY_EVENT, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static FastAction RESOURCE_LOAD_EVENT
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_RESOURCE_LOAD_EVENT, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<FastAction>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_RESOURCE_LOAD_EVENT, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static FastAction<bool, UnityEngine.Object> TEXTMESHPRO_UGUI_PROPERTY_EVENT
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_TEXTMESHPRO_UGUI_PROPERTY_EVENT, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<FastAction<bool, UnityEngine.Object>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_TEXTMESHPRO_UGUI_PROPERTY_EVENT, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static FastAction<UnityEngine.Object> TEXT_CHANGED_EVENT
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_TEXT_CHANGED_EVENT, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<FastAction<UnityEngine.Object>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_TEXT_CHANGED_EVENT, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	static TMPro_EventManager()
	{
		Il2CppClassPointerStore<TMPro_EventManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.TextMeshPro.dll", "TMPro", "TMPro_EventManager");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TMPro_EventManager>.NativeClassPtr);
		NativeFieldInfoPtr_COMPUTE_DT_EVENT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMPro_EventManager>.NativeClassPtr, "COMPUTE_DT_EVENT");
		NativeFieldInfoPtr_MATERIAL_PROPERTY_EVENT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMPro_EventManager>.NativeClassPtr, "MATERIAL_PROPERTY_EVENT");
		NativeFieldInfoPtr_FONT_PROPERTY_EVENT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMPro_EventManager>.NativeClassPtr, "FONT_PROPERTY_EVENT");
		NativeFieldInfoPtr_SPRITE_ASSET_PROPERTY_EVENT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMPro_EventManager>.NativeClassPtr, "SPRITE_ASSET_PROPERTY_EVENT");
		NativeFieldInfoPtr_TEXTMESHPRO_PROPERTY_EVENT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMPro_EventManager>.NativeClassPtr, "TEXTMESHPRO_PROPERTY_EVENT");
		NativeFieldInfoPtr_DRAG_AND_DROP_MATERIAL_EVENT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMPro_EventManager>.NativeClassPtr, "DRAG_AND_DROP_MATERIAL_EVENT");
		NativeFieldInfoPtr_TEXT_STYLE_PROPERTY_EVENT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMPro_EventManager>.NativeClassPtr, "TEXT_STYLE_PROPERTY_EVENT");
		NativeFieldInfoPtr_COLOR_GRADIENT_PROPERTY_EVENT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMPro_EventManager>.NativeClassPtr, "COLOR_GRADIENT_PROPERTY_EVENT");
		NativeFieldInfoPtr_TMP_SETTINGS_PROPERTY_EVENT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMPro_EventManager>.NativeClassPtr, "TMP_SETTINGS_PROPERTY_EVENT");
		NativeFieldInfoPtr_RESOURCE_LOAD_EVENT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMPro_EventManager>.NativeClassPtr, "RESOURCE_LOAD_EVENT");
		NativeFieldInfoPtr_TEXTMESHPRO_UGUI_PROPERTY_EVENT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMPro_EventManager>.NativeClassPtr, "TEXTMESHPRO_UGUI_PROPERTY_EVENT");
		NativeFieldInfoPtr_TEXT_CHANGED_EVENT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMPro_EventManager>.NativeClassPtr, "TEXT_CHANGED_EVENT");
		NativeMethodInfoPtr_ON_MATERIAL_PROPERTY_CHANGED_Public_Static_Void_Boolean_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMPro_EventManager>.NativeClassPtr, 100663575);
		NativeMethodInfoPtr_ON_FONT_PROPERTY_CHANGED_Public_Static_Void_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMPro_EventManager>.NativeClassPtr, 100663576);
		NativeMethodInfoPtr_ON_SPRITE_ASSET_PROPERTY_CHANGED_Public_Static_Void_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMPro_EventManager>.NativeClassPtr, 100663577);
		NativeMethodInfoPtr_ON_TEXTMESHPRO_PROPERTY_CHANGED_Public_Static_Void_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMPro_EventManager>.NativeClassPtr, 100663578);
		NativeMethodInfoPtr_ON_DRAG_AND_DROP_MATERIAL_CHANGED_Public_Static_Void_GameObject_Material_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMPro_EventManager>.NativeClassPtr, 100663579);
		NativeMethodInfoPtr_ON_TEXT_STYLE_PROPERTY_CHANGED_Public_Static_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMPro_EventManager>.NativeClassPtr, 100663580);
		NativeMethodInfoPtr_ON_COLOR_GRADIENT_PROPERTY_CHANGED_Public_Static_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMPro_EventManager>.NativeClassPtr, 100663581);
		NativeMethodInfoPtr_ON_TEXT_CHANGED_Public_Static_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMPro_EventManager>.NativeClassPtr, 100663582);
		NativeMethodInfoPtr_ON_TMP_SETTINGS_CHANGED_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMPro_EventManager>.NativeClassPtr, 100663583);
		NativeMethodInfoPtr_ON_RESOURCES_LOADED_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMPro_EventManager>.NativeClassPtr, 100663584);
		NativeMethodInfoPtr_ON_TEXTMESHPRO_UGUI_PROPERTY_CHANGED_Public_Static_Void_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMPro_EventManager>.NativeClassPtr, 100663585);
		NativeMethodInfoPtr_ON_COMPUTE_DT_EVENT_Public_Static_Void_Object_Compute_DT_EventArgs_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMPro_EventManager>.NativeClassPtr, 100663586);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1119570, XrefRangeEnd = 1119578, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void ON_MATERIAL_PROPERTY_CHANGED(bool isChanged, Material mat)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&isChanged);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)mat);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ON_MATERIAL_PROPERTY_CHANGED_Public_Static_Void_Boolean_Material_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1119586, RefRangeEnd = 1119587, XrefRangeStart = 1119578, XrefRangeEnd = 1119586, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void ON_FONT_PROPERTY_CHANGED(bool isChanged, UnityEngine.Object obj)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&isChanged);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)obj);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ON_FONT_PROPERTY_CHANGED_Public_Static_Void_Boolean_Object_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1119587, XrefRangeEnd = 1119595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void ON_SPRITE_ASSET_PROPERTY_CHANGED(bool isChanged, UnityEngine.Object obj)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&isChanged);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)obj);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ON_SPRITE_ASSET_PROPERTY_CHANGED_Public_Static_Void_Boolean_Object_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1119595, XrefRangeEnd = 1119603, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void ON_TEXTMESHPRO_PROPERTY_CHANGED(bool isChanged, UnityEngine.Object obj)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&isChanged);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)obj);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ON_TEXTMESHPRO_PROPERTY_CHANGED_Public_Static_Void_Boolean_Object_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1119603, XrefRangeEnd = 1119610, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void ON_DRAG_AND_DROP_MATERIAL_CHANGED(GameObject sender, Material currentMaterial, Material newMaterial)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)sender);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)currentMaterial);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)newMaterial);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ON_DRAG_AND_DROP_MATERIAL_CHANGED_Public_Static_Void_GameObject_Material_Material_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1119610, XrefRangeEnd = 1119618, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void ON_TEXT_STYLE_PROPERTY_CHANGED(bool isChanged)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&isChanged);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ON_TEXT_STYLE_PROPERTY_CHANGED_Public_Static_Void_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1119618, XrefRangeEnd = 1119626, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void ON_COLOR_GRADIENT_PROPERTY_CHANGED(UnityEngine.Object obj)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)obj);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ON_COLOR_GRADIENT_PROPERTY_CHANGED_Public_Static_Void_Object_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 1119634, RefRangeEnd = 1119638, XrefRangeStart = 1119626, XrefRangeEnd = 1119634, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void ON_TEXT_CHANGED(UnityEngine.Object obj)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)obj);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ON_TEXT_CHANGED_Public_Static_Void_Object_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1119638, XrefRangeEnd = 1119740, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void ON_TMP_SETTINGS_CHANGED()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ON_TMP_SETTINGS_CHANGED_Public_Static_Void_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1119740, XrefRangeEnd = 1119746, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void ON_RESOURCES_LOADED()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ON_RESOURCES_LOADED_Public_Static_Void_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1119746, XrefRangeEnd = 1119754, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void ON_TEXTMESHPRO_UGUI_PROPERTY_CHANGED(bool isChanged, UnityEngine.Object obj)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&isChanged);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)obj);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ON_TEXTMESHPRO_UGUI_PROPERTY_CHANGED_Public_Static_Void_Boolean_Object_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1119754, XrefRangeEnd = 1119762, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void ON_COMPUTE_DT_EVENT(Il2CppSystem.Object Sender, Compute_DT_EventArgs e)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)Sender);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)e);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ON_COMPUTE_DT_EVENT_Public_Static_Void_Object_Compute_DT_EventArgs_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public TMPro_EventManager(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
