using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace UnityEngine.UI;

public class MaskUtilities : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeMethodInfoPtr_Notify2DMaskStateChanged_Public_Static_Void_Component_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_NotifyStencilStateChanged_Public_Static_Void_Component_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FindRootSortOverrideCanvas_Public_Static_Transform_Transform_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetStencilDepth_Public_Static_Int32_Transform_Transform_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsDescendantOrSelf_Public_Static_Boolean_Transform_Transform_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetRectMaskForClippable_Public_Static_RectMask2D_IClippable_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetRectMasksForClip_Public_Static_Void_RectMask2D_List_1_RectMask2D_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	static MaskUtilities()
	{
		Il2CppClassPointerStore<MaskUtilities>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UI.dll", "UnityEngine.UI", "MaskUtilities");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MaskUtilities>.NativeClassPtr);
		NativeMethodInfoPtr_Notify2DMaskStateChanged_Public_Static_Void_Component_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaskUtilities>.NativeClassPtr, 100664155);
		NativeMethodInfoPtr_NotifyStencilStateChanged_Public_Static_Void_Component_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaskUtilities>.NativeClassPtr, 100664156);
		NativeMethodInfoPtr_FindRootSortOverrideCanvas_Public_Static_Transform_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaskUtilities>.NativeClassPtr, 100664157);
		NativeMethodInfoPtr_GetStencilDepth_Public_Static_Int32_Transform_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaskUtilities>.NativeClassPtr, 100664158);
		NativeMethodInfoPtr_IsDescendantOrSelf_Public_Static_Boolean_Transform_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaskUtilities>.NativeClassPtr, 100664159);
		NativeMethodInfoPtr_GetRectMaskForClippable_Public_Static_RectMask2D_IClippable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaskUtilities>.NativeClassPtr, 100664160);
		NativeMethodInfoPtr_GetRectMasksForClip_Public_Static_Void_RectMask2D_List_1_RectMask2D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaskUtilities>.NativeClassPtr, 100664161);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaskUtilities>.NativeClassPtr, 100664162);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 1294711, RefRangeEnd = 1294715, XrefRangeStart = 1294673, XrefRangeEnd = 1294711, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void Notify2DMaskStateChanged(Component mask)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)mask);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Notify2DMaskStateChanged_Public_Static_Void_Component_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 1294753, RefRangeEnd = 1294757, XrefRangeStart = 1294715, XrefRangeEnd = 1294753, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void NotifyStencilStateChanged(Component mask)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)mask);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_NotifyStencilStateChanged_Public_Static_Void_Component_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 1294782, RefRangeEnd = 1294786, XrefRangeStart = 1294757, XrefRangeEnd = 1294782, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Transform FindRootSortOverrideCanvas(Transform start)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)start);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FindRootSortOverrideCanvas_Public_Static_Transform_Transform_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 1294826, RefRangeEnd = 1294830, XrefRangeStart = 1294786, XrefRangeEnd = 1294826, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int GetStencilDepth(Transform transform, Transform stopAfter)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)transform);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)stopAfter);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetStencilDepth_Public_Static_Int32_Transform_Transform_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1294850, RefRangeEnd = 1294852, XrefRangeStart = 1294830, XrefRangeEnd = 1294850, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool IsDescendantOrSelf(Transform father, Transform child)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)father);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)child);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsDescendantOrSelf_Public_Static_Boolean_Transform_Transform_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1294909, RefRangeEnd = 1294910, XrefRangeStart = 1294852, XrefRangeEnd = 1294909, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static RectMask2D GetRectMaskForClippable(IClippable clippable)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)clippable);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetRectMaskForClippable_Public_Static_RectMask2D_IClippable_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<RectMask2D>(intPtr2) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1294964, RefRangeEnd = 1294965, XrefRangeStart = 1294910, XrefRangeEnd = 1294964, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void GetRectMasksForClip(RectMask2D clipper, List<RectMask2D> masks)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)clipper);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)masks);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetRectMasksForClip_Public_Static_Void_RectMask2D_List_1_RectMask2D_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1950)]
	[CachedScanResults(RefRangeStart = 20036, RefRangeEnd = 21986, XrefRangeStart = 20036, XrefRangeEnd = 21986, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe MaskUtilities()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MaskUtilities>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public MaskUtilities(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
