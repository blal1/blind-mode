using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Xml.Schema;

public class XsdSimpleValue : Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_xmlType;

	private static readonly System.IntPtr NativeFieldInfoPtr_typedValue;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_XmlSchemaSimpleType_Object_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_XmlType_Public_get_XmlSchemaSimpleType_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_TypedValue_Public_get_Object_0;

	public unsafe XmlSchemaSimpleType xmlType
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_xmlType);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<XmlSchemaSimpleType>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_xmlType)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe Object typedValue
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_typedValue);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Object>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_typedValue)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe XmlSchemaSimpleType XmlType
	{
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 50644, RefRangeEnd = 50653, XrefRangeStart = 50644, XrefRangeEnd = 50653, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_XmlType_Public_get_XmlSchemaSimpleType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<XmlSchemaSimpleType>(intPtr2) : null;
		}
	}

	public unsafe Object TypedValue
	{
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 25665, RefRangeEnd = 25677, XrefRangeStart = 25665, XrefRangeEnd = 25677, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_TypedValue_Public_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
		}
	}

	static XsdSimpleValue()
	{
		Il2CppClassPointerStore<XsdSimpleValue>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml.Schema", "XsdSimpleValue");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XsdSimpleValue>.NativeClassPtr);
		NativeFieldInfoPtr_xmlType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdSimpleValue>.NativeClassPtr, "xmlType");
		NativeFieldInfoPtr_typedValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdSimpleValue>.NativeClassPtr, "typedValue");
		NativeMethodInfoPtr__ctor_Public_Void_XmlSchemaSimpleType_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdSimpleValue>.NativeClassPtr, 100666146);
		NativeMethodInfoPtr_get_XmlType_Public_get_XmlSchemaSimpleType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdSimpleValue>.NativeClassPtr, 100666147);
		NativeMethodInfoPtr_get_TypedValue_Public_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdSimpleValue>.NativeClassPtr, 100666148);
	}

	[CallerCount(138)]
	[CachedScanResults(RefRangeStart = 141598, RefRangeEnd = 141736, XrefRangeStart = 141598, XrefRangeEnd = 141736, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe XsdSimpleValue(XmlSchemaSimpleType st, Object value)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XsdSimpleValue>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)st);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_XmlSchemaSimpleType_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public XsdSimpleValue(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
