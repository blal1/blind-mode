using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Reflection;

namespace Il2CppSystem.Runtime.Serialization.Formatters.Binary;

public sealed class Converter : Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_primitiveTypeEnumLength;

	private static readonly System.IntPtr NativeFieldInfoPtr_typeA;

	private static readonly System.IntPtr NativeFieldInfoPtr_arrayTypeA;

	private static readonly System.IntPtr NativeFieldInfoPtr_valueA;

	private static readonly System.IntPtr NativeFieldInfoPtr_typeCodeA;

	private static readonly System.IntPtr NativeFieldInfoPtr_codeA;

	private static readonly System.IntPtr NativeFieldInfoPtr_typeofISerializable;

	private static readonly System.IntPtr NativeFieldInfoPtr_typeofString;

	private static readonly System.IntPtr NativeFieldInfoPtr_typeofConverter;

	private static readonly System.IntPtr NativeFieldInfoPtr_typeofBoolean;

	private static readonly System.IntPtr NativeFieldInfoPtr_typeofByte;

	private static readonly System.IntPtr NativeFieldInfoPtr_typeofChar;

	private static readonly System.IntPtr NativeFieldInfoPtr_typeofDecimal;

	private static readonly System.IntPtr NativeFieldInfoPtr_typeofDouble;

	private static readonly System.IntPtr NativeFieldInfoPtr_typeofInt16;

	private static readonly System.IntPtr NativeFieldInfoPtr_typeofInt32;

	private static readonly System.IntPtr NativeFieldInfoPtr_typeofInt64;

	private static readonly System.IntPtr NativeFieldInfoPtr_typeofSByte;

	private static readonly System.IntPtr NativeFieldInfoPtr_typeofSingle;

	private static readonly System.IntPtr NativeFieldInfoPtr_typeofTimeSpan;

	private static readonly System.IntPtr NativeFieldInfoPtr_typeofDateTime;

	private static readonly System.IntPtr NativeFieldInfoPtr_typeofUInt16;

	private static readonly System.IntPtr NativeFieldInfoPtr_typeofUInt32;

	private static readonly System.IntPtr NativeFieldInfoPtr_typeofUInt64;

	private static readonly System.IntPtr NativeFieldInfoPtr_typeofObject;

	private static readonly System.IntPtr NativeFieldInfoPtr_typeofSystemVoid;

	private static readonly System.IntPtr NativeFieldInfoPtr_urtAssembly;

	private static readonly System.IntPtr NativeFieldInfoPtr_urtAssemblyString;

	private static readonly System.IntPtr NativeFieldInfoPtr_typeofTypeArray;

	private static readonly System.IntPtr NativeFieldInfoPtr_typeofObjectArray;

	private static readonly System.IntPtr NativeFieldInfoPtr_typeofStringArray;

	private static readonly System.IntPtr NativeFieldInfoPtr_typeofBooleanArray;

	private static readonly System.IntPtr NativeFieldInfoPtr_typeofByteArray;

	private static readonly System.IntPtr NativeFieldInfoPtr_typeofCharArray;

	private static readonly System.IntPtr NativeFieldInfoPtr_typeofDecimalArray;

	private static readonly System.IntPtr NativeFieldInfoPtr_typeofDoubleArray;

	private static readonly System.IntPtr NativeFieldInfoPtr_typeofInt16Array;

	private static readonly System.IntPtr NativeFieldInfoPtr_typeofInt32Array;

	private static readonly System.IntPtr NativeFieldInfoPtr_typeofInt64Array;

	private static readonly System.IntPtr NativeFieldInfoPtr_typeofSByteArray;

	private static readonly System.IntPtr NativeFieldInfoPtr_typeofSingleArray;

	private static readonly System.IntPtr NativeFieldInfoPtr_typeofTimeSpanArray;

	private static readonly System.IntPtr NativeFieldInfoPtr_typeofDateTimeArray;

	private static readonly System.IntPtr NativeFieldInfoPtr_typeofUInt16Array;

	private static readonly System.IntPtr NativeFieldInfoPtr_typeofUInt32Array;

	private static readonly System.IntPtr NativeFieldInfoPtr_typeofUInt64Array;

	private static readonly System.IntPtr NativeFieldInfoPtr_typeofMarshalByRefObject;

	private static readonly System.IntPtr NativeMethodInfoPtr_ToCode_Internal_Static_InternalPrimitiveTypeE_Type_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsWriteAsByteArray_Internal_Static_Boolean_InternalPrimitiveTypeE_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_TypeLength_Internal_Static_Int32_InternalPrimitiveTypeE_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ToArrayType_Internal_Static_Type_InternalPrimitiveTypeE_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_InitTypeA_Private_Static_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_InitArrayTypeA_Private_Static_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ToType_Internal_Static_Type_InternalPrimitiveTypeE_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CreatePrimitiveArray_Internal_Static_Array_InternalPrimitiveTypeE_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsPrimitiveArray_Internal_Static_Boolean_Type_byref_Object_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_InitValueA_Private_Static_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ToComType_Internal_Static_String_InternalPrimitiveTypeE_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_InitTypeCodeA_Private_Static_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ToTypeCode_Internal_Static_TypeCode_InternalPrimitiveTypeE_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_InitCodeA_Private_Static_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ToPrimitiveTypeEnum_Internal_Static_InternalPrimitiveTypeE_TypeCode_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FromString_Internal_Static_Object_String_InternalPrimitiveTypeE_0;

	public unsafe static int primitiveTypeEnumLength
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_primitiveTypeEnumLength, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_primitiveTypeEnumLength, (void*)(&value));
		}
	}

	public unsafe static Il2CppReferenceArray<Type> typeA
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_typeA, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Type>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_typeA, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static Il2CppReferenceArray<Type> arrayTypeA
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_arrayTypeA, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Type>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_arrayTypeA, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static Il2CppStringArray valueA
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_valueA, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_valueA, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static Il2CppStructArray<TypeCode> typeCodeA
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_typeCodeA, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<TypeCode>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_typeCodeA, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static Il2CppStructArray<InternalPrimitiveTypeE> codeA
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_codeA, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<InternalPrimitiveTypeE>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_codeA, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static Type typeofISerializable
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_typeofISerializable, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_typeofISerializable, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static Type typeofString
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_typeofString, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_typeofString, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static Type typeofConverter
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_typeofConverter, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_typeofConverter, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static Type typeofBoolean
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_typeofBoolean, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_typeofBoolean, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static Type typeofByte
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_typeofByte, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_typeofByte, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static Type typeofChar
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_typeofChar, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_typeofChar, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static Type typeofDecimal
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_typeofDecimal, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_typeofDecimal, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static Type typeofDouble
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_typeofDouble, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_typeofDouble, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static Type typeofInt16
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_typeofInt16, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_typeofInt16, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static Type typeofInt32
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_typeofInt32, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_typeofInt32, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static Type typeofInt64
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_typeofInt64, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_typeofInt64, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static Type typeofSByte
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_typeofSByte, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_typeofSByte, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static Type typeofSingle
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_typeofSingle, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_typeofSingle, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static Type typeofTimeSpan
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_typeofTimeSpan, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_typeofTimeSpan, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static Type typeofDateTime
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_typeofDateTime, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_typeofDateTime, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static Type typeofUInt16
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_typeofUInt16, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_typeofUInt16, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static Type typeofUInt32
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_typeofUInt32, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_typeofUInt32, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static Type typeofUInt64
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_typeofUInt64, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_typeofUInt64, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static Type typeofObject
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_typeofObject, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_typeofObject, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static Type typeofSystemVoid
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_typeofSystemVoid, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_typeofSystemVoid, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static Assembly urtAssembly
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_urtAssembly, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Assembly>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_urtAssembly, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static string urtAssemblyString
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_urtAssemblyString, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_urtAssemblyString, (void*)IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe static Type typeofTypeArray
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_typeofTypeArray, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_typeofTypeArray, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static Type typeofObjectArray
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_typeofObjectArray, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_typeofObjectArray, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static Type typeofStringArray
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_typeofStringArray, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_typeofStringArray, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static Type typeofBooleanArray
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_typeofBooleanArray, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_typeofBooleanArray, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static Type typeofByteArray
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_typeofByteArray, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_typeofByteArray, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static Type typeofCharArray
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_typeofCharArray, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_typeofCharArray, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static Type typeofDecimalArray
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_typeofDecimalArray, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_typeofDecimalArray, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static Type typeofDoubleArray
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_typeofDoubleArray, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_typeofDoubleArray, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static Type typeofInt16Array
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_typeofInt16Array, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_typeofInt16Array, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static Type typeofInt32Array
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_typeofInt32Array, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_typeofInt32Array, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static Type typeofInt64Array
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_typeofInt64Array, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_typeofInt64Array, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static Type typeofSByteArray
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_typeofSByteArray, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_typeofSByteArray, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static Type typeofSingleArray
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_typeofSingleArray, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_typeofSingleArray, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static Type typeofTimeSpanArray
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_typeofTimeSpanArray, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_typeofTimeSpanArray, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static Type typeofDateTimeArray
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_typeofDateTimeArray, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_typeofDateTimeArray, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static Type typeofUInt16Array
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_typeofUInt16Array, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_typeofUInt16Array, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static Type typeofUInt32Array
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_typeofUInt32Array, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_typeofUInt32Array, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static Type typeofUInt64Array
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_typeofUInt64Array, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_typeofUInt64Array, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static Type typeofMarshalByRefObject
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_typeofMarshalByRefObject, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_typeofMarshalByRefObject, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	static Converter()
	{
		Il2CppClassPointerStore<Converter>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.Serialization.Formatters.Binary", "Converter");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Converter>.NativeClassPtr);
		NativeFieldInfoPtr_primitiveTypeEnumLength = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Converter>.NativeClassPtr, "primitiveTypeEnumLength");
		NativeFieldInfoPtr_typeA = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Converter>.NativeClassPtr, "typeA");
		NativeFieldInfoPtr_arrayTypeA = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Converter>.NativeClassPtr, "arrayTypeA");
		NativeFieldInfoPtr_valueA = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Converter>.NativeClassPtr, "valueA");
		NativeFieldInfoPtr_typeCodeA = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Converter>.NativeClassPtr, "typeCodeA");
		NativeFieldInfoPtr_codeA = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Converter>.NativeClassPtr, "codeA");
		NativeFieldInfoPtr_typeofISerializable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Converter>.NativeClassPtr, "typeofISerializable");
		NativeFieldInfoPtr_typeofString = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Converter>.NativeClassPtr, "typeofString");
		NativeFieldInfoPtr_typeofConverter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Converter>.NativeClassPtr, "typeofConverter");
		NativeFieldInfoPtr_typeofBoolean = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Converter>.NativeClassPtr, "typeofBoolean");
		NativeFieldInfoPtr_typeofByte = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Converter>.NativeClassPtr, "typeofByte");
		NativeFieldInfoPtr_typeofChar = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Converter>.NativeClassPtr, "typeofChar");
		NativeFieldInfoPtr_typeofDecimal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Converter>.NativeClassPtr, "typeofDecimal");
		NativeFieldInfoPtr_typeofDouble = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Converter>.NativeClassPtr, "typeofDouble");
		NativeFieldInfoPtr_typeofInt16 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Converter>.NativeClassPtr, "typeofInt16");
		NativeFieldInfoPtr_typeofInt32 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Converter>.NativeClassPtr, "typeofInt32");
		NativeFieldInfoPtr_typeofInt64 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Converter>.NativeClassPtr, "typeofInt64");
		NativeFieldInfoPtr_typeofSByte = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Converter>.NativeClassPtr, "typeofSByte");
		NativeFieldInfoPtr_typeofSingle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Converter>.NativeClassPtr, "typeofSingle");
		NativeFieldInfoPtr_typeofTimeSpan = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Converter>.NativeClassPtr, "typeofTimeSpan");
		NativeFieldInfoPtr_typeofDateTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Converter>.NativeClassPtr, "typeofDateTime");
		NativeFieldInfoPtr_typeofUInt16 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Converter>.NativeClassPtr, "typeofUInt16");
		NativeFieldInfoPtr_typeofUInt32 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Converter>.NativeClassPtr, "typeofUInt32");
		NativeFieldInfoPtr_typeofUInt64 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Converter>.NativeClassPtr, "typeofUInt64");
		NativeFieldInfoPtr_typeofObject = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Converter>.NativeClassPtr, "typeofObject");
		NativeFieldInfoPtr_typeofSystemVoid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Converter>.NativeClassPtr, "typeofSystemVoid");
		NativeFieldInfoPtr_urtAssembly = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Converter>.NativeClassPtr, "urtAssembly");
		NativeFieldInfoPtr_urtAssemblyString = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Converter>.NativeClassPtr, "urtAssemblyString");
		NativeFieldInfoPtr_typeofTypeArray = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Converter>.NativeClassPtr, "typeofTypeArray");
		NativeFieldInfoPtr_typeofObjectArray = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Converter>.NativeClassPtr, "typeofObjectArray");
		NativeFieldInfoPtr_typeofStringArray = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Converter>.NativeClassPtr, "typeofStringArray");
		NativeFieldInfoPtr_typeofBooleanArray = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Converter>.NativeClassPtr, "typeofBooleanArray");
		NativeFieldInfoPtr_typeofByteArray = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Converter>.NativeClassPtr, "typeofByteArray");
		NativeFieldInfoPtr_typeofCharArray = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Converter>.NativeClassPtr, "typeofCharArray");
		NativeFieldInfoPtr_typeofDecimalArray = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Converter>.NativeClassPtr, "typeofDecimalArray");
		NativeFieldInfoPtr_typeofDoubleArray = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Converter>.NativeClassPtr, "typeofDoubleArray");
		NativeFieldInfoPtr_typeofInt16Array = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Converter>.NativeClassPtr, "typeofInt16Array");
		NativeFieldInfoPtr_typeofInt32Array = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Converter>.NativeClassPtr, "typeofInt32Array");
		NativeFieldInfoPtr_typeofInt64Array = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Converter>.NativeClassPtr, "typeofInt64Array");
		NativeFieldInfoPtr_typeofSByteArray = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Converter>.NativeClassPtr, "typeofSByteArray");
		NativeFieldInfoPtr_typeofSingleArray = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Converter>.NativeClassPtr, "typeofSingleArray");
		NativeFieldInfoPtr_typeofTimeSpanArray = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Converter>.NativeClassPtr, "typeofTimeSpanArray");
		NativeFieldInfoPtr_typeofDateTimeArray = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Converter>.NativeClassPtr, "typeofDateTimeArray");
		NativeFieldInfoPtr_typeofUInt16Array = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Converter>.NativeClassPtr, "typeofUInt16Array");
		NativeFieldInfoPtr_typeofUInt32Array = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Converter>.NativeClassPtr, "typeofUInt32Array");
		NativeFieldInfoPtr_typeofUInt64Array = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Converter>.NativeClassPtr, "typeofUInt64Array");
		NativeFieldInfoPtr_typeofMarshalByRefObject = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Converter>.NativeClassPtr, "typeofMarshalByRefObject");
		NativeMethodInfoPtr_ToCode_Internal_Static_InternalPrimitiveTypeE_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Converter>.NativeClassPtr, 100670916);
		NativeMethodInfoPtr_IsWriteAsByteArray_Internal_Static_Boolean_InternalPrimitiveTypeE_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Converter>.NativeClassPtr, 100670917);
		NativeMethodInfoPtr_TypeLength_Internal_Static_Int32_InternalPrimitiveTypeE_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Converter>.NativeClassPtr, 100670918);
		NativeMethodInfoPtr_ToArrayType_Internal_Static_Type_InternalPrimitiveTypeE_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Converter>.NativeClassPtr, 100670919);
		NativeMethodInfoPtr_InitTypeA_Private_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Converter>.NativeClassPtr, 100670920);
		NativeMethodInfoPtr_InitArrayTypeA_Private_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Converter>.NativeClassPtr, 100670921);
		NativeMethodInfoPtr_ToType_Internal_Static_Type_InternalPrimitiveTypeE_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Converter>.NativeClassPtr, 100670922);
		NativeMethodInfoPtr_CreatePrimitiveArray_Internal_Static_Array_InternalPrimitiveTypeE_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Converter>.NativeClassPtr, 100670923);
		NativeMethodInfoPtr_IsPrimitiveArray_Internal_Static_Boolean_Type_byref_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Converter>.NativeClassPtr, 100670924);
		NativeMethodInfoPtr_InitValueA_Private_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Converter>.NativeClassPtr, 100670925);
		NativeMethodInfoPtr_ToComType_Internal_Static_String_InternalPrimitiveTypeE_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Converter>.NativeClassPtr, 100670926);
		NativeMethodInfoPtr_InitTypeCodeA_Private_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Converter>.NativeClassPtr, 100670927);
		NativeMethodInfoPtr_ToTypeCode_Internal_Static_TypeCode_InternalPrimitiveTypeE_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Converter>.NativeClassPtr, 100670928);
		NativeMethodInfoPtr_InitCodeA_Private_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Converter>.NativeClassPtr, 100670929);
		NativeMethodInfoPtr_ToPrimitiveTypeEnum_Internal_Static_InternalPrimitiveTypeE_TypeCode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Converter>.NativeClassPtr, 100670930);
		NativeMethodInfoPtr_FromString_Internal_Static_Object_String_InternalPrimitiveTypeE_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Converter>.NativeClassPtr, 100670931);
	}

	[CallerCount(6)]
	[CachedScanResults(RefRangeStart = 800279, RefRangeEnd = 800285, XrefRangeStart = 800270, XrefRangeEnd = 800279, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static InternalPrimitiveTypeE ToCode(Type type)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)type);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ToCode_Internal_Static_InternalPrimitiveTypeE_Type_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(InternalPrimitiveTypeE*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 800285, RefRangeEnd = 800288, XrefRangeStart = 800285, XrefRangeEnd = 800285, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool IsWriteAsByteArray(InternalPrimitiveTypeE code)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&code);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsWriteAsByteArray_Internal_Static_Boolean_InternalPrimitiveTypeE_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 800288, RefRangeEnd = 800289, XrefRangeStart = 800288, XrefRangeEnd = 800288, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int TypeLength(InternalPrimitiveTypeE code)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&code);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_TypeLength_Internal_Static_Int32_InternalPrimitiveTypeE_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 800289, XrefRangeEnd = 800301, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Type ToArrayType(InternalPrimitiveTypeE code)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&code);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ToArrayType_Internal_Static_Type_InternalPrimitiveTypeE_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 800390, RefRangeEnd = 800392, XrefRangeStart = 800301, XrefRangeEnd = 800390, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void InitTypeA()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InitTypeA_Private_Static_Void_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 800481, RefRangeEnd = 800482, XrefRangeStart = 800392, XrefRangeEnd = 800481, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void InitArrayTypeA()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InitArrayTypeA_Private_Static_Void_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 800494, RefRangeEnd = 800496, XrefRangeStart = 800482, XrefRangeEnd = 800494, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Type ToType(InternalPrimitiveTypeE code)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&code);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ToType_Internal_Static_Type_InternalPrimitiveTypeE_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 800541, RefRangeEnd = 800542, XrefRangeStart = 800496, XrefRangeEnd = 800541, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Array CreatePrimitiveArray(InternalPrimitiveTypeE code, int length)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&code);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &length;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CreatePrimitiveArray_Internal_Static_Array_InternalPrimitiveTypeE_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Array>(intPtr2) : null;
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 800585, RefRangeEnd = 800587, XrefRangeStart = 800542, XrefRangeEnd = 800585, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool IsPrimitiveArray(Type type, out Object typeInformation)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)type);
		byte* num = (byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)));
		nint num2 = 0;
		*(nint**)num = &num2;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsPrimitiveArray_Internal_Static_Boolean_Type_byref_Object_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		nint num3 = num2;
		typeInformation = ((num3 == 0) ? null : new Object(num3));
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 800646, RefRangeEnd = 800648, XrefRangeStart = 800587, XrefRangeEnd = 800646, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void InitValueA()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InitValueA_Private_Static_Void_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 800660, RefRangeEnd = 800661, XrefRangeStart = 800648, XrefRangeEnd = 800660, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string ToComType(InternalPrimitiveTypeE code)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&code);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ToComType_Internal_Static_String_InternalPrimitiveTypeE_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return IL2CPP.Il2CppStringToManaged(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 800661, XrefRangeEnd = 800674, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void InitTypeCodeA()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InitTypeCodeA_Private_Static_Void_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 800674, XrefRangeEnd = 800696, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static TypeCode ToTypeCode(InternalPrimitiveTypeE code)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&code);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ToTypeCode_Internal_Static_TypeCode_InternalPrimitiveTypeE_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(TypeCode*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 800696, XrefRangeEnd = 800708, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void InitCodeA()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InitCodeA_Private_Static_Void_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 800708, XrefRangeEnd = 800729, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static InternalPrimitiveTypeE ToPrimitiveTypeEnum(TypeCode typeCode)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&typeCode);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ToPrimitiveTypeEnum_Internal_Static_InternalPrimitiveTypeE_TypeCode_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(InternalPrimitiveTypeE*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 800732, RefRangeEnd = 800735, XrefRangeStart = 800729, XrefRangeEnd = 800732, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Object FromString(string value, InternalPrimitiveTypeE code)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
		*(InternalPrimitiveTypeE**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &code;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FromString_Internal_Static_Object_String_InternalPrimitiveTypeE_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
	}

	public Converter(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
