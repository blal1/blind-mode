using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using UnityEngine;
using UnityEngine.Bindings;

namespace Unity.Profiling.LowLevel.Unsafe;

public static class ProfilerUnsafeUtility : Il2CppSystem.Object
{
	private delegate ushort CreateCategory_UnsafeDelegate(System.IntPtr name, int nameLen, ProfilerCategoryColor colorIndex);

	private delegate ushort GetCategoryByName_UnsafeDelegate(System.IntPtr name, int nameLen);

	private delegate System.IntPtr CreateMarker_UnsafeDelegate(System.IntPtr name, int nameLen, ushort categoryId, MarkerFlags flags, int metadataCount);

	private delegate void SetMarkerMetadata_UnsafeDelegate(System.IntPtr markerPtr, int index, System.IntPtr name, int nameLen, byte type, byte unit);

	private delegate void BeginSampleWithMetadataDelegate(System.IntPtr markerPtr, int metadataCount, System.IntPtr metadata);

	private delegate void SingleSampleWithMetadataDelegate(System.IntPtr markerPtr, int metadataCount, System.IntPtr metadata);

	private delegate System.IntPtr CreateCounterValue_UnsafeDelegate([Out] System.IntPtr counterPtr, System.IntPtr name, int nameLen, ushort categoryId, MarkerFlags flags, byte dataType, byte dataUnit, int dataSize, ProfilerCounterOptions counterOptions);

	private delegate void FlushCounterValueDelegate(System.IntPtr counterValuePtr);

	private delegate uint CreateFlowDelegate(ushort categoryId);

	private delegate void FlowEventDelegate(uint flowId, ProfilerFlowEventType flowEventType);

	private delegate long get_TimestampDelegate();

	private delegate ushort CreateCategory_InjectedDelegate(System.IntPtr name, ProfilerCategoryColor colorIndex);

	private delegate void GetCategoryColor_InjectedDelegate(ProfilerCategoryColor colorIndex, [Out] System.IntPtr ret);

	private delegate System.IntPtr GetMarker_InjectedDelegate(System.IntPtr name);

	private delegate void SetMarkerMetadata_InjectedDelegate(System.IntPtr markerPtr, int index, System.IntPtr name, byte type, byte unit);

	private delegate System.IntPtr CreateCounterValue_InjectedDelegate([Out] System.IntPtr counterPtr, System.IntPtr name, ushort categoryId, MarkerFlags flags, byte dataType, byte dataUnit, int dataSize, ProfilerCounterOptions counterOptions);

	private delegate void Internal_BeginWithObject_InjectedDelegate(System.IntPtr markerPtr, System.IntPtr contextUnityObject);

	private delegate void Internal_GetName_InjectedDelegate(System.IntPtr markerPtr, [Out] System.IntPtr ret);

	private static readonly System.IntPtr NativeMethodInfoPtr_CreateCategory__Unmanaged_Internal_Static_UInt16_ptr_Byte_Int32_ProfilerCategoryColor_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetCategoryDescription_Public_Static_ProfilerCategoryDescription_UInt16_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CreateMarker_Public_Static_IntPtr_String_UInt16_MarkerFlags_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CreateMarker__Unmanaged_Internal_Static_IntPtr_ptr_Byte_Int32_UInt16_MarkerFlags_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetMarkerMetadata__Unmanaged_Internal_Static_Void_IntPtr_Int32_ptr_Byte_Int32_Byte_Byte_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_BeginSample_Public_Static_Void_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_EndSample_Public_Static_Void_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CreateCounterValue__Unmanaged_Internal_Static_ptr_Void_byref_IntPtr_ptr_Byte_Int32_UInt16_MarkerFlags_Byte_Byte_Int32_ProfilerCounterOptions_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Utf8ToString_Internal_Static_String_ptr_Byte_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetCategoryDescription_Injected_Private_Static_Void_UInt16_byref_ProfilerCategoryDescription_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CreateMarker_Injected_Private_Static_IntPtr_byref_ManagedSpanWrapper_UInt16_MarkerFlags_Int32_0;

