using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.InputSystem.LowLevel;

[System.Serializable]
[StructLayout(LayoutKind.Explicit)]
public struct InputMetrics
{
	private static readonly System.IntPtr NativeFieldInfoPtr__maxNumDevices_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__currentNumDevices_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__maxStateSizeInBytes_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__currentStateSizeInBytes_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__currentControlCount_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__currentLayoutCount_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__totalEventBytes_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__totalEventCount_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__totalUpdateCount_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__totalEventProcessingTime_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__totalEventLagTime_k__BackingField;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_maxNumDevices_Public_get_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_maxNumDevices_Public_set_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_currentNumDevices_Public_get_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_currentNumDevices_Public_set_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_maxStateSizeInBytes_Public_get_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_maxStateSizeInBytes_Public_set_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_currentStateSizeInBytes_Public_get_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_currentStateSizeInBytes_Public_set_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_currentControlCount_Public_get_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_currentControlCount_Public_set_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_currentLayoutCount_Public_get_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_currentLayoutCount_Public_set_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_totalEventBytes_Public_get_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_totalEventBytes_Public_set_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_totalEventCount_Public_get_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_totalEventCount_Public_set_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_totalUpdateCount_Public_get_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_totalUpdateCount_Public_set_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_totalEventProcessingTime_Public_get_Double_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_totalEventProcessingTime_Public_set_Void_Double_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_totalEventLagTime_Public_get_Double_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_totalEventLagTime_Public_set_Void_Double_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_averageEventBytesPerFrame_Public_get_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_averageProcessingTimePerEvent_Public_get_Double_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_averageLagTimePerEvent_Public_get_Double_0;

	[FieldOffset(0)]
	public int _maxNumDevices_k__BackingField;

	[FieldOffset(4)]
	public int _currentNumDevices_k__BackingField;

	[FieldOffset(8)]
	public int _maxStateSizeInBytes_k__BackingField;

	[FieldOffset(12)]
	public int _currentStateSizeInBytes_k__BackingField;

	[FieldOffset(16)]
	public int _currentControlCount_k__BackingField;

	[FieldOffset(20)]
	public int _currentLayoutCount_k__BackingField;

	[FieldOffset(24)]
	public int _totalEventBytes_k__BackingField;

	[FieldOffset(28)]
	public int _totalEventCount_k__BackingField;

	[FieldOffset(32)]
	public int _totalUpdateCount_k__BackingField;

	[FieldOffset(40)]
	public double _totalEventProcessingTime_k__BackingField;

	[FieldOffset(48)]
	public double _totalEventLagTime_k__BackingField;

