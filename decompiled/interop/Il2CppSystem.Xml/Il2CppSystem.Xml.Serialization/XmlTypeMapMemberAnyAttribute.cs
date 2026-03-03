using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace Il2CppSystem.Xml.Serialization;

public class XmlTypeMapMemberAnyAttribute : XmlTypeMapMember
{
	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	static XmlTypeMapMemberAnyAttribute()
	{
		Il2CppClassPointerStore<XmlTypeMapMemberAnyAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml.Serialization", "XmlTypeMapMemberAnyAttribute");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XmlTypeMapMemberAnyAttribute>.NativeClassPtr);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTypeMapMemberAnyAttribute>.NativeClassPtr, 100665783);
	}

	[CallerCount(6)]
	[CachedScanResults(RefRangeStart = 919410, RefRangeEnd = 919416, XrefRangeStart = 919410, XrefRangeEnd = 919416, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe XmlTypeMapMemberAnyAttribute()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XmlTypeMapMemberAnyAttribute>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public XmlTypeMapMemberAnyAttribute(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
