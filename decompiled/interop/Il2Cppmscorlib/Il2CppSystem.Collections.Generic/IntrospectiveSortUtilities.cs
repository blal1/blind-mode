using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace Il2CppSystem.Collections.Generic;

public static class IntrospectiveSortUtilities : Object
{
	private static readonly System.IntPtr NativeMethodInfoPtr_FloorLog2PlusOne_Internal_Static_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ThrowOrIgnoreBadComparer_Internal_Static_Void_Object_0;

	static IntrospectiveSortUtilities()
	{
		Il2CppClassPointerStore<IntrospectiveSortUtilities>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Collections.Generic", "IntrospectiveSortUtilities");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IntrospectiveSortUtilities>.NativeClassPtr);
		NativeMethodInfoPtr_FloorLog2PlusOne_Internal_Static_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IntrospectiveSortUtilities>.NativeClassPtr, 100674221);
		NativeMethodInfoPtr_ThrowOrIgnoreBadComparer_Internal_Static_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IntrospectiveSortUtilities>.NativeClassPtr, 100674222);
	}

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 832628, RefRangeEnd = 832633, XrefRangeStart = 832628, XrefRangeEnd = 832628, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int FloorLog2PlusOne(int n)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&n);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FloorLog2PlusOne_Internal_Static_Int32_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 832640, RefRangeEnd = 832645, XrefRangeStart = 832633, XrefRangeEnd = 832640, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void ThrowOrIgnoreBadComparer(Object comparer)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)comparer);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ThrowOrIgnoreBadComparer_Internal_Static_Void_Object_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public IntrospectiveSortUtilities(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
