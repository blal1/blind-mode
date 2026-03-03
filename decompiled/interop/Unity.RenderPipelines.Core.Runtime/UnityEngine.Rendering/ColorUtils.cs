using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.Rendering;

public static class ColorUtils : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_s_LightMeterCalibrationConstant;

	private static readonly System.IntPtr NativeFieldInfoPtr_s_LensAttenuation;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_lensImperfectionExposureScale_Public_Static_get_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_StandardIlluminantY_Public_Static_Single_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CIExyToLMS_Public_Static_Vector3_Single_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ColorBalanceToLMSCoeffs_Public_Static_Vector3_Single_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_PrepareShadowsMidtonesHighlights_Public_Static_ValueTuple_3_Vector4_Vector4_Vector4_byref_Vector4_byref_Vector4_byref_Vector4_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_PrepareLiftGammaGain_Public_Static_ValueTuple_3_Vector4_Vector4_Vector4_byref_Vector4_byref_Vector4_byref_Vector4_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_PrepareSplitToning_Public_Static_ValueTuple_2_Vector4_Vector4_byref_Vector4_byref_Vector4_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Luminance_Public_Static_Single_byref_Color_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ComputeEV100_Public_Static_Single_Single_Single_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ConvertEV100ToExposure_Public_Static_Single_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ConvertExposureToEV100_Public_Static_Single_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ComputeEV100FromAvgLuminance_Public_Static_Single_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ComputeISO_Public_Static_Single_Single_Single_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ToHex_Public_Static_UInt32_Color_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ToRGBA_Public_Static_Color_UInt32_0;

	public unsafe static float s_LightMeterCalibrationConstant
	{
		get
		{
			Unsafe.SkipInit(out float result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_s_LightMeterCalibrationConstant, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_s_LightMeterCalibrationConstant, (void*)(&value));
		}
	}

	public unsafe static float s_LensAttenuation
	{
		get
		{
			Unsafe.SkipInit(out float result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_s_LensAttenuation, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_s_LensAttenuation, (void*)(&value));
		}
	}

	public unsafe static float lensImperfectionExposureScale
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1051508, XrefRangeEnd = 1051512, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_lensImperfectionExposureScale_Public_Static_get_Single_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(float*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	static ColorUtils()
	{
		Il2CppClassPointerStore<ColorUtils>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Core.Runtime.dll", "UnityEngine.Rendering", "ColorUtils");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ColorUtils>.NativeClassPtr);
		NativeFieldInfoPtr_s_LightMeterCalibrationConstant = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColorUtils>.NativeClassPtr, "s_LightMeterCalibrationConstant");
		NativeFieldInfoPtr_s_LensAttenuation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColorUtils>.NativeClassPtr, "s_LensAttenuation");
		NativeMethodInfoPtr_get_lensImperfectionExposureScale_Public_Static_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorUtils>.NativeClassPtr, 100666555);
		NativeMethodInfoPtr_StandardIlluminantY_Public_Static_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorUtils>.NativeClassPtr, 100666556);
		NativeMethodInfoPtr_CIExyToLMS_Public_Static_Vector3_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorUtils>.NativeClassPtr, 100666557);
		NativeMethodInfoPtr_ColorBalanceToLMSCoeffs_Public_Static_Vector3_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorUtils>.NativeClassPtr, 100666558);
		NativeMethodInfoPtr_PrepareShadowsMidtonesHighlights_Public_Static_ValueTuple_3_Vector4_Vector4_Vector4_byref_Vector4_byref_Vector4_byref_Vector4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorUtils>.NativeClassPtr, 100666559);
		NativeMethodInfoPtr_PrepareLiftGammaGain_Public_Static_ValueTuple_3_Vector4_Vector4_Vector4_byref_Vector4_byref_Vector4_byref_Vector4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorUtils>.NativeClassPtr, 100666560);
		NativeMethodInfoPtr_PrepareSplitToning_Public_Static_ValueTuple_2_Vector4_Vector4_byref_Vector4_byref_Vector4_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorUtils>.NativeClassPtr, 100666561);
		NativeMethodInfoPtr_Luminance_Public_Static_Single_byref_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorUtils>.NativeClassPtr, 100666562);
		NativeMethodInfoPtr_ComputeEV100_Public_Static_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorUtils>.NativeClassPtr, 100666563);
		NativeMethodInfoPtr_ConvertEV100ToExposure_Public_Static_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorUtils>.NativeClassPtr, 100666564);
		NativeMethodInfoPtr_ConvertExposureToEV100_Public_Static_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorUtils>.NativeClassPtr, 100666565);
		NativeMethodInfoPtr_ComputeEV100FromAvgLuminance_Public_Static_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorUtils>.NativeClassPtr, 100666566);
		NativeMethodInfoPtr_ComputeISO_Public_Static_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorUtils>.NativeClassPtr, 100666567);
		NativeMethodInfoPtr_ToHex_Public_Static_UInt32_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorUtils>.NativeClassPtr, 100666568);
		NativeMethodInfoPtr_ToRGBA_Public_Static_Color_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorUtils>.NativeClassPtr, 100666569);
	}

	[CallerCount(0)]
	public unsafe static float StandardIlluminantY(float x)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&x);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_StandardIlluminantY_Public_Static_Single_Single_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	public unsafe static Vector3 CIExyToLMS(float x, float y)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&x);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &y;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CIExyToLMS_Public_Static_Vector3_Single_Single_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(Vector3*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1051516, RefRangeEnd = 1051517, XrefRangeStart = 1051512, XrefRangeEnd = 1051516, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Vector3 ColorBalanceToLMSCoeffs(float temperature, float tint)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&temperature);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &tint;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ColorBalanceToLMSCoeffs_Public_Static_Vector3_Single_Single_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(Vector3*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1051531, RefRangeEnd = 1051532, XrefRangeStart = 1051517, XrefRangeEnd = 1051531, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Il2CppSystem.ValueTuple<Vector4, Vector4, Vector4> PrepareShadowsMidtonesHighlights([In] ref Vector4 inShadows, [In] ref Vector4 inMidtones, [In] ref Vector4 inHighlights)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)Unsafe.AsPointer(ref inShadows);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref inMidtones);
		*(void**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref inHighlights);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_PrepareShadowsMidtonesHighlights_Public_Static_ValueTuple_3_Vector4_Vector4_Vector4_byref_Vector4_byref_Vector4_byref_Vector4_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return new Il2CppSystem.ValueTuple<Vector4, Vector4, Vector4>(pointer);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1051547, RefRangeEnd = 1051548, XrefRangeStart = 1051532, XrefRangeEnd = 1051547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Il2CppSystem.ValueTuple<Vector4, Vector4, Vector4> PrepareLiftGammaGain([In] ref Vector4 inLift, [In] ref Vector4 inGamma, [In] ref Vector4 inGain)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)Unsafe.AsPointer(ref inLift);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref inGamma);
		*(void**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref inGain);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_PrepareLiftGammaGain_Public_Static_ValueTuple_3_Vector4_Vector4_Vector4_byref_Vector4_byref_Vector4_byref_Vector4_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return new Il2CppSystem.ValueTuple<Vector4, Vector4, Vector4>(pointer);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1051551, RefRangeEnd = 1051552, XrefRangeStart = 1051548, XrefRangeEnd = 1051551, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Il2CppSystem.ValueTuple<Vector4, Vector4> PrepareSplitToning([In] ref Vector4 inShadows, [In] ref Vector4 inHighlights, float balance)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)Unsafe.AsPointer(ref inShadows);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref inHighlights);
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &balance;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_PrepareSplitToning_Public_Static_ValueTuple_2_Vector4_Vector4_byref_Vector4_byref_Vector4_Single_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return new Il2CppSystem.ValueTuple<Vector4, Vector4>(pointer);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1051552, RefRangeEnd = 1051554, XrefRangeStart = 1051552, XrefRangeEnd = 1051552, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static float Luminance([In] ref Color color)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)Unsafe.AsPointer(ref color);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Luminance_Public_Static_Single_byref_Color_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1051554, XrefRangeEnd = 1051558, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static float ComputeEV100(float aperture, float shutterSpeed, float ISO)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&aperture);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &shutterSpeed;
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &ISO;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ComputeEV100_Public_Static_Single_Single_Single_Single_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1051558, XrefRangeEnd = 1051566, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static float ConvertEV100ToExposure(float EV100)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&EV100);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ConvertEV100ToExposure_Public_Static_Single_Single_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1051566, XrefRangeEnd = 1051577, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static float ConvertExposureToEV100(float exposure)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&exposure);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ConvertExposureToEV100_Public_Static_Single_Single_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1051577, XrefRangeEnd = 1051585, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static float ComputeEV100FromAvgLuminance(float avgLuminance)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&avgLuminance);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ComputeEV100FromAvgLuminance_Public_Static_Single_Single_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1051585, XrefRangeEnd = 1051586, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static float ComputeISO(float aperture, float shutterSpeed, float targetEV100)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&aperture);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &shutterSpeed;
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &targetEV100;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ComputeISO_Public_Static_Single_Single_Single_Single_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1051586, XrefRangeEnd = 1051589, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static uint ToHex(Color c)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&c);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ToHex_Public_Static_UInt32_Color_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(uint*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	public unsafe static Color ToRGBA(uint hex)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&hex);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ToRGBA_Public_Static_Color_UInt32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(Color*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	public ColorUtils(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
