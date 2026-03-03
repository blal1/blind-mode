using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppZXing.Common;

namespace Il2CppZXing.OneD.RSS.Expanded;

public static class BitArrayBuilder : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeMethodInfoPtr_buildBitArray_Internal_Static_BitArray_List_1_ExpandedPair_0;

	static BitArrayBuilder()
	{
		Il2CppClassPointerStore<BitArrayBuilder>.NativeClassPtr = IL2CPP.GetIl2CppClass("zxing.unity.dll", "ZXing.OneD.RSS.Expanded", "BitArrayBuilder");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BitArrayBuilder>.NativeClassPtr);
		NativeMethodInfoPtr_buildBitArray_Internal_Static_BitArray_List_1_ExpandedPair_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BitArrayBuilder>.NativeClassPtr, 100664291);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1424428, RefRangeEnd = 1424429, XrefRangeStart = 1424412, XrefRangeEnd = 1424428, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static BitArray buildBitArray(List<ExpandedPair> pairs)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)pairs);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_buildBitArray_Internal_Static_BitArray_List_1_ExpandedPair_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<BitArray>(intPtr2) : null;
	}

	public BitArrayBuilder(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
