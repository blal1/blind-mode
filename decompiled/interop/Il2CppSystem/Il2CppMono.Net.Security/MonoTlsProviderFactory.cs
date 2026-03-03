using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace Il2CppMono.Net.Security;

public static class MonoTlsProviderFactory : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_locker;

	private static readonly System.IntPtr NativeFieldInfoPtr_initialized;

	private static readonly System.IntPtr NativeFieldInfoPtr_defaultProvider;

	private static readonly System.IntPtr NativeFieldInfoPtr_providerRegistration;

	private static readonly System.IntPtr NativeFieldInfoPtr_providerCache;

	private static readonly System.IntPtr NativeFieldInfoPtr_UnityTlsId;

	private static readonly System.IntPtr NativeFieldInfoPtr_AppleTlsId;

	private static readonly System.IntPtr NativeFieldInfoPtr_BtlsId;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetProviderInternal_Internal_Static_MobileTlsProvider_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_InitializeInternal_Internal_Static_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_LookupProvider_Private_Static_MobileTlsProvider_String_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_InitializeProviderRegistration_Private_Static_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_PopulateUnityProviders_Private_Static_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_PopulateProviders_Private_Static_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsBtlsSupported_Internal_Static_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CreateDefaultProviderImpl_Private_Static_MobileTlsProvider_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetProvider_Internal_Static_MobileTlsProvider_0;

	public unsafe static Il2CppSystem.Object locker
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_locker, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_locker, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static bool initialized
	{
		get
		{
			Unsafe.SkipInit(out bool result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_initialized, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_initialized, (void*)(&value));
		}
	}

	public unsafe static MobileTlsProvider defaultProvider
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_defaultProvider, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<MobileTlsProvider>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_defaultProvider, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static Dictionary<string, Il2CppSystem.Tuple<Il2CppSystem.Guid, string>> providerRegistration
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_providerRegistration, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<string, Il2CppSystem.Tuple<Il2CppSystem.Guid, string>>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_providerRegistration, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static Dictionary<Il2CppSystem.Guid, MobileTlsProvider> providerCache
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_providerCache, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<Il2CppSystem.Guid, MobileTlsProvider>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_providerCache, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static Il2CppSystem.Guid UnityTlsId
	{
		get
		{
			Unsafe.SkipInit(out Il2CppSystem.Guid result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_UnityTlsId, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_UnityTlsId, (void*)(&value));
		}
	}

	public unsafe static Il2CppSystem.Guid AppleTlsId
	{
		get
		{
			Unsafe.SkipInit(out Il2CppSystem.Guid result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_AppleTlsId, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_AppleTlsId, (void*)(&value));
		}
	}

	public unsafe static Il2CppSystem.Guid BtlsId
	{
		get
		{
			Unsafe.SkipInit(out Il2CppSystem.Guid result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_BtlsId, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_BtlsId, (void*)(&value));
		}
	}

	static MonoTlsProviderFactory()
	{
		Il2CppClassPointerStore<MonoTlsProviderFactory>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "Mono.Net.Security", "MonoTlsProviderFactory");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MonoTlsProviderFactory>.NativeClassPtr);
		NativeFieldInfoPtr_locker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MonoTlsProviderFactory>.NativeClassPtr, "locker");
		NativeFieldInfoPtr_initialized = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MonoTlsProviderFactory>.NativeClassPtr, "initialized");
		NativeFieldInfoPtr_defaultProvider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MonoTlsProviderFactory>.NativeClassPtr, "defaultProvider");
		NativeFieldInfoPtr_providerRegistration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MonoTlsProviderFactory>.NativeClassPtr, "providerRegistration");
		NativeFieldInfoPtr_providerCache = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MonoTlsProviderFactory>.NativeClassPtr, "providerCache");
		NativeFieldInfoPtr_UnityTlsId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MonoTlsProviderFactory>.NativeClassPtr, "UnityTlsId");
		NativeFieldInfoPtr_AppleTlsId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MonoTlsProviderFactory>.NativeClassPtr, "AppleTlsId");
		NativeFieldInfoPtr_BtlsId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MonoTlsProviderFactory>.NativeClassPtr, "BtlsId");
		NativeMethodInfoPtr_GetProviderInternal_Internal_Static_MobileTlsProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoTlsProviderFactory>.NativeClassPtr, 100663644);
		NativeMethodInfoPtr_InitializeInternal_Internal_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoTlsProviderFactory>.NativeClassPtr, 100663645);
		NativeMethodInfoPtr_LookupProvider_Private_Static_MobileTlsProvider_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoTlsProviderFactory>.NativeClassPtr, 100663646);
		NativeMethodInfoPtr_InitializeProviderRegistration_Private_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoTlsProviderFactory>.NativeClassPtr, 100663647);
		NativeMethodInfoPtr_PopulateUnityProviders_Private_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoTlsProviderFactory>.NativeClassPtr, 100663648);
		NativeMethodInfoPtr_PopulateProviders_Private_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoTlsProviderFactory>.NativeClassPtr, 100663649);
		NativeMethodInfoPtr_IsBtlsSupported_Internal_Static_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoTlsProviderFactory>.NativeClassPtr, 100663650);
		NativeMethodInfoPtr_CreateDefaultProviderImpl_Private_Static_MobileTlsProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoTlsProviderFactory>.NativeClassPtr, 100663651);
		NativeMethodInfoPtr_GetProvider_Internal_Static_MobileTlsProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoTlsProviderFactory>.NativeClassPtr, 100663652);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 864306, RefRangeEnd = 864310, XrefRangeStart = 864294, XrefRangeEnd = 864306, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static MobileTlsProvider GetProviderInternal()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetProviderInternal_Internal_Static_MobileTlsProvider_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<MobileTlsProvider>(intPtr2) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 864351, RefRangeEnd = 864352, XrefRangeStart = 864310, XrefRangeEnd = 864351, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void InitializeInternal()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InitializeInternal_Internal_Static_Void_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 864399, RefRangeEnd = 864400, XrefRangeStart = 864352, XrefRangeEnd = 864399, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static MobileTlsProvider LookupProvider(string name, bool throwOnError)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &throwOnError;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_LookupProvider_Private_Static_MobileTlsProvider_String_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<MobileTlsProvider>(intPtr2) : null;
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 864463, RefRangeEnd = 864465, XrefRangeStart = 864400, XrefRangeEnd = 864463, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void InitializeProviderRegistration()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InitializeProviderRegistration_Private_Static_Void_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 864465, XrefRangeEnd = 864509, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void PopulateUnityProviders()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_PopulateUnityProviders_Private_Static_Void_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 864545, RefRangeEnd = 864546, XrefRangeStart = 864509, XrefRangeEnd = 864545, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void PopulateProviders()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_PopulateProviders_Private_Static_Void_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool IsBtlsSupported()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsBtlsSupported_Internal_Static_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 864583, RefRangeEnd = 864584, XrefRangeStart = 864546, XrefRangeEnd = 864583, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static MobileTlsProvider CreateDefaultProviderImpl()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CreateDefaultProviderImpl_Private_Static_MobileTlsProvider_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<MobileTlsProvider>(intPtr2) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 864584, XrefRangeEnd = 864588, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static MobileTlsProvider GetProvider()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetProvider_Internal_Static_MobileTlsProvider_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<MobileTlsProvider>(intPtr2) : null;
	}

	public MonoTlsProviderFactory(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
