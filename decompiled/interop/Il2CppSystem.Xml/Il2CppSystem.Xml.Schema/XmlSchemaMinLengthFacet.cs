using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace Il2CppSystem.Xml.Schema;

public class XmlSchemaMinLengthFacet : XmlSchemaNumericFacet
{
	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	static XmlSchemaMinLengthFacet()
	{
		Il2CppClassPointerStore<XmlSchemaMinLengthFacet>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml.Schema", "XmlSchemaMinLengthFacet");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XmlSchemaMinLengthFacet>.NativeClassPtr);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaMinLengthFacet>.NativeClassPtr, 100667667);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 940049, RefRangeEnd = 940050, XrefRangeStart = 940048, XrefRangeEnd = 940049, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe XmlSchemaMinLengthFacet()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XmlSchemaMinLengthFacet>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public XmlSchemaMinLengthFacet(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
