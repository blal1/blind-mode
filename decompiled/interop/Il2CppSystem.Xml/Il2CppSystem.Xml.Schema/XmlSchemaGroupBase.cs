using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Xml.Schema;

public class XmlSchemaGroupBase : XmlSchemaParticle
{
	private static readonly System.IntPtr NativeMethodInfoPtr_get_Items_Public_Abstract_Virtual_New_get_XmlSchemaObjectCollection_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetItems_Internal_Abstract_Virtual_New_Void_XmlSchemaObjectCollection_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

	public unsafe virtual XmlSchemaObjectCollection Items
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_get_Items_Public_Abstract_Virtual_New_get_XmlSchemaObjectCollection_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<XmlSchemaObjectCollection>(intPtr2) : null;
		}
	}

	static XmlSchemaGroupBase()
	{
		Il2CppClassPointerStore<XmlSchemaGroupBase>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml.Schema", "XmlSchemaGroupBase");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XmlSchemaGroupBase>.NativeClassPtr);
		NativeMethodInfoPtr_get_Items_Public_Abstract_Virtual_New_get_XmlSchemaObjectCollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaGroupBase>.NativeClassPtr, 100667695);
		NativeMethodInfoPtr_SetItems_Internal_Abstract_Virtual_New_Void_XmlSchemaObjectCollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaGroupBase>.NativeClassPtr, 100667696);
		NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaGroupBase>.NativeClassPtr, 100667697);
	}

	[CallerCount(0)]
	public unsafe virtual void SetItems(XmlSchemaObjectCollection newItems)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)newItems);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_SetItems_Internal_Abstract_Virtual_New_Void_XmlSchemaObjectCollection_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 940108, RefRangeEnd = 940109, XrefRangeStart = 940104, XrefRangeEnd = 940108, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe XmlSchemaGroupBase()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XmlSchemaGroupBase>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public XmlSchemaGroupBase(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
