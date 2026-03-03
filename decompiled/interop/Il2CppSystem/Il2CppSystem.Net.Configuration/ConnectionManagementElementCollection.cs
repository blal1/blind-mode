using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem.Configuration;

namespace Il2CppSystem.Net.Configuration;

[DefaultMember("Item")]
public sealed class ConnectionManagementElementCollection : ConfigurationElementCollection
{
	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	static ConnectionManagementElementCollection()
	{
		Il2CppClassPointerStore<ConnectionManagementElementCollection>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Net.Configuration", "ConnectionManagementElementCollection");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ConnectionManagementElementCollection>.NativeClassPtr);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConnectionManagementElementCollection>.NativeClassPtr, 100667542);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 900560, XrefRangeEnd = 900563, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ConnectionManagementElementCollection()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ConnectionManagementElementCollection>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public ConnectionManagementElementCollection(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
