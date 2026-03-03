using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Runtime.CompilerServices;
using Unity.Profiling.LowLevel;
using Unity.Profiling.LowLevel.Unsafe;
using UnityEngine.Bindings;

namespace Unity.Profiling;

[StructLayout(LayoutKind.Explicit)]
public struct ProfilerRecorder
{
	[OriginalName("UnityEngine.CoreModule.dll", "", "ControlOptions")]
	public enum ControlOptions
	{
		Start = 0,
		Stop = 1,
		Reset = 2,
		Release = 4,
		SetFilterToCurrentThread = 5,
		SetToCollectFromAllThreads = 6
	}

	[OriginalName("UnityEngine.CoreModule.dll", "", "CountOptions")]
	public enum CountOptions
	{
		Count,
		MaxCount
	}

	private delegate ProfilerMarkerDataUnit GetValueUnitType_InjectedDelegate([In] System.IntPtr handle);

	private delegate ProfilerMarkerDataType GetValueDataType_InjectedDelegate([In] System.IntPtr handle);

	private delegate long GetCurrentValue_InjectedDelegate([In] System.IntPtr handle);

	private delegate double GetCurrentValueAsDouble_InjectedDelegate([In] System.IntPtr handle);

	private delegate double GetLastValueAsDouble_InjectedDelegate([In] System.IntPtr handle);

	private delegate bool GetWrapped_InjectedDelegate([In] System.IntPtr handle);

	private delegate void CopyTo_List_InjectedDelegate([In] System.IntPtr handle, System.IntPtr outSamples, bool reset);

	private delegate int CopyTo_Pointer_InjectedDelegate([In] System.IntPtr handle, System.IntPtr outSamples, int outSamplesSize, bool reset);

	private static readonly System.IntPtr NativeFieldInfoPtr_handle;

	private static readonly System.IntPtr NativeFieldInfoPtr_SharedRecorder;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_ProfilerRecorderHandle_Int32_ProfilerRecorderOptions_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_Valid_Public_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Start_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Stop_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_LastValue_Public_get_Int64_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_Count_Public_get_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_IsRunning_Public_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetSample_Public_ProfilerRecorderSample_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Create_Private_Static_ProfilerRecorder_ProfilerRecorderHandle_Int32_ProfilerRecorderOptions_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Control_Private_Static_Void_ProfilerRecorder_ControlOptions_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetLastValue_Private_Static_Int64_ProfilerRecorder_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetCount_Private_Static_Int32_ProfilerRecorder_CountOptions_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetValid_Private_Static_Boolean_ProfilerRecorder_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetRunning_Private_Static_Boolean_ProfilerRecorder_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetSampleInternal_Private_Static_ProfilerRecorderSample_ProfilerRecorder_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CheckInitializedAndThrow_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Create_Injected_Private_Static_Void_byref_ProfilerRecorderHandle_Int32_ProfilerRecorderOptions_byref_ProfilerRecorder_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Control_Injected_Private_Static_Void_byref_ProfilerRecorder_ControlOptions_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetLastValue_Injected_Private_Static_Int64_byref_ProfilerRecorder_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetCount_Injected_Private_Static_Int32_byref_ProfilerRecorder_CountOptions_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetValid_Injected_Private_Static_Boolean_byref_ProfilerRecorder_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetRunning_Injected_Private_Static_Boolean_byref_ProfilerRecorder_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetSampleInternal_Injected_Private_Static_Void_byref_ProfilerRecorder_Int32_byref_ProfilerRecorderSample_0;

	[FieldOffset(0)]
	public ulong handle;

	private static readonly GetValueUnitType_InjectedDelegate GetValueUnitType_InjectedDelegateField;

	private static readonly GetValueDataType_InjectedDelegate GetValueDataType_InjectedDelegateField;

	private static readonly GetCurrentValue_InjectedDelegate GetCurrentValue_InjectedDelegateField;

	private static readonly GetCurrentValueAsDouble_InjectedDelegate GetCurrentValueAsDouble_InjectedDelegateField;

	private static readonly GetLastValueAsDouble_InjectedDelegate GetLastValueAsDouble_InjectedDelegateField;

	private static readonly GetWrapped_InjectedDelegate GetWrapped_InjectedDelegateField;

	private static readonly CopyTo_List_InjectedDelegate CopyTo_List_InjectedDelegateField;

