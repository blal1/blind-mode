using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;

namespace Il2CppZXing.OneD.RSS;

public static class RSSUtils : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeMethodInfoPtr_getRSSvalue_Public_Static_Int32_Il2CppStructArray_1_Int32_Int32_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_combins_Private_Static_Int32_Int32_Int32_0;

	static RSSUtils()
	{
		Il2CppClassPointerStore<RSSUtils>.NativeClassPtr = IL2CPP.GetIl2CppClass("zxing.unity.dll", "ZXing.OneD.RSS", "RSSUtils");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RSSUtils>.NativeClassPtr);
		NativeMethodInfoPtr_getRSSvalue_Public_Static_Int32_Il2CppStructArray_1_Int32_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RSSUtils>.NativeClassPtr, 100664289);
		NativeMethodInfoPtr_combins_Private_Static_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RSSUtils>.NativeClassPtr, 100664290);
	}

	[CallerCount(6)]
	[CachedScanResults(RefRangeStart = 1424403, RefRangeEnd = 1424409, XrefRangeStart = 1424397, XrefRangeEnd = 1424403, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int getRSSvalue(Il2CppStructArray<int> widths, int maxWidth, bool noNarrow)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)widths);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &maxWidth;
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &noNarrow;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_getRSSvalue_Public_Static_Int32_Il2CppStructArray_1_Int32_Int32_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 1424409, RefRangeEnd = 1424412, XrefRangeStart = 1424409, XrefRangeEnd = 1424409, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int combins(int n, int r)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&n);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &r;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_combins_Private_Static_Int32_Int32_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	public RSSUtils(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
