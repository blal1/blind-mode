using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine;

public class Display : Il2CppSystem.Object
{
	public sealed class DisplaysUpdatedDelegate : Il2CppSystem.MulticastDelegate
	{
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_0;

		static DisplaysUpdatedDelegate()
		{
			Il2CppClassPointerStore<DisplaysUpdatedDelegate>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Display>.NativeClassPtr, "DisplaysUpdatedDelegate");
			NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DisplaysUpdatedDelegate>.NativeClassPtr, 100664304);
			NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DisplaysUpdatedDelegate>.NativeClassPtr, 100664305);
		}

		[CallerCount(4109)]
		[CachedScanResults(RefRangeStart = 27728, RefRangeEnd = 31837, XrefRangeStart = 27728, XrefRangeEnd = 31837, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DisplaysUpdatedDelegate(Il2CppSystem.Object @object, System.IntPtr method)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DisplaysUpdatedDelegate>.NativeClassPtr))
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

		public DisplaysUpdatedDelegate(System.IntPtr pointer)
			: base(pointer)
		{
		}

		public static implicit operator DisplaysUpdatedDelegate(System.Action P_0)
		{
			return DelegateSupport.ConvertDelegate<DisplaysUpdatedDelegate>((System.Delegate)P_0);
		}

		public static DisplaysUpdatedDelegate operator +(DisplaysUpdatedDelegate P_0, DisplaysUpdatedDelegate P_1)
		{
			return ((Il2CppObjectBase)Il2CppSystem.Delegate.Combine(P_0, P_1)).Cast<DisplaysUpdatedDelegate>();
		}

		public static DisplaysUpdatedDelegate operator -(DisplaysUpdatedDelegate P_0, DisplaysUpdatedDelegate P_1)
		{
			object obj = Il2CppSystem.Delegate.Remove(P_0, P_1);
			if (obj != null)
			{
				obj = ((Il2CppObjectBase)obj).Cast<DisplaysUpdatedDelegate>();
			}
			return (DisplaysUpdatedDelegate)obj;
		}
	}

	private delegate void GetRenderingBuffersImplDelegate(System.IntPtr nativeDisplay, [Out] System.IntPtr color, [Out] System.IntPtr depth);

	private delegate void SetRenderingResolutionImplDelegate(System.IntPtr nativeDisplay, int w, int h);

	private delegate void SetParamsImplDelegate(System.IntPtr nativeDisplay, int width, int height, int x, int y);

	private delegate bool GetActiveImplDelegate(System.IntPtr nativeDisplay);

	private delegate bool RequiresBlitToBackbufferImplDelegate(System.IntPtr nativeDisplay);

	private delegate void ActivateDisplayImpl_InjectedDelegate(System.IntPtr nativeDisplay, int width, int height, [In] System.IntPtr refreshRate);

	private static readonly System.IntPtr NativeFieldInfoPtr_nativeDisplay;

	private static readonly System.IntPtr NativeFieldInfoPtr_displays;

	private static readonly System.IntPtr NativeFieldInfoPtr__mainDisplay;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_ActiveEditorGameViewTarget;

	private static readonly System.IntPtr NativeFieldInfoPtr_onDisplaysUpdated;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Internal_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_renderingWidth_Public_get_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_renderingHeight_Public_get_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_systemWidth_Public_get_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_systemHeight_Public_get_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_requiresSrgbBlitToBackbuffer_Public_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RelativeMouseAt_Public_Static_Vector3_Vector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_main_Public_Static_get_Display_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RecreateDisplayList_Internal_Static_Void_Il2CppStructArray_1_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FireDisplaysUpdated_Internal_Static_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetSystemExtImpl_Private_Static_Void_IntPtr_byref_Int32_byref_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetRenderingExtImpl_Private_Static_Void_IntPtr_byref_Int32_byref_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RelativeMouseAtImpl_Private_Static_Int32_Int32_Int32_byref_Int32_byref_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RequiresSrgbBlitToBackbufferImpl_Private_Static_Boolean_IntPtr_0;

	private static readonly GetRenderingBuffersImplDelegate GetRenderingBuffersImplDelegateField;

	private static readonly SetRenderingResolutionImplDelegate SetRenderingResolutionImplDelegateField;

	private static readonly SetParamsImplDelegate SetParamsImplDelegateField;

	private static readonly GetActiveImplDelegate GetActiveImplDelegateField;

	private static readonly RequiresBlitToBackbufferImplDelegate RequiresBlitToBackbufferImplDelegateField;

	private static readonly ActivateDisplayImpl_InjectedDelegate ActivateDisplayImpl_InjectedDelegateField;

	public unsafe System.IntPtr nativeDisplay
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_nativeDisplay);
			return *(System.IntPtr*)num;
		}
		set
		{
			*(System.IntPtr*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_nativeDisplay)) = value;
		}
	}

	public unsafe static Il2CppReferenceArray<Display> displays
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_displays, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Display>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_displays, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static Display _mainDisplay
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr__mainDisplay, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Display>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr__mainDisplay, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static int m_ActiveEditorGameViewTarget
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_m_ActiveEditorGameViewTarget, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_m_ActiveEditorGameViewTarget, (void*)(&value));
		}
	}

	public unsafe static DisplaysUpdatedDelegate onDisplaysUpdated
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_onDisplaysUpdated, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<DisplaysUpdatedDelegate>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_onDisplaysUpdated, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe int renderingWidth
	{
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1172068, RefRangeEnd = 1172071, XrefRangeStart = 1172063, XrefRangeEnd = 1172068, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_renderingWidth_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe int renderingHeight
	{
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1172076, RefRangeEnd = 1172080, XrefRangeStart = 1172071, XrefRangeEnd = 1172076, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_renderingHeight_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe int systemWidth
	{
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1172085, RefRangeEnd = 1172088, XrefRangeStart = 1172080, XrefRangeEnd = 1172085, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_systemWidth_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe int systemHeight
	{
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 1172093, RefRangeEnd = 1172105, XrefRangeStart = 1172088, XrefRangeEnd = 1172093, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_systemHeight_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe bool requiresSrgbBlitToBackbuffer
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1172110, RefRangeEnd = 1172111, XrefRangeStart = 1172105, XrefRangeEnd = 1172110, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_requiresSrgbBlitToBackbuffer_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe static Display main
	{
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 1172125, RefRangeEnd = 1172130, XrefRangeStart = 1172121, XrefRangeEnd = 1172125, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_main_Public_Static_get_Display_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Display>(intPtr2) : null;
		}
	}

	public RenderBuffer colorBuffer
	{
		get
		{
			GetRenderingBuffersImpl(nativeDisplay, out var color, out var _);
			return color;
		}
	}

	public RenderBuffer depthBuffer
	{
		get
		{
			GetRenderingBuffersImpl(nativeDisplay, out var _, out var depth);
			return depth;
		}
	}

	public bool active => GetActiveImpl(nativeDisplay);

	public bool requiresBlitToBackbuffer
	{
		get
		{
			throw new System.NotSupportedException("Method unstripping failed");
		}
	}

	public static int activeEditorGameViewTarget
	{
		get
		{
			return m_ActiveEditorGameViewTarget;
		}
		set
		{
			m_ActiveEditorGameViewTarget = value;
		}
	}

	static Display()
	{
		Il2CppClassPointerStore<Display>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "Display");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Display>.NativeClassPtr);
		NativeFieldInfoPtr_nativeDisplay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Display>.NativeClassPtr, "nativeDisplay");
		NativeFieldInfoPtr_displays = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Display>.NativeClassPtr, "displays");
		NativeFieldInfoPtr__mainDisplay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Display>.NativeClassPtr, "_mainDisplay");
		NativeFieldInfoPtr_m_ActiveEditorGameViewTarget = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Display>.NativeClassPtr, "m_ActiveEditorGameViewTarget");
		NativeFieldInfoPtr_onDisplaysUpdated = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Display>.NativeClassPtr, "onDisplaysUpdated");
		NativeMethodInfoPtr__ctor_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Display>.NativeClassPtr, 100664288);
		NativeMethodInfoPtr_get_renderingWidth_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Display>.NativeClassPtr, 100664290);
		NativeMethodInfoPtr_get_renderingHeight_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Display>.NativeClassPtr, 100664291);
		NativeMethodInfoPtr_get_systemWidth_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Display>.NativeClassPtr, 100664292);
		NativeMethodInfoPtr_get_systemHeight_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Display>.NativeClassPtr, 100664293);
		NativeMethodInfoPtr_get_requiresSrgbBlitToBackbuffer_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Display>.NativeClassPtr, 100664294);
		NativeMethodInfoPtr_RelativeMouseAt_Public_Static_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Display>.NativeClassPtr, 100664295);
		NativeMethodInfoPtr_get_main_Public_Static_get_Display_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Display>.NativeClassPtr, 100664296);
		NativeMethodInfoPtr_RecreateDisplayList_Internal_Static_Void_Il2CppStructArray_1_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Display>.NativeClassPtr, 100664297);
		NativeMethodInfoPtr_FireDisplaysUpdated_Internal_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Display>.NativeClassPtr, 100664298);
		NativeMethodInfoPtr_GetSystemExtImpl_Private_Static_Void_IntPtr_byref_Int32_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Display>.NativeClassPtr, 100664299);
		NativeMethodInfoPtr_GetRenderingExtImpl_Private_Static_Void_IntPtr_byref_Int32_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Display>.NativeClassPtr, 100664300);
		NativeMethodInfoPtr_RelativeMouseAtImpl_Private_Static_Int32_Int32_Int32_byref_Int32_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Display>.NativeClassPtr, 100664301);
		NativeMethodInfoPtr_RequiresSrgbBlitToBackbufferImpl_Private_Static_Boolean_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Display>.NativeClassPtr, 100664302);
		GetRenderingBuffersImplDelegateField = IL2CPP.ResolveICall<GetRenderingBuffersImplDelegate>("UnityEngine.Display::GetRenderingBuffersImpl");
		SetRenderingResolutionImplDelegateField = IL2CPP.ResolveICall<SetRenderingResolutionImplDelegate>("UnityEngine.Display::SetRenderingResolutionImpl");
		SetParamsImplDelegateField = IL2CPP.ResolveICall<SetParamsImplDelegate>("UnityEngine.Display::SetParamsImpl");
		GetActiveImplDelegateField = IL2CPP.ResolveICall<GetActiveImplDelegate>("UnityEngine.Display::GetActiveImpl");
		RequiresBlitToBackbufferImplDelegateField = IL2CPP.ResolveICall<RequiresBlitToBackbufferImplDelegate>("UnityEngine.Display::RequiresBlitToBackbufferImpl");
		ActivateDisplayImpl_InjectedDelegateField = IL2CPP.ResolveICall<ActivateDisplayImpl_InjectedDelegate>("UnityEngine.Display::ActivateDisplayImpl_Injected");
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1172061, XrefRangeEnd = 1172063, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Display()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Display>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 1172116, RefRangeEnd = 1172121, XrefRangeStart = 1172111, XrefRangeEnd = 1172116, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Vector3 RelativeMouseAt(Vector3 inputMouseCoordinates)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&inputMouseCoordinates);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RelativeMouseAt_Public_Static_Vector3_Vector3_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(Vector3*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1172130, XrefRangeEnd = 1172151, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void RecreateDisplayList(Il2CppStructArray<System.IntPtr> nativeDisplay)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)nativeDisplay);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RecreateDisplayList_Internal_Static_Void_Il2CppStructArray_1_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1172151, XrefRangeEnd = 1172157, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void FireDisplaysUpdated()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FireDisplaysUpdated_Internal_Static_Void_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1172157, XrefRangeEnd = 1172159, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void GetSystemExtImpl(System.IntPtr nativeDisplay, out int w, out int h)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&nativeDisplay);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref w);
		*(void**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref h);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetSystemExtImpl_Private_Static_Void_IntPtr_byref_Int32_byref_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1172159, XrefRangeEnd = 1172161, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void GetRenderingExtImpl(System.IntPtr nativeDisplay, out int w, out int h)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&nativeDisplay);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref w);
		*(void**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref h);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetRenderingExtImpl_Private_Static_Void_IntPtr_byref_Int32_byref_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1172161, XrefRangeEnd = 1172163, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int RelativeMouseAtImpl(int x, int y, out int rx, out int ry)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = (nint)(&x);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &y;
		*(void**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref rx);
		*(void**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref ry);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RelativeMouseAtImpl_Private_Static_Int32_Int32_Int32_byref_Int32_byref_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1172163, XrefRangeEnd = 1172190, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool RequiresSrgbBlitToBackbufferImpl(System.IntPtr nativeDisplay)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&nativeDisplay);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RequiresSrgbBlitToBackbufferImpl_Private_Static_Boolean_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	public Display(System.IntPtr pointer)
		: base(pointer)
	{
	}

	public void Activate()
	{
		ActivateDisplayImpl(nativeDisplay, 0, 0, new RefreshRate
		{
			numerator = 60u,
			denominator = 1u
		});
	}

	public void Activate(int width, int height, RefreshRate refreshRate)
	{
		ActivateDisplayImpl(nativeDisplay, width, height, refreshRate);
	}

	public void Activate(int width, int height, int refreshRate)
	{
		if (refreshRate < 0)
		{
			refreshRate = 0;
		}
		ActivateDisplayImpl(nativeDisplay, width, height, new RefreshRate
		{
			numerator = (uint)refreshRate,
			denominator = 1u
		});
	}

	public void SetParams(int width, int height, int x, int y)
	{
		SetParamsImpl(nativeDisplay, width, height, x, y);
	}

	public void SetRenderingResolution(int w, int h)
	{
		SetRenderingResolutionImpl(nativeDisplay, w, h);
	}

	public static bool MultiDisplayLicense()
	{
		return true;
	}

	[SpecialName]
	public static void add_onDisplaysUpdated(DisplaysUpdatedDelegate value)
	{
		throw new System.NotSupportedException("Method unstripping failed");
	}

	[SpecialName]
	public static void remove_onDisplaysUpdated(DisplaysUpdatedDelegate value)
	{
		throw new System.NotSupportedException("Method unstripping failed");
	}

	public unsafe static void GetRenderingBuffersImpl(System.IntPtr nativeDisplay, out RenderBuffer color, out RenderBuffer depth)
	{
		GetRenderingBuffersImplDelegateField(nativeDisplay, (nint)Unsafe.AsPointer(ref color), (nint)Unsafe.AsPointer(ref depth));
	}

	public static void SetRenderingResolutionImpl(System.IntPtr nativeDisplay, int w, int h)
	{
		SetRenderingResolutionImplDelegateField(nativeDisplay, w, h);
	}

	public static void ActivateDisplayImpl(System.IntPtr nativeDisplay, int width, int height, RefreshRate refreshRate)
	{
		ActivateDisplayImpl_Injected(nativeDisplay, width, height, ref refreshRate);
	}

	public static void SetParamsImpl(System.IntPtr nativeDisplay, int width, int height, int x, int y)
	{
		SetParamsImplDelegateField(nativeDisplay, width, height, x, y);
	}

	public static bool GetActiveImpl(System.IntPtr nativeDisplay)
	{
		return GetActiveImplDelegateField(nativeDisplay);
	}

	public static bool RequiresBlitToBackbufferImpl(System.IntPtr nativeDisplay)
	{
		return RequiresBlitToBackbufferImplDelegateField(nativeDisplay);
	}

	public unsafe static void ActivateDisplayImpl_Injected(System.IntPtr nativeDisplay, int width, int height, [In] ref RefreshRate refreshRate)
	{
		ActivateDisplayImpl_InjectedDelegateField(nativeDisplay, width, height, (nint)Unsafe.AsPointer(ref refreshRate));
	}
}
