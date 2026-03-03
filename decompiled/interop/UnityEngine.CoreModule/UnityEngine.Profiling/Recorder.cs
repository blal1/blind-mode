using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Unity.Profiling;
using Unity.Profiling.LowLevel.Unsafe;

namespace UnityEngine.Profiling;

public sealed class Recorder : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_s_RecorderDefaultOptions;

	private static readonly System.IntPtr NativeFieldInfoPtr_s_InvalidRecorder;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_RecorderCPU;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_RecorderGPU;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Internal_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Internal_Void_ProfilerRecorderHandle_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_enabled_Public_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_enabled_Public_set_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_elapsedNanoseconds_Public_get_Int64_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_gpuElapsedNanoseconds_Public_get_Int64_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_sampleBlockCount_Public_get_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_gpuSampleBlockCount_Public_get_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetEnabled_Private_Void_Boolean_0;

	public unsafe static ProfilerRecorderOptions s_RecorderDefaultOptions
	{
		get
		{
			Unsafe.SkipInit(out ProfilerRecorderOptions result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_s_RecorderDefaultOptions, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_s_RecorderDefaultOptions, (void*)(&value));
		}
	}

	public unsafe static Recorder s_InvalidRecorder
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_s_InvalidRecorder, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Recorder>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_s_InvalidRecorder, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe ProfilerRecorder m_RecorderCPU
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_RecorderCPU);
			return *(ProfilerRecorder*)num;
		}
		set
		{
			*(ProfilerRecorder*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_RecorderCPU)) = value;
		}
	}

	public unsafe ProfilerRecorder m_RecorderGPU
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_RecorderGPU);
			return *(ProfilerRecorder*)num;
		}
		set
		{
			*(ProfilerRecorder*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_RecorderGPU)) = value;
		}
	}

	public unsafe bool enabled
	{
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 1221966, RefRangeEnd = 1221972, XrefRangeStart = 1221965, XrefRangeEnd = 1221966, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_enabled_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 1221978, RefRangeEnd = 1221984, XrefRangeStart = 1221972, XrefRangeEnd = 1221978, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_enabled_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe long elapsedNanoseconds
	{
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1221986, RefRangeEnd = 1221988, XrefRangeStart = 1221984, XrefRangeEnd = 1221986, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_elapsedNanoseconds_Public_get_Int64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(long*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe long gpuElapsedNanoseconds
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1221990, RefRangeEnd = 1221991, XrefRangeStart = 1221988, XrefRangeEnd = 1221990, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_gpuElapsedNanoseconds_Public_get_Int64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(long*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe int sampleBlockCount
	{
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1221994, RefRangeEnd = 1221996, XrefRangeStart = 1221991, XrefRangeEnd = 1221994, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_sampleBlockCount_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe int gpuSampleBlockCount
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1221999, RefRangeEnd = 1222000, XrefRangeStart = 1221996, XrefRangeEnd = 1221999, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_gpuSampleBlockCount_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public bool isValid
	{
		get
		{
			throw new System.NotSupportedException("Method unstripping failed");
		}
	}

	static Recorder()
	{
		Il2CppClassPointerStore<Recorder>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Profiling", "Recorder");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Recorder>.NativeClassPtr);
		NativeFieldInfoPtr_s_RecorderDefaultOptions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Recorder>.NativeClassPtr, "s_RecorderDefaultOptions");
		NativeFieldInfoPtr_s_InvalidRecorder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Recorder>.NativeClassPtr, "s_InvalidRecorder");
		NativeFieldInfoPtr_m_RecorderCPU = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Recorder>.NativeClassPtr, "m_RecorderCPU");
		NativeFieldInfoPtr_m_RecorderGPU = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Recorder>.NativeClassPtr, "m_RecorderGPU");
		NativeMethodInfoPtr__ctor_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Recorder>.NativeClassPtr, 100666952);
		NativeMethodInfoPtr__ctor_Internal_Void_ProfilerRecorderHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Recorder>.NativeClassPtr, 100666953);
		NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Recorder>.NativeClassPtr, 100666954);
		NativeMethodInfoPtr_get_enabled_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Recorder>.NativeClassPtr, 100666955);
		NativeMethodInfoPtr_set_enabled_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Recorder>.NativeClassPtr, 100666956);
		NativeMethodInfoPtr_get_elapsedNanoseconds_Public_get_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Recorder>.NativeClassPtr, 100666957);
		NativeMethodInfoPtr_get_gpuElapsedNanoseconds_Public_get_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Recorder>.NativeClassPtr, 100666958);
		NativeMethodInfoPtr_get_sampleBlockCount_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Recorder>.NativeClassPtr, 100666959);
		NativeMethodInfoPtr_get_gpuSampleBlockCount_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Recorder>.NativeClassPtr, 100666960);
		NativeMethodInfoPtr_SetEnabled_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Recorder>.NativeClassPtr, 100666961);
	}

	[CallerCount(1950)]
	[CachedScanResults(RefRangeStart = 20036, RefRangeEnd = 21986, XrefRangeStart = 20036, XrefRangeEnd = 21986, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Recorder()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Recorder>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1221955, XrefRangeEnd = 1221960, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Recorder(ProfilerRecorderHandle handle)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Recorder>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&handle);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Internal_Void_ProfilerRecorderHandle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1221960, XrefRangeEnd = 1221965, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public new unsafe void Finalize()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(6)]
	[CachedScanResults(RefRangeStart = 1221978, RefRangeEnd = 1221984, XrefRangeStart = 1221978, XrefRangeEnd = 1221984, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetEnabled(bool state)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&state);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetEnabled_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public Recorder(System.IntPtr pointer)
		: base(pointer)
	{
	}

	public static Recorder Get(string samplerName)
	{
		ProfilerRecorderHandle handle = ProfilerRecorderHandle.Get(ProfilerCategory.Any, samplerName);
		if (!handle.Valid)
		{
			return s_InvalidRecorder;
		}
		return new Recorder(handle);
	}

	public void FilterToCurrentThread()
	{
		throw new System.NotSupportedException("Method unstripping failed");
	}

	public void CollectFromAllThreads()
	{
		throw new System.NotSupportedException("Method unstripping failed");
	}
}