	public const ushort CategoryRender = 0;

	public const ushort CategoryScripts = 1;

	public const ushort CategoryGUI = 4;

	public const ushort CategoryPhysics = 5;

	public const ushort CategoryAnimation = 6;

	public const ushort CategoryAi = 7;

	public const ushort CategoryAudio = 8;

	public const ushort CategoryVideo = 11;

	public const ushort CategoryParticles = 12;

	public const ushort CategoryLighting = 13;

	public const ushort CategoryLightning = 13;

	public const ushort CategoryNetwork = 14;

	public const ushort CategoryLoading = 15;

	public const ushort CategoryOther = 16;

	public const ushort CategoryVr = 22;

	public const ushort CategoryAllocation = 23;

	public const ushort CategoryInternal = 24;

	public const ushort CategoryFileIO = 25;

	public const ushort CategoryInput = 30;

	public const ushort CategoryVirtualTexturing = 31;

	public const ushort CategoryGPU = 32;

	public const ushort CategoryPhysics2D = 33;

	public const ushort CategoryAny = ushort.MaxValue;

	private static readonly CreateCategory_UnsafeDelegate CreateCategory_UnsafeDelegateField;

	private static readonly GetCategoryByName_UnsafeDelegate GetCategoryByName_UnsafeDelegateField;

	private static readonly CreateMarker_UnsafeDelegate CreateMarker_UnsafeDelegateField;

	private static readonly SetMarkerMetadata_UnsafeDelegate SetMarkerMetadata_UnsafeDelegateField;

	private static readonly BeginSampleWithMetadataDelegate BeginSampleWithMetadataDelegateField;

	private static readonly SingleSampleWithMetadataDelegate SingleSampleWithMetadataDelegateField;

	private static readonly CreateCounterValue_UnsafeDelegate CreateCounterValue_UnsafeDelegateField;

	private static readonly FlushCounterValueDelegate FlushCounterValueDelegateField;

	private static readonly CreateFlowDelegate CreateFlowDelegateField;

	private static readonly FlowEventDelegate FlowEventDelegateField;

	private static readonly get_TimestampDelegate get_TimestampDelegateField;

	private static readonly CreateCategory_InjectedDelegate CreateCategory_InjectedDelegateField;

	private static readonly GetCategoryColor_InjectedDelegate GetCategoryColor_InjectedDelegateField;

	private static readonly GetMarker_InjectedDelegate GetMarker_InjectedDelegateField;

	private static readonly SetMarkerMetadata_InjectedDelegate SetMarkerMetadata_InjectedDelegateField;

	private static readonly CreateCounterValue_InjectedDelegate CreateCounterValue_InjectedDelegateField;

	private static readonly Internal_BeginWithObject_InjectedDelegate Internal_BeginWithObject_InjectedDelegateField;

	private static readonly Internal_GetName_InjectedDelegate Internal_GetName_InjectedDelegateField;

	public static long Timestamp => get_TimestampDelegateField();

