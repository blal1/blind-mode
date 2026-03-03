using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Unity.Collections;
using Unity.Collections.LowLevel.Unsafe;

namespace UnityEngine.Rendering;

public sealed class InstanceOcclusionEventDebugArray : Il2CppSystem.ValueType
{
	[StructLayout(LayoutKind.Explicit)]
	public struct Info
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_viewInstanceID;

		private static readonly System.IntPtr NativeFieldInfoPtr_eventType;

		private static readonly System.IntPtr NativeFieldInfoPtr_occluderVersion;

		private static readonly System.IntPtr NativeFieldInfoPtr_subviewMask;

		private static readonly System.IntPtr NativeFieldInfoPtr_occlusionTest;

		private static readonly System.IntPtr NativeMethodInfoPtr_HasVersion_Public_Boolean_0;

		[FieldOffset(0)]
		public int viewInstanceID;

		[FieldOffset(4)]
		public InstanceOcclusionEventType eventType;

		[FieldOffset(8)]
		public int occluderVersion;

		[FieldOffset(12)]
		public int subviewMask;

		[FieldOffset(16)]
		public OcclusionTest occlusionTest;

		static Info()
		{
			Il2CppClassPointerStore<Info>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<InstanceOcclusionEventDebugArray>.NativeClassPtr, "Info");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Info>.NativeClassPtr);
			NativeFieldInfoPtr_viewInstanceID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Info>.NativeClassPtr, "viewInstanceID");
			NativeFieldInfoPtr_eventType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Info>.NativeClassPtr, "eventType");
			NativeFieldInfoPtr_occluderVersion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Info>.NativeClassPtr, "occluderVersion");
			NativeFieldInfoPtr_subviewMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Info>.NativeClassPtr, "subviewMask");
			NativeFieldInfoPtr_occlusionTest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Info>.NativeClassPtr, "occlusionTest");
			NativeMethodInfoPtr_HasVersion_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Info>.NativeClassPtr, 100663569);
		}

		[CallerCount(0)]
		public unsafe bool HasVersion()
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_HasVersion_Public_Boolean_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		public unsafe Il2CppSystem.Object BoxIl2CppObject()
		{
			return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Info>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
		}
	}

	public sealed class Request : Il2CppSystem.ValueType
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_info;

		private static readonly System.IntPtr NativeFieldInfoPtr_readback;

		public unsafe UnsafeList<Info> info
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_info);
				return new UnsafeList<Info>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<UnsafeList<Info>>.NativeClassPtr, (System.IntPtr)num));
			}
			set
			{
				// IL cpblk instruction
				Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_info), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<UnsafeList<Info>>.NativeClassPtr, ref *(uint*)null));
			}
		}

		public unsafe AsyncGPUReadbackRequest readback
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_readback);
				return *(AsyncGPUReadbackRequest*)num;
			}
			set
			{
				*(AsyncGPUReadbackRequest*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_readback)) = value;
			}
		}

		static Request()
		{
			Il2CppClassPointerStore<Request>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<InstanceOcclusionEventDebugArray>.NativeClassPtr, "Request");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Request>.NativeClassPtr);
			NativeFieldInfoPtr_info = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Request>.NativeClassPtr, "info");
			NativeFieldInfoPtr_readback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Request>.NativeClassPtr, "readback");
		}

		public Request(System.IntPtr pointer)
			: base(pointer)
		{
		}

		public Request()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Request>.NativeClassPtr))
		{
		}
	}

	private static readonly System.IntPtr NativeFieldInfoPtr_m_CounterBuffer;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_PendingInfo;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_Requests;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_LatestInfo;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_LatestCounters;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_HasLatest;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_CounterBuffer_Public_get_GraphicsBuffer_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Init_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_TryAdd_Public_Int32_Int32_InstanceOcclusionEventType_Int32_Int32_OcclusionTest_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_MoveToDebugStatsAndClear_Public_Void_DebugRendererBatcherStats_0;

	public unsafe GraphicsBuffer m_CounterBuffer
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_CounterBuffer);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<GraphicsBuffer>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_CounterBuffer)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe UnsafeList<Info> m_PendingInfo
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_PendingInfo);
			return new UnsafeList<Info>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<UnsafeList<Info>>.NativeClassPtr, (System.IntPtr)num));
		}
		set
		{
			// IL cpblk instruction
			Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_PendingInfo), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<UnsafeList<Info>>.NativeClassPtr, ref *(uint*)null));
		}
	}

	public unsafe NativeQueue<Request> m_Requests
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Requests);
			return new NativeQueue<Request>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeQueue<Request>>.NativeClassPtr, (System.IntPtr)num));
		}
		set
		{
			// IL cpblk instruction
			Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Requests), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeQueue<Request>>.NativeClassPtr, ref *(uint*)null));
		}
	}

	public unsafe UnsafeList<Info> m_LatestInfo
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_LatestInfo);
			return new UnsafeList<Info>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<UnsafeList<Info>>.NativeClassPtr, (System.IntPtr)num));
		}
		set
		{
			// IL cpblk instruction
			Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_LatestInfo), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<UnsafeList<Info>>.NativeClassPtr, ref *(uint*)null));
		}
	}

	public unsafe NativeArray<int> m_LatestCounters
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_LatestCounters);
			return new NativeArray<int>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeArray<int>>.NativeClassPtr, (System.IntPtr)num));
		}
		set
		{
			// IL cpblk instruction
			Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_LatestCounters), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeArray<int>>.NativeClassPtr, ref *(uint*)null));
		}
	}

	public unsafe bool m_HasLatest
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_HasLatest);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_HasLatest)) = value;
		}
	}

	public unsafe GraphicsBuffer CounterBuffer
	{
		[CallerCount(98)]
		[CachedScanResults(RefRangeStart = 110111, RefRangeEnd = 110209, XrefRangeStart = 110111, XrefRangeEnd = 110209, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_CounterBuffer_Public_get_GraphicsBuffer_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<GraphicsBuffer>(intPtr2) : null;
		}
	}

	static InstanceOcclusionEventDebugArray()
	{
		Il2CppClassPointerStore<InstanceOcclusionEventDebugArray>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.GPUDriven.Runtime.dll", "UnityEngine.Rendering", "InstanceOcclusionEventDebugArray");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InstanceOcclusionEventDebugArray>.NativeClassPtr);
		NativeFieldInfoPtr_m_CounterBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InstanceOcclusionEventDebugArray>.NativeClassPtr, "m_CounterBuffer");
		NativeFieldInfoPtr_m_PendingInfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InstanceOcclusionEventDebugArray>.NativeClassPtr, "m_PendingInfo");
		NativeFieldInfoPtr_m_Requests = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InstanceOcclusionEventDebugArray>.NativeClassPtr, "m_Requests");
		NativeFieldInfoPtr_m_LatestInfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InstanceOcclusionEventDebugArray>.NativeClassPtr, "m_LatestInfo");
		NativeFieldInfoPtr_m_LatestCounters = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InstanceOcclusionEventDebugArray>.NativeClassPtr, "m_LatestCounters");
		NativeFieldInfoPtr_m_HasLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InstanceOcclusionEventDebugArray>.NativeClassPtr, "m_HasLatest");
		NativeMethodInfoPtr_get_CounterBuffer_Public_get_GraphicsBuffer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InstanceOcclusionEventDebugArray>.NativeClassPtr, 100663564);
		NativeMethodInfoPtr_Init_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InstanceOcclusionEventDebugArray>.NativeClassPtr, 100663565);
		NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InstanceOcclusionEventDebugArray>.NativeClassPtr, 100663566);
		NativeMethodInfoPtr_TryAdd_Public_Int32_Int32_InstanceOcclusionEventType_Int32_Int32_OcclusionTest_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InstanceOcclusionEventDebugArray>.NativeClassPtr, 100663567);
		NativeMethodInfoPtr_MoveToDebugStatsAndClear_Public_Void_DebugRendererBatcherStats_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InstanceOcclusionEventDebugArray>.NativeClassPtr, 100663568);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1069553, RefRangeEnd = 1069554, XrefRangeStart = 1069540, XrefRangeEnd = 1069553, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Init()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Init_Public_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1069574, RefRangeEnd = 1069575, XrefRangeStart = 1069554, XrefRangeEnd = 1069574, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void Dispose()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1069582, RefRangeEnd = 1069584, XrefRangeStart = 1069575, XrefRangeEnd = 1069582, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int TryAdd(int viewInstanceID, InstanceOcclusionEventType eventType, int occluderVersion, int subviewMask, OcclusionTest occlusionTest)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = (nint)(&viewInstanceID);
		*(InstanceOcclusionEventType**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &eventType;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &occluderVersion;
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &subviewMask;
		*(OcclusionTest**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &occlusionTest;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_TryAdd_Public_Int32_Int32_InstanceOcclusionEventType_Int32_Int32_OcclusionTest_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1069634, RefRangeEnd = 1069636, XrefRangeStart = 1069584, XrefRangeEnd = 1069634, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void MoveToDebugStatsAndClear(DebugRendererBatcherStats debugStats)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)debugStats);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_MoveToDebugStatsAndClear_Public_Void_DebugRendererBatcherStats_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public InstanceOcclusionEventDebugArray(System.IntPtr pointer)
		: base(pointer)
	{
	}

	public InstanceOcclusionEventDebugArray()
		: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InstanceOcclusionEventDebugArray>.NativeClassPtr))
	{
	}
}
