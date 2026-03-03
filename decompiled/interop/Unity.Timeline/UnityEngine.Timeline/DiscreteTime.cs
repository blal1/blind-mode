using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem;

namespace UnityEngine.Timeline;

[StructLayout(LayoutKind.Explicit)]
public struct DiscreteTime
{
	private static readonly System.IntPtr NativeFieldInfoPtr_k_Tick;

	private static readonly System.IntPtr NativeFieldInfoPtr_kMaxTime;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_DiscreteTime;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_tickValue_Public_Static_get_Double_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_DiscreteTime_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Private_Void_Int64_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Double_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Double_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OneTickBefore_Public_DiscreteTime_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OneTickAfter_Public_DiscreteTime_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetTick_Public_Int64_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FromTicks_Public_Static_DiscreteTime_Int64_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_Object_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Equals_Public_Boolean_DiscreteTime_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DoubleToDiscreteTime_Private_Static_Int64_Double_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FloatToDiscreteTime_Private_Static_Int64_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IntToDiscreteTime_Private_Static_Int64_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ToDouble_Private_Static_Double_Int64_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ToFloat_Private_Static_Single_Int64_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_op_Explicit_Public_Static_Double_DiscreteTime_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_op_Explicit_Public_Static_Single_DiscreteTime_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_op_Explicit_Public_Static_Int64_DiscreteTime_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_op_Explicit_Public_Static_DiscreteTime_Double_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_op_Explicit_Public_Static_DiscreteTime_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_DiscreteTime_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_op_Explicit_Public_Static_DiscreteTime_Int64_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_DiscreteTime_DiscreteTime_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_DiscreteTime_DiscreteTime_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_op_GreaterThan_Public_Static_Boolean_DiscreteTime_DiscreteTime_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_op_LessThan_Public_Static_Boolean_DiscreteTime_DiscreteTime_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_op_LessThanOrEqual_Public_Static_Boolean_DiscreteTime_DiscreteTime_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_op_GreaterThanOrEqual_Public_Static_Boolean_DiscreteTime_DiscreteTime_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_op_Addition_Public_Static_DiscreteTime_DiscreteTime_DiscreteTime_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_op_Subtraction_Public_Static_DiscreteTime_DiscreteTime_DiscreteTime_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Min_Public_Static_DiscreteTime_DiscreteTime_DiscreteTime_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Max_Public_Static_DiscreteTime_DiscreteTime_DiscreteTime_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SnapToNearestTick_Public_Static_Double_Double_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SnapToNearestTick_Public_Static_Single_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetNearestTick_Public_Static_Int64_Double_0;

	[FieldOffset(0)]
	public readonly long m_DiscreteTime;

	public unsafe static double k_Tick
	{
		get
		{
			Unsafe.SkipInit(out double result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_k_Tick, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_k_Tick, (void*)(&value));
		}
	}

	public unsafe static DiscreteTime kMaxTime
	{
		get
		{
			Unsafe.SkipInit(out DiscreteTime result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_kMaxTime, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_kMaxTime, (void*)(&value));
		}
	}

