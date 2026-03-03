using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.Rendering;

public static class ProbeVolumeConstantRuntimeResources : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_m_SkySamplingDirectionsBuffer;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_AntiLeakDataBuffer;

	private static readonly System.IntPtr NativeFieldInfoPtr_NB_SKY_PRECOMPUTED_DIRECTIONS;

	private static readonly System.IntPtr NativeFieldInfoPtr_k_SkyDirections;

	private static readonly System.IntPtr NativeFieldInfoPtr_k_AntiLeakData;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetRuntimeResources_Internal_Static_Void_byref_RuntimeResources_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Initialize_Internal_Static_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetSkySamplingDirections_Public_Static_Il2CppStructArray_1_Vector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Cleanup_Internal_Static_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GenerateSkyDirections_Private_Static_Il2CppStructArray_1_Vector3_0;

	public unsafe static ComputeBuffer m_SkySamplingDirectionsBuffer
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_m_SkySamplingDirectionsBuffer, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<ComputeBuffer>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_m_SkySamplingDirectionsBuffer, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static ComputeBuffer m_AntiLeakDataBuffer
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_m_AntiLeakDataBuffer, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<ComputeBuffer>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_m_AntiLeakDataBuffer, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static int NB_SKY_PRECOMPUTED_DIRECTIONS
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_NB_SKY_PRECOMPUTED_DIRECTIONS, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_NB_SKY_PRECOMPUTED_DIRECTIONS, (void*)(&value));
		}
	}

	public unsafe static Il2CppStructArray<Vector3> k_SkyDirections
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_k_SkyDirections, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<Vector3>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_k_SkyDirections, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static Il2CppStructArray<uint> k_AntiLeakData
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_k_AntiLeakData, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<uint>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_k_AntiLeakData, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	static ProbeVolumeConstantRuntimeResources()
	{
		Il2CppClassPointerStore<ProbeVolumeConstantRuntimeResources>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Core.Runtime.dll", "UnityEngine.Rendering", "ProbeVolumeConstantRuntimeResources");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ProbeVolumeConstantRuntimeResources>.NativeClassPtr);
		NativeFieldInfoPtr_m_SkySamplingDirectionsBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeVolumeConstantRuntimeResources>.NativeClassPtr, "m_SkySamplingDirectionsBuffer");
		NativeFieldInfoPtr_m_AntiLeakDataBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeVolumeConstantRuntimeResources>.NativeClassPtr, "m_AntiLeakDataBuffer");
		NativeFieldInfoPtr_NB_SKY_PRECOMPUTED_DIRECTIONS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeVolumeConstantRuntimeResources>.NativeClassPtr, "NB_SKY_PRECOMPUTED_DIRECTIONS");
		NativeFieldInfoPtr_k_SkyDirections = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeVolumeConstantRuntimeResources>.NativeClassPtr, "k_SkyDirections");
		NativeFieldInfoPtr_k_AntiLeakData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeVolumeConstantRuntimeResources>.NativeClassPtr, "k_AntiLeakData");
		NativeMethodInfoPtr_GetRuntimeResources_Internal_Static_Void_byref_RuntimeResources_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeVolumeConstantRuntimeResources>.NativeClassPtr, 100665824);
		NativeMethodInfoPtr_Initialize_Internal_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeVolumeConstantRuntimeResources>.NativeClassPtr, 100665825);
		NativeMethodInfoPtr_GetSkySamplingDirections_Public_Static_Il2CppStructArray_1_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeVolumeConstantRuntimeResources>.NativeClassPtr, 100665826);
		NativeMethodInfoPtr_Cleanup_Internal_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeVolumeConstantRuntimeResources>.NativeClassPtr, 100665827);
		NativeMethodInfoPtr_GenerateSkyDirections_Private_Static_Il2CppStructArray_1_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeVolumeConstantRuntimeResources>.NativeClassPtr, 100665828);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1044911, XrefRangeEnd = 1044918, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void GetRuntimeResources(ref ProbeReferenceVolume.RuntimeResources rr)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)rr);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetRuntimeResources_Internal_Static_Void_byref_RuntimeResources_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1044964, RefRangeEnd = 1044965, XrefRangeStart = 1044918, XrefRangeEnd = 1044964, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void Initialize()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Initialize_Internal_Static_Void_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1044965, XrefRangeEnd = 1044969, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Il2CppStructArray<Vector3> GetSkySamplingDirections()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetSkySamplingDirections_Public_Static_Il2CppStructArray_1_Vector3_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<Vector3>>(intPtr2) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1044985, RefRangeEnd = 1044986, XrefRangeStart = 1044969, XrefRangeEnd = 1044985, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void Cleanup()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Cleanup_Internal_Static_Void_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1044986, XrefRangeEnd = 1045001, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Il2CppStructArray<Vector3> GenerateSkyDirections()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GenerateSkyDirections_Private_Static_Il2CppStructArray_1_Vector3_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<Vector3>>(intPtr2) : null;
	}

	public ProbeVolumeConstantRuntimeResources(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
