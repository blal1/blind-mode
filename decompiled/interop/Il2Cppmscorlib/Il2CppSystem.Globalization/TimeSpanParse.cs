using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Globalization;

public static class TimeSpanParse : Object
{
	private static readonly System.IntPtr NativeMethodInfoPtr_Pow10_Internal_Static_Int64_Int32_0;

	static TimeSpanParse()
	{
		Il2CppClassPointerStore<TimeSpanParse>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Globalization", "TimeSpanParse");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TimeSpanParse>.NativeClassPtr);
		NativeMethodInfoPtr_Pow10_Internal_Static_Int64_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeSpanParse>.NativeClassPtr, 100672816);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 817911, RefRangeEnd = 817914, XrefRangeStart = 817910, XrefRangeEnd = 817911, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static long Pow10(int pow)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&pow);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Pow10_Internal_Static_Int64_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(long*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	public TimeSpanParse(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
