using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace Il2CppSystem.Xml.Schema;

public class XmlSchemaMaxInclusiveFacet : XmlSchemaFacet
{
	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	static XmlSchemaMaxInclusiveFacet()
	{
		Il2CppClassPointerStore<XmlSchemaMaxInclusiveFacet>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml.Schema", "XmlSchemaMaxInclusiveFacet");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XmlSchemaMaxInclusiveFacet>.NativeClassPtr);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaMaxInclusiveFacet>.NativeClassPtr, 100667674);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 940066, RefRangeEnd = 940067, XrefRangeStart = 940065, XrefRangeEnd = 940066, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe XmlSchemaMaxInclusiveFacet()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XmlSchemaMaxInclusiveFacet>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public XmlSchemaMaxInclusiveFacet(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
