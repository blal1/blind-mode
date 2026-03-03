using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem;
using Unity.Collections;

namespace UnityEngine.Rendering;

public class DebugRendererBatcherStats : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_enabled;

	private static readonly System.IntPtr NativeFieldInfoPtr_instanceCullerStats;

	private static readonly System.IntPtr NativeFieldInfoPtr_instanceOcclusionEventStats;

	private static readonly System.IntPtr NativeFieldInfoPtr_occluderStats;

	private static readonly System.IntPtr NativeFieldInfoPtr_occlusionOverlayEnabled;

	private static readonly System.IntPtr NativeFieldInfoPtr_occlusionOverlayCountVisible;

	private static readonly System.IntPtr NativeFieldInfoPtr_overrideOcclusionTestToAlwaysPass;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FinalizeInstanceCullerViewStats_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetLastInstanceOcclusionEventStatsForView_Private_InstanceOcclusionEventStats_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;

	public unsafe bool enabled
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_enabled);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_enabled)) = value;
		}
	}

	public unsafe NativeList<InstanceCullerViewStats> instanceCullerStats
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_instanceCullerStats);
			return new NativeList<InstanceCullerViewStats>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeList<InstanceCullerViewStats>>.NativeClassPtr, (System.IntPtr)num));
		}
		set
		{
			// IL cpblk instruction
			Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_instanceCullerStats), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeList<InstanceCullerViewStats>>.NativeClassPtr, ref *(uint*)null));
		}
	}

	public unsafe NativeList<InstanceOcclusionEventStats> instanceOcclusionEventStats
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_instanceOcclusionEventStats);
			return new NativeList<InstanceOcclusionEventStats>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeList<InstanceOcclusionEventStats>>.NativeClassPtr, (System.IntPtr)num));
		}
		set
		{
			// IL cpblk instruction
			Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_instanceOcclusionEventStats), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeList<InstanceOcclusionEventStats>>.NativeClassPtr, ref *(uint*)null));
		}
	}

	public unsafe NativeList<DebugOccluderStats> occluderStats
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_occluderStats);
			return new NativeList<DebugOccluderStats>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeList<DebugOccluderStats>>.NativeClassPtr, (System.IntPtr)num));
		}
		set
		{
			// IL cpblk instruction
			Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_occluderStats), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeList<DebugOccluderStats>>.NativeClassPtr, ref *(uint*)null));
		}
	}

	public unsafe bool occlusionOverlayEnabled
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_occlusionOverlayEnabled);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_occlusionOverlayEnabled)) = value;
		}
	}

	public unsafe bool occlusionOverlayCountVisible
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_occlusionOverlayCountVisible);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_occlusionOverlayCountVisible)) = value;
		}
	}

	public unsafe bool overrideOcclusionTestToAlwaysPass
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_overrideOcclusionTestToAlwaysPass);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_overrideOcclusionTestToAlwaysPass)) = value;
		}
	}

	static DebugRendererBatcherStats()
	{
		Il2CppClassPointerStore<DebugRendererBatcherStats>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.GPUDriven.Runtime.dll", "UnityEngine.Rendering", "DebugRendererBatcherStats");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DebugRendererBatcherStats>.NativeClassPtr);
		NativeFieldInfoPtr_enabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugRendererBatcherStats>.NativeClassPtr, "enabled");
		NativeFieldInfoPtr_instanceCullerStats = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugRendererBatcherStats>.NativeClassPtr, "instanceCullerStats");
		NativeFieldInfoPtr_instanceOcclusionEventStats = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugRendererBatcherStats>.NativeClassPtr, "instanceOcclusionEventStats");
		NativeFieldInfoPtr_occluderStats = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugRendererBatcherStats>.NativeClassPtr, "occluderStats");
		NativeFieldInfoPtr_occlusionOverlayEnabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugRendererBatcherStats>.NativeClassPtr, "occlusionOverlayEnabled");
		NativeFieldInfoPtr_occlusionOverlayCountVisible = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugRendererBatcherStats>.NativeClassPtr, "occlusionOverlayCountVisible");
		NativeFieldInfoPtr_overrideOcclusionTestToAlwaysPass = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugRendererBatcherStats>.NativeClassPtr, "overrideOcclusionTestToAlwaysPass");
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugRendererBatcherStats>.NativeClassPtr, 100663519);
		NativeMethodInfoPtr_FinalizeInstanceCullerViewStats_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugRendererBatcherStats>.NativeClassPtr, 100663520);
		NativeMethodInfoPtr_GetLastInstanceOcclusionEventStatsForView_Private_InstanceOcclusionEventStats_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugRendererBatcherStats>.NativeClassPtr, 100663521);
		NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugRendererBatcherStats>.NativeClassPtr, 100663522);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1069177, RefRangeEnd = 1069178, XrefRangeStart = 1069164, XrefRangeEnd = 1069177, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe DebugRendererBatcherStats()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DebugRendererBatcherStats>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1069209, RefRangeEnd = 1069211, XrefRangeStart = 1069178, XrefRangeEnd = 1069209, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void FinalizeInstanceCullerViewStats()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FinalizeInstanceCullerViewStats_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1069211, XrefRangeEnd = 1069224, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe InstanceOcclusionEventStats GetLastInstanceOcclusionEventStatsForView(int viewIndex)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&viewIndex);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetLastInstanceOcclusionEventStatsForView_Private_InstanceOcclusionEventStats_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(InstanceOcclusionEventStats*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1069236, RefRangeEnd = 1069237, XrefRangeStart = 1069224, XrefRangeEnd = 1069236, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void Dispose()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public DebugRendererBatcherStats(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
