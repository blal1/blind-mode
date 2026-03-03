using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.Rendering;

public static class HaltonSequence : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeMethodInfoPtr_Get_Public_Static_Single_Int32_Int32_0;

	static HaltonSequence()
	{
		Il2CppClassPointerStore<HaltonSequence>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Core.Runtime.dll", "UnityEngine.Rendering", "HaltonSequence");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HaltonSequence>.NativeClassPtr);
		NativeMethodInfoPtr_Get_Public_Static_Single_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HaltonSequence>.NativeClassPtr, 100666737);
	}

	[CallerCount(10)]
	[CachedScanResults(RefRangeStart = 1053109, RefRangeEnd = 1053119, XrefRangeStart = 1053109, XrefRangeEnd = 1053109, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static float Get(int index, int radix)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&index);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &radix;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Get_Public_Static_Single_Int32_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	public HaltonSequence(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