	static ProfilerUnsafeUtility()
	{
		Il2CppClassPointerStore<ProfilerUnsafeUtility>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "Unity.Profiling.LowLevel.Unsafe", "ProfilerUnsafeUtility");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ProfilerUnsafeUtility>.NativeClassPtr);
		NativeMethodInfoPtr_CreateCategory__Unmanaged_Internal_Static_UInt16_ptr_Byte_Int32_ProfilerCategoryColor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfilerUnsafeUtility>.NativeClassPtr, 100663451);
		NativeMethodInfoPtr_GetCategoryDescription_Public_Static_ProfilerCategoryDescription_UInt16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfilerUnsafeUtility>.NativeClassPtr, 100663452);
		NativeMethodInfoPtr_CreateMarker_Public_Static_IntPtr_String_UInt16_MarkerFlags_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfilerUnsafeUtility>.NativeClassPtr, 100663453);
		NativeMethodInfoPtr_CreateMarker__Unmanaged_Internal_Static_IntPtr_ptr_Byte_Int32_UInt16_MarkerFlags_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfilerUnsafeUtility>.NativeClassPtr, 100663454);
		NativeMethodInfoPtr_SetMarkerMetadata__Unmanaged_Internal_Static_Void_IntPtr_Int32_ptr_Byte_Int32_Byte_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfilerUnsafeUtility>.NativeClassPtr, 100663455);
		NativeMethodInfoPtr_BeginSample_Public_Static_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfilerUnsafeUtility>.NativeClassPtr, 100663456);
		NativeMethodInfoPtr_EndSample_Public_Static_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfilerUnsafeUtility>.NativeClassPtr, 100663457);
		NativeMethodInfoPtr_CreateCounterValue__Unmanaged_Internal_Static_ptr_Void_byref_IntPtr_ptr_Byte_Int32_UInt16_MarkerFlags_Byte_Byte_Int32_ProfilerCounterOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfilerUnsafeUtility>.NativeClassPtr, 100663458);
		NativeMethodInfoPtr_Utf8ToString_Internal_Static_String_ptr_Byte_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfilerUnsafeUtility>.NativeClassPtr, 100663459);
		NativeMethodInfoPtr_GetCategoryDescription_Injected_Private_Static_Void_UInt16_byref_ProfilerCategoryDescription_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfilerUnsafeUtility>.NativeClassPtr, 100663460);
		NativeMethodInfoPtr_CreateMarker_Injected_Private_Static_IntPtr_byref_ManagedSpanWrapper_UInt16_MarkerFlags_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfilerUnsafeUtility>.NativeClassPtr, 100663461);
		CreateCategory_UnsafeDelegateField = IL2CPP.ResolveICall<CreateCategory_UnsafeDelegate>("Unity.Profiling.LowLevel.Unsafe.ProfilerUnsafeUtility::CreateCategory_Unsafe");
		GetCategoryByName_UnsafeDelegateField = IL2CPP.ResolveICall<GetCategoryByName_UnsafeDelegate>("Unity.Profiling.LowLevel.Unsafe.ProfilerUnsafeUtility::GetCategoryByName_Unsafe");
		CreateMarker_UnsafeDelegateField = IL2CPP.ResolveICall<CreateMarker_UnsafeDelegate>("Unity.Profiling.LowLevel.Unsafe.ProfilerUnsafeUtility::CreateMarker_Unsafe");
		SetMarkerMetadata_UnsafeDelegateField = IL2CPP.ResolveICall<SetMarkerMetadata_UnsafeDelegate>("Unity.Profiling.LowLevel.Unsafe.ProfilerUnsafeUtility::SetMarkerMetadata_Unsafe");
		BeginSampleWithMetadataDelegateField = IL2CPP.ResolveICall<BeginSampleWithMetadataDelegate>("Unity.Profiling.LowLevel.Unsafe.ProfilerUnsafeUtility::BeginSampleWithMetadata");
		SingleSampleWithMetadataDelegateField = IL2CPP.ResolveICall<SingleSampleWithMetadataDelegate>("Unity.Profiling.LowLevel.Unsafe.ProfilerUnsafeUtility::SingleSampleWithMetadata");
		CreateCounterValue_UnsafeDelegateField = IL2CPP.ResolveICall<CreateCounterValue_UnsafeDelegate>("Unity.Profiling.LowLevel.Unsafe.ProfilerUnsafeUtility::CreateCounterValue_Unsafe");
		FlushCounterValueDelegateField = IL2CPP.ResolveICall<FlushCounterValueDelegate>("Unity.Profiling.LowLevel.Unsafe.ProfilerUnsafeUtility::FlushCounterValue");
		CreateFlowDelegateField = IL2CPP.ResolveICall<CreateFlowDelegate>("Unity.Profiling.LowLevel.Unsafe.ProfilerUnsafeUtility::CreateFlow");
		FlowEventDelegateField = IL2CPP.ResolveICall<FlowEventDelegate>("Unity.Profiling.LowLevel.Unsafe.ProfilerUnsafeUtility::FlowEvent");
		get_TimestampDelegateField = IL2CPP.ResolveICall<get_TimestampDelegate>("Unity.Profiling.LowLevel.Unsafe.ProfilerUnsafeUtility::get_Timestamp");
		CreateCategory_InjectedDelegateField = IL2CPP.ResolveICall<CreateCategory_InjectedDelegate>("Unity.Profiling.LowLevel.Unsafe.ProfilerUnsafeUtility::CreateCategory_Injected");
		GetCategoryColor_InjectedDelegateField = IL2CPP.ResolveICall<GetCategoryColor_InjectedDelegate>("Unity.Profiling.LowLevel.Unsafe.ProfilerUnsafeUtility::GetCategoryColor_Injected");
		GetMarker_InjectedDelegateField = IL2CPP.ResolveICall<GetMarker_InjectedDelegate>("Unity.Profiling.LowLevel.Unsafe.ProfilerUnsafeUtility::GetMarker_Injected");
		SetMarkerMetadata_InjectedDelegateField = IL2CPP.ResolveICall<SetMarkerMetadata_InjectedDelegate>("Unity.Profiling.LowLevel.Unsafe.ProfilerUnsafeUtility::SetMarkerMetadata_Injected");
		CreateCounterValue_InjectedDelegateField = IL2CPP.ResolveICall<CreateCounterValue_InjectedDelegate>("Unity.Profiling.LowLevel.Unsafe.ProfilerUnsafeUtility::CreateCounterValue_Injected");
		Internal_BeginWithObject_InjectedDelegateField = IL2CPP.ResolveICall<Internal_BeginWithObject_InjectedDelegate>("Unity.Profiling.LowLevel.Unsafe.ProfilerUnsafeUtility::Internal_BeginWithObject_Injected");
		Internal_GetName_InjectedDelegateField = IL2CPP.ResolveICall<Internal_GetName_InjectedDelegate>("Unity.Profiling.LowLevel.Unsafe.ProfilerUnsafeUtility::Internal_GetName_Injected");
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1164612, XrefRangeEnd = 1164614, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static ushort CreateCategory__Unmanaged(byte* name, int nameLen, ProfilerCategoryColor colorIndex)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)name;
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &nameLen;
		*(ProfilerCategoryColor**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &colorIndex;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CreateCategory__Unmanaged_Internal_Static_UInt16_ptr_Byte_Int32_ProfilerCategoryColor_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(ushort*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1164614, XrefRangeEnd = 1164616, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static ProfilerCategoryDescription GetCategoryDescription(ushort categoryId)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&categoryId);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetCategoryDescription_Public_Static_ProfilerCategoryDescription_UInt16_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(ProfilerCategoryDescription*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(34)]
	[CachedScanResults(RefRangeStart = 1164630, RefRangeEnd = 1164664, XrefRangeStart = 1164616, XrefRangeEnd = 1164630, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static System.IntPtr CreateMarker(string name, ushort categoryId, MarkerFlags flags, int metadataCount)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
		*(ushort**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &categoryId;
		*(MarkerFlags**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &flags;
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &metadataCount;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CreateMarker_Public_Static_IntPtr_String_UInt16_MarkerFlags_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(System.IntPtr*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1164664, XrefRangeEnd = 1164666, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static System.IntPtr CreateMarker__Unmanaged(byte* name, int nameLen, ushort categoryId, MarkerFlags flags, int metadataCount)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = (nint)name;
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &nameLen;
		*(ushort**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &categoryId;
		*(MarkerFlags**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &flags;
		*(int**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &metadataCount;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CreateMarker__Unmanaged_Internal_Static_IntPtr_ptr_Byte_Int32_UInt16_MarkerFlags_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(System.IntPtr*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1164666, XrefRangeEnd = 1164668, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SetMarkerMetadata__Unmanaged(System.IntPtr markerPtr, int index, byte* name, int nameLen, byte type, byte unit)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[6];
		*ptr = (nint)(&markerPtr);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &index;
		*(byte**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = name;
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &nameLen;
		*(byte**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &type;
		*(byte**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = &unit;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetMarkerMetadata__Unmanaged_Internal_Static_Void_IntPtr_Int32_ptr_Byte_Int32_Byte_Byte_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(45)]
	[CachedScanResults(RefRangeStart = 1164670, RefRangeEnd = 1164715, XrefRangeStart = 1164668, XrefRangeEnd = 1164670, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void BeginSample(System.IntPtr markerPtr)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&markerPtr);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_BeginSample_Public_Static_Void_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(118)]
	[CachedScanResults(RefRangeStart = 1164717, RefRangeEnd = 1164835, XrefRangeStart = 1164715, XrefRangeEnd = 1164717, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void EndSample(System.IntPtr markerPtr)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&markerPtr);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_EndSample_Public_Static_Void_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1164835, XrefRangeEnd = 1164837, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void* CreateCounterValue__Unmanaged(out System.IntPtr counterPtr, byte* name, int nameLen, ushort categoryId, MarkerFlags flags, byte dataType, byte dataUnit, int dataSize, ProfilerCounterOptions counterOptions)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[9];
		*ptr = (nint)System.Runtime.CompilerServices.Unsafe.AsPointer(ref counterPtr);
		*(byte**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = name;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &nameLen;
		*(ushort**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &categoryId;
		*(MarkerFlags**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &flags;
		*(byte**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = &dataType;
		*(byte**)((byte*)ptr + checked((nuint)6u * unchecked((nuint)sizeof(System.IntPtr)))) = &dataUnit;
		*(int**)((byte*)ptr + checked((nuint)7u * unchecked((nuint)sizeof(System.IntPtr)))) = &dataSize;
		*(ProfilerCounterOptions**)((byte*)ptr + checked((nuint)8u * unchecked((nuint)sizeof(System.IntPtr)))) = &counterOptions;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr result = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CreateCounterValue__Unmanaged_Internal_Static_ptr_Void_byref_IntPtr_ptr_Byte_Int32_UInt16_MarkerFlags_Byte_Byte_Int32_ProfilerCounterOptions_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (void*)result;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1164837, XrefRangeEnd = 1164846, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string Utf8ToString(byte* chars, int charsLen)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)chars;
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &charsLen;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Utf8ToString_Internal_Static_String_ptr_Byte_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return IL2CPP.Il2CppStringToManaged(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1164846, XrefRangeEnd = 1164848, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void GetCategoryDescription_Injected(ushort categoryId, out ProfilerCategoryDescription ret)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&categoryId);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = System.Runtime.CompilerServices.Unsafe.AsPointer(ref ret);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetCategoryDescription_Injected_Private_Static_Void_UInt16_byref_ProfilerCategoryDescription_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1164848, XrefRangeEnd = 1164850, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static System.IntPtr CreateMarker_Injected(ref ManagedSpanWrapper name, ushort categoryId, MarkerFlags flags, int metadataCount)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = (nint)System.Runtime.CompilerServices.Unsafe.AsPointer(ref name);
		*(ushort**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &categoryId;
		*(MarkerFlags**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &flags;
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &metadataCount;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CreateMarker_Injected_Private_Static_IntPtr_byref_ManagedSpanWrapper_UInt16_MarkerFlags_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(System.IntPtr*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	public ProfilerUnsafeUtility(System.IntPtr pointer)
		: base(pointer)
	{
	}

	public unsafe static ushort CreateCategory(string name, ProfilerCategoryColor colorIndex)
	{
		//IL_0018: Expected O, but got Ref
		//IL_0024: Expected O, but got Ref
		//The blocks IL_0029 are reachable both inside and outside the pinned region starting at IL_0018. ILSpy has duplicated these blocks in order to place them both within and outside the `fixed` statement.
		try
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out ManagedSpanWrapper managedSpanWrapper);
			if (!StringMarshaller.TryMarshalEmptyOrNullString(name, ref managedSpanWrapper))
			{
				Il2CppSystem.ReadOnlySpan<char> readOnlySpan = Il2CppSystem.MemoryExtensions.AsSpan(name);
				fixed (char* begin = &((Il2CppSystem.ReadOnlySpan<char>)(&readOnlySpan)).GetPinnableReference())
				{
					managedSpanWrapper = new ManagedSpanWrapper(begin, ((Il2CppSystem.ReadOnlySpan<char>)(&readOnlySpan)).Length);
					return CreateCategory_Injected(ref managedSpanWrapper, colorIndex);
				}
			}
			return CreateCategory_Injected(ref managedSpanWrapper, colorIndex);
		}
		finally
		{
		}
	}

	public unsafe static ushort CreateCategory(char* name, int nameLen, ProfilerCategoryColor colorIndex)
	{
		return CreateCategory_Unsafe(name, nameLen, colorIndex);
	}

	public unsafe static ushort CreateCategory_Unsafe(char* name, int nameLen, ProfilerCategoryColor colorIndex)
	{
		return CreateCategory_UnsafeDelegateField((nint)name, nameLen, colorIndex);
	}

	public unsafe static ushort GetCategoryByName(char* name, int nameLen)
	{
		return GetCategoryByName_Unsafe(name, nameLen);
	}

	public unsafe static ushort GetCategoryByName_Unsafe(char* name, int nameLen)
	{
		return GetCategoryByName_UnsafeDelegateField((nint)name, nameLen);
	}

	public static Color32 GetCategoryColor(ProfilerCategoryColor colorIndex)
	{
		GetCategoryColor_Injected(colorIndex, out var ret);
		return ret;
	}

	public unsafe static System.IntPtr CreateMarker(char* name, int nameLen, ushort categoryId, MarkerFlags flags, int metadataCount)
	{
		return CreateMarker_Unsafe(name, nameLen, categoryId, flags, metadataCount);
	}

	public unsafe static System.IntPtr CreateMarker_Unsafe(char* name, int nameLen, ushort categoryId, MarkerFlags flags, int metadataCount)
	{
		return CreateMarker_UnsafeDelegateField((nint)name, nameLen, categoryId, flags, metadataCount);
	}

	public unsafe static System.IntPtr GetMarker(string name)
	{
		//IL_0018: Expected O, but got Ref
		//IL_0024: Expected O, but got Ref
		//The blocks IL_0029 are reachable both inside and outside the pinned region starting at IL_0018. ILSpy has duplicated these blocks in order to place them both within and outside the `fixed` statement.
		try
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out ManagedSpanWrapper managedSpanWrapper);
			if (!StringMarshaller.TryMarshalEmptyOrNullString(name, ref managedSpanWrapper))
			{
				Il2CppSystem.ReadOnlySpan<char> readOnlySpan = Il2CppSystem.MemoryExtensions.AsSpan(name);
				fixed (char* begin = &((Il2CppSystem.ReadOnlySpan<char>)(&readOnlySpan)).GetPinnableReference())
				{
					managedSpanWrapper = new ManagedSpanWrapper(begin, ((Il2CppSystem.ReadOnlySpan<char>)(&readOnlySpan)).Length);
					return GetMarker_Injected(ref managedSpanWrapper);
				}
			}
			return GetMarker_Injected(ref managedSpanWrapper);
		}
		finally
		{
		}
	}

	public unsafe static void SetMarkerMetadata(System.IntPtr markerPtr, int index, string name, byte type, byte unit)
	{
		//IL_001a: Expected O, but got Ref
		//IL_0026: Expected O, but got Ref
		//The blocks IL_002b are reachable both inside and outside the pinned region starting at IL_001a. ILSpy has duplicated these blocks in order to place them both within and outside the `fixed` statement.
		try
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out ManagedSpanWrapper managedSpanWrapper);
			if (!StringMarshaller.TryMarshalEmptyOrNullString(name, ref managedSpanWrapper))
			{
				Il2CppSystem.ReadOnlySpan<char> readOnlySpan = Il2CppSystem.MemoryExtensions.AsSpan(name);
				fixed (char* begin = &((Il2CppSystem.ReadOnlySpan<char>)(&readOnlySpan)).GetPinnableReference())
				{
					managedSpanWrapper = new ManagedSpanWrapper(begin, ((Il2CppSystem.ReadOnlySpan<char>)(&readOnlySpan)).Length);
					SetMarkerMetadata_Injected(markerPtr, index, ref managedSpanWrapper, type, unit);
					return;
				}
			}
			SetMarkerMetadata_Injected(markerPtr, index, ref managedSpanWrapper, type, unit);
		}
		finally
		{
		}
	}

	public unsafe static void SetMarkerMetadata(System.IntPtr markerPtr, int index, char* name, int nameLen, byte type, byte unit)
	{
		SetMarkerMetadata_Unsafe(markerPtr, index, name, nameLen, type, unit);
	}

	public unsafe static void SetMarkerMetadata_Unsafe(System.IntPtr markerPtr, int index, char* name, int nameLen, byte type, byte unit)
	{
		SetMarkerMetadata_UnsafeDelegateField(markerPtr, index, (nint)name, nameLen, type, unit);
	}

	public unsafe static void BeginSampleWithMetadata(System.IntPtr markerPtr, int metadataCount, void* metadata)
	{
		BeginSampleWithMetadataDelegateField(markerPtr, metadataCount, (nint)metadata);
	}

	public unsafe static void SingleSampleWithMetadata(System.IntPtr markerPtr, int metadataCount, void* metadata)
	{
		SingleSampleWithMetadataDelegateField(markerPtr, metadataCount, (nint)metadata);
	}

	public unsafe static void* CreateCounterValue(out System.IntPtr counterPtr, string name, ushort categoryId, MarkerFlags flags, byte dataType, byte dataUnit, int dataSize, ProfilerCounterOptions counterOptions)
	{
		//IL_0019: Expected O, but got Ref
		//IL_0025: Expected O, but got Ref
		//The blocks IL_002a are reachable both inside and outside the pinned region starting at IL_0019. ILSpy has duplicated these blocks in order to place them both within and outside the `fixed` statement.
		try
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out ManagedSpanWrapper managedSpanWrapper);
			if (!StringMarshaller.TryMarshalEmptyOrNullString(name, ref managedSpanWrapper))
			{
				Il2CppSystem.ReadOnlySpan<char> readOnlySpan = Il2CppSystem.MemoryExtensions.AsSpan(name);
				fixed (char* begin = &((Il2CppSystem.ReadOnlySpan<char>)(&readOnlySpan)).GetPinnableReference())
				{
					managedSpanWrapper = new ManagedSpanWrapper(begin, ((Il2CppSystem.ReadOnlySpan<char>)(&readOnlySpan)).Length);
					return CreateCounterValue_Injected(out counterPtr, ref managedSpanWrapper, categoryId, flags, dataType, dataUnit, dataSize, counterOptions);
				}
			}
			return CreateCounterValue_Injected(out counterPtr, ref managedSpanWrapper, categoryId, flags, dataType, dataUnit, dataSize, counterOptions);
		}
		finally
		{
		}
	}

	public unsafe static void* CreateCounterValue(out System.IntPtr counterPtr, char* name, int nameLen, ushort categoryId, MarkerFlags flags, byte dataType, byte dataUnit, int dataSize, ProfilerCounterOptions counterOptions)
	{
		return CreateCounterValue_Unsafe(out counterPtr, name, nameLen, categoryId, flags, dataType, dataUnit, dataSize, counterOptions);
	}

	public unsafe static void* CreateCounterValue_Unsafe(out System.IntPtr counterPtr, char* name, int nameLen, ushort categoryId, MarkerFlags flags, byte dataType, byte dataUnit, int dataSize, ProfilerCounterOptions counterOptions)
	{
		return (void*)CreateCounterValue_UnsafeDelegateField((nint)System.Runtime.CompilerServices.Unsafe.AsPointer(ref counterPtr), (nint)name, nameLen, categoryId, flags, dataType, dataUnit, dataSize, counterOptions);
	}

	public unsafe static void FlushCounterValue(void* counterValuePtr)
	{
		FlushCounterValueDelegateField((nint)counterValuePtr);
	}

	public static uint CreateFlow(ushort categoryId)
	{
		return CreateFlowDelegateField(categoryId);
	}

	public static void FlowEvent(uint flowId, ProfilerFlowEventType flowEventType)
	{
		FlowEventDelegateField(flowId, flowEventType);
	}

	public static void Internal_BeginWithObject(System.IntPtr markerPtr, UnityEngine.Object contextUnityObject)
	{
		Internal_BeginWithObject_Injected(markerPtr, UnityEngine.Object.MarshalledUnityObject.Marshal(contextUnityObject));
	}

	public static string Internal_GetName(System.IntPtr markerPtr)
	{
		System.Runtime.CompilerServices.Unsafe.SkipInit(out ManagedSpanWrapper ret);
		string stringAndDispose;
		try
		{
			Internal_GetName_Injected(markerPtr, out ret);
		}
		finally
		{
			stringAndDispose = OutStringMarshaller.GetStringAndDispose(ret);
		}
		return stringAndDispose;
	}

	public unsafe static ushort CreateCategory_Injected(ref ManagedSpanWrapper name, ProfilerCategoryColor colorIndex)
	{
		return CreateCategory_InjectedDelegateField((nint)System.Runtime.CompilerServices.Unsafe.AsPointer(ref name), colorIndex);
	}

	public unsafe static void GetCategoryColor_Injected(ProfilerCategoryColor colorIndex, out Color32 ret)
	{
		GetCategoryColor_InjectedDelegateField(colorIndex, (nint)System.Runtime.CompilerServices.Unsafe.AsPointer(ref ret));
	}

	public unsafe static System.IntPtr GetMarker_Injected(ref ManagedSpanWrapper name)
	{
		return GetMarker_InjectedDelegateField((nint)System.Runtime.CompilerServices.Unsafe.AsPointer(ref name));
	}

	public unsafe static void SetMarkerMetadata_Injected(System.IntPtr markerPtr, int index, ref ManagedSpanWrapper name, byte type, byte unit)
	{
		SetMarkerMetadata_InjectedDelegateField(markerPtr, index, (nint)System.Runtime.CompilerServices.Unsafe.AsPointer(ref name), type, unit);
	}

	public unsafe static void* CreateCounterValue_Injected(out System.IntPtr counterPtr, ref ManagedSpanWrapper name, ushort categoryId, MarkerFlags flags, byte dataType, byte dataUnit, int dataSize, ProfilerCounterOptions counterOptions)
	{
		return (void*)CreateCounterValue_InjectedDelegateField((nint)System.Runtime.CompilerServices.Unsafe.AsPointer(ref counterPtr), (nint)System.Runtime.CompilerServices.Unsafe.AsPointer(ref name), categoryId, flags, dataType, dataUnit, dataSize, counterOptions);
	}

	public static void Internal_BeginWithObject_Injected(System.IntPtr markerPtr, System.IntPtr contextUnityObject)
	{
		Internal_BeginWithObject_InjectedDelegateField(markerPtr, contextUnityObject);
	}

	public unsafe static void Internal_GetName_Injected(System.IntPtr markerPtr, out ManagedSpanWrapper ret)
	{
		Internal_GetName_InjectedDelegateField(markerPtr, (nint)System.Runtime.CompilerServices.Unsafe.AsPointer(ref ret));
	}
}
