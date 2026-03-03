using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem.Configuration;

namespace Il2CppSystem.Net.Configuration;

public sealed class NetSectionGroup : ConfigurationSectionGroup
{
	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	static NetSectionGroup()
	{
		Il2CppClassPointerStore<NetSectionGroup>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Net.Configuration", "NetSectionGroup");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NetSectionGroup>.NativeClassPtr);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetSectionGroup>.NativeClassPtr, 100667554);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 900596, XrefRangeEnd = 900599, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe NetSectionGroup()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NetSectionGroup>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public NetSectionGroup(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
