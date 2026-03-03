using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppSteamworks;

public class DllCheck : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeMethodInfoPtr_Test_Public_Static_Boolean_0;

	static DllCheck()
	{
		Il2CppClassPointerStore<DllCheck>.NativeClassPtr = IL2CPP.GetIl2CppClass("com.rlabrecque.steamworks.net.dll", "Steamworks", "DllCheck");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DllCheck>.NativeClassPtr);
		NativeMethodInfoPtr_Test_Public_Static_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DllCheck>.NativeClassPtr, 100663432);
	}

	[CallerCount(27)]
	[CachedScanResults(RefRangeStart = 61071, RefRangeEnd = 61098, XrefRangeStart = 61071, XrefRangeEnd = 61098, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool Test()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Test_Public_Static_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	public DllCheck(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
