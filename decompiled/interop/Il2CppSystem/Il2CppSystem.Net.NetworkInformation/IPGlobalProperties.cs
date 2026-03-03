using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Net.NetworkInformation;

public class IPGlobalProperties : Object
{
	private static readonly System.IntPtr NativeMethodInfoPtr_GetIPGlobalProperties_Public_Static_IPGlobalProperties_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_InternalGetIPGlobalProperties_Internal_Static_IPGlobalProperties_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_DomainName_Public_Abstract_Virtual_New_get_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

	public unsafe virtual string DomainName
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_get_DomainName_Public_Abstract_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return IL2CPP.Il2CppStringToManaged(intPtr2);
		}
	}

	static IPGlobalProperties()
	{
		Il2CppClassPointerStore<IPGlobalProperties>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Net.NetworkInformation", "IPGlobalProperties");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IPGlobalProperties>.NativeClassPtr);
		NativeMethodInfoPtr_GetIPGlobalProperties_Public_Static_IPGlobalProperties_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPGlobalProperties>.NativeClassPtr, 100667102);
		NativeMethodInfoPtr_InternalGetIPGlobalProperties_Internal_Static_IPGlobalProperties_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPGlobalProperties>.NativeClassPtr, 100667103);
		NativeMethodInfoPtr_get_DomainName_Public_Abstract_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPGlobalProperties>.NativeClassPtr, 100667104);
		NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPGlobalProperties>.NativeClassPtr, 100667105);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 897143, RefRangeEnd = 897146, XrefRangeStart = 897139, XrefRangeEnd = 897143, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static IPGlobalProperties GetIPGlobalProperties()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetIPGlobalProperties_Public_Static_IPGlobalProperties_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<IPGlobalProperties>(intPtr2) : null;
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 897143, RefRangeEnd = 897146, XrefRangeStart = 897143, XrefRangeEnd = 897146, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static IPGlobalProperties InternalGetIPGlobalProperties()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InternalGetIPGlobalProperties_Internal_Static_IPGlobalProperties_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<IPGlobalProperties>(intPtr2) : null;
	}

	[CallerCount(1950)]
	[CachedScanResults(RefRangeStart = 20036, RefRangeEnd = 21986, XrefRangeStart = 20036, XrefRangeEnd = 21986, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe IPGlobalProperties()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<IPGlobalProperties>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public IPGlobalProperties(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
