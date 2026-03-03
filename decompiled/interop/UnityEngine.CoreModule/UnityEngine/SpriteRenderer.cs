using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine.Bindings;
using UnityEngine.Events;

namespace UnityEngine;

public sealed class SpriteRenderer : Renderer
{
	private delegate bool get_shouldSupportTiling_InjectedDelegate(IntPtr _unity_self);

	private delegate bool get_hasSpriteChangeEvents_InjectedDelegate(IntPtr _unity_self);

	private delegate SpriteDrawMode get_drawMode_InjectedDelegate(IntPtr _unity_self);

	private delegate void set_drawMode_InjectedDelegate(IntPtr _unity_self, SpriteDrawMode value);

	private delegate void get_size_InjectedDelegate(IntPtr _unity_self, [Out] IntPtr ret);

	private delegate void set_size_InjectedDelegate(IntPtr _unity_self, [In] IntPtr value);

	private delegate float get_adaptiveModeThreshold_InjectedDelegate(IntPtr _unity_self);

	private delegate void set_adaptiveModeThreshold_InjectedDelegate(IntPtr _unity_self, float value);

	private delegate SpriteTileMode get_tileMode_InjectedDelegate(IntPtr _unity_self);

	private delegate void set_tileMode_InjectedDelegate(IntPtr _unity_self, SpriteTileMode value);

	private delegate SpriteMaskInteraction get_maskInteraction_InjectedDelegate(IntPtr _unity_self);

	private delegate void set_maskInteraction_InjectedDelegate(IntPtr _unity_self, SpriteMaskInteraction value);

	private delegate bool get_flipX_InjectedDelegate(IntPtr _unity_self);

	private delegate void set_flipX_InjectedDelegate(IntPtr _unity_self, bool value);

	private delegate bool get_flipY_InjectedDelegate(IntPtr _unity_self);

	private delegate void set_flipY_InjectedDelegate(IntPtr _unity_self, bool value);

	private delegate SpriteSortPoint get_spriteSortPoint_InjectedDelegate(IntPtr _unity_self);

	private delegate void set_spriteSortPoint_InjectedDelegate(IntPtr _unity_self, SpriteSortPoint value);

	private delegate IntPtr GetCurrentMeshDataPtr_InjectedDelegate(IntPtr _unity_self);

	private delegate void Internal_GetSpriteBounds_InjectedDelegate(IntPtr _unity_self, SpriteDrawMode mode, [Out] IntPtr ret);

	private delegate void GetSecondaryTextureProperties_InjectedDelegate(IntPtr _unity_self, IntPtr mbp);

	private static readonly IntPtr NativeFieldInfoPtr_m_SpriteChangeEvent;

	private static readonly IntPtr NativeMethodInfoPtr_RegisterSpriteChangeCallback_Public_Void_UnityAction_1_SpriteRenderer_0;

	private static readonly IntPtr NativeMethodInfoPtr_UnregisterSpriteChangeCallback_Public_Void_UnityAction_1_SpriteRenderer_0;

	private static readonly IntPtr NativeMethodInfoPtr_InvokeSpriteChanged_Private_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_set_hasSpriteChangeEvents_Internal_set_Void_Boolean_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_sprite_Public_get_Sprite_0;

	private static readonly IntPtr NativeMethodInfoPtr_set_sprite_Public_set_Void_Sprite_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_color_Public_get_Color_0;

	private static readonly IntPtr NativeMethodInfoPtr_set_color_Public_set_Void_Color_0;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_set_hasSpriteChangeEvents_Injected_Private_Static_Void_IntPtr_Boolean_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_sprite_Injected_Private_Static_IntPtr_IntPtr_0;

	private static readonly IntPtr NativeMethodInfoPtr_set_sprite_Injected_Private_Static_Void_IntPtr_IntPtr_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_color_Injected_Private_Static_Void_IntPtr_byref_Color_0;

	private static readonly IntPtr NativeMethodInfoPtr_set_color_Injected_Private_Static_Void_IntPtr_byref_Color_0;

	private static readonly get_shouldSupportTiling_InjectedDelegate get_shouldSupportTiling_InjectedDelegateField;

