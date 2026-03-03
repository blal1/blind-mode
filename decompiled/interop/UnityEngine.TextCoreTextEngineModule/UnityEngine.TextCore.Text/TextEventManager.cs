using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.TextCore.Text;

public static class TextEventManager : Il2CppSystem.Object
{
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

	private static readonly System.IntPtr NativeFieldInfoPtr_OnPreRenderObject_Event;

	private static readonly System.IntPtr NativeFieldInfoPtr_TEXT_CHANGED_EVENT;

	private static readonly System.IntPtr NativeMethodInfoPtr_ON_FONT_PROPERTY_CHANGED_Public_Static_Void_Boolean_Object_0;

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

	public unsafe static FastAction<bool, Object> FONT_PROPERTY_EVENT
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_FONT_PROPERTY_EVENT, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<FastAction<bool, Object>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_FONT_PROPERTY_EVENT, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static FastAction<bool, Object> SPRITE_ASSET_PROPERTY_EVENT
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_SPRITE_ASSET_PROPERTY_EVENT, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<FastAction<bool, Object>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_SPRITE_ASSET_PROPERTY_EVENT, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static FastAction<bool, Object> TEXTMESHPRO_PROPERTY_EVENT
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_TEXTMESHPRO_PROPERTY_EVENT, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<FastAction<bool, Object>>(intPtr2) : null;
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

	public unsafe static FastAction<Object> COLOR_GRADIENT_PROPERTY_EVENT
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_COLOR_GRADIENT_PROPERTY_EVENT, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<FastAction<Object>>(intPtr2) : null;
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

	public unsafe static FastAction<bool, Object> TEXTMESHPRO_UGUI_PROPERTY_EVENT
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_TEXTMESHPRO_UGUI_PROPERTY_EVENT, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<FastAction<bool, Object>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_TEXTMESHPRO_UGUI_PROPERTY_EVENT, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static FastAction OnPreRenderObject_Event
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_OnPreRenderObject_Event, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<FastAction>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_OnPreRenderObject_Event, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static FastAction<Object> TEXT_CHANGED_EVENT
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_TEXT_CHANGED_EVENT, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<FastAction<Object>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_TEXT_CHANGED_EVENT, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	static TextEventManager()
	{
		Il2CppClassPointerStore<TextEventManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.TextCoreTextEngineModule.dll", "UnityEngine.TextCore.Text", "TextEventManager");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TextEventManager>.NativeClassPtr);
		NativeFieldInfoPtr_MATERIAL_PROPERTY_EVENT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextEventManager>.NativeClassPtr, "MATERIAL_PROPERTY_EVENT");
		NativeFieldInfoPtr_FONT_PROPERTY_EVENT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextEventManager>.NativeClassPtr, "FONT_PROPERTY_EVENT");
		NativeFieldInfoPtr_SPRITE_ASSET_PROPERTY_EVENT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextEventManager>.NativeClassPtr, "SPRITE_ASSET_PROPERTY_EVENT");
		NativeFieldInfoPtr_TEXTMESHPRO_PROPERTY_EVENT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextEventManager>.NativeClassPtr, "TEXTMESHPRO_PROPERTY_EVENT");
		NativeFieldInfoPtr_DRAG_AND_DROP_MATERIAL_EVENT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextEventManager>.NativeClassPtr, "DRAG_AND_DROP_MATERIAL_EVENT");
		NativeFieldInfoPtr_TEXT_STYLE_PROPERTY_EVENT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextEventManager>.NativeClassPtr, "TEXT_STYLE_PROPERTY_EVENT");
		NativeFieldInfoPtr_COLOR_GRADIENT_PROPERTY_EVENT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextEventManager>.NativeClassPtr, "COLOR_GRADIENT_PROPERTY_EVENT");
		NativeFieldInfoPtr_TMP_SETTINGS_PROPERTY_EVENT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextEventManager>.NativeClassPtr, "TMP_SETTINGS_PROPERTY_EVENT");
		NativeFieldInfoPtr_RESOURCE_LOAD_EVENT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextEventManager>.NativeClassPtr, "RESOURCE_LOAD_EVENT");
		NativeFieldInfoPtr_TEXTMESHPRO_UGUI_PROPERTY_EVENT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextEventManager>.NativeClassPtr, "TEXTMESHPRO_UGUI_PROPERTY_EVENT");
		NativeFieldInfoPtr_OnPreRenderObject_Event = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextEventManager>.NativeClassPtr, "OnPreRenderObject_Event");
		NativeFieldInfoPtr_TEXT_CHANGED_EVENT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextEventManager>.NativeClassPtr, "TEXT_CHANGED_EVENT");
		NativeMethodInfoPtr_ON_FONT_PROPERTY_CHANGED_Public_Static_Void_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextEventManager>.NativeClassPtr, 100663726);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1279726, RefRangeEnd = 1279727, XrefRangeStart = 1279625, XrefRangeEnd = 1279726, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void ON_FONT_PROPERTY_CHANGED(bool isChanged, Object font)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&isChanged);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)font);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ON_FONT_PROPERTY_CHANGED_Public_Static_Void_Boolean_Object_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public TextEventManager(System.IntPtr pointer)
		: base(pointer)
	{
	}

	public static void ON_PRE_RENDER_OBJECT_CHANGED()
	{
		OnPreRenderObject_Event.Call();
	}

	public static void ON_MATERIAL_PROPERTY_CHANGED(bool isChanged, Material mat)
	{
		MATERIAL_PROPERTY_EVENT.Call(isChanged, mat);
	}

	public static void ON_SPRITE_ASSET_PROPERTY_CHANGED(bool isChanged, Object obj)
	{
		SPRITE_ASSET_PROPERTY_EVENT.Call(isChanged, obj);
	}

	public static void ON_TEXTMESHPRO_PROPERTY_CHANGED(bool isChanged, Object obj)
	{
		TEXTMESHPRO_PROPERTY_EVENT.Call(isChanged, obj);
	}

	public static void ON_DRAG_AND_DROP_MATERIAL_CHANGED(GameObject sender, Material currentMaterial, Material newMaterial)
	{
		DRAG_AND_DROP_MATERIAL_EVENT.Call(sender, currentMaterial, newMaterial);
	}

	public static void ON_TEXT_STYLE_PROPERTY_CHANGED(bool isChanged)
	{
		TEXT_STYLE_PROPERTY_EVENT.Call(isChanged);
	}

	public static void ON_COLOR_GRADIENT_PROPERTY_CHANGED(Object gradient)
	{
		COLOR_GRADIENT_PROPERTY_EVENT.Call(gradient);
	}

	public static void ON_TEXT_CHANGED(Object obj)
	{
		TEXT_CHANGED_EVENT.Call(obj);
	}

	public static void ON_TMP_SETTINGS_CHANGED()
	{
		TMP_SETTINGS_PROPERTY_EVENT.Call();
	}

	public static void ON_RESOURCES_LOADED()
	{
		RESOURCE_LOAD_EVENT.Call();
	}

	public static void ON_TEXTMESHPRO_UGUI_PROPERTY_CHANGED(bool isChanged, Object obj)
	{
		TEXTMESHPRO_UGUI_PROPERTY_EVENT.Call(isChanged, obj);
	}
}
