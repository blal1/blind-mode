using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem.Configuration;

namespace Il2CppSystem.Net.Configuration;

[DefaultMember("Item")]
public sealed class BypassElementCollection : ConfigurationElementCollection
{
	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	static BypassElementCollection()
	{
		Il2CppClassPointerStore<BypassElementCollection>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Net.Configuration", "BypassElementCollection");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BypassElementCollection>.NativeClassPtr);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BypassElementCollection>.NativeClassPtr, 100667541);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 900557, XrefRangeEnd = 900560, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe BypassElementCollection()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BypassElementCollection>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public BypassElementCollection(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
