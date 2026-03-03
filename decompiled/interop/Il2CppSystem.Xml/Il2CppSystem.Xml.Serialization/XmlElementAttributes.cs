using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections;

namespace Il2CppSystem.Xml.Serialization;

public class XmlElementAttributes : CollectionBase
{
	private static readonly System.IntPtr NativeMethodInfoPtr_get_Item_Public_get_XmlElementAttribute_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Add_Public_Int32_XmlElementAttribute_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_Order_Internal_get_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe XmlElementAttribute this[int index]
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 915754, XrefRangeEnd = 915760, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&index);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_Item_Public_get_XmlElementAttribute_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<XmlElementAttribute>(intPtr2) : null;
		}
	}

	public unsafe int Order
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 915777, RefRangeEnd = 915778, XrefRangeStart = 915767, XrefRangeEnd = 915777, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

	static XmlElementAttributes()
	{
		Il2CppClassPointerStore<XmlElementAttributes>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml.Serialization", "XmlElementAttributes");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XmlElementAttributes>.NativeClassPtr);
		NativeMethodInfoPtr_get_Item_Public_get_XmlElementAttribute_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlElementAttributes>.NativeClassPtr, 100665412);
		NativeMethodInfoPtr_Add_Public_Int32_XmlElementAttribute_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlElementAttributes>.NativeClassPtr, 100665413);
		NativeMethodInfoPtr_get_Order_Internal_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlElementAttributes>.NativeClassPtr, 100665414);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlElementAttributes>.NativeClassPtr, 100665415);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 915766, RefRangeEnd = 915767, XrefRangeStart = 915760, XrefRangeEnd = 915766, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int Add(XmlElementAttribute attribute)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)attribute);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Add_Public_Int32_XmlElementAttribute_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(13)]
	[CachedScanResults(RefRangeStart = 691958, RefRangeEnd = 691971, XrefRangeStart = 691958, XrefRangeEnd = 691971, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe XmlElementAttributes()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XmlElementAttributes>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public XmlElementAttributes(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
