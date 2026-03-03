using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;

namespace UnityEngine;

[StructLayout(LayoutKind.Explicit)]
public struct Mathf
{
	private delegate float HalfToFloatDelegate(ushort val);

	private delegate float PerlinNoise1DDelegate(float x);

	private static readonly System.IntPtr NativeFieldInfoPtr_Epsilon;

	private static readonly System.IntPtr NativeMethodInfoPtr_GammaToLinearSpace_Public_Static_Single_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_LinearToGammaSpace_Public_Static_Single_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CorrelatedColorTemperatureToRGB_Public_Static_Color_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FloatToHalf_Public_Static_UInt16_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_PerlinNoise_Public_Static_Single_Single_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Sin_Public_Static_Single_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Cos_Public_Static_Single_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Tan_Public_Static_Single_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Acos_Public_Static_Single_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Atan_Public_Static_Single_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Atan2_Public_Static_Single_Single_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Sqrt_Public_Static_Single_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Abs_Public_Static_Single_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Abs_Public_Static_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Min_Public_Static_Single_Single_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Min_Public_Static_Single_Il2CppStructArray_1_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Min_Public_Static_Int32_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Max_Public_Static_Single_Single_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Max_Public_Static_Single_Il2CppStructArray_1_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Max_Public_Static_Int32_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Pow_Public_Static_Single_Single_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Exp_Public_Static_Single_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Log_Public_Static_Single_Single_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Log_Public_Static_Single_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Log10_Public_Static_Single_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Ceil_Public_Static_Single_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Floor_Public_Static_Single_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Round_Public_Static_Single_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CeilToInt_Public_Static_Int32_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FloorToInt_Public_Static_Int32_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RoundToInt_Public_Static_Int32_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Sign_Public_Static_Single_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Clamp_Public_Static_Single_Single_Single_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Clamp_Public_Static_Int32_Int32_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Clamp01_Public_Static_Single_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Lerp_Public_Static_Single_Single_Single_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_LerpUnclamped_Public_Static_Single_Single_Single_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_LerpAngle_Public_Static_Single_Single_Single_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Approximately_Public_Static_Boolean_Single_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SmoothDamp_Public_Static_Single_Single_Single_byref_Single_Single_Single_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Repeat_Public_Static_Single_Single_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_InverseLerp_Public_Static_Single_Single_Single_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ClampToFloat_Internal_Static_Single_Double_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ClampToInt_Internal_Static_Int32_Int64_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ClampToUInt_Internal_Static_UInt32_Int64_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetNumberOfDecimalsForMinimumDifference_Internal_Static_Int32_Double_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RoundBasedOnMinimumDifference_Internal_Static_Double_Double_Double_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DiscardLeastSignificantDecimal_Internal_Static_Double_Double_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_NextPowerOfTwo_Public_Static_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsPowerOfTwo_Public_Static_Boolean_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CorrelatedColorTemperatureToRGB_Injected_Private_Static_Void_Single_byref_Color_0;

	public const float PI = MathF.PI;

	public const float Infinity = float.PositiveInfinity;

	public const float NegativeInfinity = float.NegativeInfinity;

	public const float Deg2Rad = MathF.PI / 180f;

	public const float Rad2Deg = 57.29578f;

	public const int kMaxDecimals = 15;

	private static readonly HalfToFloatDelegate HalfToFloatDelegateField;

	private static readonly PerlinNoise1DDelegate PerlinNoise1DDelegateField;

	public unsafe static float Epsilon
	{
		get
		{
			Unsafe.SkipInit(out float result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_Epsilon, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_Epsilon, (void*)(&value));
		}
	}

