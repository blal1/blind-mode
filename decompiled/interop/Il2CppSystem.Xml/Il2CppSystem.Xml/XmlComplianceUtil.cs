using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Xml;

public static class XmlComplianceUtil : Object
{
	private static readonly System.IntPtr NativeMethodInfoPtr_NonCDataNormalize_Public_Static_String_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CDataNormalize_Public_Static_String_String_0;

	static XmlComplianceUtil()
	{
		Il2CppClassPointerStore<XmlComplianceUtil>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml", "XmlComplianceUtil");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XmlComplianceUtil>.NativeClassPtr);
		NativeMethodInfoPtr_NonCDataNormalize_Public_Static_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlComplianceUtil>.NativeClassPtr, 100664958);
		NativeMethodInfoPtr_CDataNormalize_Public_Static_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlComplianceUtil>.NativeClassPtr, 100664959);
	}

	[CallerCount(6)]
	[CachedScanResults(RefRangeStart = 911117, RefRangeEnd = 911123, XrefRangeStart = 911090, XrefRangeEnd = 911117, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string NonCDataNormalize(string value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_NonCDataNormalize_Public_Static_String_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return IL2CPP.Il2CppStringToManaged(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 911134, RefRangeEnd = 911135, XrefRangeStart = 911123, XrefRangeEnd = 911134, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string CDataNormalize(string value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CDataNormalize_Public_Static_String_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return IL2CPP.Il2CppStringToManaged(intPtr2);
	}

	public XmlComplianceUtil(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
