using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine.Bindings;

namespace UnityEngine;

public sealed class SpriteMask : Renderer
{
	public enum MaskSource
	{
		Sprite,
		SupportedRenderers
	}

	private delegate int get_frontSortingLayerID_InjectedDelegate(IntPtr _unity_self);

	private delegate int get_frontSortingOrder_InjectedDelegate(IntPtr _unity_self);

	private delegate int get_backSortingLayerID_InjectedDelegate(IntPtr _unity_self);

	private delegate int get_backSortingOrder_InjectedDelegate(IntPtr _unity_self);

	private delegate float get_alphaCutoff_InjectedDelegate(IntPtr _unity_self);

	private delegate bool get_isCustomRangeActive_InjectedDelegate(IntPtr _unity_self);

	private delegate SpriteSortPoint get_spriteSortPoint_InjectedDelegate(IntPtr _unity_self);

	private delegate void set_spriteSortPoint_InjectedDelegate(IntPtr _unity_self, SpriteSortPoint value);

	private delegate MaskSource get_maskSource_InjectedDelegate(IntPtr _unity_self);

	private delegate void set_maskSource_InjectedDelegate(IntPtr _unity_self, MaskSource value);

	private delegate IntPtr get_cachedSupportedRenderer_InjectedDelegate(IntPtr _unity_self);

	private delegate void GetSpriteBounds_InjectedDelegate(IntPtr _unity_self, [Out] IntPtr ret);

	private static readonly IntPtr NativeMethodInfoPtr_set_frontSortingLayerID_Public_set_Void_Int32_0;

	private static readonly IntPtr NativeMethodInfoPtr_set_frontSortingOrder_Public_set_Void_Int32_0;

	private static readonly IntPtr NativeMethodInfoPtr_set_backSortingLayerID_Public_set_Void_Int32_0;

	private static readonly IntPtr NativeMethodInfoPtr_set_backSortingOrder_Public_set_Void_Int32_0;

	private static readonly IntPtr NativeMethodInfoPtr_set_alphaCutoff_Public_set_Void_Single_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_sprite_Public_get_Sprite_0;

	private static readonly IntPtr NativeMethodInfoPtr_set_sprite_Public_set_Void_Sprite_0;

	private static readonly IntPtr NativeMethodInfoPtr_set_isCustomRangeActive_Public_set_Void_Boolean_0;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_set_frontSortingLayerID_Injected_Private_Static_Void_IntPtr_Int32_0;

	private static readonly IntPtr NativeMethodInfoPtr_set_frontSortingOrder_Injected_Private_Static_Void_IntPtr_Int32_0;

	private static readonly IntPtr NativeMethodInfoPtr_set_backSortingLayerID_Injected_Private_Static_Void_IntPtr_Int32_0;

	private static readonly IntPtr NativeMethodInfoPtr_set_backSortingOrder_Injected_Private_Static_Void_IntPtr_Int32_0;

	private static readonly IntPtr NativeMethodInfoPtr_set_alphaCutoff_Injected_Private_Static_Void_IntPtr_Single_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_sprite_Injected_Private_Static_IntPtr_IntPtr_0;

	private static readonly IntPtr NativeMethodInfoPtr_set_sprite_Injected_Private_Static_Void_IntPtr_IntPtr_0;

	private static readonly IntPtr NativeMethodInfoPtr_set_isCustomRangeActive_Injected_Private_Static_Void_IntPtr_Boolean_0;

	private static readonly get_frontSortingLayerID_InjectedDelegate get_frontSortingLayerID_InjectedDelegateField;

	private static readonly get_frontSortingOrder_InjectedDelegate get_frontSortingOrder_InjectedDelegateField;

	private static readonly get_backSortingLayerID_InjectedDelegate get_backSortingLayerID_InjectedDelegateField;

	private static readonly get_backSortingOrder_InjectedDelegate get_backSortingOrder_InjectedDelegateField;

	private static readonly get_alphaCutoff_InjectedDelegate get_alphaCutoff_InjectedDelegateField;

	private static readonly get_isCustomRangeActive_InjectedDelegate get_isCustomRangeActive_InjectedDelegateField;

	private static readonly get_spriteSortPoint_InjectedDelegate get_spriteSortPoint_InjectedDelegateField;

	private static readonly set_spriteSortPoint_InjectedDelegate set_spriteSortPoint_InjectedDelegateField;

