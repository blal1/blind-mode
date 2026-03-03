using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Runtime.Serialization.Formatters.Binary;

public static class BinaryConverter : Object
{
	private static readonly System.IntPtr NativeMethodInfoPtr_GetBinaryTypeInfo_Internal_Static_BinaryTypeEnum_Type_WriteObjectInfo_String_ObjectWriter_byref_Object_byref_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetParserBinaryTypeInfo_Internal_Static_BinaryTypeEnum_Type_byref_Object_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_WriteTypeInfo_Internal_Static_Void_BinaryTypeEnum_Object_Int32___BinaryWriter_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ReadTypeInfo_Internal_Static_Object_BinaryTypeEnum___BinaryParser_byref_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_TypeFromInfo_Internal_Static_Void_BinaryTypeEnum_Object_ObjectReader_BinaryAssemblyInfo_byref_InternalPrimitiveTypeE_byref_String_byref_Type_byref_Boolean_0;

	static BinaryConverter()
	{
		Il2CppClassPointerStore<BinaryConverter>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.Serialization.Formatters.Binary", "BinaryConverter");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BinaryConverter>.NativeClassPtr);
		NativeMethodInfoPtr_GetBinaryTypeInfo_Internal_Static_BinaryTypeEnum_Type_WriteObjectInfo_String_ObjectWriter_byref_Object_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BinaryConverter>.NativeClassPtr, 100670816);
		NativeMethodInfoPtr_GetParserBinaryTypeInfo_Internal_Static_BinaryTypeEnum_Type_byref_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BinaryConverter>.NativeClassPtr, 100670817);
		NativeMethodInfoPtr_WriteTypeInfo_Internal_Static_Void_BinaryTypeEnum_Object_Int32___BinaryWriter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BinaryConverter>.NativeClassPtr, 100670818);
		NativeMethodInfoPtr_ReadTypeInfo_Internal_Static_Object_BinaryTypeEnum___BinaryParser_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BinaryConverter>.NativeClassPtr, 100670819);
		NativeMethodInfoPtr_TypeFromInfo_Internal_Static_Void_BinaryTypeEnum_Object_ObjectReader_BinaryAssemblyInfo_byref_InternalPrimitiveTypeE_byref_String_byref_Type_byref_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BinaryConverter>.NativeClassPtr, 100670820);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 799904, RefRangeEnd = 799908, XrefRangeStart = 799871, XrefRangeEnd = 799904, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static BinaryTypeEnum GetBinaryTypeInfo(Type type, WriteObjectInfo objectInfo, string typeName, ObjectWriter objectWriter, out Object typeInformation, out int assemId)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[6];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)type);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)objectInfo);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(typeName);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)objectWriter);
		byte* num = (byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)));
		nint num2 = 0;
		*(nint**)num = &num2;
		*(void**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref assemId);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetBinaryTypeInfo_Internal_Static_BinaryTypeEnum_Type_WriteObjectInfo_String_ObjectWriter_byref_Object_byref_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		nint num3 = num2;
		typeInformation = ((num3 == 0) ? null : new Object(num3));
		return *(BinaryTypeEnum*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 799928, RefRangeEnd = 799929, XrefRangeStart = 799908, XrefRangeEnd = 799928, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static BinaryTypeEnum GetParserBinaryTypeInfo(Type type, out Object typeInformation)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)type);
		byte* num = (byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)));
		nint num2 = 0;
		*(nint**)num = &num2;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetParserBinaryTypeInfo_Internal_Static_BinaryTypeEnum_Type_byref_Object_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		nint num3 = num2;
		typeInformation = ((num3 == 0) ? null : new Object(num3));
		return *(BinaryTypeEnum*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 799930, RefRangeEnd = 799932, XrefRangeStart = 799929, XrefRangeEnd = 799930, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void WriteTypeInfo(BinaryTypeEnum binaryTypeEnum, Object typeInformation, int assemId, __BinaryWriter sout)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = (nint)(&binaryTypeEnum);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)typeInformation);
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &assemId;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)sout);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_WriteTypeInfo_Internal_Static_Void_BinaryTypeEnum_Object_Int32___BinaryWriter_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 799934, RefRangeEnd = 799936, XrefRangeStart = 799932, XrefRangeEnd = 799934, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Object ReadTypeInfo(BinaryTypeEnum binaryTypeEnum, __BinaryParser input, out int assemId)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&binaryTypeEnum);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)input);
		*(void**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref assemId);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ReadTypeInfo_Internal_Static_Object_BinaryTypeEnum___BinaryParser_byref_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 799970, RefRangeEnd = 799972, XrefRangeStart = 799936, XrefRangeEnd = 799970, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void TypeFromInfo(BinaryTypeEnum binaryTypeEnum, Object typeInformation, ObjectReader objectReader, BinaryAssemblyInfo assemblyInfo, out InternalPrimitiveTypeE primitiveTypeEnum, out string typeString, out Type type, out bool isVariant)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[8];
		*ptr = (nint)(&binaryTypeEnum);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)typeInformation);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)objectReader);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)assemblyInfo);
		*(void**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref primitiveTypeEnum);
		byte* num = (byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)));
		nint num2 = 0;
		*(nint**)num = &num2;
		byte* num3 = (byte*)ptr + checked((nuint)6u * unchecked((nuint)sizeof(System.IntPtr)));
		nint num4 = 0;
		*(nint**)num3 = &num4;
		*(void**)((byte*)ptr + checked((nuint)7u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref isVariant);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_TypeFromInfo_Internal_Static_Void_BinaryTypeEnum_Object_ObjectReader_BinaryAssemblyInfo_byref_InternalPrimitiveTypeE_byref_String_byref_Type_byref_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		typeString = IL2CPP.Il2CppStringToManaged((System.IntPtr)num2);
		nint num5 = num4;
		type = ((num5 == 0) ? null : new Type(num5));
	}

	public BinaryConverter(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
