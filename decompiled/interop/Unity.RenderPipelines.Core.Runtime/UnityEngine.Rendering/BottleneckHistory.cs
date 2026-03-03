using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace UnityEngine.Rendering;

public class BottleneckHistory : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_m_Bottlenecks;

	private static readonly System.IntPtr NativeFieldInfoPtr_Histogram;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DiscardOldSamples_Internal_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AddBottleneckFromAveragedSample_Internal_Void_FrameTimeSample_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ComputeHistogram_Internal_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DetermineBottleneck_Private_Static_PerformanceBottleneck_FrameTimeSample_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Clear_Internal_Void_0;

	public unsafe List<PerformanceBottleneck> m_Bottlenecks
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Bottlenecks);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<PerformanceBottleneck>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Bottlenecks)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe BottleneckHistogram Histogram
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Histogram);
			return *(BottleneckHistogram*)num;
		}
		set
		{
			*(BottleneckHistogram*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Histogram)) = value;
		}
	}

	static BottleneckHistory()
	{
		Il2CppClassPointerStore<BottleneckHistory>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Core.Runtime.dll", "UnityEngine.Rendering", "BottleneckHistory");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BottleneckHistory>.NativeClassPtr);
		NativeFieldInfoPtr_m_Bottlenecks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BottleneckHistory>.NativeClassPtr, "m_Bottlenecks");
		NativeFieldInfoPtr_Histogram = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BottleneckHistory>.NativeClassPtr, "Histogram");
		NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BottleneckHistory>.NativeClassPtr, 100665030);
		NativeMethodInfoPtr_DiscardOldSamples_Internal_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BottleneckHistory>.NativeClassPtr, 100665031);
		NativeMethodInfoPtr_AddBottleneckFromAveragedSample_Internal_Void_FrameTimeSample_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BottleneckHistory>.NativeClassPtr, 100665032);
		NativeMethodInfoPtr_ComputeHistogram_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BottleneckHistory>.NativeClassPtr, 100665033);
		NativeMethodInfoPtr_DetermineBottleneck_Private_Static_PerformanceBottleneck_FrameTimeSample_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BottleneckHistory>.NativeClassPtr, 100665034);
		NativeMethodInfoPtr_Clear_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BottleneckHistory>.NativeClassPtr, 100665035);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1035481, XrefRangeEnd = 1035493, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe BottleneckHistory(int initialCapacity)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BottleneckHistory>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&initialCapacity);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1035493, XrefRangeEnd = 1035502, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void DiscardOldSamples(int historySize)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&historySize);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DiscardOldSamples_Internal_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1035502, XrefRangeEnd = 1035508, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void AddBottleneckFromAveragedSample(FrameTimeSample frameHistorySampleAverage)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&frameHistorySampleAverage);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AddBottleneckFromAveragedSample_Internal_Void_FrameTimeSample_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1035508, XrefRangeEnd = 1035516, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ComputeHistogram()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ComputeHistogram_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	public unsafe static PerformanceBottleneck DetermineBottleneck(FrameTimeSample s)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&s);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DetermineBottleneck_Private_Static_PerformanceBottleneck_FrameTimeSample_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(PerformanceBottleneck*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1035516, XrefRangeEnd = 1035517, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Clear()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Clear_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public BottleneckHistory(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
