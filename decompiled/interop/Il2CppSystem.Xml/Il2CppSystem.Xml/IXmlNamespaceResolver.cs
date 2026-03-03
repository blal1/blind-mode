using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;

namespace Il2CppSystem.Xml;

public class IXmlNamespaceResolver : Il2CppObjectBase
{
	private static readonly System.IntPtr NativeMethodInfoPtr_GetNamespacesInScope_Public_Abstract_Virtual_New_IDictionary_2_String_String_XmlNamespaceScope_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_LookupNamespace_Public_Abstract_Virtual_New_String_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_LookupPrefix_Public_Abstract_Virtual_New_String_String_0;

	static IXmlNamespaceResolver()
	{
		Il2CppClassPointerStore<IXmlNamespaceResolver>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml", "IXmlNamespaceResolver");
		NativeMethodInfoPtr_GetNamespacesInScope_Public_Abstract_Virtual_New_IDictionary_2_String_String_XmlNamespaceScope_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IXmlNamespaceResolver>.NativeClassPtr, 100664799);
		NativeMethodInfoPtr_LookupNamespace_Public_Abstract_Virtual_New_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IXmlNamespaceResolver>.NativeClassPtr, 100664800);
		NativeMethodInfoPtr_LookupPrefix_Public_Abstract_Virtual_New_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IXmlNamespaceResolver>.NativeClassPtr, 100664801);
	}

	[CallerCount(0)]
	public unsafe virtual IDictionary<string, string> GetNamespacesInScope(XmlNamespaceScope scope)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&scope);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_GetNamespacesInScope_Public_Abstract_Virtual_New_IDictionary_2_String_String_XmlNamespaceScope_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<IDictionary<string, string>>(intPtr2) : null;
	}

	[CallerCount(0)]
	public unsafe virtual string LookupNamespace(string prefix)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(prefix);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_LookupNamespace_Public_Abstract_Virtual_New_String_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return IL2CPP.Il2CppStringToManaged(intPtr2);
	}

	[CallerCount(0)]
	public unsafe virtual string LookupPrefix(string namespaceName)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(namespaceName);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_LookupPrefix_Public_Abstract_Virtual_New_String_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return IL2CPP.Il2CppStringToManaged(intPtr2);
	}

	public IXmlNamespaceResolver(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
