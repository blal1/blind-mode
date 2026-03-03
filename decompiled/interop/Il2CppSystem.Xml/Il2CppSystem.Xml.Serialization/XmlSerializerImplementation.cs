using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Xml.Serialization;

public class XmlSerializerImplementation : Object
{
	private static readonly System.IntPtr NativeMethodInfoPtr_get_Writer_Public_Virtual_New_get_XmlSerializationWriter_0;

	public unsafe virtual XmlSerializationWriter Writer
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 919215, XrefRangeEnd = 919220, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_get_Writer_Public_Virtual_New_get_XmlSerializationWriter_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<XmlSerializationWriter>(intPtr2) : null;
		}
	}

	static XmlSerializerImplementation()
	{
		Il2CppClassPointerStore<XmlSerializerImplementation>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml.Serialization", "XmlSerializerImplementation");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XmlSerializerImplementation>.NativeClassPtr);
		NativeMethodInfoPtr_get_Writer_Public_Virtual_New_get_XmlSerializationWriter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSerializerImplementation>.NativeClassPtr, 100665692);
	}

	public XmlSerializerImplementation(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
