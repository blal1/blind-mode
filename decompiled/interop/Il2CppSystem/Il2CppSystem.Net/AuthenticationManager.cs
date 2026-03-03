using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections;

namespace Il2CppSystem.Net;

public class AuthenticationManager : Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_modules;

	private static readonly System.IntPtr NativeFieldInfoPtr_locker;

	private static readonly System.IntPtr NativeFieldInfoPtr_credential_policy;

	private static readonly System.IntPtr NativeMethodInfoPtr_EnsureModules_Private_Static_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Authenticate_Public_Static_Authorization_String_WebRequest_ICredentials_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DoAuthenticate_Private_Static_Authorization_String_WebRequest_ICredentials_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_PreAuthenticate_Public_Static_Authorization_WebRequest_ICredentials_0;

	public unsafe static ArrayList modules
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_modules, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<ArrayList>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_modules, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static Object locker
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_locker, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_locker, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static ICredentialPolicy credential_policy
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_credential_policy, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<ICredentialPolicy>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_credential_policy, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	static AuthenticationManager()
	{
		Il2CppClassPointerStore<AuthenticationManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Net", "AuthenticationManager");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AuthenticationManager>.NativeClassPtr);
		NativeFieldInfoPtr_modules = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AuthenticationManager>.NativeClassPtr, "modules");
		NativeFieldInfoPtr_locker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AuthenticationManager>.NativeClassPtr, "locker");
		NativeFieldInfoPtr_credential_policy = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AuthenticationManager>.NativeClassPtr, "credential_policy");
		NativeMethodInfoPtr_EnsureModules_Private_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AuthenticationManager>.NativeClassPtr, 100666557);
		NativeMethodInfoPtr_Authenticate_Public_Static_Authorization_String_WebRequest_ICredentials_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AuthenticationManager>.NativeClassPtr, 100666558);
		NativeMethodInfoPtr_DoAuthenticate_Private_Static_Authorization_String_WebRequest_ICredentials_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AuthenticationManager>.NativeClassPtr, 100666559);
		NativeMethodInfoPtr_PreAuthenticate_Public_Static_Authorization_WebRequest_ICredentials_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AuthenticationManager>.NativeClassPtr, 100666560);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 891353, RefRangeEnd = 891355, XrefRangeStart = 891316, XrefRangeEnd = 891353, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void EnsureModules()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_EnsureModules_Private_Static_Void_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 891377, RefRangeEnd = 891379, XrefRangeStart = 891355, XrefRangeEnd = 891377, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Authorization Authenticate(string challenge, WebRequest request, ICredentials credentials)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(challenge);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)request);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)credentials);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Authenticate_Public_Static_Authorization_String_WebRequest_ICredentials_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Authorization>(intPtr2) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 891414, RefRangeEnd = 891415, XrefRangeStart = 891379, XrefRangeEnd = 891414, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Authorization DoAuthenticate(string challenge, WebRequest request, ICredentials credentials)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(challenge);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)request);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)credentials);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DoAuthenticate_Private_Static_Authorization_String_WebRequest_ICredentials_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Authorization>(intPtr2) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 891440, RefRangeEnd = 891441, XrefRangeStart = 891415, XrefRangeEnd = 891440, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Authorization PreAuthenticate(WebRequest request, ICredentials credentials)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)request);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)credentials);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_PreAuthenticate_Public_Static_Authorization_WebRequest_ICredentials_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Authorization>(intPtr2) : null;
	}

	public AuthenticationManager(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