	private static readonly get_hasSpriteChangeEvents_InjectedDelegate get_hasSpriteChangeEvents_InjectedDelegateField;

	private static readonly get_drawMode_InjectedDelegate get_drawMode_InjectedDelegateField;

	private static readonly set_drawMode_InjectedDelegate set_drawMode_InjectedDelegateField;

	private static readonly get_size_InjectedDelegate get_size_InjectedDelegateField;

	private static readonly set_size_InjectedDelegate set_size_InjectedDelegateField;

	private static readonly get_adaptiveModeThreshold_InjectedDelegate get_adaptiveModeThreshold_InjectedDelegateField;

	private static readonly set_adaptiveModeThreshold_InjectedDelegate set_adaptiveModeThreshold_InjectedDelegateField;

	private static readonly get_tileMode_InjectedDelegate get_tileMode_InjectedDelegateField;

	private static readonly set_tileMode_InjectedDelegate set_tileMode_InjectedDelegateField;

	private static readonly get_maskInteraction_InjectedDelegate get_maskInteraction_InjectedDelegateField;

	private static readonly set_maskInteraction_InjectedDelegate set_maskInteraction_InjectedDelegateField;

	private static readonly get_flipX_InjectedDelegate get_flipX_InjectedDelegateField;

	private static readonly set_flipX_InjectedDelegate set_flipX_InjectedDelegateField;

	private static readonly get_flipY_InjectedDelegate get_flipY_InjectedDelegateField;

	private static readonly set_flipY_InjectedDelegate set_flipY_InjectedDelegateField;

	private static readonly get_spriteSortPoint_InjectedDelegate get_spriteSortPoint_InjectedDelegateField;

	private static readonly set_spriteSortPoint_InjectedDelegate set_spriteSortPoint_InjectedDelegateField;

	private static readonly GetCurrentMeshDataPtr_InjectedDelegate GetCurrentMeshDataPtr_InjectedDelegateField;

	private static readonly Internal_GetSpriteBounds_InjectedDelegate Internal_GetSpriteBounds_InjectedDelegateField;

	private static readonly GetSecondaryTextureProperties_InjectedDelegate GetSecondaryTextureProperties_InjectedDelegateField;

