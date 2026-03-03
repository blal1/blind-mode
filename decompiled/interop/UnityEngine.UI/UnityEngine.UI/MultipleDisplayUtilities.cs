using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem;
using UnityEngine.EventSystems;

namespace UnityEngine.UI;

public static class MultipleDisplayUtilities : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeMethodInfoPtr_GetRelativeMousePositionForDrag_Public_Static_Boolean_PointerEventData_byref_Vector2_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetRelativeMousePositionForRaycast_Internal_Static_Vector3_PointerEventData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RelativeMouseAtScaled_Public_Static_Vector3_Vector2_Int32_0;

	static MultipleDisplayUtilities()
	{
		Il2CppClassPointerStore<MultipleDisplayUtilities>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UI.dll", "UnityEngine.UI", "MultipleDisplayUtilities");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MultipleDisplayUtilities>.NativeClassPtr);
		NativeMethodInfoPtr_GetRelativeMousePositionForDrag_Public_Static_Boolean_PointerEventData_byref_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MultipleDisplayUtilities>.NativeClassPtr, 100664166);
		NativeMethodInfoPtr_GetRelativeMousePositionForRaycast_Internal_Static_Vector3_PointerEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MultipleDisplayUtilities>.NativeClassPtr, 100664167);
		NativeMethodInfoPtr_RelativeMouseAtScaled_Public_Static_Vector3_Vector2_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MultipleDisplayUtilities>.NativeClassPtr, 100664168);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 1295000, RefRangeEnd = 1295004, XrefRangeStart = 1294998, XrefRangeEnd = 1295000, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool GetRelativeMousePositionForDrag(PointerEventData eventData, ref Vector2 position)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)eventData);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref position);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetRelativeMousePositionForDrag_Public_Static_Boolean_PointerEventData_byref_Vector2_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 1295007, RefRangeEnd = 1295010, XrefRangeStart = 1295004, XrefRangeEnd = 1295007, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Vector3 GetRelativeMousePositionForRaycast(PointerEventData eventData)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)eventData);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetRelativeMousePositionForRaycast_Internal_Static_Vector3_PointerEventData_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(Vector3*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 1295023, RefRangeEnd = 1295026, XrefRangeStart = 1295010, XrefRangeEnd = 1295023, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Vector3 RelativeMouseAtScaled(Vector2 position, int displayIndex)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&position);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &displayIndex;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RelativeMouseAtScaled_Public_Static_Vector3_Vector2_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(Vector3*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	public MultipleDisplayUtilities(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
