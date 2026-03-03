using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem;

namespace UnityEngine.Rendering;

public static class LightUnitUtils : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_SphereSolidAngle;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_k_LuminanceToEvFactor_Private_Static_get_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_k_EvToLuminanceFactor_Private_Static_get_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetNativeLightUnit_Public_Static_LightUnit_LightType_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsLightUnitSupported_Public_Static_Boolean_LightType_LightUnit_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetSolidAngleFromPointLight_Public_Static_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetSolidAngleFromSpotLight_Public_Static_Single_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetSolidAngleFromPyramidLight_Public_Static_Single_Single_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetSolidAngle_Internal_Static_Single_LightType_Boolean_Single_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetAreaFromRectangleLight_Public_Static_Single_Single_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetAreaFromRectangleLight_Public_Static_Single_Vector2_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetAreaFromDiscLight_Public_Static_Single_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetAreaFromTubeLight_Public_Static_Single_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_LumenToCandela_Public_Static_Single_Single_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CandelaToLumen_Public_Static_Single_Single_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_LumenToNits_Public_Static_Single_Single_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_NitsToLumen_Public_Static_Single_Single_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_LuxToCandela_Public_Static_Single_Single_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CandelaToLux_Public_Static_Single_Single_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Ev100ToNits_Public_Static_Single_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_NitsToEv100_Public_Static_Single_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Ev100ToCandela_Public_Static_Single_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CandelaToEv100_Public_Static_Single_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ConvertIntensityInternal_Internal_Static_Single_Single_LightUnit_LightUnit_LightType_Single_Single_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ConvertIntensity_Public_Static_Single_Light_Single_LightUnit_LightUnit_0;

	public unsafe static float SphereSolidAngle
	{
		get
		{
			Unsafe.SkipInit(out float result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_SphereSolidAngle, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_SphereSolidAngle, (void*)(&value));
		}
	}

	public unsafe static float k_LuminanceToEvFactor
	{
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1053323, RefRangeEnd = 1053327, XrefRangeStart = 1053315, XrefRangeEnd = 1053323, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_k_LuminanceToEvFactor_Private_Static_get_Single_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(float*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe static float k_EvToLuminanceFactor
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1053327, XrefRangeEnd = 1053328, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_k_EvToLuminanceFactor_Private_Static_get_Single_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(float*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	static LightUnitUtils()
	{
		Il2CppClassPointerStore<LightUnitUtils>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Core.Runtime.dll", "UnityEngine.Rendering", "LightUnitUtils");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LightUnitUtils>.NativeClassPtr);
		NativeFieldInfoPtr_SphereSolidAngle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightUnitUtils>.NativeClassPtr, "SphereSolidAngle");
		NativeMethodInfoPtr_get_k_LuminanceToEvFactor_Private_Static_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightUnitUtils>.NativeClassPtr, 100666762);
		NativeMethodInfoPtr_get_k_EvToLuminanceFactor_Private_Static_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightUnitUtils>.NativeClassPtr, 100666763);
		NativeMethodInfoPtr_GetNativeLightUnit_Public_Static_LightUnit_LightType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightUnitUtils>.NativeClassPtr, 100666764);
		NativeMethodInfoPtr_IsLightUnitSupported_Public_Static_Boolean_LightType_LightUnit_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightUnitUtils>.NativeClassPtr, 100666765);
		NativeMethodInfoPtr_GetSolidAngleFromPointLight_Public_Static_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightUnitUtils>.NativeClassPtr, 100666766);
		NativeMethodInfoPtr_GetSolidAngleFromSpotLight_Public_Static_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightUnitUtils>.NativeClassPtr, 100666767);
		NativeMethodInfoPtr_GetSolidAngleFromPyramidLight_Public_Static_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightUnitUtils>.NativeClassPtr, 100666768);
		NativeMethodInfoPtr_GetSolidAngle_Internal_Static_Single_LightType_Boolean_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightUnitUtils>.NativeClassPtr, 100666769);
		NativeMethodInfoPtr_GetAreaFromRectangleLight_Public_Static_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightUnitUtils>.NativeClassPtr, 100666770);
		NativeMethodInfoPtr_GetAreaFromRectangleLight_Public_Static_Single_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightUnitUtils>.NativeClassPtr, 100666771);
		NativeMethodInfoPtr_GetAreaFromDiscLight_Public_Static_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightUnitUtils>.NativeClassPtr, 100666772);
		NativeMethodInfoPtr_GetAreaFromTubeLight_Public_Static_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightUnitUtils>.NativeClassPtr, 100666773);
		NativeMethodInfoPtr_LumenToCandela_Public_Static_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightUnitUtils>.NativeClassPtr, 100666774);
		NativeMethodInfoPtr_CandelaToLumen_Public_Static_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightUnitUtils>.NativeClassPtr, 100666775);
		NativeMethodInfoPtr_LumenToNits_Public_Static_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightUnitUtils>.NativeClassPtr, 100666776);
		NativeMethodInfoPtr_NitsToLumen_Public_Static_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightUnitUtils>.NativeClassPtr, 100666777);
		NativeMethodInfoPtr_LuxToCandela_Public_Static_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightUnitUtils>.NativeClassPtr, 100666778);
		NativeMethodInfoPtr_CandelaToLux_Public_Static_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightUnitUtils>.NativeClassPtr, 100666779);
		NativeMethodInfoPtr_Ev100ToNits_Public_Static_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightUnitUtils>.NativeClassPtr, 100666780);
		NativeMethodInfoPtr_NitsToEv100_Public_Static_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightUnitUtils>.NativeClassPtr, 100666781);
		NativeMethodInfoPtr_Ev100ToCandela_Public_Static_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightUnitUtils>.NativeClassPtr, 100666782);
		NativeMethodInfoPtr_CandelaToEv100_Public_Static_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightUnitUtils>.NativeClassPtr, 100666783);
		NativeMethodInfoPtr_ConvertIntensityInternal_Internal_Static_Single_Single_LightUnit_LightUnit_LightType_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightUnitUtils>.NativeClassPtr, 100666784);
		NativeMethodInfoPtr_ConvertIntensity_Public_Static_Single_Light_Single_LightUnit_LightUnit_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightUnitUtils>.NativeClassPtr, 100666785);
	}

	[CallerCount(0)]
	public unsafe static LightUnit GetNativeLightUnit(LightType lightType)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&lightType);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetNativeLightUnit_Public_Static_LightUnit_LightType_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(LightUnit*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1053328, RefRangeEnd = 1053329, XrefRangeStart = 1053328, XrefRangeEnd = 1053328, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool IsLightUnitSupported(LightType lightType, LightUnit lightUnit)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&lightType);
		*(LightUnit**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &lightUnit;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsLightUnitSupported_Public_Static_Boolean_LightType_LightUnit_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	public unsafe static float GetSolidAngleFromPointLight()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetSolidAngleFromPointLight_Public_Static_Single_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1053329, XrefRangeEnd = 1053333, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static float GetSolidAngleFromSpotLight(float spotAngle)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&spotAngle);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetSolidAngleFromSpotLight_Public_Static_Single_Single_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1053333, XrefRangeEnd = 1053341, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static float GetSolidAngleFromPyramidLight(float spotAngle, float aspectRatio)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&spotAngle);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &aspectRatio;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetSolidAngleFromPyramidLight_Public_Static_Single_Single_Single_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1053345, RefRangeEnd = 1053346, XrefRangeStart = 1053341, XrefRangeEnd = 1053345, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static float GetSolidAngle(LightType lightType, bool spotReflector, float spotAngle, float aspectRatio)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = (nint)(&lightType);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &spotReflector;
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &spotAngle;
		*(float**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &aspectRatio;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetSolidAngle_Internal_Static_Single_LightType_Boolean_Single_Single_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	public unsafe static float GetAreaFromRectangleLight(float rectSizeX, float rectSizeY)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&rectSizeX);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &rectSizeY;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetAreaFromRectangleLight_Public_Static_Single_Single_Single_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	public unsafe static float GetAreaFromRectangleLight(Vector2 rectSize)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&rectSize);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetAreaFromRectangleLight_Public_Static_Single_Vector2_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	public unsafe static float GetAreaFromDiscLight(float discRadius)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&discRadius);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetAreaFromDiscLight_Public_Static_Single_Single_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	public unsafe static float GetAreaFromTubeLight(float tubeLength)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&tubeLength);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetAreaFromTubeLight_Public_Static_Single_Single_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	public unsafe static float LumenToCandela(float lumen, float solidAngle)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&lumen);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &solidAngle;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_LumenToCandela_Public_Static_Single_Single_Single_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	public unsafe static float CandelaToLumen(float candela, float solidAngle)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&candela);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &solidAngle;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CandelaToLumen_Public_Static_Single_Single_Single_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	public unsafe static float LumenToNits(float lumen, float area)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&lumen);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &area;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_LumenToNits_Public_Static_Single_Single_Single_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	public unsafe static float NitsToLumen(float nits, float area)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&nits);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &area;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_NitsToLumen_Public_Static_Single_Single_Single_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	public unsafe static float LuxToCandela(float lux, float distance)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&lux);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &distance;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_LuxToCandela_Public_Static_Single_Single_Single_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	public unsafe static float CandelaToLux(float candela, float distance)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&candela);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &distance;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CandelaToLux_Public_Static_Single_Single_Single_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 1053348, RefRangeEnd = 1053351, XrefRangeStart = 1053346, XrefRangeEnd = 1053348, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static float Ev100ToNits(float ev100)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&ev100);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Ev100ToNits_Public_Static_Single_Single_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1053356, RefRangeEnd = 1053357, XrefRangeStart = 1053351, XrefRangeEnd = 1053356, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static float NitsToEv100(float nits)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&nits);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_NitsToEv100_Public_Static_Single_Single_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 1053348, RefRangeEnd = 1053351, XrefRangeStart = 1053348, XrefRangeEnd = 1053351, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static float Ev100ToCandela(float ev100)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&ev100);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Ev100ToCandela_Public_Static_Single_Single_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1053357, XrefRangeEnd = 1053358, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static float CandelaToEv100(float candela)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&candela);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CandelaToEv100_Public_Static_Single_Single_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1053368, RefRangeEnd = 1053369, XrefRangeStart = 1053358, XrefRangeEnd = 1053368, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static float ConvertIntensityInternal(float intensity, LightUnit fromUnit, LightUnit toUnit, LightType lightType, float area, float luxAtDistance, float solidAngle)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[7];
		*ptr = (nint)(&intensity);
		*(LightUnit**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &fromUnit;
		*(LightUnit**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &toUnit;
		*(LightType**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &lightType;
		*(float**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &area;
		*(float**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = &luxAtDistance;
		*(float**)((byte*)ptr + checked((nuint)6u * unchecked((nuint)sizeof(System.IntPtr)))) = &solidAngle;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ConvertIntensityInternal_Internal_Static_Single_Single_LightUnit_LightUnit_LightType_Single_Single_Single_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1053369, XrefRangeEnd = 1053383, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static float ConvertIntensity(Light light, float intensity, LightUnit fromUnit, LightUnit toUnit)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)light);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &intensity;
		*(LightUnit**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &fromUnit;
		*(LightUnit**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &toUnit;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ConvertIntensity_Public_Static_Single_Light_Single_LightUnit_LightUnit_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	public LightUnitUtils(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