	public unsafe UnityEvent<SpriteRenderer> m_SpriteChangeEvent
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_SpriteChangeEvent);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<UnityEvent<SpriteRenderer>>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_SpriteChangeEvent)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe bool hasSpriteChangeEvents
	{
		get
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_hasSpriteChangeEvents_Injected(intPtr);
		}
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1166518, XrefRangeEnd = 1166523, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = stackalloc IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out IntPtr intPtr);
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_hasSpriteChangeEvents_Internal_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe Sprite sprite
	{
		[CallerCount(30)]
		[CachedScanResults(RefRangeStart = 1166531, RefRangeEnd = 1166561, XrefRangeStart = 1166523, XrefRangeEnd = 1166531, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr);
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_sprite_Public_get_Sprite_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (IntPtr)0) ? Il2CppObjectPool.Get<Sprite>(intPtr2) : null;
		}
		[CallerCount(56)]
		[CachedScanResults(RefRangeStart = 1166569, RefRangeEnd = 1166625, XrefRangeStart = 1166561, XrefRangeEnd = 1166569, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = stackalloc IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
			Unsafe.SkipInit(out IntPtr intPtr);
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_sprite_Public_set_Void_Sprite_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe Color color
	{
		[CallerCount(14)]
		[CachedScanResults(RefRangeStart = 1166629, RefRangeEnd = 1166643, XrefRangeStart = 1166625, XrefRangeEnd = 1166629, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr);
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_color_Public_get_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(Color*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(21)]
		[CachedScanResults(RefRangeStart = 1166647, RefRangeEnd = 1166668, XrefRangeStart = 1166643, XrefRangeEnd = 1166647, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = stackalloc IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out IntPtr intPtr);
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_color_Public_set_Void_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public bool shouldSupportTiling
	{
		get
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_shouldSupportTiling_Injected(intPtr);
		}
	}

	public SpriteDrawMode drawMode
	{
		get
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_drawMode_Injected(intPtr);
		}
		set
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			set_drawMode_Injected(intPtr, value);
		}
	}

	public Vector2 size
	{
		get
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			get_size_Injected(intPtr, out var ret);
			return ret;
		}
		set
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			set_size_Injected(intPtr, ref value);
		}
	}

	public float adaptiveModeThreshold
	{
		get
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_adaptiveModeThreshold_Injected(intPtr);
		}
		set
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			set_adaptiveModeThreshold_Injected(intPtr, value);
		}
	}

	public SpriteTileMode tileMode
	{
		get
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_tileMode_Injected(intPtr);
		}
		set
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			set_tileMode_Injected(intPtr, value);
		}
	}

	public SpriteMaskInteraction maskInteraction
	{
		get
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_maskInteraction_Injected(intPtr);
		}
		set
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			set_maskInteraction_Injected(intPtr, value);
		}
	}

	public bool flipX
	{
		get
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_flipX_Injected(intPtr);
		}
		set
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			set_flipX_Injected(intPtr, value);
		}
	}

	public bool flipY
	{
		get
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_flipY_Injected(intPtr);
		}
		set
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			set_flipY_Injected(intPtr, value);
		}
	}

	public SpriteSortPoint spriteSortPoint
	{
		get
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_spriteSortPoint_Injected(intPtr);
		}
		set
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			set_spriteSortPoint_Injected(intPtr, value);
		}
	}

	static SpriteRenderer()
	{
		Il2CppClassPointerStore<SpriteRenderer>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "SpriteRenderer");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SpriteRenderer>.NativeClassPtr);
		NativeFieldInfoPtr_m_SpriteChangeEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpriteRenderer>.NativeClassPtr, "m_SpriteChangeEvent");
		NativeMethodInfoPtr_RegisterSpriteChangeCallback_Public_Void_UnityAction_1_SpriteRenderer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteRenderer>.NativeClassPtr, 100663683);
		NativeMethodInfoPtr_UnregisterSpriteChangeCallback_Public_Void_UnityAction_1_SpriteRenderer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteRenderer>.NativeClassPtr, 100663684);
		NativeMethodInfoPtr_InvokeSpriteChanged_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteRenderer>.NativeClassPtr, 100663685);
		NativeMethodInfoPtr_set_hasSpriteChangeEvents_Internal_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteRenderer>.NativeClassPtr, 100663686);
		NativeMethodInfoPtr_get_sprite_Public_get_Sprite_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteRenderer>.NativeClassPtr, 100663687);
		NativeMethodInfoPtr_set_sprite_Public_set_Void_Sprite_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteRenderer>.NativeClassPtr, 100663688);
		NativeMethodInfoPtr_get_color_Public_get_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteRenderer>.NativeClassPtr, 100663689);
		NativeMethodInfoPtr_set_color_Public_set_Void_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteRenderer>.NativeClassPtr, 100663690);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteRenderer>.NativeClassPtr, 100663691);
		NativeMethodInfoPtr_set_hasSpriteChangeEvents_Injected_Private_Static_Void_IntPtr_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteRenderer>.NativeClassPtr, 100663692);
		NativeMethodInfoPtr_get_sprite_Injected_Private_Static_IntPtr_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteRenderer>.NativeClassPtr, 100663693);
		NativeMethodInfoPtr_set_sprite_Injected_Private_Static_Void_IntPtr_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteRenderer>.NativeClassPtr, 100663694);
		NativeMethodInfoPtr_get_color_Injected_Private_Static_Void_IntPtr_byref_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteRenderer>.NativeClassPtr, 100663695);
		NativeMethodInfoPtr_set_color_Injected_Private_Static_Void_IntPtr_byref_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteRenderer>.NativeClassPtr, 100663696);
		get_shouldSupportTiling_InjectedDelegateField = IL2CPP.ResolveICall<get_shouldSupportTiling_InjectedDelegate>("UnityEngine.SpriteRenderer::get_shouldSupportTiling_Injected");
		get_hasSpriteChangeEvents_InjectedDelegateField = IL2CPP.ResolveICall<get_hasSpriteChangeEvents_InjectedDelegate>("UnityEngine.SpriteRenderer::get_hasSpriteChangeEvents_Injected");
		get_drawMode_InjectedDelegateField = IL2CPP.ResolveICall<get_drawMode_InjectedDelegate>("UnityEngine.SpriteRenderer::get_drawMode_Injected");
		set_drawMode_InjectedDelegateField = IL2CPP.ResolveICall<set_drawMode_InjectedDelegate>("UnityEngine.SpriteRenderer::set_drawMode_Injected");
		get_size_InjectedDelegateField = IL2CPP.ResolveICall<get_size_InjectedDelegate>("UnityEngine.SpriteRenderer::get_size_Injected");
		set_size_InjectedDelegateField = IL2CPP.ResolveICall<set_size_InjectedDelegate>("UnityEngine.SpriteRenderer::set_size_Injected");
		get_adaptiveModeThreshold_InjectedDelegateField = IL2CPP.ResolveICall<get_adaptiveModeThreshold_InjectedDelegate>("UnityEngine.SpriteRenderer::get_adaptiveModeThreshold_Injected");
		set_adaptiveModeThreshold_InjectedDelegateField = IL2CPP.ResolveICall<set_adaptiveModeThreshold_InjectedDelegate>("UnityEngine.SpriteRenderer::set_adaptiveModeThreshold_Injected");
		get_tileMode_InjectedDelegateField = IL2CPP.ResolveICall<get_tileMode_InjectedDelegate>("UnityEngine.SpriteRenderer::get_tileMode_Injected");
		set_tileMode_InjectedDelegateField = IL2CPP.ResolveICall<set_tileMode_InjectedDelegate>("UnityEngine.SpriteRenderer::set_tileMode_Injected");
		get_maskInteraction_InjectedDelegateField = IL2CPP.ResolveICall<get_maskInteraction_InjectedDelegate>("UnityEngine.SpriteRenderer::get_maskInteraction_Injected");
		set_maskInteraction_InjectedDelegateField = IL2CPP.ResolveICall<set_maskInteraction_InjectedDelegate>("UnityEngine.SpriteRenderer::set_maskInteraction_Injected");
		get_flipX_InjectedDelegateField = IL2CPP.ResolveICall<get_flipX_InjectedDelegate>("UnityEngine.SpriteRenderer::get_flipX_Injected");
		set_flipX_InjectedDelegateField = IL2CPP.ResolveICall<set_flipX_InjectedDelegate>("UnityEngine.SpriteRenderer::set_flipX_Injected");
		get_flipY_InjectedDelegateField = IL2CPP.ResolveICall<get_flipY_InjectedDelegate>("UnityEngine.SpriteRenderer::get_flipY_Injected");
		set_flipY_InjectedDelegateField = IL2CPP.ResolveICall<set_flipY_InjectedDelegate>("UnityEngine.SpriteRenderer::set_flipY_Injected");
		get_spriteSortPoint_InjectedDelegateField = IL2CPP.ResolveICall<get_spriteSortPoint_InjectedDelegate>("UnityEngine.SpriteRenderer::get_spriteSortPoint_Injected");
		set_spriteSortPoint_InjectedDelegateField = IL2CPP.ResolveICall<set_spriteSortPoint_InjectedDelegate>("UnityEngine.SpriteRenderer::set_spriteSortPoint_Injected");
		GetCurrentMeshDataPtr_InjectedDelegateField = IL2CPP.ResolveICall<GetCurrentMeshDataPtr_InjectedDelegate>("UnityEngine.SpriteRenderer::GetCurrentMeshDataPtr_Injected");
		Internal_GetSpriteBounds_InjectedDelegateField = IL2CPP.ResolveICall<Internal_GetSpriteBounds_InjectedDelegate>("UnityEngine.SpriteRenderer::Internal_GetSpriteBounds_Injected");
		GetSecondaryTextureProperties_InjectedDelegateField = IL2CPP.ResolveICall<GetSecondaryTextureProperties_InjectedDelegate>("UnityEngine.SpriteRenderer::GetSecondaryTextureProperties_Injected");
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1166501, RefRangeEnd = 1166502, XrefRangeStart = 1166486, XrefRangeEnd = 1166501, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void RegisterSpriteChangeCallback(UnityAction<SpriteRenderer> callback)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)callback);
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RegisterSpriteChangeCallback_Public_Void_UnityAction_1_SpriteRenderer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1166510, RefRangeEnd = 1166511, XrefRangeStart = 1166502, XrefRangeEnd = 1166510, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void UnregisterSpriteChangeCallback(UnityAction<SpriteRenderer> callback)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)callback);
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UnregisterSpriteChangeCallback_Public_Void_UnityAction_1_SpriteRenderer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1166511, XrefRangeEnd = 1166518, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void InvokeSpriteChanged()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InvokeSpriteChanged_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(103)]
	[CachedScanResults(RefRangeStart = 22793, RefRangeEnd = 22896, XrefRangeStart = 22793, XrefRangeEnd = 22896, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe SpriteRenderer()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SpriteRenderer>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1166668, XrefRangeEnd = 1166670, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void set_hasSpriteChangeEvents_Injected(IntPtr _unity_self, bool value)
	{
		IntPtr* ptr = stackalloc IntPtr[2];
		*ptr = (nint)(&_unity_self);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = &value;
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_hasSpriteChangeEvents_Injected_Private_Static_Void_IntPtr_Boolean_0, (IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1166670, XrefRangeEnd = 1166672, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static IntPtr get_sprite_Injected(IntPtr _unity_self)
	{
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = (nint)(&_unity_self);
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_sprite_Injected_Private_Static_IntPtr_IntPtr_0, (IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(IntPtr*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1166672, XrefRangeEnd = 1166674, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void set_sprite_Injected(IntPtr _unity_self, IntPtr value)
	{
		IntPtr* ptr = stackalloc IntPtr[2];
		*ptr = (nint)(&_unity_self);
		*(IntPtr**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = &value;
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_sprite_Injected_Private_Static_Void_IntPtr_IntPtr_0, (IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1166674, XrefRangeEnd = 1166676, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void get_color_Injected(IntPtr _unity_self, out Color ret)
	{
		IntPtr* ptr = stackalloc IntPtr[2];
		*ptr = (nint)(&_unity_self);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = Unsafe.AsPointer(ref ret);
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_color_Injected_Private_Static_Void_IntPtr_byref_Color_0, (IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1166676, XrefRangeEnd = 1166678, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void set_color_Injected(IntPtr _unity_self, [In] ref Color value)
	{
		IntPtr* ptr = stackalloc IntPtr[2];
		*ptr = (nint)(&_unity_self);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = Unsafe.AsPointer(ref value);
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_color_Injected_Private_Static_Void_IntPtr_byref_Color_0, (IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public SpriteRenderer(IntPtr pointer)
		: base(pointer)
	{
	}

	public IntPtr GetCurrentMeshDataPtr()
	{
		IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
		if (intPtr == (IntPtr)0)
		{
			ThrowHelper.ThrowNullReferenceException(this);
		}
		return GetCurrentMeshDataPtr_Injected(intPtr);
	}

	public Bounds Internal_GetSpriteBounds(SpriteDrawMode mode)
	{
		IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
		if (intPtr == (IntPtr)0)
		{
			ThrowHelper.ThrowNullReferenceException(this);
		}
		Internal_GetSpriteBounds_Injected(intPtr, mode, out var ret);
		return ret;
	}

	public void GetSecondaryTextureProperties(MaterialPropertyBlock mbp)
	{
		if (mbp == null)
		{
			ThrowHelper.ThrowArgumentNullException(mbp, "mbp");
		}
		IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
		if (intPtr == (IntPtr)0)
		{
			ThrowHelper.ThrowNullReferenceException(this);
		}
		IntPtr intPtr2 = MaterialPropertyBlock.BindingsMarshaller.ConvertToNative(mbp);
		if (intPtr2 == (IntPtr)0)
		{
			ThrowHelper.ThrowArgumentNullException(mbp, "mbp");
		}
		GetSecondaryTextureProperties_Injected(intPtr, intPtr2);
	}

	public Bounds GetSpriteBounds()
	{
		return Internal_GetSpriteBounds(drawMode);
	}

	public static bool get_shouldSupportTiling_Injected(IntPtr _unity_self)
	{
		return get_shouldSupportTiling_InjectedDelegateField(_unity_self);
	}

	public static bool get_hasSpriteChangeEvents_Injected(IntPtr _unity_self)
	{
		return get_hasSpriteChangeEvents_InjectedDelegateField(_unity_self);
	}

	public static SpriteDrawMode get_drawMode_Injected(IntPtr _unity_self)
	{
		return get_drawMode_InjectedDelegateField(_unity_self);
	}

	public static void set_drawMode_Injected(IntPtr _unity_self, SpriteDrawMode value)
	{
		set_drawMode_InjectedDelegateField(_unity_self, value);
	}

	public unsafe static void get_size_Injected(IntPtr _unity_self, out Vector2 ret)
	{
		get_size_InjectedDelegateField(_unity_self, (nint)Unsafe.AsPointer(ref ret));
	}

	public unsafe static void set_size_Injected(IntPtr _unity_self, [In] ref Vector2 value)
	{
		set_size_InjectedDelegateField(_unity_self, (nint)Unsafe.AsPointer(ref value));
	}

	public static float get_adaptiveModeThreshold_Injected(IntPtr _unity_self)
	{
		return get_adaptiveModeThreshold_InjectedDelegateField(_unity_self);
	}

	public static void set_adaptiveModeThreshold_Injected(IntPtr _unity_self, float value)
	{
		set_adaptiveModeThreshold_InjectedDelegateField(_unity_self, value);
	}

	public static SpriteTileMode get_tileMode_Injected(IntPtr _unity_self)
	{
		return get_tileMode_InjectedDelegateField(_unity_self);
	}

	public static void set_tileMode_Injected(IntPtr _unity_self, SpriteTileMode value)
	{
		set_tileMode_InjectedDelegateField(_unity_self, value);
	}

	public static SpriteMaskInteraction get_maskInteraction_Injected(IntPtr _unity_self)
	{
		return get_maskInteraction_InjectedDelegateField(_unity_self);
	}

	public static void set_maskInteraction_Injected(IntPtr _unity_self, SpriteMaskInteraction value)
	{
		set_maskInteraction_InjectedDelegateField(_unity_self, value);
	}

	public static bool get_flipX_Injected(IntPtr _unity_self)
	{
		return get_flipX_InjectedDelegateField(_unity_self);
	}

	public static void set_flipX_Injected(IntPtr _unity_self, bool value)
	{
		set_flipX_InjectedDelegateField(_unity_self, value);
	}

	public static bool get_flipY_Injected(IntPtr _unity_self)
	{
		return get_flipY_InjectedDelegateField(_unity_self);
	}

	public static void set_flipY_Injected(IntPtr _unity_self, bool value)
	{
		set_flipY_InjectedDelegateField(_unity_self, value);
	}

	public static SpriteSortPoint get_spriteSortPoint_Injected(IntPtr _unity_self)
	{
		return get_spriteSortPoint_InjectedDelegateField(_unity_self);
	}

	public static void set_spriteSortPoint_Injected(IntPtr _unity_self, SpriteSortPoint value)
	{
		set_spriteSortPoint_InjectedDelegateField(_unity_self, value);
	}

	public static IntPtr GetCurrentMeshDataPtr_Injected(IntPtr _unity_self)
	{
		return GetCurrentMeshDataPtr_InjectedDelegateField(_unity_self);
	}

	public unsafe static void Internal_GetSpriteBounds_Injected(IntPtr _unity_self, SpriteDrawMode mode, out Bounds ret)
	{
		Internal_GetSpriteBounds_InjectedDelegateField(_unity_self, mode, (nint)Unsafe.AsPointer(ref ret));
	}

	public static void GetSecondaryTextureProperties_Injected(IntPtr _unity_self, IntPtr mbp)
	{
		GetSecondaryTextureProperties_InjectedDelegateField(_unity_self, mbp);
	}
}
