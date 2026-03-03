using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Xml.Schema;

public class XmlUnionConverter : XmlBaseConverter
{
	private static readonly System.IntPtr NativeFieldInfoPtr_converters;

	private static readonly System.IntPtr NativeFieldInfoPtr_hasAtomicMember;

	private static readonly System.IntPtr NativeFieldInfoPtr_hasListMember;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Protected_Void_XmlSchemaType_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Create_Public_Static_XmlValueConverter_XmlSchemaType_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ChangeType_Public_Virtual_Object_Object_Type_IXmlNamespaceResolver_0;

	public unsafe Il2CppReferenceArray<XmlValueConverter> converters
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_converters);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<XmlValueConverter>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_converters)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe bool hasAtomicMember
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_hasAtomicMember);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_hasAtomicMember)) = value;
		}
	}

	public unsafe bool hasListMember
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_hasListMember);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_hasListMember)) = value;
		}
	}

	static XmlUnionConverter()
	{
		Il2CppClassPointerStore<XmlUnionConverter>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml.Schema", "XmlUnionConverter");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XmlUnionConverter>.NativeClassPtr);
		NativeFieldInfoPtr_converters = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlUnionConverter>.NativeClassPtr, "converters");
		NativeFieldInfoPtr_hasAtomicMember = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlUnionConverter>.NativeClassPtr, "hasAtomicMember");
		NativeFieldInfoPtr_hasListMember = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlUnionConverter>.NativeClassPtr, "hasListMember");
		NativeMethodInfoPtr__ctor_Protected_Void_XmlSchemaType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlUnionConverter>.NativeClassPtr, 100668409);
		NativeMethodInfoPtr_Create_Public_Static_XmlValueConverter_XmlSchemaType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlUnionConverter>.NativeClassPtr, 100668410);
		NativeMethodInfoPtr_ChangeType_Public_Virtual_Object_Object_Type_IXmlNamespaceResolver_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlUnionConverter>.NativeClassPtr, 100668411);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 950025, RefRangeEnd = 950026, XrefRangeStart = 950007, XrefRangeEnd = 950025, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe XmlUnionConverter(XmlSchemaType schemaType)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XmlUnionConverter>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)schemaType);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Protected_Void_XmlSchemaType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 950030, RefRangeEnd = 950031, XrefRangeStart = 950026, XrefRangeEnd = 950030, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static XmlValueConverter Create(XmlSchemaType schemaType)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)schemaType);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Create_Public_Static_XmlValueConverter_XmlSchemaType_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<XmlValueConverter>(intPtr2) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 950031, XrefRangeEnd = 950047, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override Object ChangeType(Object value, Type destinationType, IXmlNamespaceResolver nsResolver)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)destinationType);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)nsResolver);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_ChangeType_Public_Virtual_Object_Object_Type_IXmlNamespaceResolver_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
	}

	public XmlUnionConverter(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
