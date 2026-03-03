using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem.Collections;

namespace Il2CppSystem.Xml.Serialization;

[DefaultMember("Item")]
public class XmlArrayItemAttributes : CollectionBase
{
	private static readonly System.IntPtr NativeMethodInfoPtr_Add_Public_Int32_XmlArrayItemAttribute_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	static XmlArrayItemAttributes()
	{
		Il2CppClassPointerStore<XmlArrayItemAttributes>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml.Serialization", "XmlArrayItemAttributes");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XmlArrayItemAttributes>.NativeClassPtr);
		NativeMethodInfoPtr_Add_Public_Int32_XmlArrayItemAttribute_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlArrayItemAttributes>.NativeClassPtr, 100665367);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlArrayItemAttributes>.NativeClassPtr, 100665368);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 915389, RefRangeEnd = 915390, XrefRangeStart = 915384, XrefRangeEnd = 915389, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int Add(XmlArrayItemAttribute attribute)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)attribute);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Add_Public_Int32_XmlArrayItemAttribute_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(13)]
	[CachedScanResults(RefRangeStart = 691958, RefRangeEnd = 691971, XrefRangeStart = 691958, XrefRangeEnd = 691971, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe XmlArrayItemAttributes()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XmlArrayItemAttributes>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public XmlArrayItemAttributes(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
