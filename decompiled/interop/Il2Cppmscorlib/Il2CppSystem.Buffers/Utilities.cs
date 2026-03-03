using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Buffers;

public static class Utilities : Object
{
	private static readonly System.IntPtr NativeMethodInfoPtr_SelectBucketIndex_Internal_Static_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetMaxSizeForBucket_Internal_Static_Int32_Int32_0;

	static Utilities()
	{
		Il2CppClassPointerStore<Utilities>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Buffers", "Utilities");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Utilities>.NativeClassPtr);
		NativeMethodInfoPtr_SelectBucketIndex_Internal_Static_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Utilities>.NativeClassPtr, 100674368);
		NativeMethodInfoPtr_GetMaxSizeForBucket_Internal_Static_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Utilities>.NativeClassPtr, 100674369);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 833523, RefRangeEnd = 833525, XrefRangeStart = 833523, XrefRangeEnd = 833523, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int SelectBucketIndex(int bufferSize)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&bufferSize);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SelectBucketIndex_Internal_Static_Int32_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	public unsafe static int GetMaxSizeForBucket(int binIndex)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&binIndex);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetMaxSizeForBucket_Internal_Static_Int32_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	public Utilities(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
