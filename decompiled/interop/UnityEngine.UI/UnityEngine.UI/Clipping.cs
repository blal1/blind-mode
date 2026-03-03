using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace UnityEngine.UI;

public static class Clipping : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeMethodInfoPtr_FindCullAndClipWorldRect_Public_Static_Rect_List_1_RectMask2D_byref_Boolean_0;

	static Clipping()
	{
		Il2CppClassPointerStore<Clipping>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UI.dll", "UnityEngine.UI", "Clipping");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Clipping>.NativeClassPtr);
		NativeMethodInfoPtr_FindCullAndClipWorldRect_Public_Static_Rect_List_1_RectMask2D_byref_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Clipping>.NativeClassPtr, 100663377);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 1286143, RefRangeEnd = 1286147, XrefRangeStart = 1286130, XrefRangeEnd = 1286143, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Rect FindCullAndClipWorldRect(List<RectMask2D> rectMaskParents, out bool validRect)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)rectMaskParents);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref validRect);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FindCullAndClipWorldRect_Public_Static_Rect_List_1_RectMask2D_byref_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(Rect*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	public Clipping(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
