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

public sealed class RectTransformUtility : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_s_Corners;

	private static readonly System.IntPtr NativeMethodInfoPtr_PixelAdjustPoint_Public_Static_Vector2_Vector2_Transform_Canvas_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_PixelAdjustRect_Public_Static_Rect_RectTransform_Canvas_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_PointInRectangle_Private_Static_Boolean_Vector2_RectTransform_Camera_Vector4_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RectangleContainsScreenPoint_Public_Static_Boolean_RectTransform_Vector2_Camera_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RectangleContainsScreenPoint_Public_Static_Boolean_RectTransform_Vector2_Camera_Vector4_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ScreenPointToWorldPointInRectangle_Public_Static_Boolean_RectTransform_Vector2_Camera_byref_Vector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ScreenPointToLocalPointInRectangle_Public_Static_Boolean_RectTransform_Vector2_Camera_byref_Vector2_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ScreenPointToRay_Public_Static_Ray_Camera_Vector2_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_WorldToScreenPoint_Public_Static_Vector2_Camera_Vector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CalculateRelativeRectTransformBounds_Public_Static_Bounds_Transform_Transform_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FlipLayoutOnAxis_Public_Static_Void_RectTransform_Int32_Boolean_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FlipLayoutAxes_Public_Static_Void_RectTransform_Boolean_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetTransposed_Private_Static_Vector2_Vector2_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_PixelAdjustPoint_Injected_Private_Static_Void_byref_Vector2_IntPtr_IntPtr_byref_Vector2_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_PixelAdjustRect_Injected_Private_Static_Void_IntPtr_IntPtr_byref_Rect_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_PointInRectangle_Injected_Private_Static_Boolean_byref_Vector2_IntPtr_IntPtr_byref_Vector4_0;

	public unsafe static Il2CppStructArray<Vector3> s_Corners
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_s_Corners, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<Vector3>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_s_Corners, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	static RectTransformUtility()
	{
		Il2CppClassPointerStore<RectTransformUtility>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIModule.dll", "UnityEngine", "RectTransformUtility");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RectTransformUtility>.NativeClassPtr);
		NativeFieldInfoPtr_s_Corners = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RectTransformUtility>.NativeClassPtr, "s_Corners");
		NativeMethodInfoPtr_PixelAdjustPoint_Public_Static_Vector2_Vector2_Transform_Canvas_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RectTransformUtility>.NativeClassPtr, 100663371);
		NativeMethodInfoPtr_PixelAdjustRect_Public_Static_Rect_RectTransform_Canvas_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RectTransformUtility>.NativeClassPtr, 100663372);
		NativeMethodInfoPtr_PointInRectangle_Private_Static_Boolean_Vector2_RectTransform_Camera_Vector4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RectTransformUtility>.NativeClassPtr, 100663373);
		NativeMethodInfoPtr_RectangleContainsScreenPoint_Public_Static_Boolean_RectTransform_Vector2_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RectTransformUtility>.NativeClassPtr, 100663374);
		NativeMethodInfoPtr_RectangleContainsScreenPoint_Public_Static_Boolean_RectTransform_Vector2_Camera_Vector4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RectTransformUtility>.NativeClassPtr, 100663375);
		NativeMethodInfoPtr_ScreenPointToWorldPointInRectangle_Public_Static_Boolean_RectTransform_Vector2_Camera_byref_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RectTransformUtility>.NativeClassPtr, 100663376);
		NativeMethodInfoPtr_ScreenPointToLocalPointInRectangle_Public_Static_Boolean_RectTransform_Vector2_Camera_byref_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RectTransformUtility>.NativeClassPtr, 100663377);
		NativeMethodInfoPtr_ScreenPointToRay_Public_Static_Ray_Camera_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RectTransformUtility>.NativeClassPtr, 100663378);
		NativeMethodInfoPtr_WorldToScreenPoint_Public_Static_Vector2_Camera_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RectTransformUtility>.NativeClassPtr, 100663379);
		NativeMethodInfoPtr_CalculateRelativeRectTransformBounds_Public_Static_Bounds_Transform_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RectTransformUtility>.NativeClassPtr, 100663380);
		NativeMethodInfoPtr_FlipLayoutOnAxis_Public_Static_Void_RectTransform_Int32_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RectTransformUtility>.NativeClassPtr, 100663381);
		NativeMethodInfoPtr_FlipLayoutAxes_Public_Static_Void_RectTransform_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RectTransformUtility>.NativeClassPtr, 100663382);
		NativeMethodInfoPtr_GetTransposed_Private_Static_Vector2_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RectTransformUtility>.NativeClassPtr, 100663383);
		NativeMethodInfoPtr_PixelAdjustPoint_Injected_Private_Static_Void_byref_Vector2_IntPtr_IntPtr_byref_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RectTransformUtility>.NativeClassPtr, 100663385);
		NativeMethodInfoPtr_PixelAdjustRect_Injected_Private_Static_Void_IntPtr_IntPtr_byref_Rect_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RectTransformUtility>.NativeClassPtr, 100663386);
		NativeMethodInfoPtr_PointInRectangle_Injected_Private_Static_Boolean_byref_Vector2_IntPtr_IntPtr_byref_Vector4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RectTransformUtility>.NativeClassPtr, 100663387);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1406823, RefRangeEnd = 1406824, XrefRangeStart = 1406811, XrefRangeEnd = 1406823, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Vector2 PixelAdjustPoint(Vector2 point, Transform elementTransform, Canvas canvas)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&point);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)elementTransform);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)canvas);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_PixelAdjustPoint_Public_Static_Vector2_Vector2_Transform_Canvas_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(Vector2*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1406836, RefRangeEnd = 1406837, XrefRangeStart = 1406824, XrefRangeEnd = 1406836, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Rect PixelAdjustRect(RectTransform rectTransform, Canvas canvas)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)rectTransform);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)canvas);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_PixelAdjustRect_Public_Static_Rect_RectTransform_Canvas_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(Rect*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1406837, XrefRangeEnd = 1406849, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool PointInRectangle(Vector2 screenPoint, RectTransform rect, Camera cam, Vector4 offset)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = (nint)(&screenPoint);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)rect);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)cam);
		*(Vector4**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &offset;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_PointInRectangle_Private_Static_Boolean_Vector2_RectTransform_Camera_Vector4_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(8)]
	[CachedScanResults(RefRangeStart = 1406869, RefRangeEnd = 1406877, XrefRangeStart = 1406849, XrefRangeEnd = 1406869, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool RectangleContainsScreenPoint(RectTransform rect, Vector2 screenPoint, Camera cam)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)rect);
		*(Vector2**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &screenPoint;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)cam);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RectangleContainsScreenPoint_Public_Static_Boolean_RectTransform_Vector2_Camera_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1406892, RefRangeEnd = 1406894, XrefRangeStart = 1406877, XrefRangeEnd = 1406892, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool RectangleContainsScreenPoint(RectTransform rect, Vector2 screenPoint, Camera cam, Vector4 offset)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)rect);
		*(Vector2**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &screenPoint;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)cam);
		*(Vector4**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &offset;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RectangleContainsScreenPoint_Public_Static_Boolean_RectTransform_Vector2_Camera_Vector4_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(8)]
	[CachedScanResults(RefRangeStart = 1406920, RefRangeEnd = 1406928, XrefRangeStart = 1406894, XrefRangeEnd = 1406920, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool ScreenPointToWorldPointInRectangle(RectTransform rect, Vector2 screenPoint, Camera cam, out Vector3 worldPoint)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)rect);
		*(Vector2**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &screenPoint;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)cam);
		*(void**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref worldPoint);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ScreenPointToWorldPointInRectangle_Public_Static_Boolean_RectTransform_Vector2_Camera_byref_Vector3_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(40)]
	[CachedScanResults(RefRangeStart = 1406934, RefRangeEnd = 1406974, XrefRangeStart = 1406928, XrefRangeEnd = 1406934, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool ScreenPointToLocalPointInRectangle(RectTransform rect, Vector2 screenPoint, Camera cam, out Vector2 localPoint)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)rect);
		*(Vector2**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &screenPoint;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)cam);
		*(void**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref localPoint);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ScreenPointToLocalPointInRectangle_Public_Static_Boolean_RectTransform_Vector2_Camera_byref_Vector2_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1406983, RefRangeEnd = 1406984, XrefRangeStart = 1406974, XrefRangeEnd = 1406983, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Ray ScreenPointToRay(Camera cam, Vector2 screenPos)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)cam);
		*(Vector2**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &screenPos;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ScreenPointToRay_Public_Static_Ray_Camera_Vector2_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(Ray*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(10)]
	[CachedScanResults(RefRangeStart = 1406989, RefRangeEnd = 1406999, XrefRangeStart = 1406984, XrefRangeEnd = 1406989, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Vector2 WorldToScreenPoint(Camera cam, Vector3 worldPoint)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)cam);
		*(Vector3**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &worldPoint;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_WorldToScreenPoint_Public_Static_Vector2_Camera_Vector3_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(Vector2*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 1407019, RefRangeEnd = 1407023, XrefRangeStart = 1406999, XrefRangeEnd = 1407019, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Bounds CalculateRelativeRectTransformBounds(Transform root, Transform child)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)root);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)child);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CalculateRelativeRectTransformBounds_Public_Static_Bounds_Transform_Transform_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(Bounds*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 1407050, RefRangeEnd = 1407055, XrefRangeStart = 1407023, XrefRangeEnd = 1407050, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void FlipLayoutOnAxis(RectTransform rect, int axis, bool keepPositioning, bool recursive)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)rect);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &axis;
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &keepPositioning;
		*(bool**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &recursive;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FlipLayoutOnAxis_Public_Static_Void_RectTransform_Int32_Boolean_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 1407085, RefRangeEnd = 1407088, XrefRangeStart = 1407055, XrefRangeEnd = 1407085, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void FlipLayoutAxes(RectTransform rect, bool keepPositioning, bool recursive)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)rect);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &keepPositioning;
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &recursive;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FlipLayoutAxes_Public_Static_Void_RectTransform_Boolean_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	public unsafe static Vector2 GetTransposed(Vector2 input)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&input);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetTransposed_Private_Static_Vector2_Vector2_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(Vector2*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1407088, XrefRangeEnd = 1407090, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void PixelAdjustPoint_Injected([In] ref Vector2 point, System.IntPtr elementTransform, System.IntPtr canvas, out Vector2 ret)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = (nint)Unsafe.AsPointer(ref point);
		*(System.IntPtr**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &elementTransform;
		*(System.IntPtr**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &canvas;
		*(void**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref ret);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_PixelAdjustPoint_Injected_Private_Static_Void_byref_Vector2_IntPtr_IntPtr_byref_Vector2_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1407090, XrefRangeEnd = 1407092, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void PixelAdjustRect_Injected(System.IntPtr rectTransform, System.IntPtr canvas, out Rect ret)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&rectTransform);
		*(System.IntPtr**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &canvas;
		*(void**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref ret);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_PixelAdjustRect_Injected_Private_Static_Void_IntPtr_IntPtr_byref_Rect_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1407092, XrefRangeEnd = 1407094, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool PointInRectangle_Injected([In] ref Vector2 screenPoint, System.IntPtr rect, System.IntPtr cam, [In] ref Vector4 offset)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = (nint)Unsafe.AsPointer(ref screenPoint);
		*(System.IntPtr**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &rect;
		*(System.IntPtr**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &cam;
		*(void**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref offset);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_PointInRectangle_Injected_Private_Static_Boolean_byref_Vector2_IntPtr_IntPtr_byref_Vector4_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	public RectTransformUtility(System.IntPtr pointer)
		: base(pointer)
	{
	}

	public static bool RectangleContainsScreenPoint(RectTransform rect, Vector2 screenPoint)
	{
		return RectangleContainsScreenPoint(rect, screenPoint, null);
	}

	public static Bounds CalculateRelativeRectTransformBounds(Transform trans)
	{
		return CalculateRelativeRectTransformBounds(trans, trans);
	}
}