	static Mathf()
	{
		Il2CppClassPointerStore<Mathf>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "Mathf");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Mathf>.NativeClassPtr);
		NativeFieldInfoPtr_Epsilon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Mathf>.NativeClassPtr, "Epsilon");
		NativeMethodInfoPtr_GammaToLinearSpace_Public_Static_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mathf>.NativeClassPtr, 100665791);
		NativeMethodInfoPtr_LinearToGammaSpace_Public_Static_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mathf>.NativeClassPtr, 100665792);
		NativeMethodInfoPtr_CorrelatedColorTemperatureToRGB_Public_Static_Color_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mathf>.NativeClassPtr, 100665793);
		NativeMethodInfoPtr_FloatToHalf_Public_Static_UInt16_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mathf>.NativeClassPtr, 100665794);
		NativeMethodInfoPtr_PerlinNoise_Public_Static_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mathf>.NativeClassPtr, 100665795);
		NativeMethodInfoPtr_Sin_Public_Static_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mathf>.NativeClassPtr, 100665796);
		NativeMethodInfoPtr_Cos_Public_Static_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mathf>.NativeClassPtr, 100665797);
		NativeMethodInfoPtr_Tan_Public_Static_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mathf>.NativeClassPtr, 100665798);
		NativeMethodInfoPtr_Acos_Public_Static_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mathf>.NativeClassPtr, 100665799);
		NativeMethodInfoPtr_Atan_Public_Static_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mathf>.NativeClassPtr, 100665800);
		NativeMethodInfoPtr_Atan2_Public_Static_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mathf>.NativeClassPtr, 100665801);
		NativeMethodInfoPtr_Sqrt_Public_Static_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mathf>.NativeClassPtr, 100665802);
		NativeMethodInfoPtr_Abs_Public_Static_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mathf>.NativeClassPtr, 100665803);
		NativeMethodInfoPtr_Abs_Public_Static_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mathf>.NativeClassPtr, 100665804);
		NativeMethodInfoPtr_Min_Public_Static_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mathf>.NativeClassPtr, 100665805);
		NativeMethodInfoPtr_Min_Public_Static_Single_Il2CppStructArray_1_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mathf>.NativeClassPtr, 100665806);
		NativeMethodInfoPtr_Min_Public_Static_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mathf>.NativeClassPtr, 100665807);
		NativeMethodInfoPtr_Max_Public_Static_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mathf>.NativeClassPtr, 100665808);
		NativeMethodInfoPtr_Max_Public_Static_Single_Il2CppStructArray_1_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mathf>.NativeClassPtr, 100665809);
		NativeMethodInfoPtr_Max_Public_Static_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mathf>.NativeClassPtr, 100665810);
		NativeMethodInfoPtr_Pow_Public_Static_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mathf>.NativeClassPtr, 100665811);
		NativeMethodInfoPtr_Exp_Public_Static_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mathf>.NativeClassPtr, 100665812);
		NativeMethodInfoPtr_Log_Public_Static_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mathf>.NativeClassPtr, 100665813);
		NativeMethodInfoPtr_Log_Public_Static_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mathf>.NativeClassPtr, 100665814);
		NativeMethodInfoPtr_Log10_Public_Static_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mathf>.NativeClassPtr, 100665815);
		NativeMethodInfoPtr_Ceil_Public_Static_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mathf>.NativeClassPtr, 100665816);
		NativeMethodInfoPtr_Floor_Public_Static_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mathf>.NativeClassPtr, 100665817);
		NativeMethodInfoPtr_Round_Public_Static_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mathf>.NativeClassPtr, 100665818);
		NativeMethodInfoPtr_CeilToInt_Public_Static_Int32_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mathf>.NativeClassPtr, 100665819);
		NativeMethodInfoPtr_FloorToInt_Public_Static_Int32_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mathf>.NativeClassPtr, 100665820);
		NativeMethodInfoPtr_RoundToInt_Public_Static_Int32_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mathf>.NativeClassPtr, 100665821);
		NativeMethodInfoPtr_Sign_Public_Static_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mathf>.NativeClassPtr, 100665822);
		NativeMethodInfoPtr_Clamp_Public_Static_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mathf>.NativeClassPtr, 100665823);
		NativeMethodInfoPtr_Clamp_Public_Static_Int32_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mathf>.NativeClassPtr, 100665824);
		NativeMethodInfoPtr_Clamp01_Public_Static_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mathf>.NativeClassPtr, 100665825);
		NativeMethodInfoPtr_Lerp_Public_Static_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mathf>.NativeClassPtr, 100665826);
		NativeMethodInfoPtr_LerpUnclamped_Public_Static_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mathf>.NativeClassPtr, 100665827);
		NativeMethodInfoPtr_LerpAngle_Public_Static_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mathf>.NativeClassPtr, 100665828);
		NativeMethodInfoPtr_Approximately_Public_Static_Boolean_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mathf>.NativeClassPtr, 100665829);
		NativeMethodInfoPtr_SmoothDamp_Public_Static_Single_Single_Single_byref_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mathf>.NativeClassPtr, 100665830);
		NativeMethodInfoPtr_Repeat_Public_Static_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mathf>.NativeClassPtr, 100665831);
		NativeMethodInfoPtr_InverseLerp_Public_Static_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mathf>.NativeClassPtr, 100665832);
		NativeMethodInfoPtr_ClampToFloat_Internal_Static_Single_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mathf>.NativeClassPtr, 100665833);
		NativeMethodInfoPtr_ClampToInt_Internal_Static_Int32_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mathf>.NativeClassPtr, 100665834);
		NativeMethodInfoPtr_ClampToUInt_Internal_Static_UInt32_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mathf>.NativeClassPtr, 100665835);
		NativeMethodInfoPtr_GetNumberOfDecimalsForMinimumDifference_Internal_Static_Int32_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mathf>.NativeClassPtr, 100665836);
		NativeMethodInfoPtr_RoundBasedOnMinimumDifference_Internal_Static_Double_Double_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mathf>.NativeClassPtr, 100665837);
		NativeMethodInfoPtr_DiscardLeastSignificantDecimal_Internal_Static_Double_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mathf>.NativeClassPtr, 100665838);
		NativeMethodInfoPtr_NextPowerOfTwo_Public_Static_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mathf>.NativeClassPtr, 100665839);
		NativeMethodInfoPtr_IsPowerOfTwo_Public_Static_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mathf>.NativeClassPtr, 100665840);
		NativeMethodInfoPtr_CorrelatedColorTemperatureToRGB_Injected_Private_Static_Void_Single_byref_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mathf>.NativeClassPtr, 100665842);
		HalfToFloatDelegateField = IL2CPP.ResolveICall<HalfToFloatDelegate>("UnityEngine.Mathf::HalfToFloat");
		PerlinNoise1DDelegateField = IL2CPP.ResolveICall<PerlinNoise1DDelegate>("UnityEngine.Mathf::PerlinNoise1D");
	}

	[CallerCount(68)]
	[CachedScanResults(RefRangeStart = 1184085, RefRangeEnd = 1184153, XrefRangeStart = 1184083, XrefRangeEnd = 1184085, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static float GammaToLinearSpace(float value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GammaToLinearSpace_Public_Static_Single_Single_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(9)]
	[CachedScanResults(RefRangeStart = 1184155, RefRangeEnd = 1184164, XrefRangeStart = 1184153, XrefRangeEnd = 1184155, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static float LinearToGammaSpace(float value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_LinearToGammaSpace_Public_Static_Single_Single_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(6)]
	[CachedScanResults(RefRangeStart = 1184166, RefRangeEnd = 1184172, XrefRangeStart = 1184164, XrefRangeEnd = 1184166, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Color CorrelatedColorTemperatureToRGB(float kelvin)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&kelvin);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CorrelatedColorTemperatureToRGB_Public_Static_Color_Single_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(Color*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 1184174, RefRangeEnd = 1184179, XrefRangeStart = 1184172, XrefRangeEnd = 1184174, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static ushort FloatToHalf(float val)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&val);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FloatToHalf_Public_Static_UInt16_Single_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(ushort*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 1184181, RefRangeEnd = 1184184, XrefRangeStart = 1184179, XrefRangeEnd = 1184181, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static float PerlinNoise(float x, float y)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&x);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &y;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_PerlinNoise_Public_Static_Single_Single_Single_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1184184, XrefRangeEnd = 1184188, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static float Sin(float f)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&f);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Sin_Public_Static_Single_Single_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1184188, XrefRangeEnd = 1184192, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static float Cos(float f)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&f);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Cos_Public_Static_Single_Single_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1184192, XrefRangeEnd = 1184196, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static float Tan(float f)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&f);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Tan_Public_Static_Single_Single_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1184196, XrefRangeEnd = 1184200, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static float Acos(float f)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&f);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Acos_Public_Static_Single_Single_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1184200, XrefRangeEnd = 1184204, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static float Atan(float f)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&f);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Atan_Public_Static_Single_Single_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1184204, XrefRangeEnd = 1184208, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static float Atan2(float y, float x)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&y);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &x;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Atan2_Public_Static_Single_Single_Single_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1184208, XrefRangeEnd = 1184211, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static float Sqrt(float f)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&f);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Sqrt_Public_Static_Single_Single_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1184211, XrefRangeEnd = 1184214, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static float Abs(float f)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&f);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Abs_Public_Static_Single_Single_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1184214, XrefRangeEnd = 1184217, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
	public unsafe static float Min(float a, float b)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&a);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &b;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Min_Public_Static_Single_Single_Single_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	public unsafe static float Min([Optional] Il2CppStructArray<float> values)
	{
		if (values == null)
		{
			values = new Il2CppStructArray<float>(0L);
		}
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)values);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Min_Public_Static_Single_Il2CppStructArray_1_Single_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	public unsafe static int Min(int a, int b)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&a);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &b;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Min_Public_Static_Int32_Int32_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	public unsafe static float Max(float a, float b)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&a);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &b;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Max_Public_Static_Single_Single_Single_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	public unsafe static float Max([Optional] Il2CppStructArray<float> values)
	{
		if (values == null)
		{
			values = new Il2CppStructArray<float>(0L);
		}
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)values);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Max_Public_Static_Single_Il2CppStructArray_1_Single_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	public unsafe static int Max(int a, int b)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&a);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &b;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Max_Public_Static_Int32_Int32_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1184217, XrefRangeEnd = 1184221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static float Pow(float f, float p)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&f);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &p;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Pow_Public_Static_Single_Single_Single_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1184221, XrefRangeEnd = 1184225, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static float Exp(float power)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&power);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Exp_Public_Static_Single_Single_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1184225, XrefRangeEnd = 1184229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static float Log(float f, float p)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&f);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &p;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Log_Public_Static_Single_Single_Single_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1184229, XrefRangeEnd = 1184233, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static float Log(float f)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&f);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Log_Public_Static_Single_Single_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1184233, XrefRangeEnd = 1184237, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static float Log10(float f)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&f);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Log10_Public_Static_Single_Single_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1184237, XrefRangeEnd = 1184241, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static float Ceil(float f)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&f);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Ceil_Public_Static_Single_Single_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1184241, XrefRangeEnd = 1184245, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static float Floor(float f)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&f);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Floor_Public_Static_Single_Single_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1184245, XrefRangeEnd = 1184249, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static float Round(float f)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&f);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Round_Public_Static_Single_Single_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1184249, XrefRangeEnd = 1184253, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int CeilToInt(float f)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&f);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CeilToInt_Public_Static_Int32_Single_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1184253, XrefRangeEnd = 1184257, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int FloorToInt(float f)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&f);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FloorToInt_Public_Static_Int32_Single_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1184257, XrefRangeEnd = 1184261, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int RoundToInt(float f)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&f);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RoundToInt_Public_Static_Int32_Single_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	public unsafe static float Sign(float f)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&f);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Sign_Public_Static_Single_Single_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(7)]
	[CachedScanResults(RefRangeStart = 843719, RefRangeEnd = 843726, XrefRangeStart = 843719, XrefRangeEnd = 843726, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

	[CallerCount(0)]
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
	public unsafe static float Clamp01(float value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Clamp01_Public_Static_Single_Single_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	public unsafe static float Lerp(float a, float b, float t)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&a);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &b;
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &t;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Lerp_Public_Static_Single_Single_Single_Single_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	public unsafe static float LerpUnclamped(float a, float b, float t)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&a);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &b;
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &t;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_LerpUnclamped_Public_Static_Single_Single_Single_Single_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1184261, XrefRangeEnd = 1184264, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static float LerpAngle(float a, float b, float t)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&a);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &b;
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &t;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_LerpAngle_Public_Static_Single_Single_Single_Single_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1184264, XrefRangeEnd = 1184266, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool Approximately(float a, float b)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&a);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &b;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Approximately_Public_Static_Boolean_Single_Single_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 1184268, RefRangeEnd = 1184271, XrefRangeStart = 1184266, XrefRangeEnd = 1184268, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static float SmoothDamp(float current, float target, ref float currentVelocity, float smoothTime, float maxSpeed, float deltaTime)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[6];
		*ptr = (nint)(&current);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &target;
		*(void**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref currentVelocity);
		*(float**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &smoothTime;
		*(float**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &maxSpeed;
		*(float**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = &deltaTime;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SmoothDamp_Public_Static_Single_Single_Single_byref_Single_Single_Single_Single_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1184271, XrefRangeEnd = 1184272, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static float Repeat(float t, float length)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&t);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &length;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Repeat_Public_Static_Single_Single_Single_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	public unsafe static float InverseLerp(float a, float b, float value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&a);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &b;
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &value;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InverseLerp_Public_Static_Single_Single_Single_Single_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1184272, RefRangeEnd = 1184274, XrefRangeStart = 1184272, XrefRangeEnd = 1184272, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static float ClampToFloat(double value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ClampToFloat_Internal_Static_Single_Double_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1184274, RefRangeEnd = 1184276, XrefRangeStart = 1184274, XrefRangeEnd = 1184274, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int ClampToInt(long value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ClampToInt_Internal_Static_Int32_Int64_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1184276, RefRangeEnd = 1184278, XrefRangeStart = 1184276, XrefRangeEnd = 1184276, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static uint ClampToUInt(long value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ClampToUInt_Internal_Static_UInt32_Int64_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(uint*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1184278, XrefRangeEnd = 1184284, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int GetNumberOfDecimalsForMinimumDifference(double minDifference)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&minDifference);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetNumberOfDecimalsForMinimumDifference_Internal_Static_Int32_Double_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1184296, RefRangeEnd = 1184298, XrefRangeStart = 1184284, XrefRangeEnd = 1184296, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static double RoundBasedOnMinimumDifference(double valueToRound, double minDifference)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&valueToRound);
		*(double**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &minDifference;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RoundBasedOnMinimumDifference_Internal_Static_Double_Double_Double_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(double*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1184310, RefRangeEnd = 1184311, XrefRangeStart = 1184298, XrefRangeEnd = 1184310, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static double DiscardLeastSignificantDecimal(double v)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&v);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DiscardLeastSignificantDecimal_Internal_Static_Double_Double_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(double*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	public unsafe static int NextPowerOfTwo(int value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_NextPowerOfTwo_Public_Static_Int32_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	public unsafe static bool IsPowerOfTwo(int value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsPowerOfTwo_Public_Static_Boolean_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1184311, XrefRangeEnd = 1184313, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void CorrelatedColorTemperatureToRGB_Injected(float kelvin, out Color ret)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&kelvin);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref ret);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CorrelatedColorTemperatureToRGB_Injected_Private_Static_Void_Single_byref_Color_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public static float Min(params float[] values)
	{
		return Min(new Il2CppStructArray<float>(values));
	}

	public static float Max(params float[] values)
	{
		return Max(new Il2CppStructArray<float>(values));
	}

	public unsafe Il2CppSystem.Object BoxIl2CppObject()
	{
		return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Mathf>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
	}

	public static float HalfToFloat(ushort val)
	{
		return HalfToFloatDelegateField(val);
	}

	public static float PerlinNoise1D(float x)
	{
		return PerlinNoise1DDelegateField(x);
	}

	public static float Asin(float f)
	{
		return (float)Il2CppSystem.Math.Asin(f);
	}

	public static int Min(Il2CppStructArray<int> values)
	{
		throw new System.NotSupportedException("Method unstripping failed");
	}

	public static int Min(params int[] values)
	{
		return Min(new Il2CppStructArray<int>(values));
	}

	public static int Max(Il2CppStructArray<int> values)
	{
		throw new System.NotSupportedException("Method unstripping failed");
	}

	public static int Max(params int[] values)
	{
		return Max(new Il2CppStructArray<int>(values));
	}

	public static float MoveTowards(float current, float target, float maxDelta)
	{
		if (Abs(target - current) <= maxDelta)
		{
			return target;
		}
		return current + Sign(target - current) * maxDelta;
	}

	public static float MoveTowardsAngle(float current, float target, float maxDelta)
	{
		float num = DeltaAngle(current, target);
		if (0f - maxDelta < num && num < maxDelta)
		{
			return target;
		}
		target = current + num;
		return MoveTowards(current, target, maxDelta);
	}

	public static float SmoothStep(float from, float to, float t)
	{
		t = Clamp01(t);
		t = -2f * t * t * t + 3f * t * t;
		return to * t + from * (1f - t);
	}

	public static float Gamma(float value, float absmax, float gamma)
	{
		bool flag = value < 0f;
		float num = Abs(value);
		if (num > absmax)
		{
			return flag ? (0f - num) : num;
		}
		float num2 = Pow(num / absmax, gamma) * absmax;
		return flag ? (0f - num2) : num2;
	}

	public static float SmoothDamp(float current, float target, ref float currentVelocity, float smoothTime, float maxSpeed)
	{
		float deltaTime = Time.deltaTime;
		return SmoothDamp(current, target, ref currentVelocity, smoothTime, maxSpeed, deltaTime);
	}

	public static float SmoothDamp(float current, float target, ref float currentVelocity, float smoothTime)
	{
		float deltaTime = Time.deltaTime;
		float maxSpeed = float.PositiveInfinity;
		return SmoothDamp(current, target, ref currentVelocity, smoothTime, maxSpeed, deltaTime);
	}

	public static float SmoothDampAngle(float current, float target, ref float currentVelocity, float smoothTime, float maxSpeed)
	{
		float deltaTime = Time.deltaTime;
		return SmoothDampAngle(current, target, ref currentVelocity, smoothTime, maxSpeed, deltaTime);
	}

	public static float SmoothDampAngle(float current, float target, ref float currentVelocity, float smoothTime)
	{
		float deltaTime = Time.deltaTime;
		float maxSpeed = float.PositiveInfinity;
		return SmoothDampAngle(current, target, ref currentVelocity, smoothTime, maxSpeed, deltaTime);
	}

	public static float SmoothDampAngle(float current, float target, ref float currentVelocity, float smoothTime, float maxSpeed, float deltaTime)
	{
		target = current + DeltaAngle(current, target);
		return SmoothDamp(current, target, ref currentVelocity, smoothTime, maxSpeed, deltaTime);
	}

	public static float PingPong(float t, float length)
	{
		t = Repeat(t, length * 2f);
		return length - Abs(t - length);
	}

	public static float DeltaAngle(float current, float target)
	{
		float num = Repeat(target - current, 360f);
		if (num > 180f)
		{
			num -= 360f;
		}
		return num;
	}

	public static bool LineIntersection(Vector2 p1, Vector2 p2, Vector2 p3, Vector2 p4, ref Vector2 result)
	{
		float num = p2.x - p1.x;
		float num2 = p2.y - p1.y;
		float num3 = p4.x - p3.x;
		float num4 = p4.y - p3.y;
		float num5 = num * num4 - num2 * num3;
		if (num5 == 0f)
		{
			return false;
		}
		float num6 = p3.x - p1.x;
		float num7 = p3.y - p1.y;
		float num8 = (num6 * num4 - num7 * num3) / num5;
		result.x = p1.x + num8 * num;
		result.y = p1.y + num8 * num2;
		return true;
	}

	public static bool LineSegmentIntersection(Vector2 p1, Vector2 p2, Vector2 p3, Vector2 p4, ref Vector2 result)
	{
		float num = p2.x - p1.x;
		float num2 = p2.y - p1.y;
		float num3 = p4.x - p3.x;
		float num4 = p4.y - p3.y;
		float num5 = num * num4 - num2 * num3;
		if (num5 == 0f)
		{
			return false;
		}
		float num6 = p3.x - p1.x;
		float num7 = p3.y - p1.y;
		float num8 = (num6 * num4 - num7 * num3) / num5;
		if (num8 < 0f || num8 > 1f)
		{
			return false;
		}
		float num9 = (num6 * num2 - num7 * num) / num5;
		if (num9 < 0f || num9 > 1f)
		{
			return false;
		}
		result.x = p1.x + num8 * num;
		result.y = p1.y + num8 * num2;
		return true;
	}

	public static long RandomToLong(Il2CppSystem.Random r)
	{
		throw new System.NotSupportedException("Method unstripping failed");
	}

	public static float RoundToMultipleOf(float value, float roundingValue)
	{
		if (roundingValue == 0f)
		{
			return value;
		}
		return Round(value / roundingValue) * roundingValue;
	}

	public static float GetClosestPowerOfTen(float positiveNumber)
	{
		if (positiveNumber <= 0f)
		{
			return 1f;
		}
		return Pow(10f, RoundToInt(Log10(positiveNumber)));
	}

	public static int GetNumberOfDecimalsForMinimumDifference(float minDifference)
	{
		return Clamp(-FloorToInt(Log10(Abs(minDifference))), 0, 15);
	}

	public static float RoundBasedOnMinimumDifference(float valueToRound, float minDifference)
	{
		if (minDifference == 0f)
		{
			return DiscardLeastSignificantDecimal(valueToRound);
		}
		return (float)Il2CppSystem.Math.Round(valueToRound, GetNumberOfDecimalsForMinimumDifference(minDifference), Il2CppSystem.MidpointRounding.AwayFromZero);
	}

	public static float DiscardLeastSignificantDecimal(float v)
	{
		int digits = Clamp((int)(5f - Log10(Abs(v))), 0, 15);
		return (float)Il2CppSystem.Math.Round(v, digits, Il2CppSystem.MidpointRounding.AwayFromZero);
	}

	public static int ClosestPowerOfTwo(int value)
	{
		int num = NextPowerOfTwo(value);
		int num2 = num >> 1;
		if (value - num2 < num - value)
		{
			return num2;
		}
		return num;
	}
}
