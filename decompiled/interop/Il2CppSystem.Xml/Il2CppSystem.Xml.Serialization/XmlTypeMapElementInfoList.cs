using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem.Collections;

namespace Il2CppSystem.Xml.Serialization;

public class XmlTypeMapElementInfoList : ArrayList
{
	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	static XmlTypeMapElementInfoList()
	{
		Il2CppClassPointerStore<XmlTypeMapElementInfoList>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml.Serialization", "XmlTypeMapElementInfoList");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XmlTypeMapElementInfoList>.NativeClassPtr);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTypeMapElementInfoList>.NativeClassPtr, 100665729);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 919281, RefRangeEnd = 919285, XrefRangeStart = 919280, XrefRangeEnd = 919281, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe XmlTypeMapElementInfoList()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XmlTypeMapElementInfoList>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public XmlTypeMapElementInfoList(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
