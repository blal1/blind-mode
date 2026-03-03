using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace Il2CppSystem.Xml.Schema;

public class XmlSchemaUnique : XmlSchemaIdentityConstraint
{
	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	static XmlSchemaUnique()
	{
		Il2CppClassPointerStore<XmlSchemaUnique>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml.Schema", "XmlSchemaUnique");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XmlSchemaUnique>.NativeClassPtr);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaUnique>.NativeClassPtr, 100667719);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 940143, RefRangeEnd = 940145, XrefRangeStart = 940142, XrefRangeEnd = 940143, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe XmlSchemaUnique()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XmlSchemaUnique>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public XmlSchemaUnique(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
