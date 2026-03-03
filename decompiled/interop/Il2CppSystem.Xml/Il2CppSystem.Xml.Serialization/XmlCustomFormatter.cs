using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Xml.Serialization;

public class XmlCustomFormatter : Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_allTimeFormats;

	private static readonly System.IntPtr NativeMethodInfoPtr_FromEnum_Internal_Static_String_Int64_Il2CppStringArray_Il2CppStructArray_1_Int64_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FromXmlName_Internal_Static_String_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FromXmlNCName_Internal_Static_String_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ToXmlString_Internal_Static_String_TypeData_Object_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FromXmlString_Internal_Static_Object_TypeData_String_0;

	public unsafe static Il2CppStringArray allTimeFormats
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_allTimeFormats, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_allTimeFormats, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	static XmlCustomFormatter()
	{
		Il2CppClassPointerStore<XmlCustomFormatter>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml.Serialization", "XmlCustomFormatter");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XmlCustomFormatter>.NativeClassPtr);
		NativeFieldInfoPtr_allTimeFormats = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlCustomFormatter>.NativeClassPtr, "allTimeFormats");
		NativeMethodInfoPtr_FromEnum_Internal_Static_String_Int64_Il2CppStringArray_Il2CppStructArray_1_Int64_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlCustomFormatter>.NativeClassPtr, 100665397);
		NativeMethodInfoPtr_FromXmlName_Internal_Static_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlCustomFormatter>.NativeClassPtr, 100665398);
		NativeMethodInfoPtr_FromXmlNCName_Internal_Static_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlCustomFormatter>.NativeClassPtr, 100665399);
		NativeMethodInfoPtr_ToXmlString_Internal_Static_String_TypeData_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlCustomFormatter>.NativeClassPtr, 100665400);
		NativeMethodInfoPtr_FromXmlString_Internal_Static_Object_TypeData_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlCustomFormatter>.NativeClassPtr, 100665401);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 915585, XrefRangeEnd = 915618, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string FromEnum(long value, Il2CppStringArray values, Il2CppStructArray<long> ids, string typeName)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = (nint)(&value);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)values);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)ids);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(typeName);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FromEnum_Internal_Static_String_Int64_Il2CppStringArray_Il2CppStructArray_1_Int64_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return IL2CPP.Il2CppStringToManaged(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 915625, RefRangeEnd = 915627, XrefRangeStart = 915618, XrefRangeEnd = 915625, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string FromXmlName(string name)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FromXmlName_Internal_Static_String_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return IL2CPP.Il2CppStringToManaged(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 915634, RefRangeEnd = 915635, XrefRangeStart = 915627, XrefRangeEnd = 915634, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string FromXmlNCName(string ncName)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(ncName);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FromXmlNCName_Internal_Static_String_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return IL2CPP.Il2CppStringToManaged(intPtr2);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 915675, RefRangeEnd = 915678, XrefRangeStart = 915635, XrefRangeEnd = 915675, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string ToXmlString(TypeData type, Object value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)type);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ToXmlString_Internal_Static_String_TypeData_Object_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return IL2CPP.Il2CppStringToManaged(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 915747, RefRangeEnd = 915749, XrefRangeStart = 915678, XrefRangeEnd = 915747, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Object FromXmlString(TypeData type, string value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)type);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FromXmlString_Internal_Static_Object_TypeData_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
	}

	public XmlCustomFormatter(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
