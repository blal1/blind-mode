using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Xml.Schema;

namespace Il2CppSystem.Xml;

public class XmlAsyncCheckReaderWithLineInfoNSSchema : XmlAsyncCheckReaderWithLineInfoNS
{
	private static readonly System.IntPtr NativeFieldInfoPtr_readerAsIXmlSchemaInfo;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_XmlReader_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_System_Xml_Schema_IXmlSchemaInfo_get_Validity_Private_Virtual_Final_New_get_XmlSchemaValidity_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_System_Xml_Schema_IXmlSchemaInfo_get_IsDefault_Private_Virtual_Final_New_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_System_Xml_Schema_IXmlSchemaInfo_get_IsNil_Private_Virtual_Final_New_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_System_Xml_Schema_IXmlSchemaInfo_get_MemberType_Private_Virtual_Final_New_get_XmlSchemaSimpleType_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_System_Xml_Schema_IXmlSchemaInfo_get_SchemaType_Private_Virtual_Final_New_get_XmlSchemaType_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_System_Xml_Schema_IXmlSchemaInfo_get_SchemaElement_Private_Virtual_Final_New_get_XmlSchemaElement_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_System_Xml_Schema_IXmlSchemaInfo_get_SchemaAttribute_Private_Virtual_Final_New_get_XmlSchemaAttribute_0;

	public unsafe IXmlSchemaInfo readerAsIXmlSchemaInfo
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_readerAsIXmlSchemaInfo);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<IXmlSchemaInfo>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_readerAsIXmlSchemaInfo)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe virtual XmlSchemaValidity System_002EXml_002ESchema_002EIXmlSchemaInfo_002EValidity
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 901894, XrefRangeEnd = 901898, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_System_Xml_Schema_IXmlSchemaInfo_get_Validity_Private_Virtual_Final_New_get_XmlSchemaValidity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(XmlSchemaValidity*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe virtual bool System_002EXml_002ESchema_002EIXmlSchemaInfo_002EIsDefault
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 901898, XrefRangeEnd = 901902, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_System_Xml_Schema_IXmlSchemaInfo_get_IsDefault_Private_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe virtual bool System_002EXml_002ESchema_002EIXmlSchemaInfo_002EIsNil
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 901902, XrefRangeEnd = 901906, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_System_Xml_Schema_IXmlSchemaInfo_get_IsNil_Private_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe virtual XmlSchemaSimpleType System_002EXml_002ESchema_002EIXmlSchemaInfo_002EMemberType
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 901906, XrefRangeEnd = 901910, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_System_Xml_Schema_IXmlSchemaInfo_get_MemberType_Private_Virtual_Final_New_get_XmlSchemaSimpleType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<XmlSchemaSimpleType>(intPtr2) : null;
		}
	}

	public unsafe virtual XmlSchemaType System_002EXml_002ESchema_002EIXmlSchemaInfo_002ESchemaType
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 901910, XrefRangeEnd = 901914, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_System_Xml_Schema_IXmlSchemaInfo_get_SchemaType_Private_Virtual_Final_New_get_XmlSchemaType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<XmlSchemaType>(intPtr2) : null;
		}
	}

	public unsafe virtual XmlSchemaElement System_002EXml_002ESchema_002EIXmlSchemaInfo_002ESchemaElement
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 901914, XrefRangeEnd = 901918, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_System_Xml_Schema_IXmlSchemaInfo_get_SchemaElement_Private_Virtual_Final_New_get_XmlSchemaElement_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<XmlSchemaElement>(intPtr2) : null;
		}
	}

	public unsafe virtual XmlSchemaAttribute System_002EXml_002ESchema_002EIXmlSchemaInfo_002ESchemaAttribute
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 901918, XrefRangeEnd = 901922, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_System_Xml_Schema_IXmlSchemaInfo_get_SchemaAttribute_Private_Virtual_Final_New_get_XmlSchemaAttribute_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<XmlSchemaAttribute>(intPtr2) : null;
		}
	}

	static XmlAsyncCheckReaderWithLineInfoNSSchema()
	{
		Il2CppClassPointerStore<XmlAsyncCheckReaderWithLineInfoNSSchema>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml", "XmlAsyncCheckReaderWithLineInfoNSSchema");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XmlAsyncCheckReaderWithLineInfoNSSchema>.NativeClassPtr);
		NativeFieldInfoPtr_readerAsIXmlSchemaInfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlAsyncCheckReaderWithLineInfoNSSchema>.NativeClassPtr, "readerAsIXmlSchemaInfo");
		NativeMethodInfoPtr__ctor_Public_Void_XmlReader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlAsyncCheckReaderWithLineInfoNSSchema>.NativeClassPtr, 100663477);
		NativeMethodInfoPtr_System_Xml_Schema_IXmlSchemaInfo_get_Validity_Private_Virtual_Final_New_get_XmlSchemaValidity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlAsyncCheckReaderWithLineInfoNSSchema>.NativeClassPtr, 100663478);
		NativeMethodInfoPtr_System_Xml_Schema_IXmlSchemaInfo_get_IsDefault_Private_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlAsyncCheckReaderWithLineInfoNSSchema>.NativeClassPtr, 100663479);
		NativeMethodInfoPtr_System_Xml_Schema_IXmlSchemaInfo_get_IsNil_Private_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlAsyncCheckReaderWithLineInfoNSSchema>.NativeClassPtr, 100663480);
		NativeMethodInfoPtr_System_Xml_Schema_IXmlSchemaInfo_get_MemberType_Private_Virtual_Final_New_get_XmlSchemaSimpleType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlAsyncCheckReaderWithLineInfoNSSchema>.NativeClassPtr, 100663481);
		NativeMethodInfoPtr_System_Xml_Schema_IXmlSchemaInfo_get_SchemaType_Private_Virtual_Final_New_get_XmlSchemaType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlAsyncCheckReaderWithLineInfoNSSchema>.NativeClassPtr, 100663482);
		NativeMethodInfoPtr_System_Xml_Schema_IXmlSchemaInfo_get_SchemaElement_Private_Virtual_Final_New_get_XmlSchemaElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlAsyncCheckReaderWithLineInfoNSSchema>.NativeClassPtr, 100663483);
		NativeMethodInfoPtr_System_Xml_Schema_IXmlSchemaInfo_get_SchemaAttribute_Private_Virtual_Final_New_get_XmlSchemaAttribute_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlAsyncCheckReaderWithLineInfoNSSchema>.NativeClassPtr, 100663484);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 901884, XrefRangeEnd = 901894, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe XmlAsyncCheckReaderWithLineInfoNSSchema(XmlReader reader)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XmlAsyncCheckReaderWithLineInfoNSSchema>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)reader);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_XmlReader_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public XmlAsyncCheckReaderWithLineInfoNSSchema(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
