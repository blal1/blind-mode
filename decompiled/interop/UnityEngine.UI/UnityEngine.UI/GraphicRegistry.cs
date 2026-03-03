using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine.UI.Collections;

namespace UnityEngine.UI;

public class GraphicRegistry : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_s_Instance;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_Graphics;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_RaycastableGraphics;

	private static readonly System.IntPtr NativeFieldInfoPtr_s_EmptyList;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_instance_Public_Static_get_GraphicRegistry_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RegisterGraphicForCanvas_Public_Static_Void_Canvas_Graphic_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RegisterRaycastGraphicForCanvas_Public_Static_Void_Canvas_Graphic_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UnregisterGraphicForCanvas_Public_Static_Void_Canvas_Graphic_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UnregisterRaycastGraphicForCanvas_Public_Static_Void_Canvas_Graphic_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DisableGraphicForCanvas_Public_Static_Void_Canvas_Graphic_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DisableRaycastGraphicForCanvas_Public_Static_Void_Canvas_Graphic_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetGraphicsForCanvas_Public_Static_IList_1_Graphic_Canvas_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetRaycastableGraphicsForCanvas_Public_Static_IList_1_Graphic_Canvas_0;

	public unsafe static GraphicRegistry s_Instance
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_s_Instance, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<GraphicRegistry>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_s_Instance, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe Dictionary<Canvas, IndexedSet<Graphic>> m_Graphics
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Graphics);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<Canvas, IndexedSet<Graphic>>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Graphics)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe Dictionary<Canvas, IndexedSet<Graphic>> m_RaycastableGraphics
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_RaycastableGraphics);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<Canvas, IndexedSet<Graphic>>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_RaycastableGraphics)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static List<Graphic> s_EmptyList
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_s_EmptyList, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<Graphic>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_s_EmptyList, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static GraphicRegistry instance
	{
		[CallerCount(17)]
		[CachedScanResults(RefRangeStart = 1289435, RefRangeEnd = 1289452, XrefRangeStart = 1289385, XrefRangeEnd = 1289435, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_instance_Public_Static_get_GraphicRegistry_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<GraphicRegistry>(intPtr2) : null;
		}
	}

	static GraphicRegistry()
	{
		Il2CppClassPointerStore<GraphicRegistry>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UI.dll", "UnityEngine.UI", "GraphicRegistry");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GraphicRegistry>.NativeClassPtr);
		NativeFieldInfoPtr_s_Instance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GraphicRegistry>.NativeClassPtr, "s_Instance");
		NativeFieldInfoPtr_m_Graphics = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GraphicRegistry>.NativeClassPtr, "m_Graphics");
		NativeFieldInfoPtr_m_RaycastableGraphics = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GraphicRegistry>.NativeClassPtr, "m_RaycastableGraphics");
		NativeFieldInfoPtr_s_EmptyList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GraphicRegistry>.NativeClassPtr, "s_EmptyList");
		NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphicRegistry>.NativeClassPtr, 100663602);
		NativeMethodInfoPtr_get_instance_Public_Static_get_GraphicRegistry_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphicRegistry>.NativeClassPtr, 100663603);
		NativeMethodInfoPtr_RegisterGraphicForCanvas_Public_Static_Void_Canvas_Graphic_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphicRegistry>.NativeClassPtr, 100663604);
		NativeMethodInfoPtr_RegisterRaycastGraphicForCanvas_Public_Static_Void_Canvas_Graphic_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphicRegistry>.NativeClassPtr, 100663605);
		NativeMethodInfoPtr_UnregisterGraphicForCanvas_Public_Static_Void_Canvas_Graphic_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphicRegistry>.NativeClassPtr, 100663606);
		NativeMethodInfoPtr_UnregisterRaycastGraphicForCanvas_Public_Static_Void_Canvas_Graphic_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphicRegistry>.NativeClassPtr, 100663607);
		NativeMethodInfoPtr_DisableGraphicForCanvas_Public_Static_Void_Canvas_Graphic_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphicRegistry>.NativeClassPtr, 100663608);
		NativeMethodInfoPtr_DisableRaycastGraphicForCanvas_Public_Static_Void_Canvas_Graphic_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphicRegistry>.NativeClassPtr, 100663609);
		NativeMethodInfoPtr_GetGraphicsForCanvas_Public_Static_IList_1_Graphic_Canvas_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphicRegistry>.NativeClassPtr, 100663610);
		NativeMethodInfoPtr_GetRaycastableGraphicsForCanvas_Public_Static_IList_1_Graphic_Canvas_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphicRegistry>.NativeClassPtr, 100663611);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1289348, XrefRangeEnd = 1289385, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe GraphicRegistry()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GraphicRegistry>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 1289483, RefRangeEnd = 1289487, XrefRangeStart = 1289452, XrefRangeEnd = 1289483, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void RegisterGraphicForCanvas(Canvas c, Graphic graphic)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)c);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)graphic);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RegisterGraphicForCanvas_Public_Static_Void_Canvas_Graphic_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 1289517, RefRangeEnd = 1289520, XrefRangeStart = 1289487, XrefRangeEnd = 1289517, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void RegisterRaycastGraphicForCanvas(Canvas c, Graphic graphic)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)c);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)graphic);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RegisterRaycastGraphicForCanvas_Public_Static_Void_Canvas_Graphic_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(6)]
	[CachedScanResults(RefRangeStart = 1289549, RefRangeEnd = 1289555, XrefRangeStart = 1289520, XrefRangeEnd = 1289549, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void UnregisterGraphicForCanvas(Canvas c, Graphic graphic)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)c);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)graphic);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UnregisterGraphicForCanvas_Public_Static_Void_Canvas_Graphic_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1289579, RefRangeEnd = 1289581, XrefRangeStart = 1289555, XrefRangeEnd = 1289579, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void UnregisterRaycastGraphicForCanvas(Canvas c, Graphic graphic)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)c);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)graphic);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UnregisterRaycastGraphicForCanvas_Public_Static_Void_Canvas_Graphic_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1289629, RefRangeEnd = 1289630, XrefRangeStart = 1289581, XrefRangeEnd = 1289629, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void DisableGraphicForCanvas(Canvas c, Graphic graphic)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)c);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)graphic);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DisableGraphicForCanvas_Public_Static_Void_Canvas_Graphic_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1289630, XrefRangeEnd = 1289653, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void DisableRaycastGraphicForCanvas(Canvas c, Graphic graphic)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)c);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)graphic);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DisableRaycastGraphicForCanvas_Public_Static_Void_Canvas_Graphic_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1289663, RefRangeEnd = 1289664, XrefRangeStart = 1289653, XrefRangeEnd = 1289663, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static IList<Graphic> GetGraphicsForCanvas(Canvas canvas)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)canvas);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetGraphicsForCanvas_Public_Static_IList_1_Graphic_Canvas_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<IList<Graphic>>(intPtr2) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1289664, XrefRangeEnd = 1289674, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static IList<Graphic> GetRaycastableGraphicsForCanvas(Canvas canvas)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)canvas);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetRaycastableGraphicsForCanvas_Public_Static_IList_1_Graphic_Canvas_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<IList<Graphic>>(intPtr2) : null;
	}

	public GraphicRegistry(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
