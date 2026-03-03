using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Net.Cache;

public class RequestCacheBinding : Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_m_RequestCache;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_CacheValidator;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_Cache_Internal_get_RequestCache_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_Validator_Internal_get_RequestCacheValidator_0;

	public unsafe RequestCache m_RequestCache
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_RequestCache);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<RequestCache>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_RequestCache)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe RequestCacheValidator m_CacheValidator
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_CacheValidator);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<RequestCacheValidator>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_CacheValidator)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe RequestCache Cache
	{
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 50644, RefRangeEnd = 50653, XrefRangeStart = 50644, XrefRangeEnd = 50653, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_Cache_Internal_get_RequestCache_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<RequestCache>(intPtr2) : null;
		}
	}

	public unsafe RequestCacheValidator Validator
	{
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 25665, RefRangeEnd = 25677, XrefRangeStart = 25665, XrefRangeEnd = 25677, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_Validator_Internal_get_RequestCacheValidator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<RequestCacheValidator>(intPtr2) : null;
		}
	}

	static RequestCacheBinding()
	{
		Il2CppClassPointerStore<RequestCacheBinding>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Net.Cache", "RequestCacheBinding");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RequestCacheBinding>.NativeClassPtr);
		NativeFieldInfoPtr_m_RequestCache = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RequestCacheBinding>.NativeClassPtr, "m_RequestCache");
		NativeFieldInfoPtr_m_CacheValidator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RequestCacheBinding>.NativeClassPtr, "m_CacheValidator");
		NativeMethodInfoPtr_get_Cache_Internal_get_RequestCache_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RequestCacheBinding>.NativeClassPtr, 100667158);
		NativeMethodInfoPtr_get_Validator_Internal_get_RequestCacheValidator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RequestCacheBinding>.NativeClassPtr, 100667159);
	}

	public RequestCacheBinding(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