	private static readonly get_maskSource_InjectedDelegate get_maskSource_InjectedDelegateField;

	private static readonly set_maskSource_InjectedDelegate set_maskSource_InjectedDelegateField;

	private static readonly get_cachedSupportedRenderer_InjectedDelegate get_cachedSupportedRenderer_InjectedDelegateField;

	private static readonly GetSpriteBounds_InjectedDelegate GetSpriteBounds_InjectedDelegateField;

	public unsafe int frontSortingLayerID
	{
		get
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_frontSortingLayerID_Injected(intPtr);
		}
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1271611, RefRangeEnd = 1271614, XrefRangeStart = 1271606, XrefRangeEnd = 1271611, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = stackalloc IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out IntPtr intPtr);
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_frontSortingLayerID_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe int frontSortingOrder
	{
		get
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_frontSortingOrder_Injected(intPtr);
		}
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1271619, RefRangeEnd = 1271622, XrefRangeStart = 1271614, XrefRangeEnd = 1271619, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = stackalloc IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out IntPtr intPtr);
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_frontSortingOrder_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe int backSortingLayerID
	{
		get
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_backSortingLayerID_Injected(intPtr);
		}
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1271627, RefRangeEnd = 1271630, XrefRangeStart = 1271622, XrefRangeEnd = 1271627, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = stackalloc IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out IntPtr intPtr);
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_backSortingLayerID_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe int backSortingOrder
	{
		get
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_backSortingOrder_Injected(intPtr);
		}
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1271635, RefRangeEnd = 1271638, XrefRangeStart = 1271630, XrefRangeEnd = 1271635, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = stackalloc IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out IntPtr intPtr);
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_backSortingOrder_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe float alphaCutoff
	{
		get
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_alphaCutoff_Injected(intPtr);
		}
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1271643, RefRangeEnd = 1271644, XrefRangeStart = 1271638, XrefRangeEnd = 1271643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = stackalloc IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out IntPtr intPtr);
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_alphaCutoff_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe Sprite sprite
	{
		[CallerCount(14)]
		[CachedScanResults(RefRangeStart = 1271657, RefRangeEnd = 1271671, XrefRangeStart = 1271644, XrefRangeEnd = 1271657, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr);
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_sprite_Public_get_Sprite_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (IntPtr)0) ? Il2CppObjectPool.Get<Sprite>(intPtr2) : null;
		}
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1271679, RefRangeEnd = 1271681, XrefRangeStart = 1271671, XrefRangeEnd = 1271679, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

	public unsafe bool isCustomRangeActive
	{
		get
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_isCustomRangeActive_Injected(intPtr);
		}
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1271686, RefRangeEnd = 1271687, XrefRangeStart = 1271681, XrefRangeEnd = 1271686, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = stackalloc IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out IntPtr intPtr);
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_isCustomRangeActive_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
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

	public MaskSource maskSource
	{
		get
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_maskSource_Injected(intPtr);
		}
		set
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			set_maskSource_Injected(intPtr, value);
		}
	}

	public Renderer cachedSupportedRenderer
	{
		get
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			return Unmarshal.UnmarshalUnityObject<Renderer>(get_cachedSupportedRenderer_Injected(intPtr));
		}
	}

	static SpriteMask()
	{
		Il2CppClassPointerStore<SpriteMask>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.SpriteMaskModule.dll", "UnityEngine", "SpriteMask");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SpriteMask>.NativeClassPtr);
		NativeMethodInfoPtr_set_frontSortingLayerID_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteMask>.NativeClassPtr, 100663297);
		NativeMethodInfoPtr_set_frontSortingOrder_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteMask>.NativeClassPtr, 100663298);
		NativeMethodInfoPtr_set_backSortingLayerID_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteMask>.NativeClassPtr, 100663299);
		NativeMethodInfoPtr_set_backSortingOrder_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteMask>.NativeClassPtr, 100663300);
		NativeMethodInfoPtr_set_alphaCutoff_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteMask>.NativeClassPtr, 100663301);
		NativeMethodInfoPtr_get_sprite_Public_get_Sprite_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteMask>.NativeClassPtr, 100663302);
		NativeMethodInfoPtr_set_sprite_Public_set_Void_Sprite_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteMask>.NativeClassPtr, 100663303);
		NativeMethodInfoPtr_set_isCustomRangeActive_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteMask>.NativeClassPtr, 100663304);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteMask>.NativeClassPtr, 100663305);
		NativeMethodInfoPtr_set_frontSortingLayerID_Injected_Private_Static_Void_IntPtr_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteMask>.NativeClassPtr, 100663306);
		NativeMethodInfoPtr_set_frontSortingOrder_Injected_Private_Static_Void_IntPtr_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteMask>.NativeClassPtr, 100663307);
		NativeMethodInfoPtr_set_backSortingLayerID_Injected_Private_Static_Void_IntPtr_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteMask>.NativeClassPtr, 100663308);
		NativeMethodInfoPtr_set_backSortingOrder_Injected_Private_Static_Void_IntPtr_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteMask>.NativeClassPtr, 100663309);
		NativeMethodInfoPtr_set_alphaCutoff_Injected_Private_Static_Void_IntPtr_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteMask>.NativeClassPtr, 100663310);
		NativeMethodInfoPtr_get_sprite_Injected_Private_Static_IntPtr_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteMask>.NativeClassPtr, 100663311);
		NativeMethodInfoPtr_set_sprite_Injected_Private_Static_Void_IntPtr_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteMask>.NativeClassPtr, 100663312);
		NativeMethodInfoPtr_set_isCustomRangeActive_Injected_Private_Static_Void_IntPtr_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteMask>.NativeClassPtr, 100663313);
		get_frontSortingLayerID_InjectedDelegateField = IL2CPP.ResolveICall<get_frontSortingLayerID_InjectedDelegate>("UnityEngine.SpriteMask::get_frontSortingLayerID_Injected");
		get_frontSortingOrder_InjectedDelegateField = IL2CPP.ResolveICall<get_frontSortingOrder_InjectedDelegate>("UnityEngine.SpriteMask::get_frontSortingOrder_Injected");
		get_backSortingLayerID_InjectedDelegateField = IL2CPP.ResolveICall<get_backSortingLayerID_InjectedDelegate>("UnityEngine.SpriteMask::get_backSortingLayerID_Injected");
		get_backSortingOrder_InjectedDelegateField = IL2CPP.ResolveICall<get_backSortingOrder_InjectedDelegate>("UnityEngine.SpriteMask::get_backSortingOrder_Injected");
		get_alphaCutoff_InjectedDelegateField = IL2CPP.ResolveICall<get_alphaCutoff_InjectedDelegate>("UnityEngine.SpriteMask::get_alphaCutoff_Injected");
		get_isCustomRangeActive_InjectedDelegateField = IL2CPP.ResolveICall<get_isCustomRangeActive_InjectedDelegate>("UnityEngine.SpriteMask::get_isCustomRangeActive_Injected");
		get_spriteSortPoint_InjectedDelegateField = IL2CPP.ResolveICall<get_spriteSortPoint_InjectedDelegate>("UnityEngine.SpriteMask::get_spriteSortPoint_Injected");
		set_spriteSortPoint_InjectedDelegateField = IL2CPP.ResolveICall<set_spriteSortPoint_InjectedDelegate>("UnityEngine.SpriteMask::set_spriteSortPoint_Injected");
		get_maskSource_InjectedDelegateField = IL2CPP.ResolveICall<get_maskSource_InjectedDelegate>("UnityEngine.SpriteMask::get_maskSource_Injected");
		set_maskSource_InjectedDelegateField = IL2CPP.ResolveICall<set_maskSource_InjectedDelegate>("UnityEngine.SpriteMask::set_maskSource_Injected");
		get_cachedSupportedRenderer_InjectedDelegateField = IL2CPP.ResolveICall<get_cachedSupportedRenderer_InjectedDelegate>("UnityEngine.SpriteMask::get_cachedSupportedRenderer_Injected");
		GetSpriteBounds_InjectedDelegateField = IL2CPP.ResolveICall<GetSpriteBounds_InjectedDelegate>("UnityEngine.SpriteMask::GetSpriteBounds_Injected");
	}

	[CallerCount(103)]
	[CachedScanResults(RefRangeStart = 22793, RefRangeEnd = 22896, XrefRangeStart = 22793, XrefRangeEnd = 22896, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe SpriteMask()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SpriteMask>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1271687, XrefRangeEnd = 1271689, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void set_frontSortingLayerID_Injected(IntPtr _unity_self, int value)
	{
		IntPtr* ptr = stackalloc IntPtr[2];
		*ptr = (nint)(&_unity_self);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = &value;
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_frontSortingLayerID_Injected_Private_Static_Void_IntPtr_Int32_0, (IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1271689, XrefRangeEnd = 1271691, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void set_frontSortingOrder_Injected(IntPtr _unity_self, int value)
	{
		IntPtr* ptr = stackalloc IntPtr[2];
		*ptr = (nint)(&_unity_self);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = &value;
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_frontSortingOrder_Injected_Private_Static_Void_IntPtr_Int32_0, (IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1271691, XrefRangeEnd = 1271693, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void set_backSortingLayerID_Injected(IntPtr _unity_self, int value)
	{
		IntPtr* ptr = stackalloc IntPtr[2];
		*ptr = (nint)(&_unity_self);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = &value;
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_backSortingLayerID_Injected_Private_Static_Void_IntPtr_Int32_0, (IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1271693, XrefRangeEnd = 1271695, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void set_backSortingOrder_Injected(IntPtr _unity_self, int value)
	{
		IntPtr* ptr = stackalloc IntPtr[2];
		*ptr = (nint)(&_unity_self);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = &value;
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_backSortingOrder_Injected_Private_Static_Void_IntPtr_Int32_0, (IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1271695, XrefRangeEnd = 1271697, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void set_alphaCutoff_Injected(IntPtr _unity_self, float value)
	{
		IntPtr* ptr = stackalloc IntPtr[2];
		*ptr = (nint)(&_unity_self);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = &value;
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_alphaCutoff_Injected_Private_Static_Void_IntPtr_Single_0, (IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1271697, XrefRangeEnd = 1271699, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1271699, XrefRangeEnd = 1271701, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1271701, XrefRangeEnd = 1271703, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void set_isCustomRangeActive_Injected(IntPtr _unity_self, bool value)
	{
		IntPtr* ptr = stackalloc IntPtr[2];
		*ptr = (nint)(&_unity_self);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = &value;
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_isCustomRangeActive_Injected_Private_Static_Void_IntPtr_Boolean_0, (IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public SpriteMask(IntPtr pointer)
		: base(pointer)
	{
	}

	public Bounds GetSpriteBounds()
	{
		IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
		if (intPtr == (IntPtr)0)
		{
			ThrowHelper.ThrowNullReferenceException(this);
		}
		GetSpriteBounds_Injected(intPtr, out var ret);
		return ret;
	}

	public static int get_frontSortingLayerID_Injected(IntPtr _unity_self)
	{
		return get_frontSortingLayerID_InjectedDelegateField(_unity_self);
	}

	public static int get_frontSortingOrder_Injected(IntPtr _unity_self)
	{
		return get_frontSortingOrder_InjectedDelegateField(_unity_self);
	}

	public static int get_backSortingLayerID_Injected(IntPtr _unity_self)
	{
		return get_backSortingLayerID_InjectedDelegateField(_unity_self);
	}

	public static int get_backSortingOrder_Injected(IntPtr _unity_self)
	{
		return get_backSortingOrder_InjectedDelegateField(_unity_self);
	}

	public static float get_alphaCutoff_Injected(IntPtr _unity_self)
	{
		return get_alphaCutoff_InjectedDelegateField(_unity_self);
	}

	public static bool get_isCustomRangeActive_Injected(IntPtr _unity_self)
	{
		return get_isCustomRangeActive_InjectedDelegateField(_unity_self);
	}

	public static SpriteSortPoint get_spriteSortPoint_Injected(IntPtr _unity_self)
	{
		return get_spriteSortPoint_InjectedDelegateField(_unity_self);
	}

	public static void set_spriteSortPoint_Injected(IntPtr _unity_self, SpriteSortPoint value)
	{
		set_spriteSortPoint_InjectedDelegateField(_unity_self, value);
	}

	public static MaskSource get_maskSource_Injected(IntPtr _unity_self)
	{
		return get_maskSource_InjectedDelegateField(_unity_self);
	}

	public static void set_maskSource_Injected(IntPtr _unity_self, MaskSource value)
	{
		set_maskSource_InjectedDelegateField(_unity_self, value);
	}

	public static IntPtr get_cachedSupportedRenderer_Injected(IntPtr _unity_self)
	{
		return get_cachedSupportedRenderer_InjectedDelegateField(_unity_self);
	}

	public unsafe static void GetSpriteBounds_Injected(IntPtr _unity_self, out Bounds ret)
	{
		GetSpriteBounds_InjectedDelegateField(_unity_self, (nint)Unsafe.AsPointer(ref ret));
	}
}
