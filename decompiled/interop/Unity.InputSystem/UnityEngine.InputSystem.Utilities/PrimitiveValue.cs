using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Reflection;

namespace UnityEngine.InputSystem.Utilities;

[StructLayout(LayoutKind.Explicit)]
public struct PrimitiveValue
{
	private sealed class MethodInfoStoreGeneric_From_Public_Static_PrimitiveValue_TValue_0<TValue>
	{
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_From_Public_Static_PrimitiveValue_TValue_0, Il2CppClassPointerStore<PrimitiveValue>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1] { Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TValue>.NativeClassPtr)) }))));
	}

	private static readonly System.IntPtr NativeFieldInfoPtr_m_Type;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_BoolValue;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_CharValue;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_ByteValue;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_SByteValue;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_ShortValue;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_UShortValue;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_IntValue;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_UIntValue;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_LongValue;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_ULongValue;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_FloatValue;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_DoubleValue;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_valuePtr_Internal_get_ptr_Byte_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_type_Public_get_TypeCode_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_isEmpty_Public_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Char_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Byte_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_SByte_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int16_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_UInt16_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_UInt32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int64_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_UInt64_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Double_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ConvertTo_Public_PrimitiveValue_TypeCode_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_PrimitiveValue_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_PrimitiveValue_PrimitiveValue_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_PrimitiveValue_PrimitiveValue_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FromString_Public_Static_PrimitiveValue_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetTypeCode_Public_Virtual_Final_New_TypeCode_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ToBoolean_Public_Virtual_Final_New_Boolean_IFormatProvider_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ToByte_Public_Virtual_Final_New_Byte_IFormatProvider_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ToChar_Public_Virtual_Final_New_Char_IFormatProvider_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ToDateTime_Public_Virtual_Final_New_DateTime_IFormatProvider_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ToDecimal_Public_Virtual_Final_New_Decimal_IFormatProvider_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ToDouble_Public_Virtual_Final_New_Double_IFormatProvider_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ToInt16_Public_Virtual_Final_New_Int16_IFormatProvider_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ToInt32_Public_Virtual_Final_New_Int32_IFormatProvider_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ToInt64_Public_Virtual_Final_New_Int64_IFormatProvider_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ToSByte_Public_Virtual_Final_New_SByte_IFormatProvider_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ToSingle_Public_Virtual_Final_New_Single_IFormatProvider_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_Final_New_String_IFormatProvider_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ToType_Public_Virtual_Final_New_Object_Type_IFormatProvider_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ToUInt16_Public_Virtual_Final_New_UInt16_IFormatProvider_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ToUInt32_Public_Virtual_Final_New_UInt32_IFormatProvider_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ToUInt64_Public_Virtual_Final_New_UInt64_IFormatProvider_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ToObject_Public_Object_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_From_Public_Static_PrimitiveValue_TValue_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FromObject_Public_Static_PrimitiveValue_Object_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_PrimitiveValue_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_PrimitiveValue_Char_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_PrimitiveValue_Byte_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_PrimitiveValue_SByte_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_PrimitiveValue_Int16_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_PrimitiveValue_UInt16_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_PrimitiveValue_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_PrimitiveValue_UInt32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_PrimitiveValue_Int64_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_PrimitiveValue_UInt64_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_PrimitiveValue_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_PrimitiveValue_Double_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FromBoolean_Public_Static_PrimitiveValue_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FromChar_Public_Static_PrimitiveValue_Char_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FromByte_Public_Static_PrimitiveValue_Byte_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FromSByte_Public_Static_PrimitiveValue_SByte_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FromInt16_Public_Static_PrimitiveValue_Int16_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FromUInt16_Public_Static_PrimitiveValue_UInt16_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FromInt32_Public_Static_PrimitiveValue_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FromUInt32_Public_Static_PrimitiveValue_UInt32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FromInt64_Public_Static_PrimitiveValue_Int64_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FromUInt64_Public_Static_PrimitiveValue_UInt64_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FromSingle_Public_Static_PrimitiveValue_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FromDouble_Public_Static_PrimitiveValue_Double_0;

	[FieldOffset(0)]
	public Il2CppSystem.TypeCode m_Type;

	[FieldOffset(4)]
	[MarshalAs(UnmanagedType.U1)]
	public bool m_BoolValue;

	[FieldOffset(4)]
	public char m_CharValue;

	[FieldOffset(4)]
	public byte m_ByteValue;

	[FieldOffset(4)]
	public sbyte m_SByteValue;

	[FieldOffset(4)]
	public short m_ShortValue;

	[FieldOffset(4)]
	public ushort m_UShortValue;

	[FieldOffset(4)]
	public int m_IntValue;

	[FieldOffset(4)]
	public uint m_UIntValue;

	[FieldOffset(4)]
	public long m_LongValue;

	[FieldOffset(4)]
	public ulong m_ULongValue;

	[FieldOffset(4)]
	public float m_FloatValue;

	[FieldOffset(4)]
	public double m_DoubleValue;

	public unsafe byte* valuePtr
	{
		[CallerCount(0)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr result = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_valuePtr_Internal_get_ptr_Byte_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (byte*)result;
		}
	}

	public unsafe Il2CppSystem.TypeCode type
	{
		[CallerCount(175)]
		[CachedScanResults(RefRangeStart = 52464, RefRangeEnd = 52639, XrefRangeStart = 52464, XrefRangeEnd = 52639, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_type_Public_get_TypeCode_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(Il2CppSystem.TypeCode*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe bool isEmpty
	{
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 87177, RefRangeEnd = 87189, XrefRangeStart = 87177, XrefRangeEnd = 87189, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_isEmpty_Public_get_Boolean_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	static PrimitiveValue()
	{
		Il2CppClassPointerStore<PrimitiveValue>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.InputSystem.dll", "UnityEngine.InputSystem.Utilities", "PrimitiveValue");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PrimitiveValue>.NativeClassPtr);
		NativeFieldInfoPtr_m_Type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PrimitiveValue>.NativeClassPtr, "m_Type");
		NativeFieldInfoPtr_m_BoolValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PrimitiveValue>.NativeClassPtr, "m_BoolValue");
		NativeFieldInfoPtr_m_CharValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PrimitiveValue>.NativeClassPtr, "m_CharValue");
		NativeFieldInfoPtr_m_ByteValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PrimitiveValue>.NativeClassPtr, "m_ByteValue");
		NativeFieldInfoPtr_m_SByteValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PrimitiveValue>.NativeClassPtr, "m_SByteValue");
		NativeFieldInfoPtr_m_ShortValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PrimitiveValue>.NativeClassPtr, "m_ShortValue");
		NativeFieldInfoPtr_m_UShortValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PrimitiveValue>.NativeClassPtr, "m_UShortValue");
		NativeFieldInfoPtr_m_IntValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PrimitiveValue>.NativeClassPtr, "m_IntValue");
		NativeFieldInfoPtr_m_UIntValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PrimitiveValue>.NativeClassPtr, "m_UIntValue");
		NativeFieldInfoPtr_m_LongValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PrimitiveValue>.NativeClassPtr, "m_LongValue");
		NativeFieldInfoPtr_m_ULongValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PrimitiveValue>.NativeClassPtr, "m_ULongValue");
		NativeFieldInfoPtr_m_FloatValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PrimitiveValue>.NativeClassPtr, "m_FloatValue");
		NativeFieldInfoPtr_m_DoubleValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PrimitiveValue>.NativeClassPtr, "m_DoubleValue");
		NativeMethodInfoPtr_get_valuePtr_Internal_get_ptr_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrimitiveValue>.NativeClassPtr, 100668932);
		NativeMethodInfoPtr_get_type_Public_get_TypeCode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrimitiveValue>.NativeClassPtr, 100668933);
		NativeMethodInfoPtr_get_isEmpty_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrimitiveValue>.NativeClassPtr, 100668934);
		NativeMethodInfoPtr__ctor_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrimitiveValue>.NativeClassPtr, 100668935);
		NativeMethodInfoPtr__ctor_Public_Void_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrimitiveValue>.NativeClassPtr, 100668936);
		NativeMethodInfoPtr__ctor_Public_Void_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrimitiveValue>.NativeClassPtr, 100668937);
		NativeMethodInfoPtr__ctor_Public_Void_SByte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrimitiveValue>.NativeClassPtr, 100668938);
		NativeMethodInfoPtr__ctor_Public_Void_Int16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrimitiveValue>.NativeClassPtr, 100668939);
		NativeMethodInfoPtr__ctor_Public_Void_UInt16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrimitiveValue>.NativeClassPtr, 100668940);
		NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrimitiveValue>.NativeClassPtr, 100668941);
		NativeMethodInfoPtr__ctor_Public_Void_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrimitiveValue>.NativeClassPtr, 100668942);
		NativeMethodInfoPtr__ctor_Public_Void_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrimitiveValue>.NativeClassPtr, 100668943);
		NativeMethodInfoPtr__ctor_Public_Void_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrimitiveValue>.NativeClassPtr, 100668944);
		NativeMethodInfoPtr__ctor_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrimitiveValue>.NativeClassPtr, 100668945);
		NativeMethodInfoPtr__ctor_Public_Void_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrimitiveValue>.NativeClassPtr, 100668946);
		NativeMethodInfoPtr_ConvertTo_Public_PrimitiveValue_TypeCode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrimitiveValue>.NativeClassPtr, 100668947);
		NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_PrimitiveValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrimitiveValue>.NativeClassPtr, 100668948);
		NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrimitiveValue>.NativeClassPtr, 100668949);
		NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_PrimitiveValue_PrimitiveValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrimitiveValue>.NativeClassPtr, 100668950);
		NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_PrimitiveValue_PrimitiveValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrimitiveValue>.NativeClassPtr, 100668951);
		NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrimitiveValue>.NativeClassPtr, 100668952);
		NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrimitiveValue>.NativeClassPtr, 100668953);
		NativeMethodInfoPtr_FromString_Public_Static_PrimitiveValue_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrimitiveValue>.NativeClassPtr, 100668954);
		NativeMethodInfoPtr_GetTypeCode_Public_Virtual_Final_New_TypeCode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrimitiveValue>.NativeClassPtr, 100668955);
		NativeMethodInfoPtr_ToBoolean_Public_Virtual_Final_New_Boolean_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrimitiveValue>.NativeClassPtr, 100668956);
		NativeMethodInfoPtr_ToByte_Public_Virtual_Final_New_Byte_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrimitiveValue>.NativeClassPtr, 100668957);
		NativeMethodInfoPtr_ToChar_Public_Virtual_Final_New_Char_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrimitiveValue>.NativeClassPtr, 100668958);
		NativeMethodInfoPtr_ToDateTime_Public_Virtual_Final_New_DateTime_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrimitiveValue>.NativeClassPtr, 100668959);
		NativeMethodInfoPtr_ToDecimal_Public_Virtual_Final_New_Decimal_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrimitiveValue>.NativeClassPtr, 100668960);
		NativeMethodInfoPtr_ToDouble_Public_Virtual_Final_New_Double_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrimitiveValue>.NativeClassPtr, 100668961);
		NativeMethodInfoPtr_ToInt16_Public_Virtual_Final_New_Int16_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrimitiveValue>.NativeClassPtr, 100668962);
		NativeMethodInfoPtr_ToInt32_Public_Virtual_Final_New_Int32_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrimitiveValue>.NativeClassPtr, 100668963);
		NativeMethodInfoPtr_ToInt64_Public_Virtual_Final_New_Int64_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrimitiveValue>.NativeClassPtr, 100668964);
		NativeMethodInfoPtr_ToSByte_Public_Virtual_Final_New_SByte_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrimitiveValue>.NativeClassPtr, 100668965);
		NativeMethodInfoPtr_ToSingle_Public_Virtual_Final_New_Single_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrimitiveValue>.NativeClassPtr, 100668966);
		NativeMethodInfoPtr_ToString_Public_Virtual_Final_New_String_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrimitiveValue>.NativeClassPtr, 100668967);
		NativeMethodInfoPtr_ToType_Public_Virtual_Final_New_Object_Type_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrimitiveValue>.NativeClassPtr, 100668968);
		NativeMethodInfoPtr_ToUInt16_Public_Virtual_Final_New_UInt16_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrimitiveValue>.NativeClassPtr, 100668969);
		NativeMethodInfoPtr_ToUInt32_Public_Virtual_Final_New_UInt32_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrimitiveValue>.NativeClassPtr, 100668970);
		NativeMethodInfoPtr_ToUInt64_Public_Virtual_Final_New_UInt64_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrimitiveValue>.NativeClassPtr, 100668971);
		NativeMethodInfoPtr_ToObject_Public_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrimitiveValue>.NativeClassPtr, 100668972);
		NativeMethodInfoPtr_From_Public_Static_PrimitiveValue_TValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrimitiveValue>.NativeClassPtr, 100668973);
		NativeMethodInfoPtr_FromObject_Public_Static_PrimitiveValue_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrimitiveValue>.NativeClassPtr, 100668974);
		NativeMethodInfoPtr_op_Implicit_Public_Static_PrimitiveValue_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrimitiveValue>.NativeClassPtr, 100668975);
		NativeMethodInfoPtr_op_Implicit_Public_Static_PrimitiveValue_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrimitiveValue>.NativeClassPtr, 100668976);
		NativeMethodInfoPtr_op_Implicit_Public_Static_PrimitiveValue_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrimitiveValue>.NativeClassPtr, 100668977);
		NativeMethodInfoPtr_op_Implicit_Public_Static_PrimitiveValue_SByte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrimitiveValue>.NativeClassPtr, 100668978);
		NativeMethodInfoPtr_op_Implicit_Public_Static_PrimitiveValue_Int16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrimitiveValue>.NativeClassPtr, 100668979);
		NativeMethodInfoPtr_op_Implicit_Public_Static_PrimitiveValue_UInt16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrimitiveValue>.NativeClassPtr, 100668980);
		NativeMethodInfoPtr_op_Implicit_Public_Static_PrimitiveValue_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrimitiveValue>.NativeClassPtr, 100668981);
		NativeMethodInfoPtr_op_Implicit_Public_Static_PrimitiveValue_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrimitiveValue>.NativeClassPtr, 100668982);
		NativeMethodInfoPtr_op_Implicit_Public_Static_PrimitiveValue_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrimitiveValue>.NativeClassPtr, 100668983);
		NativeMethodInfoPtr_op_Implicit_Public_Static_PrimitiveValue_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrimitiveValue>.NativeClassPtr, 100668984);
		NativeMethodInfoPtr_op_Implicit_Public_Static_PrimitiveValue_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrimitiveValue>.NativeClassPtr, 100668985);
		NativeMethodInfoPtr_op_Implicit_Public_Static_PrimitiveValue_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrimitiveValue>.NativeClassPtr, 100668986);
		NativeMethodInfoPtr_FromBoolean_Public_Static_PrimitiveValue_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrimitiveValue>.NativeClassPtr, 100668987);
		NativeMethodInfoPtr_FromChar_Public_Static_PrimitiveValue_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrimitiveValue>.NativeClassPtr, 100668988);
		NativeMethodInfoPtr_FromByte_Public_Static_PrimitiveValue_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrimitiveValue>.NativeClassPtr, 100668989);
		NativeMethodInfoPtr_FromSByte_Public_Static_PrimitiveValue_SByte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrimitiveValue>.NativeClassPtr, 100668990);
		NativeMethodInfoPtr_FromInt16_Public_Static_PrimitiveValue_Int16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrimitiveValue>.NativeClassPtr, 100668991);
		NativeMethodInfoPtr_FromUInt16_Public_Static_PrimitiveValue_UInt16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrimitiveValue>.NativeClassPtr, 100668992);
		NativeMethodInfoPtr_FromInt32_Public_Static_PrimitiveValue_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrimitiveValue>.NativeClassPtr, 100668993);
		NativeMethodInfoPtr_FromUInt32_Public_Static_PrimitiveValue_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrimitiveValue>.NativeClassPtr, 100668994);
		NativeMethodInfoPtr_FromInt64_Public_Static_PrimitiveValue_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrimitiveValue>.NativeClassPtr, 100668995);
		NativeMethodInfoPtr_FromUInt64_Public_Static_PrimitiveValue_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrimitiveValue>.NativeClassPtr, 100668996);
		NativeMethodInfoPtr_FromSingle_Public_Static_PrimitiveValue_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrimitiveValue>.NativeClassPtr, 100668997);
		NativeMethodInfoPtr_FromDouble_Public_Static_PrimitiveValue_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrimitiveValue>.NativeClassPtr, 100668998);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1020689, RefRangeEnd = 1020690, XrefRangeStart = 1020689, XrefRangeEnd = 1020689, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe PrimitiveValue(bool value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Boolean_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	public unsafe PrimitiveValue(char value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Char_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	public unsafe PrimitiveValue(byte value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Byte_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	public unsafe PrimitiveValue(sbyte value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_SByte_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	public unsafe PrimitiveValue(short value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Int16_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	public unsafe PrimitiveValue(ushort value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_UInt16_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1020690, RefRangeEnd = 1020691, XrefRangeStart = 1020690, XrefRangeEnd = 1020690, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe PrimitiveValue(int value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Int32_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	public unsafe PrimitiveValue(uint value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_UInt32_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	public unsafe PrimitiveValue(long value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Int64_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	public unsafe PrimitiveValue(ulong value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_UInt64_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	public unsafe PrimitiveValue(float value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Single_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	public unsafe PrimitiveValue(double value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Double_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 1020691, RefRangeEnd = 1020695, XrefRangeStart = 1020691, XrefRangeEnd = 1020691, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe PrimitiveValue ConvertTo(Il2CppSystem.TypeCode type)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&type);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ConvertTo_Public_PrimitiveValue_TypeCode_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(PrimitiveValue*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1020695, XrefRangeEnd = 1020696, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual bool Equals(PrimitiveValue other)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&other);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_PrimitiveValue_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1020696, XrefRangeEnd = 1020712, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool Equals(Il2CppSystem.Object obj)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)obj);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1020712, XrefRangeEnd = 1020713, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool operator ==(PrimitiveValue left, PrimitiveValue right)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&left);
		*(PrimitiveValue**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &right;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_PrimitiveValue_PrimitiveValue_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1020713, XrefRangeEnd = 1020714, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool operator !=(PrimitiveValue left, PrimitiveValue right)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&left);
		*(PrimitiveValue**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &right;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_PrimitiveValue_PrimitiveValue_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1020714, XrefRangeEnd = 1020715, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override int GetHashCode()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(6)]
	[CachedScanResults(RefRangeStart = 1020721, RefRangeEnd = 1020727, XrefRangeStart = 1020715, XrefRangeEnd = 1020721, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override string ToString()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ToString_Public_Virtual_String_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return IL2CPP.Il2CppStringToManaged(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1020766, RefRangeEnd = 1020767, XrefRangeStart = 1020727, XrefRangeEnd = 1020766, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static PrimitiveValue FromString(string value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FromString_Public_Static_PrimitiveValue_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(PrimitiveValue*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(175)]
	[CachedScanResults(RefRangeStart = 52464, RefRangeEnd = 52639, XrefRangeStart = 52464, XrefRangeEnd = 52639, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual Il2CppSystem.TypeCode GetTypeCode()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetTypeCode_Public_Virtual_Final_New_TypeCode_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(Il2CppSystem.TypeCode*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	public unsafe virtual bool ToBoolean(Il2CppSystem.IFormatProvider provider = null)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)provider);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ToBoolean_Public_Virtual_Final_New_Boolean_IFormatProvider_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1020768, RefRangeEnd = 1020769, XrefRangeStart = 1020767, XrefRangeEnd = 1020768, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual byte ToByte(Il2CppSystem.IFormatProvider provider = null)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)provider);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ToByte_Public_Virtual_Final_New_Byte_IFormatProvider_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(byte*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	public unsafe virtual char ToChar(Il2CppSystem.IFormatProvider provider = null)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)provider);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ToChar_Public_Virtual_Final_New_Char_IFormatProvider_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(char*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1020769, XrefRangeEnd = 1020775, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual Il2CppSystem.DateTime ToDateTime(Il2CppSystem.IFormatProvider provider = null)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)provider);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ToDateTime_Public_Virtual_Final_New_DateTime_IFormatProvider_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(Il2CppSystem.DateTime*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1020775, XrefRangeEnd = 1020777, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual Il2CppSystem.Decimal ToDecimal(Il2CppSystem.IFormatProvider provider = null)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)provider);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ToDecimal_Public_Virtual_Final_New_Decimal_IFormatProvider_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(Il2CppSystem.Decimal*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1020777, RefRangeEnd = 1020779, XrefRangeStart = 1020777, XrefRangeEnd = 1020777, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual double ToDouble(Il2CppSystem.IFormatProvider provider = null)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)provider);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ToDouble_Public_Virtual_Final_New_Double_IFormatProvider_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(double*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1020768, RefRangeEnd = 1020769, XrefRangeStart = 1020768, XrefRangeEnd = 1020769, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual short ToInt16(Il2CppSystem.IFormatProvider provider = null)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)provider);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ToInt16_Public_Virtual_Final_New_Int16_IFormatProvider_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(short*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1020768, RefRangeEnd = 1020769, XrefRangeStart = 1020768, XrefRangeEnd = 1020769, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual int ToInt32(Il2CppSystem.IFormatProvider provider = null)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)provider);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ToInt32_Public_Virtual_Final_New_Int32_IFormatProvider_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 1020779, RefRangeEnd = 1020783, XrefRangeStart = 1020779, XrefRangeEnd = 1020779, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual long ToInt64(Il2CppSystem.IFormatProvider provider = null)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)provider);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ToInt64_Public_Virtual_Final_New_Int64_IFormatProvider_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(long*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1020768, RefRangeEnd = 1020769, XrefRangeStart = 1020768, XrefRangeEnd = 1020769, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual sbyte ToSByte(Il2CppSystem.IFormatProvider provider = null)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)provider);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ToSByte_Public_Virtual_Final_New_SByte_IFormatProvider_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(sbyte*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 1020784, RefRangeEnd = 1020788, XrefRangeStart = 1020783, XrefRangeEnd = 1020784, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual float ToSingle(Il2CppSystem.IFormatProvider provider = null)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)provider);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ToSingle_Public_Virtual_Final_New_Single_IFormatProvider_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1020788, XrefRangeEnd = 1020789, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual string ToString(Il2CppSystem.IFormatProvider provider)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)provider);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ToString_Public_Virtual_Final_New_String_IFormatProvider_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return IL2CPP.Il2CppStringToManaged(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1020789, XrefRangeEnd = 1020794, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual Il2CppSystem.Object ToType(Il2CppSystem.Type conversionType, Il2CppSystem.IFormatProvider provider)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)conversionType);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)provider);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ToType_Public_Virtual_Final_New_Object_Type_IFormatProvider_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1020794, XrefRangeEnd = 1020795, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual ushort ToUInt16(Il2CppSystem.IFormatProvider provider = null)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)provider);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ToUInt16_Public_Virtual_Final_New_UInt16_IFormatProvider_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(ushort*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual uint ToUInt32(Il2CppSystem.IFormatProvider provider = null)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)provider);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ToUInt32_Public_Virtual_Final_New_UInt32_IFormatProvider_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(uint*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1020795, RefRangeEnd = 1020797, XrefRangeStart = 1020795, XrefRangeEnd = 1020795, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual ulong ToUInt64(Il2CppSystem.IFormatProvider provider = null)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)provider);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ToUInt64_Public_Virtual_Final_New_UInt64_IFormatProvider_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(ulong*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 1020799, RefRangeEnd = 1020803, XrefRangeStart = 1020797, XrefRangeEnd = 1020799, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Il2CppSystem.Object ToObject()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ToObject_Public_Object_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1020803, XrefRangeEnd = 1020818, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static PrimitiveValue From<TValue>(TValue value) where TValue : new()
	{
		//IL_0045->IL0048: Incompatible stack types: I vs Ref
		//IL_0038->IL0048: Incompatible stack types: I vs Ref
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		ref TValue reference;
		if (!typeof(TValue).IsValueType)
		{
			object obj = value;
			reference = ref *(_003F*)((!(obj is string)) ? IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)((obj is Il2CppObjectBase) ? obj : null)) : IL2CPP.ManagedStringToIl2Cpp(obj as string));
		}
		else
		{
			reference = ref value;
		}
		*ptr = (nint)Unsafe.AsPointer(ref reference);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(MethodInfoStoreGeneric_From_Public_Static_PrimitiveValue_TValue_0<TValue>.Pointer, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(PrimitiveValue*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(8)]
	[CachedScanResults(RefRangeStart = 1020869, RefRangeEnd = 1020877, XrefRangeStart = 1020818, XrefRangeEnd = 1020869, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static PrimitiveValue FromObject(Il2CppSystem.Object value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FromObject_Public_Static_PrimitiveValue_Object_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(PrimitiveValue*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	public unsafe static implicit operator PrimitiveValue(bool value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_op_Implicit_Public_Static_PrimitiveValue_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(PrimitiveValue*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	public unsafe static implicit operator PrimitiveValue(char value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_op_Implicit_Public_Static_PrimitiveValue_Char_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(PrimitiveValue*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	public unsafe static implicit operator PrimitiveValue(byte value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_op_Implicit_Public_Static_PrimitiveValue_Byte_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(PrimitiveValue*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	public unsafe static implicit operator PrimitiveValue(sbyte value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_op_Implicit_Public_Static_PrimitiveValue_SByte_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(PrimitiveValue*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 1020877, RefRangeEnd = 1020880, XrefRangeStart = 1020877, XrefRangeEnd = 1020877, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static implicit operator PrimitiveValue(short value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_op_Implicit_Public_Static_PrimitiveValue_Int16_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(PrimitiveValue*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1020880, RefRangeEnd = 1020881, XrefRangeStart = 1020880, XrefRangeEnd = 1020880, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static implicit operator PrimitiveValue(ushort value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_op_Implicit_Public_Static_PrimitiveValue_UInt16_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(PrimitiveValue*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(337)]
	[CachedScanResults(RefRangeStart = 1020881, RefRangeEnd = 1021218, XrefRangeStart = 1020881, XrefRangeEnd = 1020881, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static implicit operator PrimitiveValue(int value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_op_Implicit_Public_Static_PrimitiveValue_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(PrimitiveValue*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1021218, RefRangeEnd = 1021219, XrefRangeStart = 1021218, XrefRangeEnd = 1021218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static implicit operator PrimitiveValue(uint value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_op_Implicit_Public_Static_PrimitiveValue_UInt32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(PrimitiveValue*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	public unsafe static implicit operator PrimitiveValue(long value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_op_Implicit_Public_Static_PrimitiveValue_Int64_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(PrimitiveValue*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	public unsafe static implicit operator PrimitiveValue(ulong value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_op_Implicit_Public_Static_PrimitiveValue_UInt64_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(PrimitiveValue*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 1021219, RefRangeEnd = 1021223, XrefRangeStart = 1021219, XrefRangeEnd = 1021219, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static implicit operator PrimitiveValue(float value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_op_Implicit_Public_Static_PrimitiveValue_Single_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(PrimitiveValue*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	public unsafe static implicit operator PrimitiveValue(double value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_op_Implicit_Public_Static_PrimitiveValue_Double_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(PrimitiveValue*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	public unsafe static PrimitiveValue FromBoolean(bool value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FromBoolean_Public_Static_PrimitiveValue_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(PrimitiveValue*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	public unsafe static PrimitiveValue FromChar(char value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FromChar_Public_Static_PrimitiveValue_Char_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(PrimitiveValue*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	public unsafe static PrimitiveValue FromByte(byte value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FromByte_Public_Static_PrimitiveValue_Byte_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(PrimitiveValue*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	public unsafe static PrimitiveValue FromSByte(sbyte value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FromSByte_Public_Static_PrimitiveValue_SByte_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(PrimitiveValue*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 1020877, RefRangeEnd = 1020880, XrefRangeStart = 1020877, XrefRangeEnd = 1020880, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static PrimitiveValue FromInt16(short value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FromInt16_Public_Static_PrimitiveValue_Int16_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(PrimitiveValue*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1020880, RefRangeEnd = 1020881, XrefRangeStart = 1020880, XrefRangeEnd = 1020881, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static PrimitiveValue FromUInt16(ushort value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FromUInt16_Public_Static_PrimitiveValue_UInt16_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(PrimitiveValue*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(337)]
	[CachedScanResults(RefRangeStart = 1020881, RefRangeEnd = 1021218, XrefRangeStart = 1020881, XrefRangeEnd = 1021218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static PrimitiveValue FromInt32(int value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FromInt32_Public_Static_PrimitiveValue_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(PrimitiveValue*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1021218, RefRangeEnd = 1021219, XrefRangeStart = 1021218, XrefRangeEnd = 1021219, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static PrimitiveValue FromUInt32(uint value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FromUInt32_Public_Static_PrimitiveValue_UInt32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(PrimitiveValue*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	public unsafe static PrimitiveValue FromInt64(long value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FromInt64_Public_Static_PrimitiveValue_Int64_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(PrimitiveValue*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	public unsafe static PrimitiveValue FromUInt64(ulong value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FromUInt64_Public_Static_PrimitiveValue_UInt64_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(PrimitiveValue*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 1021219, RefRangeEnd = 1021223, XrefRangeStart = 1021219, XrefRangeEnd = 1021223, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static PrimitiveValue FromSingle(float value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FromSingle_Public_Static_PrimitiveValue_Single_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(PrimitiveValue*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	public unsafe static PrimitiveValue FromDouble(double value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FromDouble_Public_Static_PrimitiveValue_Double_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(PrimitiveValue*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	public unsafe Il2CppSystem.Object BoxIl2CppObject()
	{
		return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<PrimitiveValue>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
	}
}
