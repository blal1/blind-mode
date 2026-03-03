using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace Il2CppSystem.Xml.Schema;

public class XmlSchemaMinExclusiveFacet : XmlSchemaFacet
{
	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	static XmlSchemaMinExclusiveFacet()
	{
		Il2CppClassPointerStore<XmlSchemaMinExclusiveFacet>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml.Schema", "XmlSchemaMinExclusiveFacet");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XmlSchemaMinExclusiveFacet>.NativeClassPtr);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaMinExclusiveFacet>.NativeClassPtr, 100667671);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 940060, RefRangeEnd = 940061, XrefRangeStart = 940059, XrefRangeEnd = 940060, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe XmlSchemaMinExclusiveFacet()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XmlSchemaMinExclusiveFacet>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public XmlSchemaMinExclusiveFacet(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
