using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace Il2CppSystem.Net.NetworkInformation;

public class IPv4InterfaceStatistics : Object
{
	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

	static IPv4InterfaceStatistics()
	{
		Il2CppClassPointerStore<IPv4InterfaceStatistics>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Net.NetworkInformation", "IPv4InterfaceStatistics");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IPv4InterfaceStatistics>.NativeClassPtr);
		NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPv4InterfaceStatistics>.NativeClassPtr, 100667107);
	}

	[CallerCount(1950)]
	[CachedScanResults(RefRangeStart = 20036, RefRangeEnd = 21986, XrefRangeStart = 20036, XrefRangeEnd = 21986, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe IPv4InterfaceStatistics()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<IPv4InterfaceStatistics>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public IPv4InterfaceStatistics(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
