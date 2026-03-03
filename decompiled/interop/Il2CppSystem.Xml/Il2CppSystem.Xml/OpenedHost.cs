using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace Il2CppSystem.Xml;

public class OpenedHost : Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_nonCachedConnectionsCount;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe int nonCachedConnectionsCount
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_nonCachedConnectionsCount);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_nonCachedConnectionsCount)) = value;
		}
	}

	static OpenedHost()
	{
		Il2CppClassPointerStore<OpenedHost>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml", "OpenedHost");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<OpenedHost>.NativeClassPtr);
		NativeFieldInfoPtr_nonCachedConnectionsCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OpenedHost>.NativeClassPtr, "nonCachedConnectionsCount");
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OpenedHost>.NativeClassPtr, 100665058);
	}

	[CallerCount(1950)]
	[CachedScanResults(RefRangeStart = 20036, RefRangeEnd = 21986, XrefRangeStart = 20036, XrefRangeEnd = 21986, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe OpenedHost()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<OpenedHost>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public OpenedHost(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
