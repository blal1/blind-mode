using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Reflection;

namespace Il2CppSystem;

public static class Math : Object
{
	private sealed class MethodInfoStoreGeneric_ThrowMinMaxException_Private_Static_Void_T_T_0<T>
	{
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_ThrowMinMaxException_Private_Static_Void_T_T_0, Il2CppClassPointerStore<Math>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[1] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
	}

	private static readonly System.IntPtr NativeFieldInfoPtr_doubleRoundLimit;

	private static readonly System.IntPtr NativeFieldInfoPtr_roundPower10Double;

	private static readonly System.IntPtr NativeMethodInfoPtr_Abs_Public_Static_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Abs_Public_Static_Int64_Int64_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ThrowAbsOverflow_Private_Static_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DivRem_Public_Static_Int32_Int32_Int32_byref_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Clamp_Public_Static_Int32_Int32_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Clamp_Public_Static_Single_Single_Single_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Log_Public_Static_Double_Double_Double_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Max_Public_Static_Byte_Byte_Byte_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Max_Public_Static_Double_Double_Double_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Max_Public_Static_Int16_Int16_Int16_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Max_Public_Static_Int32_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Max_Public_Static_Int64_Int64_Int64_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Max_Public_Static_Single_Single_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Max_Public_Static_UInt32_UInt32_UInt32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Min_Public_Static_Double_Double_Double_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Min_Public_Static_Int16_Int16_Int16_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Min_Public_Static_Int32_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Min_Public_Static_Int64_Int64_Int64_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Min_Public_Static_Single_Single_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Min_Public_Static_UInt32_UInt32_UInt32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Round_Public_Static_Double_Double_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Round_Public_Static_Double_Double_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Round_Public_Static_Double_Double_MidpointRounding_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Round_Public_Static_Double_Double_Int32_MidpointRounding_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Sign_Public_Static_Int32_Double_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Sign_Public_Static_Int32_Int64_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Sign_Public_Static_Int32_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ThrowMinMaxException_Private_Static_Void_T_T_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Abs_Public_Static_Double_Double_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Abs_Public_Static_Single_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Acos_Public_Static_Double_Double_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Asin_Public_Static_Double_Double_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Atan_Public_Static_Double_Double_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Atan2_Public_Static_Double_Double_Double_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Ceiling_Public_Static_Double_Double_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Cos_Public_Static_Double_Double_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Exp_Public_Static_Double_Double_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Floor_Public_Static_Double_Double_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Log_Public_Static_Double_Double_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Log10_Public_Static_Double_Double_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Pow_Public_Static_Double_Double_Double_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Sin_Public_Static_Double_Double_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Sqrt_Public_Static_Double_Double_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Tan_Public_Static_Double_Double_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ModF_Private_Static_Double_Double_ptr_Double_0;

	public unsafe static double doubleRoundLimit
	{
		get
		{
			Unsafe.SkipInit(out double result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_doubleRoundLimit, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_doubleRoundLimit, (void*)(&value));
		}
	}

