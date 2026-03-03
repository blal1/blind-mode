using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine;

public class NumericFieldDraggerUtility : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_s_UseYSign;

	private static readonly System.IntPtr NativeMethodInfoPtr_Acceleration_Public_Static_Single_Boolean_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_NiceDelta_Public_Static_Single_Vector2_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CalculateFloatDragSensitivity_Public_Static_Double_Double_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CalculateFloatDragSensitivity_Public_Static_Double_Double_Double_Double_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CalculateIntDragSensitivity_Public_Static_Int64_Int64_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CalculateIntDragSensitivity_Public_Static_UInt64_UInt64_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CalculateIntDragSensitivity_Public_Static_Double_Double_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CalculateIntDragSensitivity_Public_Static_Int64_Int64_Int64_Int64_0;

	public const float kDragSensitivity = 0.03f;

	public unsafe static bool s_UseYSign
	{
		get
		{
			Unsafe.SkipInit(out bool result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_s_UseYSign, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_s_UseYSign, (void*)(&value));
		}
	}

	static NumericFieldDraggerUtility()
	{
		Il2CppClassPointerStore<NumericFieldDraggerUtility>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "NumericFieldDraggerUtility");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NumericFieldDraggerUtility>.NativeClassPtr);
		NativeFieldInfoPtr_s_UseYSign = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NumericFieldDraggerUtility>.NativeClassPtr, "s_UseYSign");
		NativeMethodInfoPtr_Acceleration_Public_Static_Single_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NumericFieldDraggerUtility>.NativeClassPtr, 100665998);
		NativeMethodInfoPtr_NiceDelta_Public_Static_Single_Vector2_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NumericFieldDraggerUtility>.NativeClassPtr, 100665999);
		NativeMethodInfoPtr_CalculateFloatDragSensitivity_Public_Static_Double_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NumericFieldDraggerUtility>.NativeClassPtr, 100666000);
		NativeMethodInfoPtr_CalculateFloatDragSensitivity_Public_Static_Double_Double_Double_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NumericFieldDraggerUtility>.NativeClassPtr, 100666001);
		NativeMethodInfoPtr_CalculateIntDragSensitivity_Public_Static_Int64_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NumericFieldDraggerUtility>.NativeClassPtr, 100666002);
		NativeMethodInfoPtr_CalculateIntDragSensitivity_Public_Static_UInt64_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NumericFieldDraggerUtility>.NativeClassPtr, 100666003);
		NativeMethodInfoPtr_CalculateIntDragSensitivity_Public_Static_Double_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NumericFieldDraggerUtility>.NativeClassPtr, 100666004);
		NativeMethodInfoPtr_CalculateIntDragSensitivity_Public_Static_Int64_Int64_Int64_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NumericFieldDraggerUtility>.NativeClassPtr, 100666005);
	}

	[CallerCount(8)]
	[CachedScanResults(RefRangeStart = 1184890, RefRangeEnd = 1184898, XrefRangeStart = 1184890, XrefRangeEnd = 1184890, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static float Acceleration(bool shiftPressed, bool altPressed)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&shiftPressed);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &altPressed;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Acceleration_Public_Static_Single_Boolean_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(8)]
	[CachedScanResults(RefRangeStart = 1184905, RefRangeEnd = 1184913, XrefRangeStart = 1184898, XrefRangeEnd = 1184905, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static float NiceDelta(Vector2 deviceDelta, float acceleration)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&deviceDelta);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &acceleration;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_NiceDelta_Public_Static_Single_Vector2_Single_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1184918, RefRangeEnd = 1184920, XrefRangeStart = 1184913, XrefRangeEnd = 1184918, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static double CalculateFloatDragSensitivity(double value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CalculateFloatDragSensitivity_Public_Static_Double_Double_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(double*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1184924, RefRangeEnd = 1184925, XrefRangeStart = 1184920, XrefRangeEnd = 1184924, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static double CalculateFloatDragSensitivity(double value, double minValue, double maxValue)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&value);
		*(double**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &minValue;
		*(double**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &maxValue;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CalculateFloatDragSensitivity_Public_Static_Double_Double_Double_Double_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(double*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 1184926, RefRangeEnd = 1184929, XrefRangeStart = 1184925, XrefRangeEnd = 1184926, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static long CalculateIntDragSensitivity(long value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CalculateIntDragSensitivity_Public_Static_Int64_Int64_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(long*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1184931, RefRangeEnd = 1184932, XrefRangeStart = 1184929, XrefRangeEnd = 1184931, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static ulong CalculateIntDragSensitivity(ulong value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CalculateIntDragSensitivity_Public_Static_UInt64_UInt64_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(ulong*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1184937, RefRangeEnd = 1184939, XrefRangeStart = 1184932, XrefRangeEnd = 1184937, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static double CalculateIntDragSensitivity(double value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CalculateIntDragSensitivity_Public_Static_Double_Double_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(double*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1184943, RefRangeEnd = 1184944, XrefRangeStart = 1184939, XrefRangeEnd = 1184943, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static long CalculateIntDragSensitivity(long value, long minValue, long maxValue)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&value);
		*(long**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &minValue;
		*(long**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &maxValue;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CalculateIntDragSensitivity_Public_Static_Int64_Int64_Int64_Int64_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(long*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	public NumericFieldDraggerUtility(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
