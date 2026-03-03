using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem;

namespace Unity.IntegerTime;

[System.Serializable]
[StructLayout(LayoutKind.Explicit)]
public struct DiscreteTime
{
	private static readonly System.IntPtr NativeFieldInfoPtr_Value;

	private static readonly System.IntPtr NativeFieldInfoPtr_Zero;

	private static readonly System.IntPtr NativeFieldInfoPtr_MinValue;

	private static readonly System.IntPtr NativeFieldInfoPtr_MaxValue;

	private static readonly System.IntPtr NativeFieldInfoPtr_TicksPerSecondBits;

	private static readonly System.IntPtr NativeFieldInfoPtr_NonPow2TpsBits;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Double_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Private_Void_Int64_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FromTicks_Public_Static_DiscreteTime_Int64_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_op_Explicit_Public_Static_Single_DiscreteTime_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_op_Explicit_Public_Static_Double_DiscreteTime_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_DiscreteTime_DiscreteTime_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_op_GreaterThan_Public_Static_Boolean_DiscreteTime_DiscreteTime_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_op_GreaterThanOrEqual_Public_Static_Boolean_DiscreteTime_DiscreteTime_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_op_Addition_Public_Static_DiscreteTime_DiscreteTime_DiscreteTime_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_op_Subtraction_Public_Static_DiscreteTime_DiscreteTime_DiscreteTime_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_DiscreteTime_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_Final_New_String_String_IFormatProvider_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_DiscreteTime_0;

	[FieldOffset(0)]
	public long Value;

	public const int Pow2Exp = 9;

	public const uint Pow2Tps = 512u;

	public const uint NonPow2Tps = 275625u;

	public const uint TicksPerSecond = 141120000u;

	public const double Tick = 7.0861678004535145E-09;

	public const long MaxValueSeconds = 65358361939L;

	public const long MinValueSeconds = -65358361939L;

	public const uint Tick5Fps = 28224000u;

	public const uint Tick10Fps = 14112000u;

	public const uint Tick12Fps = 11760000u;

	public const uint Tick15Fps = 9408000u;

	public const uint Tick2397Fps = 5885880u;

	public const uint Tick24Fps = 5880000u;

	public const uint Tick25Fps = 5644800u;

	public const uint Tick2997Fps = 4708704u;

	public const uint Tick30Fps = 4704000u;

	public const uint Tick48Fps = 2940000u;

	public const uint Tick50Fps = 2822400u;

	public const uint Tick5995Fps = 2354352u;

	public const uint Tick60Fps = 2352000u;

	public const uint Tick90Fps = 1568000u;

	public const uint Tick11988Fps = 1177176u;

	public const uint Tick120Fps = 1176000u;

	public const uint Tick240Fps = 588000u;

	public const uint Tick1000Fps = 141120u;

	public const uint Tick8Khz = 17640u;

	public const uint Tick16Khz = 8820u;

	public const uint Tick22Khz = 6400u;

	public const uint Tick44Khz = 3200u;

	public const uint Tick48Khz = 2940u;

	public const uint Tick88Khz = 1600u;

	public const uint Tick96Khz = 1470u;

	public const uint Tick192Khz = 735u;

	public unsafe static DiscreteTime Zero
	{
		get
		{
			Unsafe.SkipInit(out DiscreteTime result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_Zero, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_Zero, (void*)(&value));
		}
	}

	public unsafe static DiscreteTime MinValue
	{
		get
		{
			Unsafe.SkipInit(out DiscreteTime result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_MinValue, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_MinValue, (void*)(&value));
		}
	}

	public unsafe static DiscreteTime MaxValue
	{
		get
		{
			Unsafe.SkipInit(out DiscreteTime result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_MaxValue, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_MaxValue, (void*)(&value));
		}
	}

