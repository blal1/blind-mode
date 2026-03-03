using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem.Collections.Generic;

namespace Il2CppSystem.Net;

public class AutoWebProxyScriptEngine : Object
{
	private static readonly System.IntPtr NativeMethodInfoPtr_GetProxies_Public_Boolean_Uri_byref_IList_1_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetProxies_Public_Boolean_Uri_byref_IList_1_String_byref_Int32_0;

	static AutoWebProxyScriptEngine()
	{
		Il2CppClassPointerStore<AutoWebProxyScriptEngine>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Net", "AutoWebProxyScriptEngine");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AutoWebProxyScriptEngine>.NativeClassPtr);
		NativeMethodInfoPtr_GetProxies_Public_Boolean_Uri_byref_IList_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AutoWebProxyScriptEngine>.NativeClassPtr, 100666544);
		NativeMethodInfoPtr_GetProxies_Public_Boolean_Uri_byref_IList_1_String_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AutoWebProxyScriptEngine>.NativeClassPtr, 100666545);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 891252, XrefRangeEnd = 891253, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool GetProxies(Uri destination, out IList<string> proxyList)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)destination);
		byte* num = (byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)));
		nint num2 = 0;
		*(nint**)num = &num2;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetProxies_Public_Boolean_Uri_byref_IList_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		nint num3 = num2;
		proxyList = ((num3 == 0) ? null : new IList<string>(num3));
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool GetProxies(Uri destination, out IList<string> proxyList, ref int syncStatus)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)destination);
		byte* num = (byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)));
		nint num2 = 0;
		*(nint**)num = &num2;
		*(void**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref syncStatus);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetProxies_Public_Boolean_Uri_byref_IList_1_String_byref_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		nint num3 = num2;
		proxyList = ((num3 == 0) ? null : new IList<string>(num3));
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	public AutoWebProxyScriptEngine(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