	public unsafe static Il2CppStructArray<double> roundPower10Double
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_roundPower10Double, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<double>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_roundPower10Double, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	static Math()
	{
		Il2CppClassPointerStore<Math>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System", "Math");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Math>.NativeClassPtr);
		NativeFieldInfoPtr_doubleRoundLimit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Math>.NativeClassPtr, "doubleRoundLimit");
		NativeFieldInfoPtr_roundPower10Double = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Math>.NativeClassPtr, "roundPower10Double");
		NativeMethodInfoPtr_Abs_Public_Static_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Math>.NativeClassPtr, 100665349);
		NativeMethodInfoPtr_Abs_Public_Static_Int64_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Math>.NativeClassPtr, 100665350);
		NativeMethodInfoPtr_ThrowAbsOverflow_Private_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Math>.NativeClassPtr, 100665351);
		NativeMethodInfoPtr_DivRem_Public_Static_Int32_Int32_Int32_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Math>.NativeClassPtr, 100665352);
		NativeMethodInfoPtr_Clamp_Public_Static_Int32_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Math>.NativeClassPtr, 100665353);
		NativeMethodInfoPtr_Clamp_Public_Static_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Math>.NativeClassPtr, 100665354);
		NativeMethodInfoPtr_Log_Public_Static_Double_Double_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Math>.NativeClassPtr, 100665355);
		NativeMethodInfoPtr_Max_Public_Static_Byte_Byte_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Math>.NativeClassPtr, 100665356);
		NativeMethodInfoPtr_Max_Public_Static_Double_Double_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Math>.NativeClassPtr, 100665357);
		NativeMethodInfoPtr_Max_Public_Static_Int16_Int16_Int16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Math>.NativeClassPtr, 100665358);
		NativeMethodInfoPtr_Max_Public_Static_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Math>.NativeClassPtr, 100665359);
		NativeMethodInfoPtr_Max_Public_Static_Int64_Int64_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Math>.NativeClassPtr, 100665360);
		NativeMethodInfoPtr_Max_Public_Static_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Math>.NativeClassPtr, 100665361);
		NativeMethodInfoPtr_Max_Public_Static_UInt32_UInt32_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Math>.NativeClassPtr, 100665362);
		NativeMethodInfoPtr_Min_Public_Static_Double_Double_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Math>.NativeClassPtr, 100665363);
		NativeMethodInfoPtr_Min_Public_Static_Int16_Int16_Int16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Math>.NativeClassPtr, 100665364);
		NativeMethodInfoPtr_Min_Public_Static_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Math>.NativeClassPtr, 100665365);
		NativeMethodInfoPtr_Min_Public_Static_Int64_Int64_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Math>.NativeClassPtr, 100665366);
		NativeMethodInfoPtr_Min_Public_Static_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Math>.NativeClassPtr, 100665367);
		NativeMethodInfoPtr_Min_Public_Static_UInt32_UInt32_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Math>.NativeClassPtr, 100665368);
		NativeMethodInfoPtr_Round_Public_Static_Double_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Math>.NativeClassPtr, 100665369);
		NativeMethodInfoPtr_Round_Public_Static_Double_Double_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Math>.NativeClassPtr, 100665370);
		NativeMethodInfoPtr_Round_Public_Static_Double_Double_MidpointRounding_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Math>.NativeClassPtr, 100665371);
		NativeMethodInfoPtr_Round_Public_Static_Double_Double_Int32_MidpointRounding_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Math>.NativeClassPtr, 100665372);
		NativeMethodInfoPtr_Sign_Public_Static_Int32_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Math>.NativeClassPtr, 100665373);
		NativeMethodInfoPtr_Sign_Public_Static_Int32_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Math>.NativeClassPtr, 100665374);
		NativeMethodInfoPtr_Sign_Public_Static_Int32_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Math>.NativeClassPtr, 100665375);
		NativeMethodInfoPtr_ThrowMinMaxException_Private_Static_Void_T_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Math>.NativeClassPtr, 100665376);
		NativeMethodInfoPtr_Abs_Public_Static_Double_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Math>.NativeClassPtr, 100665377);
		NativeMethodInfoPtr_Abs_Public_Static_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Math>.NativeClassPtr, 100665378);
		NativeMethodInfoPtr_Acos_Public_Static_Double_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Math>.NativeClassPtr, 100665379);
		NativeMethodInfoPtr_Asin_Public_Static_Double_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Math>.NativeClassPtr, 100665380);
		NativeMethodInfoPtr_Atan_Public_Static_Double_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Math>.NativeClassPtr, 100665381);
		NativeMethodInfoPtr_Atan2_Public_Static_Double_Double_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Math>.NativeClassPtr, 100665382);
		NativeMethodInfoPtr_Ceiling_Public_Static_Double_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Math>.NativeClassPtr, 100665383);
		NativeMethodInfoPtr_Cos_Public_Static_Double_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Math>.NativeClassPtr, 100665384);
		NativeMethodInfoPtr_Exp_Public_Static_Double_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Math>.NativeClassPtr, 100665385);
		NativeMethodInfoPtr_Floor_Public_Static_Double_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Math>.NativeClassPtr, 100665386);
		NativeMethodInfoPtr_Log_Public_Static_Double_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Math>.NativeClassPtr, 100665387);
		NativeMethodInfoPtr_Log10_Public_Static_Double_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Math>.NativeClassPtr, 100665388);
		NativeMethodInfoPtr_Pow_Public_Static_Double_Double_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Math>.NativeClassPtr, 100665389);
		NativeMethodInfoPtr_Sin_Public_Static_Double_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Math>.NativeClassPtr, 100665390);
		NativeMethodInfoPtr_Sqrt_Public_Static_Double_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Math>.NativeClassPtr, 100665391);
		NativeMethodInfoPtr_Tan_Public_Static_Double_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Math>.NativeClassPtr, 100665392);
		NativeMethodInfoPtr_ModF_Private_Static_Double_Double_ptr_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Math>.NativeClassPtr, 100665393);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 731725, XrefRangeEnd = 731726, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int Abs(int value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Abs_Public_Static_Int32_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 731726, XrefRangeEnd = 731727, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static long Abs(long value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Abs_Public_Static_Int64_Int64_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(long*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 731727, XrefRangeEnd = 731744, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void ThrowAbsOverflow()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ThrowAbsOverflow_Private_Static_Void_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 731744, RefRangeEnd = 731748, XrefRangeStart = 731744, XrefRangeEnd = 731744, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int DivRem(int a, int b, out int result)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&a);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &b;
		*(void**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref result);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DivRem_Public_Static_Int32_Int32_Int32_byref_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 731748, XrefRangeEnd = 731754, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int Clamp(int value, int min, int max)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&value);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &min;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &max;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Clamp_Public_Static_Int32_Int32_Int32_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 731754, XrefRangeEnd = 731762, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static float Clamp(float value, float min, float max)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&value);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &min;
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &max;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Clamp_Public_Static_Single_Single_Single_Single_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(27)]
	[CachedScanResults(RefRangeStart = 731763, RefRangeEnd = 731790, XrefRangeStart = 731762, XrefRangeEnd = 731763, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static double Log(double a, double newBase)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&a);
		*(double**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &newBase;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Log_Public_Static_Double_Double_Double_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(double*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 731790, RefRangeEnd = 731791, XrefRangeStart = 731790, XrefRangeEnd = 731790, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static byte Max(byte val1, byte val2)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&val1);
		*(byte**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &val2;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Max_Public_Static_Byte_Byte_Byte_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(byte*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(38)]
	[CachedScanResults(RefRangeStart = 731791, RefRangeEnd = 731829, XrefRangeStart = 731791, XrefRangeEnd = 731791, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static double Max(double val1, double val2)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&val1);
		*(double**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &val2;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Max_Public_Static_Double_Double_Double_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(double*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 731829, RefRangeEnd = 731833, XrefRangeStart = 731829, XrefRangeEnd = 731829, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static short Max(short val1, short val2)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&val1);
		*(short**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &val2;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Max_Public_Static_Int16_Int16_Int16_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(short*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(176)]
	[CachedScanResults(RefRangeStart = 731833, RefRangeEnd = 732009, XrefRangeStart = 731833, XrefRangeEnd = 731833, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int Max(int val1, int val2)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&val1);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &val2;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Max_Public_Static_Int32_Int32_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(6)]
	[CachedScanResults(RefRangeStart = 732009, RefRangeEnd = 732015, XrefRangeStart = 732009, XrefRangeEnd = 732009, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static long Max(long val1, long val2)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&val1);
		*(long**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &val2;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Max_Public_Static_Int64_Int64_Int64_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(long*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(36)]
	[CachedScanResults(RefRangeStart = 732015, RefRangeEnd = 732051, XrefRangeStart = 732015, XrefRangeEnd = 732015, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static float Max(float val1, float val2)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&val1);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &val2;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Max_Public_Static_Single_Single_Single_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(16)]
	[CachedScanResults(RefRangeStart = 732051, RefRangeEnd = 732067, XrefRangeStart = 732051, XrefRangeEnd = 732051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static uint Max(uint val1, uint val2)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&val1);
		*(uint**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &val2;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Max_Public_Static_UInt32_UInt32_UInt32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(uint*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(20)]
	[CachedScanResults(RefRangeStart = 732067, RefRangeEnd = 732087, XrefRangeStart = 732067, XrefRangeEnd = 732067, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static double Min(double val1, double val2)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&val1);
		*(double**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &val2;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Min_Public_Static_Double_Double_Double_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(double*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 732087, RefRangeEnd = 732092, XrefRangeStart = 732087, XrefRangeEnd = 732087, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static short Min(short val1, short val2)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&val1);
		*(short**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &val2;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Min_Public_Static_Int16_Int16_Int16_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(short*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(172)]
	[CachedScanResults(RefRangeStart = 732092, RefRangeEnd = 732264, XrefRangeStart = 732092, XrefRangeEnd = 732092, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int Min(int val1, int val2)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&val1);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &val2;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Min_Public_Static_Int32_Int32_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(13)]
	[CachedScanResults(RefRangeStart = 732264, RefRangeEnd = 732277, XrefRangeStart = 732264, XrefRangeEnd = 732264, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static long Min(long val1, long val2)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&val1);
		*(long**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &val2;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Min_Public_Static_Int64_Int64_Int64_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(long*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(31)]
	[CachedScanResults(RefRangeStart = 732277, RefRangeEnd = 732308, XrefRangeStart = 732277, XrefRangeEnd = 732277, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static float Min(float val1, float val2)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&val1);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &val2;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Min_Public_Static_Single_Single_Single_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(11)]
	[CachedScanResults(RefRangeStart = 732308, RefRangeEnd = 732319, XrefRangeStart = 732308, XrefRangeEnd = 732308, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static uint Min(uint val1, uint val2)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&val1);
		*(uint**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &val2;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Min_Public_Static_UInt32_UInt32_UInt32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(uint*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 732319, XrefRangeEnd = 732320, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static double Round(double a)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&a);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Round_Public_Static_Double_Double_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(double*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 732320, XrefRangeEnd = 732324, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static double Round(double value, int digits)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&value);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &digits;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Round_Public_Static_Double_Double_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(double*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 732324, XrefRangeEnd = 732328, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static double Round(double value, MidpointRounding mode)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&value);
		*(MidpointRounding**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &mode;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Round_Public_Static_Double_Double_MidpointRounding_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(double*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(8)]
	[CachedScanResults(RefRangeStart = 732344, RefRangeEnd = 732352, XrefRangeStart = 732328, XrefRangeEnd = 732344, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static double Round(double value, int digits, MidpointRounding mode)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&value);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &digits;
		*(MidpointRounding**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &mode;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Round_Public_Static_Double_Double_Int32_MidpointRounding_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(double*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	public unsafe static int Sign(double value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Sign_Public_Static_Int32_Double_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 732352, RefRangeEnd = 732354, XrefRangeStart = 732352, XrefRangeEnd = 732352, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int Sign(long value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Sign_Public_Static_Int32_Int64_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 732354, RefRangeEnd = 732356, XrefRangeStart = 732354, XrefRangeEnd = 732354, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int Sign(float value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Sign_Public_Static_Int32_Single_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 732378, RefRangeEnd = 732382, XrefRangeStart = 732356, XrefRangeEnd = 732378, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void ThrowMinMaxException<T>(T min, T max)
	{
		//IL_0045->IL0048: Incompatible stack types: I vs Ref
		//IL_0038->IL0048: Incompatible stack types: I vs Ref
		//IL_008d->IL0090: Incompatible stack types: I vs Ref
		//IL_0080->IL0090: Incompatible stack types: I vs Ref
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		ref T reference;
		if (!typeof(T).IsValueType)
		{
			object obj = min;
			reference = ref *(_003F*)((!(obj is string)) ? IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)((obj is Il2CppObjectBase) ? obj : null)) : IL2CPP.ManagedStringToIl2Cpp(obj as string));
		}
		else
		{
			reference = ref min;
		}
		*ptr = (nint)Unsafe.AsPointer(ref reference);
		byte* num = (byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)));
		ref T reference2;
		if (!typeof(T).IsValueType)
		{
			object obj2 = max;
			reference2 = ref *(_003F*)((!(obj2 is string)) ? IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)((obj2 is Il2CppObjectBase) ? obj2 : null)) : IL2CPP.ManagedStringToIl2Cpp(obj2 as string));
		}
		else
		{
			reference2 = ref max;
		}
		*(void**)num = Unsafe.AsPointer(ref reference2);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(MethodInfoStoreGeneric_ThrowMinMaxException_Private_Static_Void_T_T_0<T>.Pointer, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	public unsafe static double Abs(double value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Abs_Public_Static_Double_Double_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(double*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	public unsafe static float Abs(float value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Abs_Public_Static_Single_Single_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 732382, XrefRangeEnd = 732383, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static double Acos(double d)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&d);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Acos_Public_Static_Double_Double_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(double*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 732383, XrefRangeEnd = 732384, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static double Asin(double d)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&d);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Asin_Public_Static_Double_Double_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(double*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 732384, XrefRangeEnd = 732385, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static double Atan(double d)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&d);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Atan_Public_Static_Double_Double_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(double*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 732385, XrefRangeEnd = 732386, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static double Atan2(double y, double x)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&y);
		*(double**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &x;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Atan2_Public_Static_Double_Double_Double_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(double*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 732386, XrefRangeEnd = 732387, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static double Ceiling(double a)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&a);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Ceiling_Public_Static_Double_Double_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(double*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 732387, XrefRangeEnd = 732388, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static double Cos(double d)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&d);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Cos_Public_Static_Double_Double_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(double*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 732388, XrefRangeEnd = 732389, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static double Exp(double d)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&d);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Exp_Public_Static_Double_Double_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(double*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 732389, XrefRangeEnd = 732390, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static double Floor(double d)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&d);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Floor_Public_Static_Double_Double_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(double*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 732390, XrefRangeEnd = 732391, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static double Log(double d)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&d);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Log_Public_Static_Double_Double_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(double*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 732391, XrefRangeEnd = 732392, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static double Log10(double d)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&d);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Log10_Public_Static_Double_Double_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(double*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(11)]
	[CachedScanResults(RefRangeStart = 732393, RefRangeEnd = 732404, XrefRangeStart = 732392, XrefRangeEnd = 732393, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static double Pow(double x, double y)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&x);
		*(double**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &y;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Pow_Public_Static_Double_Double_Double_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(double*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 732404, XrefRangeEnd = 732405, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static double Sin(double a)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&a);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Sin_Public_Static_Double_Double_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(double*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	public unsafe static double Sqrt(double d)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&d);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Sqrt_Public_Static_Double_Double_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(double*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 732405, XrefRangeEnd = 732406, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static double Tan(double a)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&a);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Tan_Public_Static_Double_Double_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(double*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 732406, XrefRangeEnd = 732407, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static double ModF(double x, double* intptr)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&x);
		*(double**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = intptr;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ModF_Private_Static_Double_Double_ptr_Double_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(double*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	public Math(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