	public unsafe static int TicksPerSecondBits
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_TicksPerSecondBits, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_TicksPerSecondBits, (void*)(&value));
		}
	}

	public unsafe static int NonPow2TpsBits
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_NonPow2TpsBits, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_NonPow2TpsBits, (void*)(&value));
		}
	}

	static DiscreteTime()
	{
		Il2CppClassPointerStore<DiscreteTime>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "Unity.IntegerTime", "DiscreteTime");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DiscreteTime>.NativeClassPtr);
		NativeFieldInfoPtr_Value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DiscreteTime>.NativeClassPtr, "Value");
		NativeFieldInfoPtr_Zero = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DiscreteTime>.NativeClassPtr, "Zero");
		NativeFieldInfoPtr_MinValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DiscreteTime>.NativeClassPtr, "MinValue");
		NativeFieldInfoPtr_MaxValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DiscreteTime>.NativeClassPtr, "MaxValue");
		NativeFieldInfoPtr_TicksPerSecondBits = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DiscreteTime>.NativeClassPtr, "TicksPerSecondBits");
		NativeFieldInfoPtr_NonPow2TpsBits = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DiscreteTime>.NativeClassPtr, "NonPow2TpsBits");
		NativeMethodInfoPtr__ctor_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DiscreteTime>.NativeClassPtr, 100663373);
		NativeMethodInfoPtr__ctor_Public_Void_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DiscreteTime>.NativeClassPtr, 100663374);
		NativeMethodInfoPtr__ctor_Private_Void_Int64_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DiscreteTime>.NativeClassPtr, 100663375);
		NativeMethodInfoPtr_FromTicks_Public_Static_DiscreteTime_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DiscreteTime>.NativeClassPtr, 100663376);
		NativeMethodInfoPtr_op_Explicit_Public_Static_Single_DiscreteTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DiscreteTime>.NativeClassPtr, 100663377);
		NativeMethodInfoPtr_op_Explicit_Public_Static_Double_DiscreteTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DiscreteTime>.NativeClassPtr, 100663378);
		NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_DiscreteTime_DiscreteTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DiscreteTime>.NativeClassPtr, 100663379);
		NativeMethodInfoPtr_op_GreaterThan_Public_Static_Boolean_DiscreteTime_DiscreteTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DiscreteTime>.NativeClassPtr, 100663380);
		NativeMethodInfoPtr_op_GreaterThanOrEqual_Public_Static_Boolean_DiscreteTime_DiscreteTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DiscreteTime>.NativeClassPtr, 100663381);
		NativeMethodInfoPtr_op_Addition_Public_Static_DiscreteTime_DiscreteTime_DiscreteTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DiscreteTime>.NativeClassPtr, 100663382);
		NativeMethodInfoPtr_op_Subtraction_Public_Static_DiscreteTime_DiscreteTime_DiscreteTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DiscreteTime>.NativeClassPtr, 100663383);
		NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_DiscreteTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DiscreteTime>.NativeClassPtr, 100663384);
		NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DiscreteTime>.NativeClassPtr, 100663385);
		NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DiscreteTime>.NativeClassPtr, 100663386);
		NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DiscreteTime>.NativeClassPtr, 100663387);
		NativeMethodInfoPtr_ToString_Public_Virtual_Final_New_String_String_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DiscreteTime>.NativeClassPtr, 100663388);
		NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_DiscreteTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DiscreteTime>.NativeClassPtr, 100663389);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1164424, XrefRangeEnd = 1164428, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe DiscreteTime(float v)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&v);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Single_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1164428, XrefRangeEnd = 1164432, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe DiscreteTime(double v)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&v);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Double_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 687877, RefRangeEnd = 687880, XrefRangeStart = 687877, XrefRangeEnd = 687880, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe DiscreteTime(long v, int _)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&v);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &_;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Private_Void_Int64_Int32_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(607)]
	[CachedScanResults(RefRangeStart = 761994, RefRangeEnd = 762601, XrefRangeStart = 761994, XrefRangeEnd = 762601, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static DiscreteTime FromTicks(long v)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&v);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FromTicks_Public_Static_DiscreteTime_Int64_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(DiscreteTime*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	public unsafe static explicit operator float(DiscreteTime d)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&d);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_op_Explicit_Public_Static_Single_DiscreteTime_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	public unsafe static explicit operator double(DiscreteTime d)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&d);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_op_Explicit_Public_Static_Double_DiscreteTime_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(double*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	public unsafe static bool operator !=(DiscreteTime lhs, DiscreteTime rhs)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&lhs);
		*(DiscreteTime**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &rhs;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_DiscreteTime_DiscreteTime_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	public unsafe static bool operator >(DiscreteTime lhs, DiscreteTime rhs)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&lhs);
		*(DiscreteTime**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &rhs;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_op_GreaterThan_Public_Static_Boolean_DiscreteTime_DiscreteTime_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	public unsafe static bool operator >=(DiscreteTime lhs, DiscreteTime rhs)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&lhs);
		*(DiscreteTime**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &rhs;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_op_GreaterThanOrEqual_Public_Static_Boolean_DiscreteTime_DiscreteTime_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1164432, XrefRangeEnd = 1164435, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static DiscreteTime operator +(DiscreteTime lhs, DiscreteTime rhs)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&lhs);
		*(DiscreteTime**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &rhs;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_op_Addition_Public_Static_DiscreteTime_DiscreteTime_DiscreteTime_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(DiscreteTime*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1164435, XrefRangeEnd = 1164438, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static DiscreteTime operator -(DiscreteTime lhs, DiscreteTime rhs)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&lhs);
		*(DiscreteTime**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &rhs;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_op_Subtraction_Public_Static_DiscreteTime_DiscreteTime_DiscreteTime_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(DiscreteTime*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(6)]
	[CachedScanResults(RefRangeStart = 1164438, RefRangeEnd = 1164444, XrefRangeStart = 1164438, XrefRangeEnd = 1164438, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual bool Equals(DiscreteTime rhs)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&rhs);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_DiscreteTime_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1164444, XrefRangeEnd = 1164449, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool Equals(Il2CppSystem.Object o)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)o);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1164449, XrefRangeEnd = 1164450, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override int GetHashCode()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1164450, XrefRangeEnd = 1164454, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override string ToString()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ToString_Public_Virtual_String_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return IL2CPP.Il2CppStringToManaged(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1164454, XrefRangeEnd = 1164458, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual string ToString(string format, Il2CppSystem.IFormatProvider formatProvider)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(format);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)formatProvider);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ToString_Public_Virtual_Final_New_String_String_IFormatProvider_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return IL2CPP.Il2CppStringToManaged(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1164458, XrefRangeEnd = 1164459, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual int CompareTo(DiscreteTime other)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&other);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_DiscreteTime_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	public unsafe Il2CppSystem.Object BoxIl2CppObject()
	{
		return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<DiscreteTime>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
	}

	public static explicit operator DiscreteTime(float v)
	{
		return new DiscreteTime(v);
	}

	public static explicit operator DiscreteTime(double v)
	{
		return new DiscreteTime(v);
	}

	public static implicit operator RationalTime(DiscreteTime t)
	{
		return new RationalTime(t.Value, RationalTime.TicksPerSecond.DiscreteTimeRate);
	}

	public static bool operator ==(DiscreteTime lhs, DiscreteTime rhs)
	{
		return lhs.Value == rhs.Value;
	}

	public static bool operator <(DiscreteTime lhs, DiscreteTime rhs)
	{
		return lhs.Value < rhs.Value;
	}

	public static bool operator <=(DiscreteTime lhs, DiscreteTime rhs)
	{
		return lhs.Value <= rhs.Value;
	}

	public static DiscreteTime operator *(DiscreteTime lhs, long rhs)
	{
		return FromTicks(lhs.Value * rhs);
	}

	public static DiscreteTime operator *(DiscreteTime lhs, double s)
	{
		double i;
		double num = Modf(s, out i);
		long num2 = lhs.Value * (long)i;
		if (Il2CppSystem.Math.Abs(num) >= 7.0861678004535145E-09)
		{
			int num3 = Lzcnt(Il2CppSystem.Math.Abs(lhs.Value)) - 1;
			long num4 = 1 << num3;
			if (num3 >= TicksPerSecondBits)
			{
				num4 = 141120000L;
			}
			else if (num3 >= NonPow2TpsBits)
			{
				num4 = (uint)(275625 << num3 - NonPow2TpsBits);
			}
			long num5 = (long)Il2CppSystem.Math.Round((double)num4 / num);
			num2 += lhs.Value * num4 / num5;
		}
		return FromTicks(num2);
	}

	public static double Modf(double x, out double i)
	{
		i = Il2CppSystem.Math.Truncate(x);
		return x - i;
	}

	public static int Lzcnt(long x)
	{
		throw new System.NotSupportedException("Method unstripping failed");
	}

	public static DiscreteTime operator *(DiscreteTime lhs, float s)
	{
		return lhs * (double)s;
	}

	public static DiscreteTime operator /(DiscreteTime lhs, double s)
	{
		return lhs * (1.0 / s);
	}

	public static DiscreteTime operator /(DiscreteTime lhs, long s)
	{
		return FromTicks(lhs.Value / s);
	}

	public static DiscreteTime operator %(DiscreteTime lhs, DiscreteTime rhs)
	{
		return FromTicks(lhs.Value % rhs.Value);
	}

	public static DiscreteTime operator -(DiscreteTime lhs)
	{
		return FromTicks(-lhs.Value);
	}
}
