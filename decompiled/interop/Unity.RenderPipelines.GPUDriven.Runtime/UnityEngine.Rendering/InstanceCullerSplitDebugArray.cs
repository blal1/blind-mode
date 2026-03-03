using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem;
using Unity.Collections;
using Unity.Jobs;

namespace UnityEngine.Rendering;

public sealed class InstanceCullerSplitDebugArray : Il2CppSystem.ValueType
{
	[StructLayout(LayoutKind.Explicit)]
	public struct Info
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_viewType;

		private static readonly System.IntPtr NativeFieldInfoPtr_viewInstanceID;

		private static readonly System.IntPtr NativeFieldInfoPtr_splitIndex;

		[FieldOffset(0)]
		public BatchCullingViewType viewType;

		[FieldOffset(4)]
		public int viewInstanceID;

		[FieldOffset(8)]
		public int splitIndex;

		static Info()
		{
			Il2CppClassPointerStore<Info>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<InstanceCullerSplitDebugArray>.NativeClassPtr, "Info");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Info>.NativeClassPtr);
			NativeFieldInfoPtr_viewType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Info>.NativeClassPtr, "viewType");
			NativeFieldInfoPtr_viewInstanceID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Info>.NativeClassPtr, "viewInstanceID");
			NativeFieldInfoPtr_splitIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Info>.NativeClassPtr, "splitIndex");
		}

		public unsafe Il2CppSystem.Object BoxIl2CppObject()
		{
			return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Info>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
		}
	}

	private static readonly System.IntPtr NativeFieldInfoPtr_m_Info;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_Counters;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_CounterSync;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_Counters_Public_get_NativeArray_1_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Init_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_TryAddSplits_Public_Int32_BatchCullingViewType_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AddSync_Public_Void_Int32_JobHandle_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_MoveToDebugStatsAndClear_Public_Void_DebugRendererBatcherStats_0;

	public unsafe NativeList<Info> m_Info
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Info);
			return new NativeList<Info>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeList<Info>>.NativeClassPtr, (System.IntPtr)num));
		}
		set
		{
			// IL cpblk instruction
			Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Info), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeList<Info>>.NativeClassPtr, ref *(uint*)null));
		}
	}

	public unsafe NativeArray<int> m_Counters
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Counters);
			return new NativeArray<int>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeArray<int>>.NativeClassPtr, (System.IntPtr)num));
		}
		set
		{
			// IL cpblk instruction
			Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Counters), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeArray<int>>.NativeClassPtr, ref *(uint*)null));
		}
	}

	public unsafe NativeQueue<JobHandle> m_CounterSync
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_CounterSync);
			return new NativeQueue<JobHandle>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeQueue<JobHandle>>.NativeClassPtr, (System.IntPtr)num));
		}
		set
		{
			// IL cpblk instruction
			Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_CounterSync), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeQueue<JobHandle>>.NativeClassPtr, ref *(uint*)null));
		}
	}

	public unsafe NativeArray<int> Counters
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_Counters_Public_get_NativeArray_1_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return new NativeArray<int>(pointer);
		}
	}

	static InstanceCullerSplitDebugArray()
	{
		Il2CppClassPointerStore<InstanceCullerSplitDebugArray>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.GPUDriven.Runtime.dll", "UnityEngine.Rendering", "InstanceCullerSplitDebugArray");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InstanceCullerSplitDebugArray>.NativeClassPtr);
		NativeFieldInfoPtr_m_Info = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InstanceCullerSplitDebugArray>.NativeClassPtr, "m_Info");
		NativeFieldInfoPtr_m_Counters = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InstanceCullerSplitDebugArray>.NativeClassPtr, "m_Counters");
		NativeFieldInfoPtr_m_CounterSync = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InstanceCullerSplitDebugArray>.NativeClassPtr, "m_CounterSync");
		NativeMethodInfoPtr_get_Counters_Public_get_NativeArray_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InstanceCullerSplitDebugArray>.NativeClassPtr, 100663558);
		NativeMethodInfoPtr_Init_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InstanceCullerSplitDebugArray>.NativeClassPtr, 100663559);
		NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InstanceCullerSplitDebugArray>.NativeClassPtr, 100663560);
		NativeMethodInfoPtr_TryAddSplits_Public_Int32_BatchCullingViewType_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InstanceCullerSplitDebugArray>.NativeClassPtr, 100663561);
		NativeMethodInfoPtr_AddSync_Public_Void_Int32_JobHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InstanceCullerSplitDebugArray>.NativeClassPtr, 100663562);
		NativeMethodInfoPtr_MoveToDebugStatsAndClear_Public_Void_DebugRendererBatcherStats_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InstanceCullerSplitDebugArray>.NativeClassPtr, 100663563);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1069491, RefRangeEnd = 1069492, XrefRangeStart = 1069480, XrefRangeEnd = 1069491, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Init()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Init_Public_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1069501, RefRangeEnd = 1069502, XrefRangeStart = 1069492, XrefRangeEnd = 1069501, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void Dispose()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1069509, RefRangeEnd = 1069510, XrefRangeStart = 1069502, XrefRangeEnd = 1069509, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int TryAddSplits(BatchCullingViewType viewType, int viewInstanceID, int splitCount)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&viewType);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &viewInstanceID;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &splitCount;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_TryAddSplits_Public_Int32_BatchCullingViewType_Int32_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1069510, XrefRangeEnd = 1069513, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void AddSync(int baseIndex, JobHandle jobHandle)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&baseIndex);
		*(JobHandle**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &jobHandle;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AddSync_Public_Void_Int32_JobHandle_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1069538, RefRangeEnd = 1069540, XrefRangeStart = 1069513, XrefRangeEnd = 1069538, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void MoveToDebugStatsAndClear(DebugRendererBatcherStats debugStats)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)debugStats);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_MoveToDebugStatsAndClear_Public_Void_DebugRendererBatcherStats_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public InstanceCullerSplitDebugArray(System.IntPtr pointer)
		: base(pointer)
	{
	}

	public InstanceCullerSplitDebugArray()
		: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InstanceCullerSplitDebugArray>.NativeClassPtr))
	{
	}
}
