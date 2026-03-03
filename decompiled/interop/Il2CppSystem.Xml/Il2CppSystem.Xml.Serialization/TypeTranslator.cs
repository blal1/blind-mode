using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections;

namespace Il2CppSystem.Xml.Serialization;

public class TypeTranslator : Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_nameCache;

	private static readonly System.IntPtr NativeFieldInfoPtr_primitiveTypes;

	private static readonly System.IntPtr NativeFieldInfoPtr_primitiveArrayTypes;

	private static readonly System.IntPtr NativeFieldInfoPtr_nullableTypes;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetTypeData_Public_Static_TypeData_Type_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetTypeData_Public_Static_TypeData_Type_String_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetPrimitiveTypeData_Public_Static_TypeData_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetPrimitiveTypeData_Public_Static_TypeData_String_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FindPrimitiveTypeData_Public_Static_TypeData_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetArrayName_Public_Static_String_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ParseArrayType_Public_Static_Void_String_byref_String_byref_String_byref_String_0;

	public unsafe static Hashtable nameCache
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_nameCache, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Hashtable>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_nameCache, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static Hashtable primitiveTypes
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_primitiveTypes, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Hashtable>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_primitiveTypes, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static Hashtable primitiveArrayTypes
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_primitiveArrayTypes, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Hashtable>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_primitiveArrayTypes, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static Hashtable nullableTypes
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_nullableTypes, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Hashtable>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_nullableTypes, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	static TypeTranslator()
	{
		Il2CppClassPointerStore<TypeTranslator>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml.Serialization", "TypeTranslator");
		NativeFieldInfoPtr_nameCache = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TypeTranslator>.NativeClassPtr, "nameCache");
		NativeFieldInfoPtr_primitiveTypes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TypeTranslator>.NativeClassPtr, "primitiveTypes");
		NativeFieldInfoPtr_primitiveArrayTypes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TypeTranslator>.NativeClassPtr, "primitiveArrayTypes");
		NativeFieldInfoPtr_nullableTypes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TypeTranslator>.NativeClassPtr, "nullableTypes");
		NativeMethodInfoPtr_GetTypeData_Public_Static_TypeData_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeTranslator>.NativeClassPtr, 100665337);
		NativeMethodInfoPtr_GetTypeData_Public_Static_TypeData_Type_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeTranslator>.NativeClassPtr, 100665338);
		NativeMethodInfoPtr_GetPrimitiveTypeData_Public_Static_TypeData_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeTranslator>.NativeClassPtr, 100665339);
		NativeMethodInfoPtr_GetPrimitiveTypeData_Public_Static_TypeData_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeTranslator>.NativeClassPtr, 100665340);
		NativeMethodInfoPtr_FindPrimitiveTypeData_Public_Static_TypeData_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeTranslator>.NativeClassPtr, 100665341);
		NativeMethodInfoPtr_GetArrayName_Public_Static_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeTranslator>.NativeClassPtr, 100665342);
		NativeMethodInfoPtr_ParseArrayType_Public_Static_Void_String_byref_String_byref_String_byref_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeTranslator>.NativeClassPtr, 100665343);
	}

	[CallerCount(15)]
	[CachedScanResults(RefRangeStart = 914635, RefRangeEnd = 914650, XrefRangeStart = 914631, XrefRangeEnd = 914635, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static TypeData GetTypeData(Type type)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)type);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetTypeData_Public_Static_TypeData_Type_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<TypeData>(intPtr2) : null;
	}

	[CallerCount(10)]
	[CachedScanResults(RefRangeStart = 914690, RefRangeEnd = 914700, XrefRangeStart = 914650, XrefRangeEnd = 914690, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static TypeData GetTypeData(Type runtimeType, string xmlDataType, bool underlyingEnumType = false)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)runtimeType);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(xmlDataType);
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &underlyingEnumType;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetTypeData_Public_Static_TypeData_Type_String_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<TypeData>(intPtr2) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 914704, RefRangeEnd = 914705, XrefRangeStart = 914700, XrefRangeEnd = 914704, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static TypeData GetPrimitiveTypeData(string typeName)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(typeName);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetPrimitiveTypeData_Public_Static_TypeData_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<TypeData>(intPtr2) : null;
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 914712, RefRangeEnd = 914714, XrefRangeStart = 914705, XrefRangeEnd = 914712, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static TypeData GetPrimitiveTypeData(string typeName, bool nullable)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(typeName);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &nullable;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetPrimitiveTypeData_Public_Static_TypeData_String_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<TypeData>(intPtr2) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 914720, RefRangeEnd = 914721, XrefRangeStart = 914714, XrefRangeEnd = 914720, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static TypeData FindPrimitiveTypeData(string typeName)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(typeName);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FindPrimitiveTypeData_Public_Static_TypeData_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<TypeData>(intPtr2) : null;
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 914734, RefRangeEnd = 914737, XrefRangeStart = 914721, XrefRangeEnd = 914734, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string GetArrayName(string elemName)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(elemName);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetArrayName_Public_Static_String_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return IL2CPP.Il2CppStringToManaged(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 915346, RefRangeEnd = 915348, XrefRangeStart = 914737, XrefRangeEnd = 915346, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void ParseArrayType(string arrayType, out string type, out string ns, out string dimensions)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(arrayType);
		byte* num = (byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)));
		nint num2 = 0;
		*(nint**)num = &num2;
		byte* num3 = (byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)));
		nint num4 = 0;
		*(nint**)num3 = &num4;
		byte* num5 = (byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)));
		nint num6 = 0;
		*(nint**)num5 = &num6;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ParseArrayType_Public_Static_Void_String_byref_String_byref_String_byref_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		type = IL2CPP.Il2CppStringToManaged((System.IntPtr)num2);
		ns = IL2CPP.Il2CppStringToManaged((System.IntPtr)num4);
		dimensions = IL2CPP.Il2CppStringToManaged((System.IntPtr)num6);
	}

	public TypeTranslator(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