	public unsafe int maxNumDevices
	{
		[CallerCount(175)]
		[CachedScanResults(RefRangeStart = 52464, RefRangeEnd = 52639, XrefRangeStart = 52464, XrefRangeEnd = 52639, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_maxNumDevices_Public_get_Int32_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 53703, RefRangeEnd = 53715, XrefRangeStart = 53703, XrefRangeEnd = 53715, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_maxNumDevices_Public_set_Void_Int32_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe int currentNumDevices
	{
		[CallerCount(0)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_currentNumDevices_Public_get_Int32_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 376349, RefRangeEnd = 376359, XrefRangeStart = 376349, XrefRangeEnd = 376359, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_currentNumDevices_Public_set_Void_Int32_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe int maxStateSizeInBytes
	{
		[CallerCount(24)]
		[CachedScanResults(RefRangeStart = 719678, RefRangeEnd = 719702, XrefRangeStart = 719678, XrefRangeEnd = 719702, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_maxStateSizeInBytes_Public_get_Int32_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 765810, RefRangeEnd = 765814, XrefRangeStart = 765810, XrefRangeEnd = 765814, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_maxStateSizeInBytes_Public_set_Void_Int32_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe int currentStateSizeInBytes
	{
		[CallerCount(0)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_currentStateSizeInBytes_Public_get_Int32_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 376360, RefRangeEnd = 376363, XrefRangeStart = 376360, XrefRangeEnd = 376363, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_currentStateSizeInBytes_Public_set_Void_Int32_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe int currentControlCount
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 50668, RefRangeEnd = 50669, XrefRangeStart = 50668, XrefRangeEnd = 50669, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_currentControlCount_Public_get_Int32_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 86468, RefRangeEnd = 86476, XrefRangeStart = 86468, XrefRangeEnd = 86476, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_currentControlCount_Public_set_Void_Int32_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe int currentLayoutCount
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 82717, RefRangeEnd = 82718, XrefRangeStart = 82717, XrefRangeEnd = 82718, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_currentLayoutCount_Public_get_Int32_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 164133, RefRangeEnd = 164138, XrefRangeStart = 164133, XrefRangeEnd = 164138, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_currentLayoutCount_Public_set_Void_Int32_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe int totalEventBytes
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 54510, RefRangeEnd = 54511, XrefRangeStart = 54510, XrefRangeEnd = 54511, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_totalEventBytes_Public_get_Int32_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 155401, RefRangeEnd = 155404, XrefRangeStart = 155401, XrefRangeEnd = 155404, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_totalEventBytes_Public_set_Void_Int32_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe int totalEventCount
	{
		[CallerCount(0)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_totalEventCount_Public_get_Int32_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(0)]
		set
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_totalEventCount_Public_set_Void_Int32_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe int totalUpdateCount
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 63233, RefRangeEnd = 63234, XrefRangeStart = 63233, XrefRangeEnd = 63234, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_totalUpdateCount_Public_get_Int32_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 102244, RefRangeEnd = 102245, XrefRangeStart = 102244, XrefRangeEnd = 102245, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_totalUpdateCount_Public_set_Void_Int32_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe double totalEventProcessingTime
	{
		[CallerCount(0)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_totalEventProcessingTime_Public_get_Double_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(double*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(0)]
		set
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_totalEventProcessingTime_Public_set_Void_Double_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe double totalEventLagTime
	{
		[CallerCount(0)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_totalEventLagTime_Public_get_Double_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(double*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(0)]
		set
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_totalEventLagTime_Public_set_Void_Double_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe float averageEventBytesPerFrame
	{
		[CallerCount(0)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_averageEventBytesPerFrame_Public_get_Single_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(float*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe double averageProcessingTimePerEvent
	{
		[CallerCount(0)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_averageProcessingTimePerEvent_Public_get_Double_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(double*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe double averageLagTimePerEvent
	{
		[CallerCount(0)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_averageLagTimePerEvent_Public_get_Double_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(double*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	static InputMetrics()
	{
		Il2CppClassPointerStore<InputMetrics>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.InputSystem.dll", "UnityEngine.InputSystem.LowLevel", "InputMetrics");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InputMetrics>.NativeClassPtr);
		NativeFieldInfoPtr__maxNumDevices_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputMetrics>.NativeClassPtr, "<maxNumDevices>k__BackingField");
		NativeFieldInfoPtr__currentNumDevices_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputMetrics>.NativeClassPtr, "<currentNumDevices>k__BackingField");
		NativeFieldInfoPtr__maxStateSizeInBytes_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputMetrics>.NativeClassPtr, "<maxStateSizeInBytes>k__BackingField");
		NativeFieldInfoPtr__currentStateSizeInBytes_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputMetrics>.NativeClassPtr, "<currentStateSizeInBytes>k__BackingField");
		NativeFieldInfoPtr__currentControlCount_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputMetrics>.NativeClassPtr, "<currentControlCount>k__BackingField");
		NativeFieldInfoPtr__currentLayoutCount_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputMetrics>.NativeClassPtr, "<currentLayoutCount>k__BackingField");
		NativeFieldInfoPtr__totalEventBytes_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputMetrics>.NativeClassPtr, "<totalEventBytes>k__BackingField");
		NativeFieldInfoPtr__totalEventCount_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputMetrics>.NativeClassPtr, "<totalEventCount>k__BackingField");
		NativeFieldInfoPtr__totalUpdateCount_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputMetrics>.NativeClassPtr, "<totalUpdateCount>k__BackingField");
		NativeFieldInfoPtr__totalEventProcessingTime_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputMetrics>.NativeClassPtr, "<totalEventProcessingTime>k__BackingField");
		NativeFieldInfoPtr__totalEventLagTime_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputMetrics>.NativeClassPtr, "<totalEventLagTime>k__BackingField");
		NativeMethodInfoPtr_get_maxNumDevices_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputMetrics>.NativeClassPtr, 100667720);
		NativeMethodInfoPtr_set_maxNumDevices_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputMetrics>.NativeClassPtr, 100667721);
		NativeMethodInfoPtr_get_currentNumDevices_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputMetrics>.NativeClassPtr, 100667722);
		NativeMethodInfoPtr_set_currentNumDevices_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputMetrics>.NativeClassPtr, 100667723);
		NativeMethodInfoPtr_get_maxStateSizeInBytes_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputMetrics>.NativeClassPtr, 100667724);
		NativeMethodInfoPtr_set_maxStateSizeInBytes_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputMetrics>.NativeClassPtr, 100667725);
		NativeMethodInfoPtr_get_currentStateSizeInBytes_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputMetrics>.NativeClassPtr, 100667726);
		NativeMethodInfoPtr_set_currentStateSizeInBytes_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputMetrics>.NativeClassPtr, 100667727);
		NativeMethodInfoPtr_get_currentControlCount_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputMetrics>.NativeClassPtr, 100667728);
		NativeMethodInfoPtr_set_currentControlCount_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputMetrics>.NativeClassPtr, 100667729);
		NativeMethodInfoPtr_get_currentLayoutCount_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputMetrics>.NativeClassPtr, 100667730);
		NativeMethodInfoPtr_set_currentLayoutCount_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputMetrics>.NativeClassPtr, 100667731);
		NativeMethodInfoPtr_get_totalEventBytes_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputMetrics>.NativeClassPtr, 100667732);
		NativeMethodInfoPtr_set_totalEventBytes_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputMetrics>.NativeClassPtr, 100667733);
		NativeMethodInfoPtr_get_totalEventCount_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputMetrics>.NativeClassPtr, 100667734);
		NativeMethodInfoPtr_set_totalEventCount_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputMetrics>.NativeClassPtr, 100667735);
		NativeMethodInfoPtr_get_totalUpdateCount_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputMetrics>.NativeClassPtr, 100667736);
		NativeMethodInfoPtr_set_totalUpdateCount_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputMetrics>.NativeClassPtr, 100667737);
		NativeMethodInfoPtr_get_totalEventProcessingTime_Public_get_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputMetrics>.NativeClassPtr, 100667738);
		NativeMethodInfoPtr_set_totalEventProcessingTime_Public_set_Void_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputMetrics>.NativeClassPtr, 100667739);
		NativeMethodInfoPtr_get_totalEventLagTime_Public_get_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputMetrics>.NativeClassPtr, 100667740);
		NativeMethodInfoPtr_set_totalEventLagTime_Public_set_Void_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputMetrics>.NativeClassPtr, 100667741);
		NativeMethodInfoPtr_get_averageEventBytesPerFrame_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputMetrics>.NativeClassPtr, 100667742);
		NativeMethodInfoPtr_get_averageProcessingTimePerEvent_Public_get_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputMetrics>.NativeClassPtr, 100667743);
		NativeMethodInfoPtr_get_averageLagTimePerEvent_Public_get_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputMetrics>.NativeClassPtr, 100667744);
	}

	public unsafe Il2CppSystem.Object BoxIl2CppObject()
	{
		return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<InputMetrics>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
	}
}
