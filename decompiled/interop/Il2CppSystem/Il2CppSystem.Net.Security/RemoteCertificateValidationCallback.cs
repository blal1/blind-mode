using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem.Security.Cryptography.X509Certificates;

namespace Il2CppSystem.Net.Security;

public sealed class RemoteCertificateValidationCallback : MulticastDelegate
{
	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Boolean_Object_X509Certificate_X509Chain_SslPolicyErrors_0;

	static RemoteCertificateValidationCallback()
	{
		Il2CppClassPointerStore<RemoteCertificateValidationCallback>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Net.Security", "RemoteCertificateValidationCallback");
		NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RemoteCertificateValidationCallback>.NativeClassPtr, 100667493);
		NativeMethodInfoPtr_Invoke_Public_Virtual_New_Boolean_Object_X509Certificate_X509Chain_SslPolicyErrors_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RemoteCertificateValidationCallback>.NativeClassPtr, 100667494);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 900348, RefRangeEnd = 900350, XrefRangeStart = 900338, XrefRangeEnd = 900348, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe RemoteCertificateValidationCallback(Object @object, System.IntPtr method)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RemoteCertificateValidationCallback>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)@object);
		*(System.IntPtr**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &method;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	public unsafe virtual bool Invoke(Object sender, X509Certificate certificate, X509Chain chain, SslPolicyErrors sslPolicyErrors)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)sender);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)certificate);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)chain);
		*(SslPolicyErrors**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &sslPolicyErrors;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Invoke_Public_Virtual_New_Boolean_Object_X509Certificate_X509Chain_SslPolicyErrors_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	public RemoteCertificateValidationCallback(System.IntPtr pointer)
		: base(pointer)
	{
	}

	public static implicit operator RemoteCertificateValidationCallback(System.Func<Object, X509Certificate, X509Chain, SslPolicyErrors, bool> P_0)
	{
		return DelegateSupport.ConvertDelegate<RemoteCertificateValidationCallback>((System.Delegate)P_0);
	}

	public static RemoteCertificateValidationCallback operator +(RemoteCertificateValidationCallback P_0, RemoteCertificateValidationCallback P_1)
	{
		return ((Il2CppObjectBase)Delegate.Combine(P_0, P_1)).Cast<RemoteCertificateValidationCallback>();
	}

	public static RemoteCertificateValidationCallback operator -(RemoteCertificateValidationCallback P_0, RemoteCertificateValidationCallback P_1)
	{
		object obj = Delegate.Remove(P_0, P_1);
		if (obj != null)
		{
			obj = ((Il2CppObjectBase)obj).Cast<RemoteCertificateValidationCallback>();
		}
		return (RemoteCertificateValidationCallback)obj;
	}
}
