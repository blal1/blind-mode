using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace Il2CppSystem;

public static class IOSelector : Object
{
	private static readonly System.IntPtr NativeMethodInfoPtr_Add_Public_Static_Void_IntPtr_IOSelectorJob_0;

	static IOSelector()
	{
		Il2CppClassPointerStore<IOSelector>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System", "IOSelector");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IOSelector>.NativeClassPtr);
		NativeMethodInfoPtr_Add_Public_Static_Void_IntPtr_IOSelectorJob_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IOSelector>.NativeClassPtr, 100664362);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 871756, RefRangeEnd = 871757, XrefRangeStart = 871755, XrefRangeEnd = 871756, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void Add(System.IntPtr handle, IOSelectorJob job)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&handle);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)job);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Add_Public_Static_Void_IntPtr_IOSelectorJob_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public IOSelector(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
