using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem.Collections;

namespace Il2CppSystem.Xml.Serialization;

[DefaultMember("Item")]
public class XmlAnyElementAttributes : CollectionBase
{
	private static readonly System.IntPtr NativeMethodInfoPtr_Add_Public_Int32_XmlAnyElementAttribute_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_Order_Internal_get_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe int Order
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 915375, RefRangeEnd = 915376, XrefRangeStart = 915365, XrefRangeEnd = 915375, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_Order_Internal_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	static XmlAnyElementAttributes()
	{
		Il2CppClassPointerStore<XmlAnyElementAttributes>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml.Serialization", "XmlAnyElementAttributes");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XmlAnyElementAttributes>.NativeClassPtr);
		NativeMethodInfoPtr_Add_Public_Int32_XmlAnyElementAttribute_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlAnyElementAttributes>.NativeClassPtr, 100665349);
		NativeMethodInfoPtr_get_Order_Internal_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlAnyElementAttributes>.NativeClassPtr, 100665350);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlAnyElementAttributes>.NativeClassPtr, 100665351);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 915364, RefRangeEnd = 915365, XrefRangeStart = 915359, XrefRangeEnd = 915364, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int Add(XmlAnyElementAttribute attribute)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)attribute);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Add_Public_Int32_XmlAnyElementAttribute_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(13)]
	[CachedScanResults(RefRangeStart = 691958, RefRangeEnd = 691971, XrefRangeStart = 691958, XrefRangeEnd = 691971, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe XmlAnyElementAttributes()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XmlAnyElementAttributes>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public XmlAnyElementAttributes(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
