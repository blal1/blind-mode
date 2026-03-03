using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Security.Cryptography.X509Certificates;

namespace Il2CppSystem.Net.Security;

public sealed class ServerCertSelectionCallback : MulticastDelegate
{
	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_X509Certificate_String_0;

	static ServerCertSelectionCallback()
	{
		Il2CppClassPointerStore<ServerCertSelectionCallback>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Net.Security", "ServerCertSelectionCallback");
		NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerCertSelectionCallback>.NativeClassPtr, 100667497);
		NativeMethodInfoPtr_Invoke_Public_Virtual_New_X509Certificate_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerCertSelectionCallback>.NativeClassPtr, 100667498);
	}

	[CallerCount(6)]
	[CachedScanResults(RefRangeStart = 862554, RefRangeEnd = 862560, XrefRangeStart = 862554, XrefRangeEnd = 862560, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ServerCertSelectionCallback(Object @object, System.IntPtr method)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ServerCertSelectionCallback>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)@object);
		*(System.IntPtr**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &method;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	public unsafe virtual X509Certificate Invoke(string hostName)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(hostName);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Invoke_Public_Virtual_New_X509Certificate_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<X509Certificate>(intPtr2) : null;
	}

	public ServerCertSelectionCallback(System.IntPtr pointer)
		: base(pointer)
	{
	}

	public static implicit operator ServerCertSelectionCallback(System.Func<string, X509Certificate> P_0)
	{
		return DelegateSupport.ConvertDelegate<ServerCertSelectionCallback>((System.Delegate)P_0);
	}

	public static ServerCertSelectionCallback operator +(ServerCertSelectionCallback P_0, ServerCertSelectionCallback P_1)
	{
		return ((Il2CppObjectBase)Delegate.Combine(P_0, P_1)).Cast<ServerCertSelectionCallback>();
	}

	public static ServerCertSelectionCallback operator -(ServerCertSelectionCallback P_0, ServerCertSelectionCallback P_1)
	{
		object obj = Delegate.Remove(P_0, P_1);
		if (obj != null)
		{
			obj = ((Il2CppObjectBase)obj).Cast<ServerCertSelectionCallback>();
		}
		return (ServerCertSelectionCallback)obj;
	}
}
