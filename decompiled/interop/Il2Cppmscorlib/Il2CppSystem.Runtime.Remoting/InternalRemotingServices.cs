using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections;
using Il2CppSystem.Runtime.Remoting.Metadata;

namespace Il2CppSystem.Runtime.Remoting;

public class InternalRemotingServices : Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr__soapAttributes;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetCachedSoapAttribute_Public_Static_SoapAttribute_Object_0;

	public unsafe static Hashtable _soapAttributes
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr__soapAttributes, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Hashtable>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr__soapAttributes, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	static InternalRemotingServices()
	{
		Il2CppClassPointerStore<InternalRemotingServices>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.Remoting", "InternalRemotingServices");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InternalRemotingServices>.NativeClassPtr);
		NativeFieldInfoPtr__soapAttributes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InternalRemotingServices>.NativeClassPtr, "_soapAttributes");
		NativeMethodInfoPtr_GetCachedSoapAttribute_Public_Static_SoapAttribute_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InternalRemotingServices>.NativeClassPtr, 100669811);
	}

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 789835, RefRangeEnd = 789840, XrefRangeStart = 789775, XrefRangeEnd = 789835, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static SoapAttribute GetCachedSoapAttribute(Object reflectionObject)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)reflectionObject);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetCachedSoapAttribute_Public_Static_SoapAttribute_Object_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<SoapAttribute>(intPtr2) : null;
	}

	public InternalRemotingServices(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
