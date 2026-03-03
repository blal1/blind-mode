using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Net;

public static class Logging : Object
{
	private static readonly System.IntPtr NativeMethodInfoPtr_get_On_Internal_Static_get_Boolean_0;

	public unsafe static bool On
	{
		[CallerCount(143)]
		[CachedScanResults(RefRangeStart = 9, RefRangeEnd = 152, XrefRangeStart = 9, XrefRangeEnd = 152, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_On_Internal_Static_get_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	static Logging()
	{
		Il2CppClassPointerStore<Logging>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Net", "Logging");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Logging>.NativeClassPtr);
		NativeMethodInfoPtr_get_On_Internal_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Logging>.NativeClassPtr, 100666551);
	}

	public Logging(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
