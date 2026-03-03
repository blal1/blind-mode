using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Net.Cache;

public class RequestCacheValidator : Object
{
	private static readonly System.IntPtr NativeMethodInfoPtr_CreateValidator_Public_Object_0;

	static RequestCacheValidator()
	{
		Il2CppClassPointerStore<RequestCacheValidator>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Net.Cache", "RequestCacheValidator");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RequestCacheValidator>.NativeClassPtr);
		NativeMethodInfoPtr_CreateValidator_Public_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RequestCacheValidator>.NativeClassPtr, 100667157);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 897417, RefRangeEnd = 897419, XrefRangeStart = 897403, XrefRangeEnd = 897417, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Object CreateValidator()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CreateValidator_Public_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
	}

	public RequestCacheValidator(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
