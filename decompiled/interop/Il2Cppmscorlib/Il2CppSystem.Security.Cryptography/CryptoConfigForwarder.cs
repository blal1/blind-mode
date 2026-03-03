using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Security.Cryptography;

public static class CryptoConfigForwarder : Object
{
	private static readonly System.IntPtr NativeMethodInfoPtr_CreateFromName_Internal_Static_Object_String_0;

	static CryptoConfigForwarder()
	{
		Il2CppClassPointerStore<CryptoConfigForwarder>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Security.Cryptography", "CryptoConfigForwarder");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CryptoConfigForwarder>.NativeClassPtr);
		NativeMethodInfoPtr_CreateFromName_Internal_Static_Object_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CryptoConfigForwarder>.NativeClassPtr, 100669632);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 788462, RefRangeEnd = 788463, XrefRangeStart = 788458, XrefRangeEnd = 788462, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Object CreateFromName(string name)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CreateFromName_Internal_Static_Object_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
	}

	public CryptoConfigForwarder(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
