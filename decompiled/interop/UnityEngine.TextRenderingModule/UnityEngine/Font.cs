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

namespace UnityEngine;

public sealed class Font : Object
{
	public sealed class FontTextureRebuildCallback : Il2CppSystem.MulticastDelegate
	{
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_0;

		static FontTextureRebuildCallback()
		{
			Il2CppClassPointerStore<FontTextureRebuildCallback>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Font>.NativeClassPtr, "FontTextureRebuildCallback");
			NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FontTextureRebuildCallback>.NativeClassPtr, 100663358);
			NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FontTextureRebuildCallback>.NativeClassPtr, 100663359);
		}

		[CallerCount(4109)]
		[CachedScanResults(RefRangeStart = 27728, RefRangeEnd = 31837, XrefRangeStart = 27728, XrefRangeEnd = 31837, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FontTextureRebuildCallback(Il2CppSystem.Object @object, System.IntPtr method)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FontTextureRebuildCallback>.NativeClassPtr))
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[2];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)@object);
			*(System.IntPtr**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &method;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		[CallerCount(0)]
		public unsafe virtual void Invoke()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		public FontTextureRebuildCallback(System.IntPtr pointer)
			: base(pointer)
		{
		}

		public static implicit operator FontTextureRebuildCallback(System.Action P_0)
		{
			return DelegateSupport.ConvertDelegate<FontTextureRebuildCallback>((System.Delegate)P_0);
		}

		public static FontTextureRebuildCallback operator +(FontTextureRebuildCallback P_0, FontTextureRebuildCallback P_1)
		{
			return ((Il2CppObjectBase)Il2CppSystem.Delegate.Combine(P_0, P_1)).Cast<FontTextureRebuildCallback>();
		}

		public static FontTextureRebuildCallback operator -(FontTextureRebuildCallback P_0, FontTextureRebuildCallback P_1)
		{
			object obj = Il2CppSystem.Delegate.Remove(P_0, P_1);
			if (obj != null)
			{
				obj = ((Il2CppObjectBase)obj).Cast<FontTextureRebuildCallback>();
			}
			return (FontTextureRebuildCallback)obj;
		}
	}

	private delegate System.IntPtr GetOSInstalledFontNamesDelegate();

	private delegate void Internal_CreateDynamicFontDelegate(System.IntPtr self, System.IntPtr _names, int size);

	private delegate void set_material_InjectedDelegate(System.IntPtr _unity_self, System.IntPtr value);

	private delegate System.IntPtr get_fontNames_InjectedDelegate(System.IntPtr _unity_self);

	private delegate void set_fontNames_InjectedDelegate(System.IntPtr _unity_self, System.IntPtr value);

	private delegate int get_ascent_InjectedDelegate(System.IntPtr _unity_self);

	private delegate void get_characterInfo_InjectedDelegate(System.IntPtr _unity_self, [Out] System.IntPtr ret);

	private delegate void set_characterInfo_InjectedDelegate(System.IntPtr _unity_self, System.IntPtr value);

	private delegate int get_lineHeight_InjectedDelegate(System.IntPtr _unity_self);

	private delegate System.IntPtr GetDefault_InjectedDelegate();

	private delegate void Internal_CreateFontFromPath_InjectedDelegate(System.IntPtr self, System.IntPtr fontPath);

	private delegate void RequestCharactersInTexture_InjectedDelegate(System.IntPtr _unity_self, System.IntPtr characters, int size, FontStyle style);

	private static readonly System.IntPtr NativeFieldInfoPtr_textureRebuilt;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_FontTextureRebuildCallback;

	private static readonly System.IntPtr NativeMethodInfoPtr_add_textureRebuilt_Public_Static_add_Void_Action_1_Font_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_remove_textureRebuilt_Public_Static_rem_Void_Action_1_Font_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_material_Public_get_Material_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_dynamic_Public_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_fontSize_Public_get_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_InvokeTextureRebuilt_Internal_Internal_Static_Void_Font_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_HasCharacter_Public_Boolean_Char_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_HasCharacter_Private_Boolean_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetPathsToOSFonts_Public_Static_Il2CppStringArray_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetOSFallbacks_Internal_Static_Il2CppStringArray_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Internal_CreateFont_Private_Static_Void_Font_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_material_Injected_Private_Static_IntPtr_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_dynamic_Injected_Private_Static_Boolean_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_fontSize_Injected_Private_Static_Int32_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_HasCharacter_Injected_Private_Static_Boolean_IntPtr_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Internal_CreateFont_Injected_Private_Static_Void_Font_byref_ManagedSpanWrapper_0;

	private static readonly GetOSInstalledFontNamesDelegate GetOSInstalledFontNamesDelegateField;

	private static readonly Internal_CreateDynamicFontDelegate Internal_CreateDynamicFontDelegateField;

	private static readonly set_material_InjectedDelegate set_material_InjectedDelegateField;

	private static readonly get_fontNames_InjectedDelegate get_fontNames_InjectedDelegateField;

	private static readonly set_fontNames_InjectedDelegate set_fontNames_InjectedDelegateField;

	private static readonly get_ascent_InjectedDelegate get_ascent_InjectedDelegateField;

	private static readonly get_characterInfo_InjectedDelegate get_characterInfo_InjectedDelegateField;

	private static readonly set_characterInfo_InjectedDelegate set_characterInfo_InjectedDelegateField;

	private static readonly get_lineHeight_InjectedDelegate get_lineHeight_InjectedDelegateField;

	private static readonly GetDefault_InjectedDelegate GetDefault_InjectedDelegateField;

	private static readonly Internal_CreateFontFromPath_InjectedDelegate Internal_CreateFontFromPath_InjectedDelegateField;

	private static readonly RequestCharactersInTexture_InjectedDelegate RequestCharactersInTexture_InjectedDelegateField;

	public unsafe static Il2CppSystem.Action<Font> textureRebuilt
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_textureRebuilt, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Action<Font>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_textureRebuilt, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe FontTextureRebuildCallback m_FontTextureRebuildCallback
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_FontTextureRebuildCallback);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<FontTextureRebuildCallback>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_FontTextureRebuildCallback)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe Material material
	{
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1285233, RefRangeEnd = 1285236, XrefRangeStart = 1285220, XrefRangeEnd = 1285233, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_material_Public_get_Material_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
		}
		set
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			set_material_Injected(intPtr, MarshalledUnityObject.Marshal(value));
		}
	}

	public unsafe bool dynamic
	{
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1285241, RefRangeEnd = 1285243, XrefRangeStart = 1285236, XrefRangeEnd = 1285241, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_dynamic_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe int fontSize
	{
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1285248, RefRangeEnd = 1285251, XrefRangeStart = 1285243, XrefRangeEnd = 1285248, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_fontSize_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public Il2CppStringArray fontNames
	{
		get
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_fontNames_Injected(intPtr);
		}
		set
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			set_fontNames_Injected(intPtr, value);
		}
	}

	public int ascent
	{
		get
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_ascent_Injected(intPtr);
		}
	}

	public int lineHeight
	{
		get
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_lineHeight_Injected(intPtr);
		}
	}

	public FontTextureRebuildCallback textureRebuildCallback
	{
		get
		{
			return m_FontTextureRebuildCallback;
		}
		set
		{
			m_FontTextureRebuildCallback = value;
		}
	}

	static Font()
	{
		Il2CppClassPointerStore<Font>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.TextRenderingModule.dll", "UnityEngine", "Font");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Font>.NativeClassPtr);
		NativeFieldInfoPtr_textureRebuilt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Font>.NativeClassPtr, "textureRebuilt");
		NativeFieldInfoPtr_m_FontTextureRebuildCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Font>.NativeClassPtr, "m_FontTextureRebuildCallback");
		NativeMethodInfoPtr_add_textureRebuilt_Public_Static_add_Void_Action_1_Font_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Font>.NativeClassPtr, 100663341);
		NativeMethodInfoPtr_remove_textureRebuilt_Public_Static_rem_Void_Action_1_Font_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Font>.NativeClassPtr, 100663342);
		NativeMethodInfoPtr_get_material_Public_get_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Font>.NativeClassPtr, 100663343);
		NativeMethodInfoPtr_get_dynamic_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Font>.NativeClassPtr, 100663344);
		NativeMethodInfoPtr_get_fontSize_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Font>.NativeClassPtr, 100663345);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Font>.NativeClassPtr, 100663346);
		NativeMethodInfoPtr_InvokeTextureRebuilt_Internal_Internal_Static_Void_Font_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Font>.NativeClassPtr, 100663347);
		NativeMethodInfoPtr_HasCharacter_Public_Boolean_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Font>.NativeClassPtr, 100663348);
		NativeMethodInfoPtr_HasCharacter_Private_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Font>.NativeClassPtr, 100663349);
		NativeMethodInfoPtr_GetPathsToOSFonts_Public_Static_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Font>.NativeClassPtr, 100663350);
		NativeMethodInfoPtr_GetOSFallbacks_Internal_Static_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Font>.NativeClassPtr, 100663351);
		NativeMethodInfoPtr_Internal_CreateFont_Private_Static_Void_Font_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Font>.NativeClassPtr, 100663352);
		NativeMethodInfoPtr_get_material_Injected_Private_Static_IntPtr_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Font>.NativeClassPtr, 100663353);
		NativeMethodInfoPtr_get_dynamic_Injected_Private_Static_Boolean_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Font>.NativeClassPtr, 100663354);
		NativeMethodInfoPtr_get_fontSize_Injected_Private_Static_Int32_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Font>.NativeClassPtr, 100663355);
		NativeMethodInfoPtr_HasCharacter_Injected_Private_Static_Boolean_IntPtr_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Font>.NativeClassPtr, 100663356);
		NativeMethodInfoPtr_Internal_CreateFont_Injected_Private_Static_Void_Font_byref_ManagedSpanWrapper_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Font>.NativeClassPtr, 100663357);
		GetOSInstalledFontNamesDelegateField = IL2CPP.ResolveICall<GetOSInstalledFontNamesDelegate>("UnityEngine.Font::GetOSInstalledFontNames");
		Internal_CreateDynamicFontDelegateField = IL2CPP.ResolveICall<Internal_CreateDynamicFontDelegate>("UnityEngine.Font::Internal_CreateDynamicFont");
		set_material_InjectedDelegateField = IL2CPP.ResolveICall<set_material_InjectedDelegate>("UnityEngine.Font::set_material_Injected");
		get_fontNames_InjectedDelegateField = IL2CPP.ResolveICall<get_fontNames_InjectedDelegate>("UnityEngine.Font::get_fontNames_Injected");
		set_fontNames_InjectedDelegateField = IL2CPP.ResolveICall<set_fontNames_InjectedDelegate>("UnityEngine.Font::set_fontNames_Injected");
		get_ascent_InjectedDelegateField = IL2CPP.ResolveICall<get_ascent_InjectedDelegate>("UnityEngine.Font::get_ascent_Injected");
		get_characterInfo_InjectedDelegateField = IL2CPP.ResolveICall<get_characterInfo_InjectedDelegate>("UnityEngine.Font::get_characterInfo_Injected");
		set_characterInfo_InjectedDelegateField = IL2CPP.ResolveICall<set_characterInfo_InjectedDelegate>("UnityEngine.Font::set_characterInfo_Injected");
		get_lineHeight_InjectedDelegateField = IL2CPP.ResolveICall<get_lineHeight_InjectedDelegate>("UnityEngine.Font::get_lineHeight_Injected");
		GetDefault_InjectedDelegateField = IL2CPP.ResolveICall<GetDefault_InjectedDelegate>("UnityEngine.Font::GetDefault_Injected");
		Internal_CreateFontFromPath_InjectedDelegateField = IL2CPP.ResolveICall<Internal_CreateFontFromPath_InjectedDelegate>("UnityEngine.Font::Internal_CreateFontFromPath_Injected");
		RequestCharactersInTexture_InjectedDelegateField = IL2CPP.ResolveICall<RequestCharactersInTexture_InjectedDelegate>("UnityEngine.Font::RequestCharactersInTexture_Injected");
	}

	[SpecialName]
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1285210, RefRangeEnd = 1285211, XrefRangeStart = 1285202, XrefRangeEnd = 1285210, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void add_textureRebuilt(Il2CppSystem.Action<Font> value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_add_textureRebuilt_Public_Static_add_Void_Action_1_Font_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[SpecialName]
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1285219, RefRangeEnd = 1285220, XrefRangeStart = 1285211, XrefRangeEnd = 1285219, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void remove_textureRebuilt(Il2CppSystem.Action<Font> value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_remove_textureRebuilt_Public_Static_rem_Void_Action_1_Font_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1285251, XrefRangeEnd = 1285256, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Font()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Font>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1285256, XrefRangeEnd = 1285258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void InvokeTextureRebuilt_Internal(Font font)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)font);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InvokeTextureRebuilt_Internal_Internal_Static_Void_Font_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1285263, RefRangeEnd = 1285264, XrefRangeStart = 1285258, XrefRangeEnd = 1285263, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool HasCharacter(char c)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&c);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_HasCharacter_Public_Boolean_Char_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1285264, XrefRangeEnd = 1285269, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool HasCharacter(int c)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&c);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_HasCharacter_Private_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1285271, RefRangeEnd = 1285272, XrefRangeStart = 1285269, XrefRangeEnd = 1285271, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Il2CppStringArray GetPathsToOSFonts()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetPathsToOSFonts_Public_Static_Il2CppStringArray_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 1285274, RefRangeEnd = 1285278, XrefRangeStart = 1285272, XrefRangeEnd = 1285274, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Il2CppStringArray GetOSFallbacks()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetOSFallbacks_Internal_Static_Il2CppStringArray_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1285292, RefRangeEnd = 1285293, XrefRangeStart = 1285278, XrefRangeEnd = 1285292, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void Internal_CreateFont(Font self, string name)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)self);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(name);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Internal_CreateFont_Private_Static_Void_Font_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1285293, XrefRangeEnd = 1285295, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static System.IntPtr get_material_Injected(System.IntPtr _unity_self)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&_unity_self);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_material_Injected_Private_Static_IntPtr_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(System.IntPtr*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1285295, XrefRangeEnd = 1285297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool get_dynamic_Injected(System.IntPtr _unity_self)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&_unity_self);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_dynamic_Injected_Private_Static_Boolean_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1285297, XrefRangeEnd = 1285299, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int get_fontSize_Injected(System.IntPtr _unity_self)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&_unity_self);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_fontSize_Injected_Private_Static_Int32_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1285299, XrefRangeEnd = 1285301, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool HasCharacter_Injected(System.IntPtr _unity_self, int c)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&_unity_self);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &c;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_HasCharacter_Injected_Private_Static_Boolean_IntPtr_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1285301, XrefRangeEnd = 1285303, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void Internal_CreateFont_Injected(Font self, ref ManagedSpanWrapper name)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)self);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref name);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Internal_CreateFont_Injected_Private_Static_Void_Font_byref_ManagedSpanWrapper_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public Font(System.IntPtr pointer)
		: base(pointer)
	{
	}

	[SpecialName]
	public void add_m_FontTextureRebuildCallback(FontTextureRebuildCallback value)
	{
		throw new System.NotSupportedException("Method unstripping failed");
	}

	[SpecialName]
	public void remove_m_FontTextureRebuildCallback(FontTextureRebuildCallback value)
	{
		throw new System.NotSupportedException("Method unstripping failed");
	}

	public static Font CreateDynamicFontFromOSFont(string fontname, int size)
	{
		throw new System.NotSupportedException("Method unstripping failed");
	}

	public static Font CreateDynamicFontFromOSFont(Il2CppStringArray fontnames, int size)
	{
		return new Font(fontnames, size);
	}

	public static int GetMaxVertsForString(string str)
	{
		return str.Length * 4 + 4;
	}

	public static Font GetDefault()
	{
		return Unmarshal.UnmarshalUnityObject<Font>(GetDefault_Injected());
	}

	public static Il2CppStringArray GetOSInstalledFontNames()
	{
		System.IntPtr intPtr = GetOSInstalledFontNamesDelegateField();
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr) : null;
	}

	public unsafe static void Internal_CreateFontFromPath(Font self, string fontPath)
	{
		//IL_0019: Expected O, but got Ref
		//IL_0025: Expected O, but got Ref
		//The blocks IL_002a are reachable both inside and outside the pinned region starting at IL_0019. ILSpy has duplicated these blocks in order to place them both within and outside the `fixed` statement.
		try
		{
			Unsafe.SkipInit(out ManagedSpanWrapper managedSpanWrapper);
			if (!StringMarshaller.TryMarshalEmptyOrNullString(fontPath, ref managedSpanWrapper))
			{
				Il2CppSystem.ReadOnlySpan<char> readOnlySpan = Il2CppSystem.MemoryExtensions.AsSpan(fontPath);
				fixed (char* begin = &((Il2CppSystem.ReadOnlySpan<char>)(&readOnlySpan)).GetPinnableReference())
				{
					managedSpanWrapper = new ManagedSpanWrapper(begin, ((Il2CppSystem.ReadOnlySpan<char>)(&readOnlySpan)).Length);
					Internal_CreateFontFromPath_Injected(self, ref managedSpanWrapper);
					return;
				}
			}
			Internal_CreateFontFromPath_Injected(self, ref managedSpanWrapper);
		}
		finally
		{
		}
	}

	public static void Internal_CreateDynamicFont(Font self, Il2CppStringArray _names, int size)
	{
		Internal_CreateDynamicFontDelegateField(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)self), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)_names), size);
	}

	public unsafe void RequestCharactersInTexture(string characters, int size, FontStyle style)
	{
		//IL_0028: Expected O, but got Ref
		//IL_0034: Expected O, but got Ref
		//The blocks IL_0039 are reachable both inside and outside the pinned region starting at IL_0028. ILSpy has duplicated these blocks in order to place them both within and outside the `fixed` statement.
		try
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			Unsafe.SkipInit(out ManagedSpanWrapper managedSpanWrapper);
			if (!StringMarshaller.TryMarshalEmptyOrNullString(characters, ref managedSpanWrapper))
			{
				Il2CppSystem.ReadOnlySpan<char> readOnlySpan = Il2CppSystem.MemoryExtensions.AsSpan(characters);
				fixed (char* begin = &((Il2CppSystem.ReadOnlySpan<char>)(&readOnlySpan)).GetPinnableReference())
				{
					managedSpanWrapper = new ManagedSpanWrapper(begin, ((Il2CppSystem.ReadOnlySpan<char>)(&readOnlySpan)).Length);
					RequestCharactersInTexture_Injected(intPtr, ref managedSpanWrapper, size, style);
					return;
				}
			}
			RequestCharactersInTexture_Injected(intPtr, ref managedSpanWrapper, size, style);
		}
		finally
		{
		}
	}

	public void RequestCharactersInTexture(string characters, int size)
	{
		RequestCharactersInTexture(characters, size, FontStyle.Normal);
	}

	public void RequestCharactersInTexture(string characters)
	{
		RequestCharactersInTexture(characters, 0, FontStyle.Normal);
	}

	public static void set_material_Injected(System.IntPtr _unity_self, System.IntPtr value)
	{
		set_material_InjectedDelegateField(_unity_self, value);
	}

	public static Il2CppStringArray get_fontNames_Injected(System.IntPtr _unity_self)
	{
		System.IntPtr intPtr = get_fontNames_InjectedDelegateField(_unity_self);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr) : null;
	}

	public static void set_fontNames_Injected(System.IntPtr _unity_self, Il2CppStringArray value)
	{
		set_fontNames_InjectedDelegateField(_unity_self, IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
	}

	public static int get_ascent_Injected(System.IntPtr _unity_self)
	{
		return get_ascent_InjectedDelegateField(_unity_self);
	}

	public unsafe static void get_characterInfo_Injected(System.IntPtr _unity_self, out BlittableArrayWrapper ret)
	{
		get_characterInfo_InjectedDelegateField(_unity_self, (nint)Unsafe.AsPointer(ref ret));
	}

	public unsafe static void set_characterInfo_Injected(System.IntPtr _unity_self, ref ManagedSpanWrapper value)
	{
		set_characterInfo_InjectedDelegateField(_unity_self, (nint)Unsafe.AsPointer(ref value));
	}

	public static int get_lineHeight_Injected(System.IntPtr _unity_self)
	{
		return get_lineHeight_InjectedDelegateField(_unity_self);
	}

	public static System.IntPtr GetDefault_Injected()
	{
		return GetDefault_InjectedDelegateField();
	}

	public unsafe static void Internal_CreateFontFromPath_Injected(Font self, ref ManagedSpanWrapper fontPath)
	{
		Internal_CreateFontFromPath_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)self), (nint)Unsafe.AsPointer(ref fontPath));
	}

	public unsafe static void RequestCharactersInTexture_Injected(System.IntPtr _unity_self, ref ManagedSpanWrapper characters, int size, FontStyle style)
	{
		RequestCharactersInTexture_InjectedDelegateField(_unity_self, (nint)Unsafe.AsPointer(ref characters), size, style);
	}
}
