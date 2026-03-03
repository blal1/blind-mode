using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace Il2CppSystem.Xml.Schema;

public class XmlSchemaLengthFacet : XmlSchemaNumericFacet
{
	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	static XmlSchemaLengthFacet()
	{
		Il2CppClassPointerStore<XmlSchemaLengthFacet>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml.Schema", "XmlSchemaLengthFacet");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XmlSchemaLengthFacet>.NativeClassPtr);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaLengthFacet>.NativeClassPtr, 100667666);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 940047, RefRangeEnd = 940048, XrefRangeStart = 940046, XrefRangeEnd = 940047, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe XmlSchemaLengthFacet()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XmlSchemaLengthFacet>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public XmlSchemaLengthFacet(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