	private static readonly CopyTo_Pointer_InjectedDelegate CopyTo_Pointer_InjectedDelegateField;

	public unsafe static ProfilerRecorderOptions SharedRecorder
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out ProfilerRecorderOptions result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_SharedRecorder, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_SharedRecorder, (void*)(&value));
		}
	}

	public unsafe bool Valid
	{
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 1164531, RefRangeEnd = 1164539, XrefRangeStart = 1164531, XrefRangeEnd = 1164531, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_Valid_Public_get_Boolean_0, (System.IntPtr)(nint)System.Runtime.CompilerServices.Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe long LastValue
	{
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1164553, RefRangeEnd = 1164555, XrefRangeStart = 1164551, XrefRangeEnd = 1164553, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_LastValue_Public_get_Int64_0, (System.IntPtr)(nint)System.Runtime.CompilerServices.Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(long*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe int Count
	{
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1164557, RefRangeEnd = 1164559, XrefRangeStart = 1164555, XrefRangeEnd = 1164557, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_Count_Public_get_Int32_0, (System.IntPtr)(nint)System.Runtime.CompilerServices.Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe bool IsRunning
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1164561, RefRangeEnd = 1164562, XrefRangeStart = 1164559, XrefRangeEnd = 1164561, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_IsRunning_Public_get_Boolean_0, (System.IntPtr)(nint)System.Runtime.CompilerServices.Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public ProfilerMarkerDataType DataType
	{
		get
		{
			CheckInitializedAndThrow();
			return GetValueDataType(this);
		}
	}

	public ProfilerMarkerDataUnit UnitType
	{
		get
		{
			CheckInitializedAndThrow();
			return GetValueUnitType(this);
		}
	}

	public long CurrentValue
	{
		get
		{
			CheckInitializedAndThrow();
			return GetCurrentValue(this);
		}
	}

	public double CurrentValueAsDouble
	{
		get
		{
			CheckInitializedAndThrow();
			return GetCurrentValueAsDouble(this);
		}
	}

	public double LastValueAsDouble
	{
		get
		{
			CheckInitializedAndThrow();
			return GetLastValueAsDouble(this);
		}
	}

	public int Capacity
	{
		get
		{
			CheckInitializedAndThrow();
			return GetCount(this, CountOptions.MaxCount);
		}
	}

	public bool WrappedAround
	{
		get
		{
			CheckInitializedAndThrow();
			return GetWrapped(this);
		}
	}

	static ProfilerRecorder()
	{
		Il2CppClassPointerStore<ProfilerRecorder>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "Unity.Profiling", "ProfilerRecorder");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ProfilerRecorder>.NativeClassPtr);
		NativeFieldInfoPtr_handle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfilerRecorder>.NativeClassPtr, "handle");
		NativeFieldInfoPtr_SharedRecorder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfilerRecorder>.NativeClassPtr, "SharedRecorder");
		NativeMethodInfoPtr__ctor_Public_Void_ProfilerRecorderHandle_Int32_ProfilerRecorderOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfilerRecorder>.NativeClassPtr, 100663415);
		NativeMethodInfoPtr_get_Valid_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfilerRecorder>.NativeClassPtr, 100663416);
		NativeMethodInfoPtr_Start_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfilerRecorder>.NativeClassPtr, 100663417);
		NativeMethodInfoPtr_Stop_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfilerRecorder>.NativeClassPtr, 100663418);
		NativeMethodInfoPtr_get_LastValue_Public_get_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfilerRecorder>.NativeClassPtr, 100663419);
		NativeMethodInfoPtr_get_Count_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfilerRecorder>.NativeClassPtr, 100663420);
		NativeMethodInfoPtr_get_IsRunning_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfilerRecorder>.NativeClassPtr, 100663421);
		NativeMethodInfoPtr_GetSample_Public_ProfilerRecorderSample_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfilerRecorder>.NativeClassPtr, 100663422);
		NativeMethodInfoPtr_Create_Private_Static_ProfilerRecorder_ProfilerRecorderHandle_Int32_ProfilerRecorderOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfilerRecorder>.NativeClassPtr, 100663423);
		NativeMethodInfoPtr_Control_Private_Static_Void_ProfilerRecorder_ControlOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfilerRecorder>.NativeClassPtr, 100663424);
		NativeMethodInfoPtr_GetLastValue_Private_Static_Int64_ProfilerRecorder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfilerRecorder>.NativeClassPtr, 100663425);
		NativeMethodInfoPtr_GetCount_Private_Static_Int32_ProfilerRecorder_CountOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfilerRecorder>.NativeClassPtr, 100663426);
		NativeMethodInfoPtr_GetValid_Private_Static_Boolean_ProfilerRecorder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfilerRecorder>.NativeClassPtr, 100663427);
		NativeMethodInfoPtr_GetRunning_Private_Static_Boolean_ProfilerRecorder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfilerRecorder>.NativeClassPtr, 100663428);
		NativeMethodInfoPtr_GetSampleInternal_Private_Static_ProfilerRecorderSample_ProfilerRecorder_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfilerRecorder>.NativeClassPtr, 100663429);
		NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfilerRecorder>.NativeClassPtr, 100663430);
		NativeMethodInfoPtr_CheckInitializedAndThrow_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfilerRecorder>.NativeClassPtr, 100663431);
		NativeMethodInfoPtr_Create_Injected_Private_Static_Void_byref_ProfilerRecorderHandle_Int32_ProfilerRecorderOptions_byref_ProfilerRecorder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfilerRecorder>.NativeClassPtr, 100663432);
		NativeMethodInfoPtr_Control_Injected_Private_Static_Void_byref_ProfilerRecorder_ControlOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfilerRecorder>.NativeClassPtr, 100663433);
		NativeMethodInfoPtr_GetLastValue_Injected_Private_Static_Int64_byref_ProfilerRecorder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfilerRecorder>.NativeClassPtr, 100663434);
		NativeMethodInfoPtr_GetCount_Injected_Private_Static_Int32_byref_ProfilerRecorder_CountOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfilerRecorder>.NativeClassPtr, 100663435);
		NativeMethodInfoPtr_GetValid_Injected_Private_Static_Boolean_byref_ProfilerRecorder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfilerRecorder>.NativeClassPtr, 100663436);
		NativeMethodInfoPtr_GetRunning_Injected_Private_Static_Boolean_byref_ProfilerRecorder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfilerRecorder>.NativeClassPtr, 100663437);
		NativeMethodInfoPtr_GetSampleInternal_Injected_Private_Static_Void_byref_ProfilerRecorder_Int32_byref_ProfilerRecorderSample_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfilerRecorder>.NativeClassPtr, 100663438);
		GetValueUnitType_InjectedDelegateField = IL2CPP.ResolveICall<GetValueUnitType_InjectedDelegate>("Unity.Profiling.ProfilerRecorder::GetValueUnitType_Injected");
		GetValueDataType_InjectedDelegateField = IL2CPP.ResolveICall<GetValueDataType_InjectedDelegate>("Unity.Profiling.ProfilerRecorder::GetValueDataType_Injected");
		GetCurrentValue_InjectedDelegateField = IL2CPP.ResolveICall<GetCurrentValue_InjectedDelegate>("Unity.Profiling.ProfilerRecorder::GetCurrentValue_Injected");
		GetCurrentValueAsDouble_InjectedDelegateField = IL2CPP.ResolveICall<GetCurrentValueAsDouble_InjectedDelegate>("Unity.Profiling.ProfilerRecorder::GetCurrentValueAsDouble_Injected");
		GetLastValueAsDouble_InjectedDelegateField = IL2CPP.ResolveICall<GetLastValueAsDouble_InjectedDelegate>("Unity.Profiling.ProfilerRecorder::GetLastValueAsDouble_Injected");
		GetWrapped_InjectedDelegateField = IL2CPP.ResolveICall<GetWrapped_InjectedDelegate>("Unity.Profiling.ProfilerRecorder::GetWrapped_Injected");
		CopyTo_List_InjectedDelegateField = IL2CPP.ResolveICall<CopyTo_List_InjectedDelegate>("Unity.Profiling.ProfilerRecorder::CopyTo_List_Injected");
		CopyTo_Pointer_InjectedDelegateField = IL2CPP.ResolveICall<CopyTo_Pointer_InjectedDelegate>("Unity.Profiling.ProfilerRecorder::CopyTo_Pointer_Injected");
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 1164527, RefRangeEnd = 1164531, XrefRangeStart = 1164525, XrefRangeEnd = 1164527, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ProfilerRecorder(ProfilerRecorderHandle statHandle, int capacity = 1, ProfilerRecorderOptions options = ProfilerRecorderOptions.Default)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&statHandle);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &capacity;
		*(ProfilerRecorderOptions**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &options;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_ProfilerRecorderHandle_Int32_ProfilerRecorderOptions_0, (System.IntPtr)(nint)System.Runtime.CompilerServices.Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 1164541, RefRangeEnd = 1164545, XrefRangeStart = 1164539, XrefRangeEnd = 1164541, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Start()
	{
		System.IntPtr* ptr = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Start_Public_Void_0, (System.IntPtr)(nint)System.Runtime.CompilerServices.Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 1164547, RefRangeEnd = 1164551, XrefRangeStart = 1164545, XrefRangeEnd = 1164547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Stop()
	{
		System.IntPtr* ptr = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Stop_Public_Void_0, (System.IntPtr)(nint)System.Runtime.CompilerServices.Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1164564, RefRangeEnd = 1164566, XrefRangeStart = 1164562, XrefRangeEnd = 1164564, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ProfilerRecorderSample GetSample(int index)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&index);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetSample_Public_ProfilerRecorderSample_Int32_0, (System.IntPtr)(nint)System.Runtime.CompilerServices.Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(ProfilerRecorderSample*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1164566, XrefRangeEnd = 1164568, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static ProfilerRecorder Create(ProfilerRecorderHandle statHandle, int maxSampleCount, ProfilerRecorderOptions options)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&statHandle);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &maxSampleCount;
		*(ProfilerRecorderOptions**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &options;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Create_Private_Static_ProfilerRecorder_ProfilerRecorderHandle_Int32_ProfilerRecorderOptions_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(ProfilerRecorder*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1164568, XrefRangeEnd = 1164570, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void Control(ProfilerRecorder handle, ControlOptions options)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&handle);
		*(ControlOptions**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &options;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Control_Private_Static_Void_ProfilerRecorder_ControlOptions_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1164570, XrefRangeEnd = 1164572, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static long GetLastValue(ProfilerRecorder handle)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&handle);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetLastValue_Private_Static_Int64_ProfilerRecorder_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(long*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1164572, XrefRangeEnd = 1164574, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int GetCount(ProfilerRecorder handle, CountOptions countOptions)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&handle);
		*(CountOptions**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &countOptions;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetCount_Private_Static_Int32_ProfilerRecorder_CountOptions_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1164574, XrefRangeEnd = 1164576, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool GetValid(ProfilerRecorder handle)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&handle);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetValid_Private_Static_Boolean_ProfilerRecorder_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1164576, XrefRangeEnd = 1164578, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool GetRunning(ProfilerRecorder handle)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&handle);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetRunning_Private_Static_Boolean_ProfilerRecorder_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1164578, XrefRangeEnd = 1164580, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static ProfilerRecorderSample GetSampleInternal(ProfilerRecorder handle, int index)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&handle);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &index;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetSampleInternal_Private_Static_ProfilerRecorderSample_ProfilerRecorder_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(ProfilerRecorderSample*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1164582, RefRangeEnd = 1164584, XrefRangeStart = 1164580, XrefRangeEnd = 1164582, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void Dispose()
	{
		System.IntPtr* ptr = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, (System.IntPtr)(nint)System.Runtime.CompilerServices.Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	public unsafe void CheckInitializedAndThrow()
	{
		System.IntPtr* ptr = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CheckInitializedAndThrow_Private_Void_0, (System.IntPtr)(nint)System.Runtime.CompilerServices.Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1164584, XrefRangeEnd = 1164586, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void Create_Injected([In] ref ProfilerRecorderHandle statHandle, int maxSampleCount, ProfilerRecorderOptions options, out ProfilerRecorder ret)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = (nint)System.Runtime.CompilerServices.Unsafe.AsPointer(ref statHandle);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &maxSampleCount;
		*(ProfilerRecorderOptions**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &options;
		*(void**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = System.Runtime.CompilerServices.Unsafe.AsPointer(ref ret);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Create_Injected_Private_Static_Void_byref_ProfilerRecorderHandle_Int32_ProfilerRecorderOptions_byref_ProfilerRecorder_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1164586, XrefRangeEnd = 1164588, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void Control_Injected([In] ref ProfilerRecorder handle, ControlOptions options)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)System.Runtime.CompilerServices.Unsafe.AsPointer(ref handle);
		*(ControlOptions**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &options;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Control_Injected_Private_Static_Void_byref_ProfilerRecorder_ControlOptions_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1164588, XrefRangeEnd = 1164590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static long GetLastValue_Injected([In] ref ProfilerRecorder handle)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)System.Runtime.CompilerServices.Unsafe.AsPointer(ref handle);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetLastValue_Injected_Private_Static_Int64_byref_ProfilerRecorder_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(long*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1164590, XrefRangeEnd = 1164592, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int GetCount_Injected([In] ref ProfilerRecorder handle, CountOptions countOptions)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)System.Runtime.CompilerServices.Unsafe.AsPointer(ref handle);
		*(CountOptions**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &countOptions;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetCount_Injected_Private_Static_Int32_byref_ProfilerRecorder_CountOptions_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1164592, XrefRangeEnd = 1164594, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool GetValid_Injected([In] ref ProfilerRecorder handle)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)System.Runtime.CompilerServices.Unsafe.AsPointer(ref handle);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetValid_Injected_Private_Static_Boolean_byref_ProfilerRecorder_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1164594, XrefRangeEnd = 1164596, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool GetRunning_Injected([In] ref ProfilerRecorder handle)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)System.Runtime.CompilerServices.Unsafe.AsPointer(ref handle);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetRunning_Injected_Private_Static_Boolean_byref_ProfilerRecorder_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1164596, XrefRangeEnd = 1164598, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void GetSampleInternal_Injected([In] ref ProfilerRecorder handle, int index, out ProfilerRecorderSample ret)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)System.Runtime.CompilerServices.Unsafe.AsPointer(ref handle);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &index;
		*(void**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = System.Runtime.CompilerServices.Unsafe.AsPointer(ref ret);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetSampleInternal_Injected_Private_Static_Void_byref_ProfilerRecorder_Int32_byref_ProfilerRecorderSample_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public unsafe Il2CppSystem.Object BoxIl2CppObject()
	{
		return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ProfilerRecorder>.NativeClassPtr, (System.IntPtr)(nint)System.Runtime.CompilerServices.Unsafe.AsPointer(ref this)));
	}

	public unsafe static ProfilerRecorder StartNew(ProfilerCategory category, string statName, [Optional] int capacity, [Optional] ProfilerRecorderOptions options)
	{
		fixed (string text = statName)
		{
			char* ptr = (char*)(nuint)text;
			if (ptr != null)
			{
				ptr = (char*)((byte*)ptr + Il2CppSystem.Runtime.CompilerServices.RuntimeHelpers.OffsetToStringData);
			}
			return new ProfilerRecorder(category, ptr, statName.Length, capacity, options | ProfilerRecorderOptions.StartImmediately);
		}
	}

	public static ProfilerRecorder StartNew(ProfilerMarker marker, [Optional] int capacity, [Optional] ProfilerRecorderOptions options)
	{
		return new ProfilerRecorder(marker, capacity, options | ProfilerRecorderOptions.StartImmediately);
	}

	public static ProfilerRecorder StartNew()
	{
		return Create(default(ProfilerRecorderHandle), 0, ProfilerRecorderOptions.StartImmediately);
	}

	public void Reset()
	{
		CheckInitializedAndThrow();
		Control(this, ControlOptions.Reset);
	}

	public void CopyTo(List<ProfilerRecorderSample> outSamples, [Optional] bool reset)
	{
		if (outSamples == null)
		{
			throw new Il2CppSystem.ArgumentNullException("outSamples");
		}
		CheckInitializedAndThrow();
		CopyTo_List(this, outSamples, reset);
	}

	public unsafe int CopyTo(ProfilerRecorderSample* dest, int destSize, [Optional] bool reset)
	{
		CheckInitializedWithParamsAndThrow(dest);
		return CopyTo_Pointer(this, dest, destSize, reset);
	}

	public Il2CppStructArray<ProfilerRecorderSample> ToArray()
	{
		throw new System.NotSupportedException("Method unstripping failed");
	}

	public void FilterToCurrentThread()
	{
		CheckInitializedAndThrow();
		Control(this, ControlOptions.SetFilterToCurrentThread);
	}

	public void CollectFromAllThreads()
	{
		CheckInitializedAndThrow();
		Control(this, ControlOptions.SetToCollectFromAllThreads);
	}

	public static ProfilerMarkerDataUnit GetValueUnitType(ProfilerRecorder handle)
	{
		return GetValueUnitType_Injected(ref handle);
	}

	public static ProfilerMarkerDataType GetValueDataType(ProfilerRecorder handle)
	{
		return GetValueDataType_Injected(ref handle);
	}

	public static long GetCurrentValue(ProfilerRecorder handle)
	{
		return GetCurrentValue_Injected(ref handle);
	}

	public static double GetCurrentValueAsDouble(ProfilerRecorder handle)
	{
		return GetCurrentValueAsDouble_Injected(ref handle);
	}

	public static double GetLastValueAsDouble(ProfilerRecorder handle)
	{
		return GetLastValueAsDouble_Injected(ref handle);
	}

	public static bool GetWrapped(ProfilerRecorder handle)
	{
		return GetWrapped_Injected(ref handle);
	}

	public static void CopyTo_List(ProfilerRecorder handle, List<ProfilerRecorderSample> outSamples, bool reset)
	{
		throw new System.NotSupportedException("Method unstripping failed");
	}

	public unsafe static int CopyTo_Pointer(ProfilerRecorder handle, ProfilerRecorderSample* outSamples, int outSamplesSize, bool reset)
	{
		return CopyTo_Pointer_Injected(ref handle, outSamples, outSamplesSize, reset);
	}

	public unsafe void CheckInitializedWithParamsAndThrow(ProfilerRecorderSample* dest)
	{
		if (handle == 0)
		{
			throw new Il2CppSystem.InvalidOperationException("ProfilerRecorder object is not initialized or has been disposed.");
		}
		if (dest == null)
		{
			throw new Il2CppSystem.ArgumentNullException("dest");
		}
	}

	public unsafe static ProfilerMarkerDataUnit GetValueUnitType_Injected([In] ref ProfilerRecorder handle)
	{
		return GetValueUnitType_InjectedDelegateField((nint)System.Runtime.CompilerServices.Unsafe.AsPointer(ref handle));
	}

	public unsafe static ProfilerMarkerDataType GetValueDataType_Injected([In] ref ProfilerRecorder handle)
	{
		return GetValueDataType_InjectedDelegateField((nint)System.Runtime.CompilerServices.Unsafe.AsPointer(ref handle));
	}

	public unsafe static long GetCurrentValue_Injected([In] ref ProfilerRecorder handle)
	{
		return GetCurrentValue_InjectedDelegateField((nint)System.Runtime.CompilerServices.Unsafe.AsPointer(ref handle));
	}

	public unsafe static double GetCurrentValueAsDouble_Injected([In] ref ProfilerRecorder handle)
	{
		return GetCurrentValueAsDouble_InjectedDelegateField((nint)System.Runtime.CompilerServices.Unsafe.AsPointer(ref handle));
	}

	public unsafe static double GetLastValueAsDouble_Injected([In] ref ProfilerRecorder handle)
	{
		return GetLastValueAsDouble_InjectedDelegateField((nint)System.Runtime.CompilerServices.Unsafe.AsPointer(ref handle));
	}

	public unsafe static bool GetWrapped_Injected([In] ref ProfilerRecorder handle)
	{
		return GetWrapped_InjectedDelegateField((nint)System.Runtime.CompilerServices.Unsafe.AsPointer(ref handle));
	}

	public unsafe static void CopyTo_List_Injected([In] ref ProfilerRecorder handle, ref BlittableListWrapper outSamples, bool reset)
	{
		CopyTo_List_InjectedDelegateField((nint)System.Runtime.CompilerServices.Unsafe.AsPointer(ref handle), (nint)System.Runtime.CompilerServices.Unsafe.AsPointer(ref outSamples), reset);
	}

	public unsafe static int CopyTo_Pointer_Injected([In] ref ProfilerRecorder handle, ProfilerRecorderSample* outSamples, int outSamplesSize, bool reset)
	{
		return CopyTo_Pointer_InjectedDelegateField((nint)System.Runtime.CompilerServices.Unsafe.AsPointer(ref handle), (nint)outSamples, outSamplesSize, reset);
	}
}
