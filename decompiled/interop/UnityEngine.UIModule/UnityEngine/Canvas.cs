using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine.Bindings;

namespace UnityEngine;

public sealed class Canvas : Behaviour
{
	public sealed class WillRenderCanvases : Il2CppSystem.MulticastDelegate
	{
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_0;

		static WillRenderCanvases()
		{
			Il2CppClassPointerStore<WillRenderCanvases>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Canvas>.NativeClassPtr, "WillRenderCanvases");
			NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WillRenderCanvases>.NativeClassPtr, 100663460);
			NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WillRenderCanvases>.NativeClassPtr, 100663461);
		}

		[CallerCount(4109)]
		[CachedScanResults(RefRangeStart = 27728, RefRangeEnd = 31837, XrefRangeStart = 27728, XrefRangeEnd = 31837, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WillRenderCanvases(Il2CppSystem.Object @object, System.IntPtr method)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WillRenderCanvases>.NativeClassPtr))
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

		public WillRenderCanvases(System.IntPtr pointer)
			: base(pointer)
		{
		}

		public static implicit operator WillRenderCanvases(System.Action P_0)
		{
			return DelegateSupport.ConvertDelegate<WillRenderCanvases>((System.Delegate)P_0);
		}

		public static WillRenderCanvases operator +(WillRenderCanvases P_0, WillRenderCanvases P_1)
		{
			return ((Il2CppObjectBase)Il2CppSystem.Delegate.Combine(P_0, P_1)).Cast<WillRenderCanvases>();
		}

		public static WillRenderCanvases operator -(WillRenderCanvases P_0, WillRenderCanvases P_1)
		{
			object obj = Il2CppSystem.Delegate.Remove(P_0, P_1);
			if (obj != null)
			{
				obj = ((Il2CppObjectBase)obj).Cast<WillRenderCanvases>();
			}
			return (WillRenderCanvases)obj;
		}
	}

	private delegate bool get_overridePixelPerfect_InjectedDelegate(System.IntPtr _unity_self);

	private delegate void set_overridePixelPerfect_InjectedDelegate(System.IntPtr _unity_self, bool value);

	private delegate bool get_vertexColorAlwaysGammaSpace_InjectedDelegate(System.IntPtr _unity_self);

	private delegate void set_vertexColorAlwaysGammaSpace_InjectedDelegate(System.IntPtr _unity_self, bool value);

	private delegate void set_pixelPerfect_InjectedDelegate(System.IntPtr _unity_self, bool value);

	private delegate void set_targetDisplay_InjectedDelegate(System.IntPtr _unity_self, int value);

	private delegate int get_cachedSortingLayerValue_InjectedDelegate(System.IntPtr _unity_self);

	private delegate void get_sortingLayerName_InjectedDelegate(System.IntPtr _unity_self, [Out] System.IntPtr ret);

	private delegate void set_sortingLayerName_InjectedDelegate(System.IntPtr _unity_self, System.IntPtr value);

	private delegate StandaloneRenderResize get_updateRectTransformForStandalone_InjectedDelegate(System.IntPtr _unity_self);

	private delegate void set_updateRectTransformForStandalone_InjectedDelegate(System.IntPtr _unity_self, StandaloneRenderResize value);

	private delegate float get_normalizedSortingGridSize_InjectedDelegate(System.IntPtr _unity_self);

	private delegate void set_normalizedSortingGridSize_InjectedDelegate(System.IntPtr _unity_self, float value);

	private delegate int get_sortingGridNormalizedSize_InjectedDelegate(System.IntPtr _unity_self);

	private delegate void set_sortingGridNormalizedSize_InjectedDelegate(System.IntPtr _unity_self, int value);

	private delegate System.IntPtr GetDefaultCanvasTextMaterial_InjectedDelegate();

	private delegate void UpdateCanvasRectTransform_InjectedDelegate(System.IntPtr _unity_self, bool alignWithCamera);

	private static readonly System.IntPtr NativeFieldInfoPtr_preWillRenderCanvases;

	private static readonly System.IntPtr NativeFieldInfoPtr_willRenderCanvases;

	private static readonly System.IntPtr NativeFieldInfoPtr__externBeginRenderOverlays_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__externRenderOverlaysBefore_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__externEndRenderOverlays_k__BackingField;

	private static readonly System.IntPtr NativeMethodInfoPtr_add_preWillRenderCanvases_Public_Static_add_Void_WillRenderCanvases_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_remove_preWillRenderCanvases_Public_Static_rem_Void_WillRenderCanvases_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_add_willRenderCanvases_Public_Static_add_Void_WillRenderCanvases_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_remove_willRenderCanvases_Public_Static_rem_Void_WillRenderCanvases_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_renderMode_Public_get_RenderMode_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_renderMode_Public_set_Void_RenderMode_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_isRootCanvas_Public_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_pixelRect_Public_get_Rect_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_scaleFactor_Public_get_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_scaleFactor_Public_set_Void_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_referencePixelsPerUnit_Public_get_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_referencePixelsPerUnit_Public_set_Void_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_pixelPerfect_Public_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_planeDistance_Public_get_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_planeDistance_Public_set_Void_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_renderOrder_Public_get_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_overrideSorting_Public_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_overrideSorting_Public_set_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_sortingOrder_Public_get_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_sortingOrder_Public_set_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_targetDisplay_Public_get_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_sortingLayerID_Public_get_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_sortingLayerID_Public_set_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_additionalShaderChannels_Public_get_AdditionalCanvasShaderChannels_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_additionalShaderChannels_Public_set_Void_AdditionalCanvasShaderChannels_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_rootCanvas_Public_get_Canvas_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_renderingDisplaySize_Public_get_Vector2_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_externBeginRenderOverlays_Internal_Static_get_Action_1_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_externBeginRenderOverlays_Internal_Static_set_Void_Action_1_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_externRenderOverlaysBefore_Internal_Static_get_Action_2_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_externRenderOverlaysBefore_Internal_Static_set_Void_Action_2_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_externEndRenderOverlays_Internal_Static_get_Action_1_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_externEndRenderOverlays_Internal_Static_set_Void_Action_1_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetExternalCanvasEnabled_Internal_Static_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_worldCamera_Public_get_Camera_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_worldCamera_Public_set_Void_Camera_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetDefaultCanvasMaterial_Public_Static_Material_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetETC1SupportedCanvasMaterial_Public_Static_Material_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ForceUpdateCanvases_Public_Static_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SendPreWillRenderCanvases_Private_Static_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SendWillRenderCanvases_Private_Static_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_BeginRenderExtraOverlays_Private_Static_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RenderExtraOverlaysBefore_Private_Static_Void_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_EndRenderExtraOverlays_Private_Static_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_renderMode_Injected_Private_Static_RenderMode_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_renderMode_Injected_Private_Static_Void_IntPtr_RenderMode_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_isRootCanvas_Injected_Private_Static_Boolean_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_pixelRect_Injected_Private_Static_Void_IntPtr_byref_Rect_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_scaleFactor_Injected_Private_Static_Single_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_scaleFactor_Injected_Private_Static_Void_IntPtr_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_referencePixelsPerUnit_Injected_Private_Static_Single_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_referencePixelsPerUnit_Injected_Private_Static_Void_IntPtr_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_pixelPerfect_Injected_Private_Static_Boolean_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_planeDistance_Injected_Private_Static_Single_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_planeDistance_Injected_Private_Static_Void_IntPtr_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_renderOrder_Injected_Private_Static_Int32_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_overrideSorting_Injected_Private_Static_Boolean_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_overrideSorting_Injected_Private_Static_Void_IntPtr_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_sortingOrder_Injected_Private_Static_Int32_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_sortingOrder_Injected_Private_Static_Void_IntPtr_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_targetDisplay_Injected_Private_Static_Int32_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_sortingLayerID_Injected_Private_Static_Int32_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_sortingLayerID_Injected_Private_Static_Void_IntPtr_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_additionalShaderChannels_Injected_Private_Static_AdditionalCanvasShaderChannels_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_additionalShaderChannels_Injected_Private_Static_Void_IntPtr_AdditionalCanvasShaderChannels_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_rootCanvas_Injected_Private_Static_IntPtr_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_renderingDisplaySize_Injected_Private_Static_Void_IntPtr_byref_Vector2_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_worldCamera_Injected_Private_Static_IntPtr_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_worldCamera_Injected_Private_Static_Void_IntPtr_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetDefaultCanvasMaterial_Injected_Private_Static_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetETC1SupportedCanvasMaterial_Injected_Private_Static_IntPtr_0;

	private static readonly get_overridePixelPerfect_InjectedDelegate get_overridePixelPerfect_InjectedDelegateField;

	private static readonly set_overridePixelPerfect_InjectedDelegate set_overridePixelPerfect_InjectedDelegateField;

	private static readonly get_vertexColorAlwaysGammaSpace_InjectedDelegate get_vertexColorAlwaysGammaSpace_InjectedDelegateField;

	private static readonly set_vertexColorAlwaysGammaSpace_InjectedDelegate set_vertexColorAlwaysGammaSpace_InjectedDelegateField;

	private static readonly set_pixelPerfect_InjectedDelegate set_pixelPerfect_InjectedDelegateField;

	private static readonly set_targetDisplay_InjectedDelegate set_targetDisplay_InjectedDelegateField;

	private static readonly get_cachedSortingLayerValue_InjectedDelegate get_cachedSortingLayerValue_InjectedDelegateField;

	private static readonly get_sortingLayerName_InjectedDelegate get_sortingLayerName_InjectedDelegateField;

	private static readonly set_sortingLayerName_InjectedDelegate set_sortingLayerName_InjectedDelegateField;

	private static readonly get_updateRectTransformForStandalone_InjectedDelegate get_updateRectTransformForStandalone_InjectedDelegateField;

	private static readonly set_updateRectTransformForStandalone_InjectedDelegate set_updateRectTransformForStandalone_InjectedDelegateField;

	private static readonly get_normalizedSortingGridSize_InjectedDelegate get_normalizedSortingGridSize_InjectedDelegateField;

	private static readonly set_normalizedSortingGridSize_InjectedDelegate set_normalizedSortingGridSize_InjectedDelegateField;

	private static readonly get_sortingGridNormalizedSize_InjectedDelegate get_sortingGridNormalizedSize_InjectedDelegateField;

	private static readonly set_sortingGridNormalizedSize_InjectedDelegate set_sortingGridNormalizedSize_InjectedDelegateField;

	private static readonly GetDefaultCanvasTextMaterial_InjectedDelegate GetDefaultCanvasTextMaterial_InjectedDelegateField;

	private static readonly UpdateCanvasRectTransform_InjectedDelegate UpdateCanvasRectTransform_InjectedDelegateField;

	public unsafe static WillRenderCanvases preWillRenderCanvases
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_preWillRenderCanvases, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<WillRenderCanvases>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_preWillRenderCanvases, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static WillRenderCanvases willRenderCanvases
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_willRenderCanvases, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<WillRenderCanvases>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_willRenderCanvases, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static Il2CppSystem.Action<int> _externBeginRenderOverlays_k__BackingField
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr__externBeginRenderOverlays_k__BackingField, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Action<int>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr__externBeginRenderOverlays_k__BackingField, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static Il2CppSystem.Action<int, int> _externRenderOverlaysBefore_k__BackingField
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr__externRenderOverlaysBefore_k__BackingField, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Action<int, int>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr__externRenderOverlaysBefore_k__BackingField, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static Il2CppSystem.Action<int> _externEndRenderOverlays_k__BackingField
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr__externEndRenderOverlays_k__BackingField, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Action<int>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr__externEndRenderOverlays_k__BackingField, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe RenderMode renderMode
	{
		[CallerCount(18)]
		[CachedScanResults(RefRangeStart = 1407133, RefRangeEnd = 1407151, XrefRangeStart = 1407128, XrefRangeEnd = 1407133, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_renderMode_Public_get_RenderMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(RenderMode*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1407156, RefRangeEnd = 1407158, XrefRangeStart = 1407151, XrefRangeEnd = 1407156, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_renderMode_Public_set_Void_RenderMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe bool isRootCanvas
	{
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1407163, RefRangeEnd = 1407167, XrefRangeStart = 1407158, XrefRangeEnd = 1407163, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_isRootCanvas_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe Rect pixelRect
	{
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 1407171, RefRangeEnd = 1407178, XrefRangeStart = 1407167, XrefRangeEnd = 1407171, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_pixelRect_Public_get_Rect_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(Rect*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe float scaleFactor
	{
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 1407183, RefRangeEnd = 1407189, XrefRangeStart = 1407178, XrefRangeEnd = 1407183, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_scaleFactor_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(float*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 1407194, RefRangeEnd = 1407200, XrefRangeStart = 1407189, XrefRangeEnd = 1407194, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_scaleFactor_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe float referencePixelsPerUnit
	{
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 1407205, RefRangeEnd = 1407210, XrefRangeStart = 1407200, XrefRangeEnd = 1407205, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_referencePixelsPerUnit_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(float*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 1407215, RefRangeEnd = 1407221, XrefRangeStart = 1407210, XrefRangeEnd = 1407215, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_referencePixelsPerUnit_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe bool pixelPerfect
	{
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1407226, RefRangeEnd = 1407228, XrefRangeStart = 1407221, XrefRangeEnd = 1407226, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_pixelPerfect_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		set
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			set_pixelPerfect_Injected(intPtr, value);
		}
	}

	public unsafe float planeDistance
	{
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1407233, RefRangeEnd = 1407236, XrefRangeStart = 1407228, XrefRangeEnd = 1407233, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_planeDistance_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(float*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1407241, RefRangeEnd = 1407243, XrefRangeStart = 1407236, XrefRangeEnd = 1407241, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_planeDistance_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe int renderOrder
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1407248, RefRangeEnd = 1407249, XrefRangeStart = 1407243, XrefRangeEnd = 1407248, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_renderOrder_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe bool overrideSorting
	{
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 1407254, RefRangeEnd = 1407261, XrefRangeStart = 1407249, XrefRangeEnd = 1407254, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_overrideSorting_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 1407266, RefRangeEnd = 1407271, XrefRangeStart = 1407261, XrefRangeEnd = 1407266, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_overrideSorting_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe int sortingOrder
	{
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 1407276, RefRangeEnd = 1407282, XrefRangeStart = 1407271, XrefRangeEnd = 1407276, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_sortingOrder_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 1407287, RefRangeEnd = 1407292, XrefRangeStart = 1407282, XrefRangeEnd = 1407287, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_sortingOrder_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe int targetDisplay
	{
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1407297, RefRangeEnd = 1407300, XrefRangeStart = 1407292, XrefRangeEnd = 1407297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_targetDisplay_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		set
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			set_targetDisplay_Injected(intPtr, value);
		}
	}

	public unsafe int sortingLayerID
	{
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 1407305, RefRangeEnd = 1407310, XrefRangeStart = 1407300, XrefRangeEnd = 1407305, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_sortingLayerID_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1407315, RefRangeEnd = 1407319, XrefRangeStart = 1407310, XrefRangeEnd = 1407315, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_sortingLayerID_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe AdditionalCanvasShaderChannels additionalShaderChannels
	{
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1407324, RefRangeEnd = 1407326, XrefRangeStart = 1407319, XrefRangeEnd = 1407324, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_additionalShaderChannels_Public_get_AdditionalCanvasShaderChannels_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(AdditionalCanvasShaderChannels*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1407331, RefRangeEnd = 1407332, XrefRangeStart = 1407326, XrefRangeEnd = 1407331, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_additionalShaderChannels_Public_set_Void_AdditionalCanvasShaderChannels_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe Canvas rootCanvas
	{
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 1407340, RefRangeEnd = 1407350, XrefRangeStart = 1407332, XrefRangeEnd = 1407340, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_rootCanvas_Public_get_Canvas_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Canvas>(intPtr2) : null;
		}
	}

	public unsafe Vector2 renderingDisplaySize
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1407354, RefRangeEnd = 1407355, XrefRangeStart = 1407350, XrefRangeEnd = 1407354, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_renderingDisplaySize_Public_get_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(Vector2*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe static Il2CppSystem.Action<int> externBeginRenderOverlays
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1407355, XrefRangeEnd = 1407357, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_externBeginRenderOverlays_Internal_Static_get_Action_1_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Action<int>>(intPtr2) : null;
		}
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1407357, XrefRangeEnd = 1407361, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_externBeginRenderOverlays_Internal_Static_set_Void_Action_1_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe static Il2CppSystem.Action<int, int> externRenderOverlaysBefore
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1407361, XrefRangeEnd = 1407363, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_externRenderOverlaysBefore_Internal_Static_get_Action_2_Int32_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Action<int, int>>(intPtr2) : null;
		}
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1407363, XrefRangeEnd = 1407367, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_externRenderOverlaysBefore_Internal_Static_set_Void_Action_2_Int32_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe static Il2CppSystem.Action<int> externEndRenderOverlays
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1407367, XrefRangeEnd = 1407369, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_externEndRenderOverlays_Internal_Static_get_Action_1_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Action<int>>(intPtr2) : null;
		}
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1407369, XrefRangeEnd = 1407373, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_externEndRenderOverlays_Internal_Static_set_Void_Action_1_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe Camera worldCamera
	{
		[CallerCount(48)]
		[CachedScanResults(RefRangeStart = 1407385, RefRangeEnd = 1407433, XrefRangeStart = 1407377, XrefRangeEnd = 1407385, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_worldCamera_Public_get_Camera_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Camera>(intPtr2) : null;
		}
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 1407441, RefRangeEnd = 1407448, XrefRangeStart = 1407433, XrefRangeEnd = 1407441, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_worldCamera_Public_set_Void_Camera_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public bool overridePixelPerfect
	{
		get
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_overridePixelPerfect_Injected(intPtr);
		}
		set
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			set_overridePixelPerfect_Injected(intPtr, value);
		}
	}

	public bool vertexColorAlwaysGammaSpace
	{
		get
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_vertexColorAlwaysGammaSpace_Injected(intPtr);
		}
		set
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			set_vertexColorAlwaysGammaSpace_Injected(intPtr, value);
		}
	}

	public int cachedSortingLayerValue
	{
		get
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_cachedSortingLayerValue_Injected(intPtr);
		}
	}

	public unsafe string sortingLayerName
	{
		get
		{
			Unsafe.SkipInit(out ManagedSpanWrapper ret);
			string stringAndDispose;
			try
			{
				System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
				if (intPtr == (System.IntPtr)0)
				{
					UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
				}
				get_sortingLayerName_Injected(intPtr, out ret);
			}
			finally
			{
				stringAndDispose = OutStringMarshaller.GetStringAndDispose(ret);
			}
			return stringAndDispose;
		}
		set
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
				if (!StringMarshaller.TryMarshalEmptyOrNullString(value, ref managedSpanWrapper))
				{
					Il2CppSystem.ReadOnlySpan<char> readOnlySpan = Il2CppSystem.MemoryExtensions.AsSpan(value);
					fixed (char* begin = &((Il2CppSystem.ReadOnlySpan<char>)(&readOnlySpan)).GetPinnableReference())
					{
						managedSpanWrapper = new ManagedSpanWrapper(begin, ((Il2CppSystem.ReadOnlySpan<char>)(&readOnlySpan)).Length);
						set_sortingLayerName_Injected(intPtr, ref managedSpanWrapper);
						return;
					}
				}
				set_sortingLayerName_Injected(intPtr, ref managedSpanWrapper);
			}
			finally
			{
			}
		}
	}

	public StandaloneRenderResize updateRectTransformForStandalone
	{
		get
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_updateRectTransformForStandalone_Injected(intPtr);
		}
		set
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			set_updateRectTransformForStandalone_Injected(intPtr, value);
		}
	}

	public float normalizedSortingGridSize
	{
		get
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_normalizedSortingGridSize_Injected(intPtr);
		}
		set
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			set_normalizedSortingGridSize_Injected(intPtr, value);
		}
	}

	public int sortingGridNormalizedSize
	{
		get
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_sortingGridNormalizedSize_Injected(intPtr);
		}
		set
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			set_sortingGridNormalizedSize_Injected(intPtr, value);
		}
	}

	static Canvas()
	{
		Il2CppClassPointerStore<Canvas>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIModule.dll", "UnityEngine", "Canvas");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Canvas>.NativeClassPtr);
		NativeFieldInfoPtr_preWillRenderCanvases = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Canvas>.NativeClassPtr, "preWillRenderCanvases");
		NativeFieldInfoPtr_willRenderCanvases = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Canvas>.NativeClassPtr, "willRenderCanvases");
		NativeFieldInfoPtr__externBeginRenderOverlays_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Canvas>.NativeClassPtr, "<externBeginRenderOverlays>k__BackingField");
		NativeFieldInfoPtr__externRenderOverlaysBefore_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Canvas>.NativeClassPtr, "<externRenderOverlaysBefore>k__BackingField");
		NativeFieldInfoPtr__externEndRenderOverlays_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Canvas>.NativeClassPtr, "<externEndRenderOverlays>k__BackingField");
		NativeMethodInfoPtr_add_preWillRenderCanvases_Public_Static_add_Void_WillRenderCanvases_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Canvas>.NativeClassPtr, 100663388);
		NativeMethodInfoPtr_remove_preWillRenderCanvases_Public_Static_rem_Void_WillRenderCanvases_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Canvas>.NativeClassPtr, 100663389);
		NativeMethodInfoPtr_add_willRenderCanvases_Public_Static_add_Void_WillRenderCanvases_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Canvas>.NativeClassPtr, 100663390);
		NativeMethodInfoPtr_remove_willRenderCanvases_Public_Static_rem_Void_WillRenderCanvases_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Canvas>.NativeClassPtr, 100663391);
		NativeMethodInfoPtr_get_renderMode_Public_get_RenderMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Canvas>.NativeClassPtr, 100663392);
		NativeMethodInfoPtr_set_renderMode_Public_set_Void_RenderMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Canvas>.NativeClassPtr, 100663393);
		NativeMethodInfoPtr_get_isRootCanvas_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Canvas>.NativeClassPtr, 100663394);
		NativeMethodInfoPtr_get_pixelRect_Public_get_Rect_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Canvas>.NativeClassPtr, 100663395);
		NativeMethodInfoPtr_get_scaleFactor_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Canvas>.NativeClassPtr, 100663396);
		NativeMethodInfoPtr_set_scaleFactor_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Canvas>.NativeClassPtr, 100663397);
		NativeMethodInfoPtr_get_referencePixelsPerUnit_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Canvas>.NativeClassPtr, 100663398);
		NativeMethodInfoPtr_set_referencePixelsPerUnit_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Canvas>.NativeClassPtr, 100663399);
		NativeMethodInfoPtr_get_pixelPerfect_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Canvas>.NativeClassPtr, 100663400);
		NativeMethodInfoPtr_get_planeDistance_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Canvas>.NativeClassPtr, 100663401);
		NativeMethodInfoPtr_set_planeDistance_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Canvas>.NativeClassPtr, 100663402);
		NativeMethodInfoPtr_get_renderOrder_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Canvas>.NativeClassPtr, 100663403);
		NativeMethodInfoPtr_get_overrideSorting_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Canvas>.NativeClassPtr, 100663404);
		NativeMethodInfoPtr_set_overrideSorting_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Canvas>.NativeClassPtr, 100663405);
		NativeMethodInfoPtr_get_sortingOrder_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Canvas>.NativeClassPtr, 100663406);
		NativeMethodInfoPtr_set_sortingOrder_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Canvas>.NativeClassPtr, 100663407);
		NativeMethodInfoPtr_get_targetDisplay_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Canvas>.NativeClassPtr, 100663408);
		NativeMethodInfoPtr_get_sortingLayerID_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Canvas>.NativeClassPtr, 100663409);
		NativeMethodInfoPtr_set_sortingLayerID_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Canvas>.NativeClassPtr, 100663410);
		NativeMethodInfoPtr_get_additionalShaderChannels_Public_get_AdditionalCanvasShaderChannels_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Canvas>.NativeClassPtr, 100663411);
		NativeMethodInfoPtr_set_additionalShaderChannels_Public_set_Void_AdditionalCanvasShaderChannels_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Canvas>.NativeClassPtr, 100663412);
		NativeMethodInfoPtr_get_rootCanvas_Public_get_Canvas_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Canvas>.NativeClassPtr, 100663413);
		NativeMethodInfoPtr_get_renderingDisplaySize_Public_get_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Canvas>.NativeClassPtr, 100663414);
		NativeMethodInfoPtr_get_externBeginRenderOverlays_Internal_Static_get_Action_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Canvas>.NativeClassPtr, 100663415);
		NativeMethodInfoPtr_set_externBeginRenderOverlays_Internal_Static_set_Void_Action_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Canvas>.NativeClassPtr, 100663416);
		NativeMethodInfoPtr_get_externRenderOverlaysBefore_Internal_Static_get_Action_2_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Canvas>.NativeClassPtr, 100663417);
		NativeMethodInfoPtr_set_externRenderOverlaysBefore_Internal_Static_set_Void_Action_2_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Canvas>.NativeClassPtr, 100663418);
		NativeMethodInfoPtr_get_externEndRenderOverlays_Internal_Static_get_Action_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Canvas>.NativeClassPtr, 100663419);
		NativeMethodInfoPtr_set_externEndRenderOverlays_Internal_Static_set_Void_Action_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Canvas>.NativeClassPtr, 100663420);
		NativeMethodInfoPtr_SetExternalCanvasEnabled_Internal_Static_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Canvas>.NativeClassPtr, 100663421);
		NativeMethodInfoPtr_get_worldCamera_Public_get_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Canvas>.NativeClassPtr, 100663422);
		NativeMethodInfoPtr_set_worldCamera_Public_set_Void_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Canvas>.NativeClassPtr, 100663423);
		NativeMethodInfoPtr_GetDefaultCanvasMaterial_Public_Static_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Canvas>.NativeClassPtr, 100663424);
		NativeMethodInfoPtr_GetETC1SupportedCanvasMaterial_Public_Static_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Canvas>.NativeClassPtr, 100663425);
		NativeMethodInfoPtr_ForceUpdateCanvases_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Canvas>.NativeClassPtr, 100663426);
		NativeMethodInfoPtr_SendPreWillRenderCanvases_Private_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Canvas>.NativeClassPtr, 100663427);
		NativeMethodInfoPtr_SendWillRenderCanvases_Private_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Canvas>.NativeClassPtr, 100663428);
		NativeMethodInfoPtr_BeginRenderExtraOverlays_Private_Static_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Canvas>.NativeClassPtr, 100663429);
		NativeMethodInfoPtr_RenderExtraOverlaysBefore_Private_Static_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Canvas>.NativeClassPtr, 100663430);
		NativeMethodInfoPtr_EndRenderExtraOverlays_Private_Static_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Canvas>.NativeClassPtr, 100663431);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Canvas>.NativeClassPtr, 100663432);
		NativeMethodInfoPtr_get_renderMode_Injected_Private_Static_RenderMode_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Canvas>.NativeClassPtr, 100663433);
		NativeMethodInfoPtr_set_renderMode_Injected_Private_Static_Void_IntPtr_RenderMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Canvas>.NativeClassPtr, 100663434);
		NativeMethodInfoPtr_get_isRootCanvas_Injected_Private_Static_Boolean_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Canvas>.NativeClassPtr, 100663435);
		NativeMethodInfoPtr_get_pixelRect_Injected_Private_Static_Void_IntPtr_byref_Rect_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Canvas>.NativeClassPtr, 100663436);
		NativeMethodInfoPtr_get_scaleFactor_Injected_Private_Static_Single_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Canvas>.NativeClassPtr, 100663437);
		NativeMethodInfoPtr_set_scaleFactor_Injected_Private_Static_Void_IntPtr_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Canvas>.NativeClassPtr, 100663438);
		NativeMethodInfoPtr_get_referencePixelsPerUnit_Injected_Private_Static_Single_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Canvas>.NativeClassPtr, 100663439);
		NativeMethodInfoPtr_set_referencePixelsPerUnit_Injected_Private_Static_Void_IntPtr_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Canvas>.NativeClassPtr, 100663440);
		NativeMethodInfoPtr_get_pixelPerfect_Injected_Private_Static_Boolean_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Canvas>.NativeClassPtr, 100663441);
		NativeMethodInfoPtr_get_planeDistance_Injected_Private_Static_Single_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Canvas>.NativeClassPtr, 100663442);
		NativeMethodInfoPtr_set_planeDistance_Injected_Private_Static_Void_IntPtr_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Canvas>.NativeClassPtr, 100663443);
		NativeMethodInfoPtr_get_renderOrder_Injected_Private_Static_Int32_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Canvas>.NativeClassPtr, 100663444);
		NativeMethodInfoPtr_get_overrideSorting_Injected_Private_Static_Boolean_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Canvas>.NativeClassPtr, 100663445);
		NativeMethodInfoPtr_set_overrideSorting_Injected_Private_Static_Void_IntPtr_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Canvas>.NativeClassPtr, 100663446);
		NativeMethodInfoPtr_get_sortingOrder_Injected_Private_Static_Int32_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Canvas>.NativeClassPtr, 100663447);
		NativeMethodInfoPtr_set_sortingOrder_Injected_Private_Static_Void_IntPtr_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Canvas>.NativeClassPtr, 100663448);
		NativeMethodInfoPtr_get_targetDisplay_Injected_Private_Static_Int32_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Canvas>.NativeClassPtr, 100663449);
		NativeMethodInfoPtr_get_sortingLayerID_Injected_Private_Static_Int32_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Canvas>.NativeClassPtr, 100663450);
		NativeMethodInfoPtr_set_sortingLayerID_Injected_Private_Static_Void_IntPtr_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Canvas>.NativeClassPtr, 100663451);
		NativeMethodInfoPtr_get_additionalShaderChannels_Injected_Private_Static_AdditionalCanvasShaderChannels_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Canvas>.NativeClassPtr, 100663452);
		NativeMethodInfoPtr_set_additionalShaderChannels_Injected_Private_Static_Void_IntPtr_AdditionalCanvasShaderChannels_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Canvas>.NativeClassPtr, 100663453);
		NativeMethodInfoPtr_get_rootCanvas_Injected_Private_Static_IntPtr_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Canvas>.NativeClassPtr, 100663454);
		NativeMethodInfoPtr_get_renderingDisplaySize_Injected_Private_Static_Void_IntPtr_byref_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Canvas>.NativeClassPtr, 100663455);
		NativeMethodInfoPtr_get_worldCamera_Injected_Private_Static_IntPtr_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Canvas>.NativeClassPtr, 100663456);
		NativeMethodInfoPtr_set_worldCamera_Injected_Private_Static_Void_IntPtr_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Canvas>.NativeClassPtr, 100663457);
		NativeMethodInfoPtr_GetDefaultCanvasMaterial_Injected_Private_Static_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Canvas>.NativeClassPtr, 100663458);
		NativeMethodInfoPtr_GetETC1SupportedCanvasMaterial_Injected_Private_Static_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Canvas>.NativeClassPtr, 100663459);
		get_overridePixelPerfect_InjectedDelegateField = IL2CPP.ResolveICall<get_overridePixelPerfect_InjectedDelegate>("UnityEngine.Canvas::get_overridePixelPerfect_Injected");
		set_overridePixelPerfect_InjectedDelegateField = IL2CPP.ResolveICall<set_overridePixelPerfect_InjectedDelegate>("UnityEngine.Canvas::set_overridePixelPerfect_Injected");
		get_vertexColorAlwaysGammaSpace_InjectedDelegateField = IL2CPP.ResolveICall<get_vertexColorAlwaysGammaSpace_InjectedDelegate>("UnityEngine.Canvas::get_vertexColorAlwaysGammaSpace_Injected");
		set_vertexColorAlwaysGammaSpace_InjectedDelegateField = IL2CPP.ResolveICall<set_vertexColorAlwaysGammaSpace_InjectedDelegate>("UnityEngine.Canvas::set_vertexColorAlwaysGammaSpace_Injected");
		set_pixelPerfect_InjectedDelegateField = IL2CPP.ResolveICall<set_pixelPerfect_InjectedDelegate>("UnityEngine.Canvas::set_pixelPerfect_Injected");
		set_targetDisplay_InjectedDelegateField = IL2CPP.ResolveICall<set_targetDisplay_InjectedDelegate>("UnityEngine.Canvas::set_targetDisplay_Injected");
		get_cachedSortingLayerValue_InjectedDelegateField = IL2CPP.ResolveICall<get_cachedSortingLayerValue_InjectedDelegate>("UnityEngine.Canvas::get_cachedSortingLayerValue_Injected");
		get_sortingLayerName_InjectedDelegateField = IL2CPP.ResolveICall<get_sortingLayerName_InjectedDelegate>("UnityEngine.Canvas::get_sortingLayerName_Injected");
		set_sortingLayerName_InjectedDelegateField = IL2CPP.ResolveICall<set_sortingLayerName_InjectedDelegate>("UnityEngine.Canvas::set_sortingLayerName_Injected");
		get_updateRectTransformForStandalone_InjectedDelegateField = IL2CPP.ResolveICall<get_updateRectTransformForStandalone_InjectedDelegate>("UnityEngine.Canvas::get_updateRectTransformForStandalone_Injected");
		set_updateRectTransformForStandalone_InjectedDelegateField = IL2CPP.ResolveICall<set_updateRectTransformForStandalone_InjectedDelegate>("UnityEngine.Canvas::set_updateRectTransformForStandalone_Injected");
		get_normalizedSortingGridSize_InjectedDelegateField = IL2CPP.ResolveICall<get_normalizedSortingGridSize_InjectedDelegate>("UnityEngine.Canvas::get_normalizedSortingGridSize_Injected");
		set_normalizedSortingGridSize_InjectedDelegateField = IL2CPP.ResolveICall<set_normalizedSortingGridSize_InjectedDelegate>("UnityEngine.Canvas::set_normalizedSortingGridSize_Injected");
		get_sortingGridNormalizedSize_InjectedDelegateField = IL2CPP.ResolveICall<get_sortingGridNormalizedSize_InjectedDelegate>("UnityEngine.Canvas::get_sortingGridNormalizedSize_Injected");
		set_sortingGridNormalizedSize_InjectedDelegateField = IL2CPP.ResolveICall<set_sortingGridNormalizedSize_InjectedDelegate>("UnityEngine.Canvas::set_sortingGridNormalizedSize_Injected");
		GetDefaultCanvasTextMaterial_InjectedDelegateField = IL2CPP.ResolveICall<GetDefaultCanvasTextMaterial_InjectedDelegate>("UnityEngine.Canvas::GetDefaultCanvasTextMaterial_Injected");
		UpdateCanvasRectTransform_InjectedDelegateField = IL2CPP.ResolveICall<UpdateCanvasRectTransform_InjectedDelegate>("UnityEngine.Canvas::UpdateCanvasRectTransform_Injected");
	}

	[SpecialName]
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1407101, RefRangeEnd = 1407102, XrefRangeStart = 1407094, XrefRangeEnd = 1407101, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void add_preWillRenderCanvases(WillRenderCanvases value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_add_preWillRenderCanvases_Public_Static_add_Void_WillRenderCanvases_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[SpecialName]
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1407109, RefRangeEnd = 1407110, XrefRangeStart = 1407102, XrefRangeEnd = 1407109, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void remove_preWillRenderCanvases(WillRenderCanvases value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_remove_preWillRenderCanvases_Public_Static_rem_Void_WillRenderCanvases_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[SpecialName]
	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 1407117, RefRangeEnd = 1407121, XrefRangeStart = 1407110, XrefRangeEnd = 1407117, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void add_willRenderCanvases(WillRenderCanvases value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_add_willRenderCanvases_Public_Static_add_Void_WillRenderCanvases_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[SpecialName]
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1407121, XrefRangeEnd = 1407128, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void remove_willRenderCanvases(WillRenderCanvases value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_remove_willRenderCanvases_Public_Static_rem_Void_WillRenderCanvases_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1407375, RefRangeEnd = 1407377, XrefRangeStart = 1407373, XrefRangeEnd = 1407375, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SetExternalCanvasEnabled(bool enabled)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&enabled);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetExternalCanvasEnabled_Internal_Static_Void_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1407453, RefRangeEnd = 1407455, XrefRangeStart = 1407448, XrefRangeEnd = 1407453, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Material GetDefaultCanvasMaterial()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetDefaultCanvasMaterial_Public_Static_Material_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1407460, RefRangeEnd = 1407462, XrefRangeStart = 1407455, XrefRangeEnd = 1407460, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Material GetETC1SupportedCanvasMaterial()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetETC1SupportedCanvasMaterial_Public_Static_Material_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
	}

	[CallerCount(13)]
	[CachedScanResults(RefRangeStart = 1407466, RefRangeEnd = 1407479, XrefRangeStart = 1407462, XrefRangeEnd = 1407466, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void ForceUpdateCanvases()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ForceUpdateCanvases_Public_Static_Void_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1407479, XrefRangeEnd = 1407481, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SendPreWillRenderCanvases()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SendPreWillRenderCanvases_Private_Static_Void_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1407481, XrefRangeEnd = 1407483, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SendWillRenderCanvases()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SendWillRenderCanvases_Private_Static_Void_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1407483, XrefRangeEnd = 1407485, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void BeginRenderExtraOverlays(int displayIndex)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&displayIndex);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_BeginRenderExtraOverlays_Private_Static_Void_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1407485, XrefRangeEnd = 1407487, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void RenderExtraOverlaysBefore(int displayIndex, int sortingOrder)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&displayIndex);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &sortingOrder;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RenderExtraOverlaysBefore_Private_Static_Void_Int32_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1407487, XrefRangeEnd = 1407489, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void EndRenderExtraOverlays(int displayIndex)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&displayIndex);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_EndRenderExtraOverlays_Private_Static_Void_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(646)]
	[CachedScanResults(RefRangeStart = 1152221, RefRangeEnd = 1152867, XrefRangeStart = 1152221, XrefRangeEnd = 1152867, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Canvas()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Canvas>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1407489, XrefRangeEnd = 1407491, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static RenderMode get_renderMode_Injected(System.IntPtr _unity_self)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&_unity_self);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_renderMode_Injected_Private_Static_RenderMode_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(RenderMode*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1407491, XrefRangeEnd = 1407493, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void set_renderMode_Injected(System.IntPtr _unity_self, RenderMode value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&_unity_self);
		*(RenderMode**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &value;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_renderMode_Injected_Private_Static_Void_IntPtr_RenderMode_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1407493, XrefRangeEnd = 1407495, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool get_isRootCanvas_Injected(System.IntPtr _unity_self)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&_unity_self);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_isRootCanvas_Injected_Private_Static_Boolean_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1407495, XrefRangeEnd = 1407497, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void get_pixelRect_Injected(System.IntPtr _unity_self, out Rect ret)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&_unity_self);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref ret);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_pixelRect_Injected_Private_Static_Void_IntPtr_byref_Rect_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1407497, XrefRangeEnd = 1407499, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static float get_scaleFactor_Injected(System.IntPtr _unity_self)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&_unity_self);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_scaleFactor_Injected_Private_Static_Single_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1407499, XrefRangeEnd = 1407501, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void set_scaleFactor_Injected(System.IntPtr _unity_self, float value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&_unity_self);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &value;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_scaleFactor_Injected_Private_Static_Void_IntPtr_Single_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1407501, XrefRangeEnd = 1407503, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static float get_referencePixelsPerUnit_Injected(System.IntPtr _unity_self)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&_unity_self);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_referencePixelsPerUnit_Injected_Private_Static_Single_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1407503, XrefRangeEnd = 1407505, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void set_referencePixelsPerUnit_Injected(System.IntPtr _unity_self, float value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&_unity_self);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &value;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_referencePixelsPerUnit_Injected_Private_Static_Void_IntPtr_Single_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1407505, XrefRangeEnd = 1407507, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool get_pixelPerfect_Injected(System.IntPtr _unity_self)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&_unity_self);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_pixelPerfect_Injected_Private_Static_Boolean_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1407507, XrefRangeEnd = 1407509, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static float get_planeDistance_Injected(System.IntPtr _unity_self)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&_unity_self);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_planeDistance_Injected_Private_Static_Single_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1407509, XrefRangeEnd = 1407511, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void set_planeDistance_Injected(System.IntPtr _unity_self, float value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&_unity_self);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &value;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_planeDistance_Injected_Private_Static_Void_IntPtr_Single_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1407511, XrefRangeEnd = 1407513, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int get_renderOrder_Injected(System.IntPtr _unity_self)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&_unity_self);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_renderOrder_Injected_Private_Static_Int32_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1407513, XrefRangeEnd = 1407515, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool get_overrideSorting_Injected(System.IntPtr _unity_self)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&_unity_self);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_overrideSorting_Injected_Private_Static_Boolean_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1407515, XrefRangeEnd = 1407517, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void set_overrideSorting_Injected(System.IntPtr _unity_self, bool value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&_unity_self);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &value;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_overrideSorting_Injected_Private_Static_Void_IntPtr_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1407517, XrefRangeEnd = 1407519, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int get_sortingOrder_Injected(System.IntPtr _unity_self)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&_unity_self);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_sortingOrder_Injected_Private_Static_Int32_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1407519, XrefRangeEnd = 1407521, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void set_sortingOrder_Injected(System.IntPtr _unity_self, int value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&_unity_self);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &value;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_sortingOrder_Injected_Private_Static_Void_IntPtr_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1407521, XrefRangeEnd = 1407523, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int get_targetDisplay_Injected(System.IntPtr _unity_self)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&_unity_self);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_targetDisplay_Injected_Private_Static_Int32_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1407523, XrefRangeEnd = 1407525, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int get_sortingLayerID_Injected(System.IntPtr _unity_self)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&_unity_self);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_sortingLayerID_Injected_Private_Static_Int32_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1407525, XrefRangeEnd = 1407527, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void set_sortingLayerID_Injected(System.IntPtr _unity_self, int value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&_unity_self);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &value;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_sortingLayerID_Injected_Private_Static_Void_IntPtr_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1407527, XrefRangeEnd = 1407529, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static AdditionalCanvasShaderChannels get_additionalShaderChannels_Injected(System.IntPtr _unity_self)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&_unity_self);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_additionalShaderChannels_Injected_Private_Static_AdditionalCanvasShaderChannels_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(AdditionalCanvasShaderChannels*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1407529, XrefRangeEnd = 1407531, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void set_additionalShaderChannels_Injected(System.IntPtr _unity_self, AdditionalCanvasShaderChannels value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&_unity_self);
		*(AdditionalCanvasShaderChannels**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &value;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_additionalShaderChannels_Injected_Private_Static_Void_IntPtr_AdditionalCanvasShaderChannels_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1407531, XrefRangeEnd = 1407533, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static System.IntPtr get_rootCanvas_Injected(System.IntPtr _unity_self)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&_unity_self);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_rootCanvas_Injected_Private_Static_IntPtr_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(System.IntPtr*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1407533, XrefRangeEnd = 1407535, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void get_renderingDisplaySize_Injected(System.IntPtr _unity_self, out Vector2 ret)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&_unity_self);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref ret);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_renderingDisplaySize_Injected_Private_Static_Void_IntPtr_byref_Vector2_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1407535, XrefRangeEnd = 1407537, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static System.IntPtr get_worldCamera_Injected(System.IntPtr _unity_self)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&_unity_self);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_worldCamera_Injected_Private_Static_IntPtr_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(System.IntPtr*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1407537, XrefRangeEnd = 1407539, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void set_worldCamera_Injected(System.IntPtr _unity_self, System.IntPtr value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&_unity_self);
		*(System.IntPtr**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &value;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_worldCamera_Injected_Private_Static_Void_IntPtr_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1407539, XrefRangeEnd = 1407541, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static System.IntPtr GetDefaultCanvasMaterial_Injected()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetDefaultCanvasMaterial_Injected_Private_Static_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(System.IntPtr*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1407541, XrefRangeEnd = 1407543, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static System.IntPtr GetETC1SupportedCanvasMaterial_Injected()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetETC1SupportedCanvasMaterial_Injected_Private_Static_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(System.IntPtr*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	public Canvas(System.IntPtr pointer)
		: base(pointer)
	{
	}

	public static Material GetDefaultCanvasTextMaterial()
	{
		return Unmarshal.UnmarshalUnityObject<Material>(GetDefaultCanvasTextMaterial_Injected());
	}

	public void UpdateCanvasRectTransform(bool alignWithCamera)
	{
		System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		UpdateCanvasRectTransform_Injected(intPtr, alignWithCamera);
	}

	public static bool get_overridePixelPerfect_Injected(System.IntPtr _unity_self)
	{
		return get_overridePixelPerfect_InjectedDelegateField(_unity_self);
	}

	public static void set_overridePixelPerfect_Injected(System.IntPtr _unity_self, bool value)
	{
		set_overridePixelPerfect_InjectedDelegateField(_unity_self, value);
	}

	public static bool get_vertexColorAlwaysGammaSpace_Injected(System.IntPtr _unity_self)
	{
		return get_vertexColorAlwaysGammaSpace_InjectedDelegateField(_unity_self);
	}

	public static void set_vertexColorAlwaysGammaSpace_Injected(System.IntPtr _unity_self, bool value)
	{
		set_vertexColorAlwaysGammaSpace_InjectedDelegateField(_unity_self, value);
	}

	public static void set_pixelPerfect_Injected(System.IntPtr _unity_self, bool value)
	{
		set_pixelPerfect_InjectedDelegateField(_unity_self, value);
	}

	public static void set_targetDisplay_Injected(System.IntPtr _unity_self, int value)
	{
		set_targetDisplay_InjectedDelegateField(_unity_self, value);
	}

	public static int get_cachedSortingLayerValue_Injected(System.IntPtr _unity_self)
	{
		return get_cachedSortingLayerValue_InjectedDelegateField(_unity_self);
	}

	public unsafe static void get_sortingLayerName_Injected(System.IntPtr _unity_self, out ManagedSpanWrapper ret)
	{
		get_sortingLayerName_InjectedDelegateField(_unity_self, (nint)Unsafe.AsPointer(ref ret));
	}

	public unsafe static void set_sortingLayerName_Injected(System.IntPtr _unity_self, ref ManagedSpanWrapper value)
	{
		set_sortingLayerName_InjectedDelegateField(_unity_self, (nint)Unsafe.AsPointer(ref value));
	}

	public static StandaloneRenderResize get_updateRectTransformForStandalone_Injected(System.IntPtr _unity_self)
	{
		return get_updateRectTransformForStandalone_InjectedDelegateField(_unity_self);
	}

	public static void set_updateRectTransformForStandalone_Injected(System.IntPtr _unity_self, StandaloneRenderResize value)
	{
		set_updateRectTransformForStandalone_InjectedDelegateField(_unity_self, value);
	}

	public static float get_normalizedSortingGridSize_Injected(System.IntPtr _unity_self)
	{
		return get_normalizedSortingGridSize_InjectedDelegateField(_unity_self);
	}

	public static void set_normalizedSortingGridSize_Injected(System.IntPtr _unity_self, float value)
	{
		set_normalizedSortingGridSize_InjectedDelegateField(_unity_self, value);
	}

	public static int get_sortingGridNormalizedSize_Injected(System.IntPtr _unity_self)
	{
		return get_sortingGridNormalizedSize_InjectedDelegateField(_unity_self);
	}

	public static void set_sortingGridNormalizedSize_Injected(System.IntPtr _unity_self, int value)
	{
		set_sortingGridNormalizedSize_InjectedDelegateField(_unity_self, value);
	}

	public static System.IntPtr GetDefaultCanvasTextMaterial_Injected()
	{
		return GetDefaultCanvasTextMaterial_InjectedDelegateField();
	}

	public static void UpdateCanvasRectTransform_Injected(System.IntPtr _unity_self, bool alignWithCamera)
	{
		UpdateCanvasRectTransform_InjectedDelegateField(_unity_self, alignWithCamera);
	}
}
