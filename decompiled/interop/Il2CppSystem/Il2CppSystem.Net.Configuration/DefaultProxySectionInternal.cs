using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Net.Configuration;

public sealed class DefaultProxySectionInternal : Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_webProxy;

	private static readonly System.IntPtr NativeFieldInfoPtr_classSyncObject;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetDefaultProxy_UsingOldMonoCode_Private_Static_IWebProxy_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetSystemWebProxy_Private_Static_IWebProxy_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_ClassSyncObject_Internal_Static_get_Object_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetSection_Internal_Static_DefaultProxySectionInternal_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_WebProxy_Internal_get_IWebProxy_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe IWebProxy webProxy
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_webProxy);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<IWebProxy>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_webProxy)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static Object classSyncObject
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_classSyncObject, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_classSyncObject, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static Object ClassSyncObject
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 897369, XrefRangeEnd = 897378, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_ClassSyncObject_Internal_Static_get_Object_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
		}
	}

	public unsafe IWebProxy WebProxy
	{
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 50644, RefRangeEnd = 50653, XrefRangeStart = 50644, XrefRangeEnd = 50653, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_WebProxy_Internal_get_IWebProxy_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<IWebProxy>(intPtr2) : null;
		}
	}

	static DefaultProxySectionInternal()
	{
		Il2CppClassPointerStore<DefaultProxySectionInternal>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Net.Configuration", "DefaultProxySectionInternal");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DefaultProxySectionInternal>.NativeClassPtr);
		NativeFieldInfoPtr_webProxy = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DefaultProxySectionInternal>.NativeClassPtr, "webProxy");
		NativeFieldInfoPtr_classSyncObject = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DefaultProxySectionInternal>.NativeClassPtr, "classSyncObject");
		NativeMethodInfoPtr_GetDefaultProxy_UsingOldMonoCode_Private_Static_IWebProxy_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultProxySectionInternal>.NativeClassPtr, 100667146);
		NativeMethodInfoPtr_GetSystemWebProxy_Private_Static_IWebProxy_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultProxySectionInternal>.NativeClassPtr, 100667147);
		NativeMethodInfoPtr_get_ClassSyncObject_Internal_Static_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultProxySectionInternal>.NativeClassPtr, 100667148);
		NativeMethodInfoPtr_GetSection_Internal_Static_DefaultProxySectionInternal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultProxySectionInternal>.NativeClassPtr, 100667149);
		NativeMethodInfoPtr_get_WebProxy_Internal_get_IWebProxy_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultProxySectionInternal>.NativeClassPtr, 100667150);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultProxySectionInternal>.NativeClassPtr, 100667151);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 897368, XrefRangeEnd = 897369, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static IWebProxy GetDefaultProxy_UsingOldMonoCode()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetDefaultProxy_UsingOldMonoCode_Private_Static_IWebProxy_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<IWebProxy>(intPtr2) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static IWebProxy GetSystemWebProxy()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetSystemWebProxy_Private_Static_IWebProxy_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<IWebProxy>(intPtr2) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 897397, RefRangeEnd = 897398, XrefRangeStart = 897378, XrefRangeEnd = 897397, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static DefaultProxySectionInternal GetSection()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetSection_Internal_Static_DefaultProxySectionInternal_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<DefaultProxySectionInternal>(intPtr2) : null;
	}

	[CallerCount(1950)]
	[CachedScanResults(RefRangeStart = 20036, RefRangeEnd = 21986, XrefRangeStart = 20036, XrefRangeEnd = 21986, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe DefaultProxySectionInternal()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DefaultProxySectionInternal>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public DefaultProxySectionInternal(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
