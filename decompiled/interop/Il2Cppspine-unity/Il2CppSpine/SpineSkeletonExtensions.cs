using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem;

namespace Il2CppSpine;

public static class SpineSkeletonExtensions : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeMethodInfoPtr_IsWeighted_Public_Static_Boolean_VertexAttachment_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_InheritsRotation_Public_Static_Boolean_Inherit_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_InheritsScale_Public_Static_Boolean_Inherit_0;

	static SpineSkeletonExtensions()
	{
		Il2CppClassPointerStore<SpineSkeletonExtensions>.NativeClassPtr = IL2CPP.GetIl2CppClass("spine-unity.dll", "Spine", "SpineSkeletonExtensions");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SpineSkeletonExtensions>.NativeClassPtr);
		NativeMethodInfoPtr_IsWeighted_Public_Static_Boolean_VertexAttachment_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpineSkeletonExtensions>.NativeClassPtr, 100663304);
		NativeMethodInfoPtr_InheritsRotation_Public_Static_Boolean_Inherit_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpineSkeletonExtensions>.NativeClassPtr, 100663305);
		NativeMethodInfoPtr_InheritsScale_Public_Static_Boolean_Inherit_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpineSkeletonExtensions>.NativeClassPtr, 100663306);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 850140, RefRangeEnd = 850144, XrefRangeStart = 850140, XrefRangeEnd = 850140, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool IsWeighted(this VertexAttachment va)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)va);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsWeighted_Public_Static_Boolean_VertexAttachment_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	public unsafe static bool InheritsRotation(this Inherit mode)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&mode);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InheritsRotation_Public_Static_Boolean_Inherit_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 850144, RefRangeEnd = 850145, XrefRangeStart = 850144, XrefRangeEnd = 850144, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool InheritsScale(this Inherit mode)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&mode);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InheritsScale_Public_Static_Boolean_Inherit_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	public SpineSkeletonExtensions(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
