using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Il2CppMono.Security.X509;

public sealed class X509StoreManager : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr__userPath;

	private static readonly System.IntPtr NativeFieldInfoPtr__localMachinePath;

	private static readonly System.IntPtr NativeFieldInfoPtr__newUserPath;

	private static readonly System.IntPtr NativeFieldInfoPtr__newLocalMachinePath;

	private static readonly System.IntPtr NativeFieldInfoPtr__userStore;

	private static readonly System.IntPtr NativeFieldInfoPtr__machineStore;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_CurrentUserPath_Internal_Static_get_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_LocalMachinePath_Internal_Static_get_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_NewCurrentUserPath_Internal_Static_get_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_NewLocalMachinePath_Internal_Static_get_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_CurrentUser_Public_Static_get_X509Stores_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_LocalMachine_Public_Static_get_X509Stores_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_TrustedRootCertificates_Public_Static_get_X509CertificateCollection_0;

	public unsafe static string _userPath
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr__userPath, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr__userPath, (void*)IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe static string _localMachinePath
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr__localMachinePath, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr__localMachinePath, (void*)IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe static string _newUserPath
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr__newUserPath, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr__newUserPath, (void*)IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe static string _newLocalMachinePath
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr__newLocalMachinePath, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr__newLocalMachinePath, (void*)IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe static X509Stores _userStore
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr__userStore, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<X509Stores>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr__userStore, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static X509Stores _machineStore
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr__machineStore, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<X509Stores>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr__machineStore, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static string CurrentUserPath
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 692397, XrefRangeEnd = 692417, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_CurrentUserPath_Internal_Static_get_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return IL2CPP.Il2CppStringToManaged(intPtr2);
		}
	}

	public unsafe static string LocalMachinePath
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 692417, XrefRangeEnd = 692437, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_LocalMachinePath_Internal_Static_get_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return IL2CPP.Il2CppStringToManaged(intPtr2);
		}
	}

	public unsafe static string NewCurrentUserPath
	{
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 692457, RefRangeEnd = 692459, XrefRangeStart = 692437, XrefRangeEnd = 692457, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_NewCurrentUserPath_Internal_Static_get_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return IL2CPP.Il2CppStringToManaged(intPtr2);
		}
	}

	public unsafe static string NewLocalMachinePath
	{
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 692479, RefRangeEnd = 692481, XrefRangeStart = 692459, XrefRangeEnd = 692479, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_NewLocalMachinePath_Internal_Static_get_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return IL2CPP.Il2CppStringToManaged(intPtr2);
		}
	}

	public unsafe static X509Stores CurrentUser
	{
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 692512, RefRangeEnd = 692514, XrefRangeStart = 692481, XrefRangeEnd = 692512, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_CurrentUser_Public_Static_get_X509Stores_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<X509Stores>(intPtr2) : null;
		}
	}

	public unsafe static X509Stores LocalMachine
	{
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 692545, RefRangeEnd = 692547, XrefRangeStart = 692514, XrefRangeEnd = 692545, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_LocalMachine_Public_Static_get_X509Stores_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<X509Stores>(intPtr2) : null;
		}
	}

	public unsafe static X509CertificateCollection TrustedRootCertificates
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 692547, XrefRangeEnd = 692621, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_TrustedRootCertificates_Public_Static_get_X509CertificateCollection_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<X509CertificateCollection>(intPtr2) : null;
		}
	}

	static X509StoreManager()
	{
		Il2CppClassPointerStore<X509StoreManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("Mono.Security.dll", "Mono.Security.X509", "X509StoreManager");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<X509StoreManager>.NativeClassPtr);
		NativeFieldInfoPtr__userPath = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<X509StoreManager>.NativeClassPtr, "_userPath");
		NativeFieldInfoPtr__localMachinePath = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<X509StoreManager>.NativeClassPtr, "_localMachinePath");
		NativeFieldInfoPtr__newUserPath = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<X509StoreManager>.NativeClassPtr, "_newUserPath");
		NativeFieldInfoPtr__newLocalMachinePath = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<X509StoreManager>.NativeClassPtr, "_newLocalMachinePath");
		NativeFieldInfoPtr__userStore = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<X509StoreManager>.NativeClassPtr, "_userStore");
		NativeFieldInfoPtr__machineStore = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<X509StoreManager>.NativeClassPtr, "_machineStore");
		NativeMethodInfoPtr_get_CurrentUserPath_Internal_Static_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509StoreManager>.NativeClassPtr, 100663518);
		NativeMethodInfoPtr_get_LocalMachinePath_Internal_Static_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509StoreManager>.NativeClassPtr, 100663519);
		NativeMethodInfoPtr_get_NewCurrentUserPath_Internal_Static_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509StoreManager>.NativeClassPtr, 100663520);
		NativeMethodInfoPtr_get_NewLocalMachinePath_Internal_Static_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509StoreManager>.NativeClassPtr, 100663521);
		NativeMethodInfoPtr_get_CurrentUser_Public_Static_get_X509Stores_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509StoreManager>.NativeClassPtr, 100663522);
		NativeMethodInfoPtr_get_LocalMachine_Public_Static_get_X509Stores_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509StoreManager>.NativeClassPtr, 100663523);
		NativeMethodInfoPtr_get_TrustedRootCertificates_Public_Static_get_X509CertificateCollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509StoreManager>.NativeClassPtr, 100663524);
	}

	public X509StoreManager(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