	public unsafe static double tickValue
	{
		[CallerCount(0)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_tickValue_Public_Static_get_Double_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(double*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	static DiscreteTime()
	{
		Il2CppClassPointerStore<DiscreteTime>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.Timeline.dll", "UnityEngine.Timeline", "DiscreteTime");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DiscreteTime>.NativeClassPtr);
		NativeFieldInfoPtr_k_Tick = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DiscreteTime>.NativeClassPtr, "k_Tick");
		NativeFieldInfoPtr_kMaxTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DiscreteTime>.NativeClassPtr, "kMaxTime");
		NativeFieldInfoPtr_m_DiscreteTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DiscreteTime>.NativeClassPtr, "m_DiscreteTime");
		NativeMethodInfoPtr_get_tickValue_Public_Static_get_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DiscreteTime>.NativeClassPtr, 100663827);
		NativeMethodInfoPtr__ctor_Public_Void_DiscreteTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DiscreteTime>.NativeClassPtr, 100663828);
		NativeMethodInfoPtr__ctor_Private_Void_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DiscreteTime>.NativeClassPtr, 100663829);
		NativeMethodInfoPtr__ctor_Public_Void_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DiscreteTime>.NativeClassPtr, 100663830);
		NativeMethodInfoPtr__ctor_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DiscreteTime>.NativeClassPtr, 100663831);
		NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DiscreteTime>.NativeClassPtr, 100663832);
		NativeMethodInfoPtr__ctor_Public_Void_Int32_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DiscreteTime>.NativeClassPtr, 100663833);
		NativeMethodInfoPtr_OneTickBefore_Public_DiscreteTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DiscreteTime>.NativeClassPtr, 100663834);
		NativeMethodInfoPtr_OneTickAfter_Public_DiscreteTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DiscreteTime>.NativeClassPtr, 100663835);
		NativeMethodInfoPtr_GetTick_Public_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DiscreteTime>.NativeClassPtr, 100663836);
		NativeMethodInfoPtr_FromTicks_Public_Static_DiscreteTime_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DiscreteTime>.NativeClassPtr, 100663837);
		NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DiscreteTime>.NativeClassPtr, 100663838);
		NativeMethodInfoPtr_Equals_Public_Boolean_DiscreteTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DiscreteTime>.NativeClassPtr, 100663839);
		NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DiscreteTime>.NativeClassPtr, 100663840);
		NativeMethodInfoPtr_DoubleToDiscreteTime_Private_Static_Int64_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DiscreteTime>.NativeClassPtr, 100663841);
		NativeMethodInfoPtr_FloatToDiscreteTime_Private_Static_Int64_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DiscreteTime>.NativeClassPtr, 100663842);
		NativeMethodInfoPtr_IntToDiscreteTime_Private_Static_Int64_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DiscreteTime>.NativeClassPtr, 100663843);
		NativeMethodInfoPtr_ToDouble_Private_Static_Double_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DiscreteTime>.NativeClassPtr, 100663844);
		NativeMethodInfoPtr_ToFloat_Private_Static_Single_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DiscreteTime>.NativeClassPtr, 100663845);
		NativeMethodInfoPtr_op_Explicit_Public_Static_Double_DiscreteTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DiscreteTime>.NativeClassPtr, 100663846);
		NativeMethodInfoPtr_op_Explicit_Public_Static_Single_DiscreteTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DiscreteTime>.NativeClassPtr, 100663847);
		NativeMethodInfoPtr_op_Explicit_Public_Static_Int64_DiscreteTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DiscreteTime>.NativeClassPtr, 100663848);
		NativeMethodInfoPtr_op_Explicit_Public_Static_DiscreteTime_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DiscreteTime>.NativeClassPtr, 100663849);
		NativeMethodInfoPtr_op_Explicit_Public_Static_DiscreteTime_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DiscreteTime>.NativeClassPtr, 100663850);
		NativeMethodInfoPtr_op_Implicit_Public_Static_DiscreteTime_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DiscreteTime>.NativeClassPtr, 100663851);
		NativeMethodInfoPtr_op_Explicit_Public_Static_DiscreteTime_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DiscreteTime>.NativeClassPtr, 100663852);
		NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_DiscreteTime_DiscreteTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DiscreteTime>.NativeClassPtr, 100663853);
		NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_DiscreteTime_DiscreteTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DiscreteTime>.NativeClassPtr, 100663854);
		NativeMethodInfoPtr_op_GreaterThan_Public_Static_Boolean_DiscreteTime_DiscreteTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DiscreteTime>.NativeClassPtr, 100663855);
		NativeMethodInfoPtr_op_LessThan_Public_Static_Boolean_DiscreteTime_DiscreteTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DiscreteTime>.NativeClassPtr, 100663856);
		NativeMethodInfoPtr_op_LessThanOrEqual_Public_Static_Boolean_DiscreteTime_DiscreteTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DiscreteTime>.NativeClassPtr, 100663857);
		NativeMethodInfoPtr_op_GreaterThanOrEqual_Public_Static_Boolean_DiscreteTime_DiscreteTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DiscreteTime>.NativeClassPtr, 100663858);
		NativeMethodInfoPtr_op_Addition_Public_Static_DiscreteTime_DiscreteTime_DiscreteTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DiscreteTime>.NativeClassPtr, 100663859);
		NativeMethodInfoPtr_op_Subtraction_Public_Static_DiscreteTime_DiscreteTime_DiscreteTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DiscreteTime>.NativeClassPtr, 100663860);
		NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DiscreteTime>.NativeClassPtr, 100663861);
		NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DiscreteTime>.NativeClassPtr, 100663862);
		NativeMethodInfoPtr_Min_Public_Static_DiscreteTime_DiscreteTime_DiscreteTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DiscreteTime>.NativeClassPtr, 100663863);
		NativeMethodInfoPtr_Max_Public_Static_DiscreteTime_DiscreteTime_DiscreteTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DiscreteTime>.NativeClassPtr, 100663864);
		NativeMethodInfoPtr_SnapToNearestTick_Public_Static_Double_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DiscreteTime>.NativeClassPtr, 100663865);
		NativeMethodInfoPtr_SnapToNearestTick_Public_Static_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DiscreteTime>.NativeClassPtr, 100663866);
		NativeMethodInfoPtr_GetNearestTick_Public_Static_Int64_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DiscreteTime>.NativeClassPtr, 100663867);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 687877, RefRangeEnd = 687880, XrefRangeStart = 687877, XrefRangeEnd = 687880, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe DiscreteTime(DiscreteTime time)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&time);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_DiscreteTime_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 687877, RefRangeEnd = 687880, XrefRangeStart = 687877, XrefRangeEnd = 687880, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe DiscreteTime(long time)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&time);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Private_Void_Int64_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1139749, RefRangeEnd = 1139750, XrefRangeStart = 1139745, XrefRangeEnd = 1139749, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe DiscreteTime(double time)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&time);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Double_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1139750, XrefRangeEnd = 1139754, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe DiscreteTime(float time)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&time);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Single_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1139754, XrefRangeEnd = 1139761, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe DiscreteTime(int time)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&time);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Int32_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1139761, XrefRangeEnd = 1139765, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe DiscreteTime(int frame, double fps)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&frame);
		*(double**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &fps;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Int32_Double_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1139765, RefRangeEnd = 1139766, XrefRangeStart = 1139765, XrefRangeEnd = 1139765, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe DiscreteTime OneTickBefore()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OneTickBefore_Public_DiscreteTime_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(DiscreteTime*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1139766, RefRangeEnd = 1139767, XrefRangeStart = 1139766, XrefRangeEnd = 1139766, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe DiscreteTime OneTickAfter()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OneTickAfter_Public_DiscreteTime_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(DiscreteTime*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(98)]
	[CachedScanResults(RefRangeStart = 110111, RefRangeEnd = 110209, XrefRangeStart = 110111, XrefRangeEnd = 110209, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe long GetTick()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetTick_Public_Int64_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(long*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1403)]
	[CachedScanResults(RefRangeStart = 106100, RefRangeEnd = 107503, XrefRangeStart = 106100, XrefRangeEnd = 107503, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static DiscreteTime FromTicks(long ticks)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&ticks);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FromTicks_Public_Static_DiscreteTime_Int64_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(DiscreteTime*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1139767, XrefRangeEnd = 1139771, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual int CompareTo(Il2CppSystem.Object obj)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)obj);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_Object_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(6)]
	[CachedScanResults(RefRangeStart = 687924, RefRangeEnd = 687930, XrefRangeStart = 687924, XrefRangeEnd = 687930, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool Equals(DiscreteTime other)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&other);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Equals_Public_Boolean_DiscreteTime_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1139771, XrefRangeEnd = 1139776, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool Equals(Il2CppSystem.Object obj)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)obj);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(15)]
	[CachedScanResults(RefRangeStart = 1139776, RefRangeEnd = 1139791, XrefRangeStart = 1139776, XrefRangeEnd = 1139776, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static long DoubleToDiscreteTime(double time)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&time);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DoubleToDiscreteTime_Private_Static_Int64_Double_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(long*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 1139791, RefRangeEnd = 1139794, XrefRangeStart = 1139791, XrefRangeEnd = 1139791, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static long FloatToDiscreteTime(float time)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&time);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FloatToDiscreteTime_Private_Static_Int64_Single_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(long*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1139794, XrefRangeEnd = 1139798, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static long IntToDiscreteTime(int time)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&time);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IntToDiscreteTime_Private_Static_Int64_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(long*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	public unsafe static double ToDouble(long time)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&time);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ToDouble_Private_Static_Double_Int64_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(double*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1139798, XrefRangeEnd = 1139801, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static float ToFloat(long time)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&time);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ToFloat_Private_Static_Single_Int64_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 1139804, RefRangeEnd = 1139808, XrefRangeStart = 1139801, XrefRangeEnd = 1139804, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static explicit operator double(DiscreteTime b)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&b);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_op_Explicit_Public_Static_Double_DiscreteTime_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(double*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1139808, XrefRangeEnd = 1139814, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static explicit operator float(DiscreteTime b)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&b);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_op_Explicit_Public_Static_Single_DiscreteTime_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1403)]
	[CachedScanResults(RefRangeStart = 106100, RefRangeEnd = 107503, XrefRangeStart = 106100, XrefRangeEnd = 107503, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static explicit operator long(DiscreteTime b)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&b);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_op_Explicit_Public_Static_Int64_DiscreteTime_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(long*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 1139818, RefRangeEnd = 1139822, XrefRangeStart = 1139814, XrefRangeEnd = 1139818, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static explicit operator DiscreteTime(double time)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&time);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_op_Explicit_Public_Static_DiscreteTime_Double_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(DiscreteTime*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1139822, XrefRangeEnd = 1139826, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static explicit operator DiscreteTime(float time)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&time);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_op_Explicit_Public_Static_DiscreteTime_Single_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(DiscreteTime*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1139833, RefRangeEnd = 1139835, XrefRangeStart = 1139826, XrefRangeEnd = 1139833, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static implicit operator DiscreteTime(int time)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&time);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_op_Implicit_Public_Static_DiscreteTime_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(DiscreteTime*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1403)]
	[CachedScanResults(RefRangeStart = 106100, RefRangeEnd = 107503, XrefRangeStart = 106100, XrefRangeEnd = 107503, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static explicit operator DiscreteTime(long time)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&time);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_op_Explicit_Public_Static_DiscreteTime_Int64_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(DiscreteTime*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1225)]
	[CachedScanResults(RefRangeStart = 682879, RefRangeEnd = 684104, XrefRangeStart = 682879, XrefRangeEnd = 684104, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool operator ==(DiscreteTime lhs, DiscreteTime rhs)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&lhs);
		*(DiscreteTime**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &rhs;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_DiscreteTime_DiscreteTime_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1139838, RefRangeEnd = 1139839, XrefRangeStart = 1139835, XrefRangeEnd = 1139838, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 739672, RefRangeEnd = 739675, XrefRangeStart = 739672, XrefRangeEnd = 739675, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 739665, RefRangeEnd = 739670, XrefRangeStart = 739665, XrefRangeEnd = 739670, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool operator <(DiscreteTime lhs, DiscreteTime rhs)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&lhs);
		*(DiscreteTime**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &rhs;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_op_LessThan_Public_Static_Boolean_DiscreteTime_DiscreteTime_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 739670, RefRangeEnd = 739672, XrefRangeStart = 739670, XrefRangeEnd = 739672, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool operator <=(DiscreteTime lhs, DiscreteTime rhs)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&lhs);
		*(DiscreteTime**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &rhs;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_op_LessThanOrEqual_Public_Static_Boolean_DiscreteTime_DiscreteTime_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 739675, RefRangeEnd = 739677, XrefRangeStart = 739675, XrefRangeEnd = 739677, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1139839, XrefRangeEnd = 1139840, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override string ToString()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ToString_Public_Virtual_String_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return IL2CPP.Il2CppStringToManaged(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1139840, XrefRangeEnd = 1139841, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override int GetHashCode()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1139841, XrefRangeEnd = 1139845, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static DiscreteTime Min(DiscreteTime lhs, DiscreteTime rhs)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&lhs);
		*(DiscreteTime**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &rhs;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Min_Public_Static_DiscreteTime_DiscreteTime_DiscreteTime_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(DiscreteTime*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1139849, RefRangeEnd = 1139850, XrefRangeStart = 1139845, XrefRangeEnd = 1139849, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static DiscreteTime Max(DiscreteTime lhs, DiscreteTime rhs)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&lhs);
		*(DiscreteTime**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &rhs;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Max_Public_Static_DiscreteTime_DiscreteTime_DiscreteTime_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(DiscreteTime*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1139850, XrefRangeEnd = 1139854, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static double SnapToNearestTick(double time)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&time);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SnapToNearestTick_Public_Static_Double_Double_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(double*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1139854, XrefRangeEnd = 1139861, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static float SnapToNearestTick(float time)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&time);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SnapToNearestTick_Public_Static_Single_Single_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1139865, RefRangeEnd = 1139866, XrefRangeStart = 1139861, XrefRangeEnd = 1139865, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static long GetNearestTick(double time)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&time);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetNearestTick_Public_Static_Int64_Double_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(long*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	public unsafe Il2CppSystem.Object BoxIl2CppObject()
	{
		return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<DiscreteTime>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
	}
}
