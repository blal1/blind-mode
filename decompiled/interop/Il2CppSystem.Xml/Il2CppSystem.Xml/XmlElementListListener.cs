using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Xml;

public class XmlElementListListener : Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_elemList;

	private static readonly System.IntPtr NativeFieldInfoPtr_doc;

	private static readonly System.IntPtr NativeFieldInfoPtr_nodeChangeHandler;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Internal_Void_XmlDocument_XmlElementList_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnListChanged_Private_Void_Object_XmlNodeChangedEventArgs_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Unregister_Internal_Void_0;

	public unsafe WeakReference elemList
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_elemList);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<WeakReference>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_elemList)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe XmlDocument doc
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_doc);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<XmlDocument>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_doc)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe XmlNodeChangedEventHandler nodeChangeHandler
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_nodeChangeHandler);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<XmlNodeChangedEventHandler>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_nodeChangeHandler)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	static XmlElementListListener()
	{
		Il2CppClassPointerStore<XmlElementListListener>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml", "XmlElementListListener");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XmlElementListListener>.NativeClassPtr);
		NativeFieldInfoPtr_elemList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlElementListListener>.NativeClassPtr, "elemList");
		NativeFieldInfoPtr_doc = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlElementListListener>.NativeClassPtr, "doc");
		NativeFieldInfoPtr_nodeChangeHandler = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlElementListListener>.NativeClassPtr, "nodeChangeHandler");
		NativeMethodInfoPtr__ctor_Internal_Void_XmlDocument_XmlElementList_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlElementListListener>.NativeClassPtr, 100664523);
		NativeMethodInfoPtr_OnListChanged_Private_Void_Object_XmlNodeChangedEventArgs_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlElementListListener>.NativeClassPtr, 100664524);
		NativeMethodInfoPtr_Unregister_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlElementListListener>.NativeClassPtr, 100664525);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 907915, RefRangeEnd = 907917, XrefRangeStart = 907875, XrefRangeEnd = 907915, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe XmlElementListListener(XmlDocument doc, XmlElementList elemList)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XmlElementListListener>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)doc);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)elemList);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Internal_Void_XmlDocument_XmlElementList_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 907917, XrefRangeEnd = 907933, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnListChanged(Object sender, XmlNodeChangedEventArgs args)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)sender);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)args);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnListChanged_Private_Void_Object_XmlNodeChangedEventArgs_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 907940, RefRangeEnd = 907941, XrefRangeStart = 907933, XrefRangeEnd = 907940, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Unregister()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Unregister_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public XmlElementListListener(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
