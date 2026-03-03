using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppMono.Btls;

public static class MonoBtlsX509StoreManager : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_initialized;

	private static readonly System.IntPtr NativeFieldInfoPtr_machineTrustedRootPath;

	private static readonly System.IntPtr NativeFieldInfoPtr_machineIntermediateCAPath;

	private static readonly System.IntPtr NativeFieldInfoPtr_machineUntrustedPath;

	private static readonly System.IntPtr NativeFieldInfoPtr_userTrustedRootPath;

	private static readonly System.IntPtr NativeFieldInfoPtr_userIntermediateCAPath;

	private static readonly System.IntPtr NativeFieldInfoPtr_userUntrustedPath;

	private static readonly System.IntPtr NativeMethodInfoPtr_Initialize_Private_Static_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DoInitialize_Private_Static_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetStorePath_Public_Static_String_MonoBtlsX509StoreType_0;

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

	public unsafe static string machineTrustedRootPath
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_machineTrustedRootPath, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_machineTrustedRootPath, (void*)IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe static string machineIntermediateCAPath
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_machineIntermediateCAPath, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_machineIntermediateCAPath, (void*)IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe static string machineUntrustedPath
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_machineUntrustedPath, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_machineUntrustedPath, (void*)IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe static string userTrustedRootPath
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_userTrustedRootPath, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_userTrustedRootPath, (void*)IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe static string userIntermediateCAPath
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_userIntermediateCAPath, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_userIntermediateCAPath, (void*)IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe static string userUntrustedPath
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_userUntrustedPath, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_userUntrustedPath, (void*)IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	static MonoBtlsX509StoreManager()
	{
		Il2CppClassPointerStore<MonoBtlsX509StoreManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "Mono.Btls", "MonoBtlsX509StoreManager");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MonoBtlsX509StoreManager>.NativeClassPtr);
		NativeFieldInfoPtr_initialized = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MonoBtlsX509StoreManager>.NativeClassPtr, "initialized");
		NativeFieldInfoPtr_machineTrustedRootPath = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MonoBtlsX509StoreManager>.NativeClassPtr, "machineTrustedRootPath");
		NativeFieldInfoPtr_machineIntermediateCAPath = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MonoBtlsX509StoreManager>.NativeClassPtr, "machineIntermediateCAPath");
		NativeFieldInfoPtr_machineUntrustedPath = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MonoBtlsX509StoreManager>.NativeClassPtr, "machineUntrustedPath");
		NativeFieldInfoPtr_userTrustedRootPath = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MonoBtlsX509StoreManager>.NativeClassPtr, "userTrustedRootPath");
		NativeFieldInfoPtr_userIntermediateCAPath = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MonoBtlsX509StoreManager>.NativeClassPtr, "userIntermediateCAPath");
		NativeFieldInfoPtr_userUntrustedPath = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MonoBtlsX509StoreManager>.NativeClassPtr, "userUntrustedPath");
		NativeMethodInfoPtr_Initialize_Private_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBtlsX509StoreManager>.NativeClassPtr, 100664054);
		NativeMethodInfoPtr_DoInitialize_Private_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBtlsX509StoreManager>.NativeClassPtr, 100664055);
		NativeMethodInfoPtr_GetStorePath_Public_Static_String_MonoBtlsX509StoreType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBtlsX509StoreManager>.NativeClassPtr, 100664056);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 867930, RefRangeEnd = 867931, XrefRangeStart = 867880, XrefRangeEnd = 867930, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void Initialize()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Initialize_Private_Static_Void_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 867931, XrefRangeEnd = 867970, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void DoInitialize()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DoInitialize_Private_Static_Void_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(28)]
	[CachedScanResults(RefRangeStart = 867973, RefRangeEnd = 868001, XrefRangeStart = 867970, XrefRangeEnd = 867973, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string GetStorePath(MonoBtlsX509StoreType type)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&type);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetStorePath_Public_Static_String_MonoBtlsX509StoreType_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return IL2CPP.Il2CppStringToManaged(intPtr2);
	}

	public MonoBtlsX509StoreManager(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
