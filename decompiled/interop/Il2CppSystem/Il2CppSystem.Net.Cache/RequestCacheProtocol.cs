using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace Il2CppSystem.Net.Cache;

public class RequestCacheProtocol : Object
{
	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_Object_0;

	static RequestCacheProtocol()
	{
		Il2CppClassPointerStore<RequestCacheProtocol>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Net.Cache", "RequestCacheProtocol");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RequestCacheProtocol>.NativeClassPtr);
		NativeMethodInfoPtr__ctor_Public_Void_Object_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RequestCacheProtocol>.NativeClassPtr, 100667163);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 897432, RefRangeEnd = 897434, XrefRangeStart = 897426, XrefRangeEnd = 897432, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe RequestCacheProtocol(Object arg1, Object arg2)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RequestCacheProtocol>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)arg1);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)arg2);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Object_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public RequestCacheProtocol(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
