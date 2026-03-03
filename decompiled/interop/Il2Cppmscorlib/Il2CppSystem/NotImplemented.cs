using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem;

public static class NotImplemented : Object
{
	private static readonly System.IntPtr NativeMethodInfoPtr_get_ByDesign_Internal_Static_get_Exception_0;

	public unsafe static Exception ByDesign
	{
		[CallerCount(16)]
		[CachedScanResults(RefRangeStart = 748933, RefRangeEnd = 748949, XrefRangeStart = 748929, XrefRangeEnd = 748933, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_ByDesign_Internal_Static_get_Exception_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Exception>(intPtr2) : null;
		}
	}

	static NotImplemented()
	{
		Il2CppClassPointerStore<NotImplemented>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System", "NotImplemented");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NotImplemented>.NativeClassPtr);
		NativeMethodInfoPtr_get_ByDesign_Internal_Static_get_Exception_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NotImplemented>.NativeClassPtr, 100666292);
	}

	public NotImplemented(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
