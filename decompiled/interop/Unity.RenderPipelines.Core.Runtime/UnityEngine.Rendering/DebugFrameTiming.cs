using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace UnityEngine.Rendering;

public class DebugFrameTiming : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_k_FpsFormatString;

	private static readonly System.IntPtr NativeFieldInfoPtr_k_MsFormatString;

	private static readonly System.IntPtr NativeFieldInfoPtr_k_RefreshRate;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_FrameHistory;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_BottleneckHistory;

	private static readonly System.IntPtr NativeFieldInfoPtr__bottleneckHistorySize_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__sampleHistorySize_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_Timing;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_Sample;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_bottleneckHistorySize_Public_get_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_bottleneckHistorySize_Public_set_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_sampleHistorySize_Public_get_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_sampleHistorySize_Public_set_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UpdateFrameTiming_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RegisterDebugUI_Public_Void_List_1_Widget_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Reset_Internal_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__RegisterDebugUI_b__17_0_Private_Object_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__RegisterDebugUI_b__17_1_Private_Object_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__RegisterDebugUI_b__17_2_Private_Object_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__RegisterDebugUI_b__17_3_Private_Object_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__RegisterDebugUI_b__17_4_Private_Object_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__RegisterDebugUI_b__17_5_Private_Object_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__RegisterDebugUI_b__17_6_Private_Object_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__RegisterDebugUI_b__17_7_Private_Object_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__RegisterDebugUI_b__17_8_Private_Object_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__RegisterDebugUI_b__17_9_Private_Object_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__RegisterDebugUI_b__17_10_Private_Object_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__RegisterDebugUI_b__17_11_Private_Object_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__RegisterDebugUI_b__17_12_Private_Object_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__RegisterDebugUI_b__17_13_Private_Object_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__RegisterDebugUI_b__17_14_Private_Object_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__RegisterDebugUI_b__17_15_Private_Object_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__RegisterDebugUI_b__17_16_Private_Object_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__RegisterDebugUI_b__17_17_Private_Object_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__RegisterDebugUI_b__17_18_Private_Object_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__RegisterDebugUI_b__17_19_Private_Object_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__RegisterDebugUI_b__17_20_Private_Object_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__RegisterDebugUI_b__17_21_Private_Object_0;

	public unsafe static string k_FpsFormatString
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_k_FpsFormatString, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_k_FpsFormatString, (void*)IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe static string k_MsFormatString
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_k_MsFormatString, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_k_MsFormatString, (void*)IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe static float k_RefreshRate
	{
		get
		{
			Unsafe.SkipInit(out float result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_k_RefreshRate, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_k_RefreshRate, (void*)(&value));
		}
	}

	public unsafe FrameTimeSampleHistory m_FrameHistory
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_FrameHistory);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<FrameTimeSampleHistory>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_FrameHistory)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe BottleneckHistory m_BottleneckHistory
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_BottleneckHistory);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<BottleneckHistory>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_BottleneckHistory)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe int _bottleneckHistorySize_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__bottleneckHistorySize_k__BackingField);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__bottleneckHistorySize_k__BackingField)) = value;
		}
	}

	public unsafe int _sampleHistorySize_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__sampleHistorySize_k__BackingField);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__sampleHistorySize_k__BackingField)) = value;
		}
	}

	public unsafe Il2CppStructArray<FrameTiming> m_Timing
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Timing);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<FrameTiming>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Timing)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe FrameTimeSample m_Sample
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Sample);
			return *(FrameTimeSample*)num;
		}
		set
		{
			*(FrameTimeSample*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Sample)) = value;
		}
	}

	public unsafe int bottleneckHistorySize
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 63233, RefRangeEnd = 63234, XrefRangeStart = 63233, XrefRangeEnd = 63234, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_bottleneckHistorySize_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 102244, RefRangeEnd = 102245, XrefRangeStart = 102244, XrefRangeEnd = 102245, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_bottleneckHistorySize_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe int sampleHistorySize
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_sampleHistorySize_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(0)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_sampleHistorySize_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	static DebugFrameTiming()
	{
		Il2CppClassPointerStore<DebugFrameTiming>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Core.Runtime.dll", "UnityEngine.Rendering", "DebugFrameTiming");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DebugFrameTiming>.NativeClassPtr);
		NativeFieldInfoPtr_k_FpsFormatString = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugFrameTiming>.NativeClassPtr, "k_FpsFormatString");
		NativeFieldInfoPtr_k_MsFormatString = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugFrameTiming>.NativeClassPtr, "k_MsFormatString");
		NativeFieldInfoPtr_k_RefreshRate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugFrameTiming>.NativeClassPtr, "k_RefreshRate");
		NativeFieldInfoPtr_m_FrameHistory = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugFrameTiming>.NativeClassPtr, "m_FrameHistory");
		NativeFieldInfoPtr_m_BottleneckHistory = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugFrameTiming>.NativeClassPtr, "m_BottleneckHistory");
		NativeFieldInfoPtr__bottleneckHistorySize_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugFrameTiming>.NativeClassPtr, "<bottleneckHistorySize>k__BackingField");
		NativeFieldInfoPtr__sampleHistorySize_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugFrameTiming>.NativeClassPtr, "<sampleHistorySize>k__BackingField");
		NativeFieldInfoPtr_m_Timing = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugFrameTiming>.NativeClassPtr, "m_Timing");
		NativeFieldInfoPtr_m_Sample = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugFrameTiming>.NativeClassPtr, "m_Sample");
		NativeMethodInfoPtr_get_bottleneckHistorySize_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugFrameTiming>.NativeClassPtr, 100664685);
		NativeMethodInfoPtr_set_bottleneckHistorySize_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugFrameTiming>.NativeClassPtr, 100664686);
		NativeMethodInfoPtr_get_sampleHistorySize_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugFrameTiming>.NativeClassPtr, 100664687);
		NativeMethodInfoPtr_set_sampleHistorySize_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugFrameTiming>.NativeClassPtr, 100664688);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugFrameTiming>.NativeClassPtr, 100664689);
		NativeMethodInfoPtr_UpdateFrameTiming_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugFrameTiming>.NativeClassPtr, 100664690);
		NativeMethodInfoPtr_RegisterDebugUI_Public_Void_List_1_Widget_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugFrameTiming>.NativeClassPtr, 100664691);
		NativeMethodInfoPtr_Reset_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugFrameTiming>.NativeClassPtr, 100664692);
		NativeMethodInfoPtr__RegisterDebugUI_b__17_0_Private_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugFrameTiming>.NativeClassPtr, 100664693);
		NativeMethodInfoPtr__RegisterDebugUI_b__17_1_Private_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugFrameTiming>.NativeClassPtr, 100664694);
		NativeMethodInfoPtr__RegisterDebugUI_b__17_2_Private_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugFrameTiming>.NativeClassPtr, 100664695);
		NativeMethodInfoPtr__RegisterDebugUI_b__17_3_Private_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugFrameTiming>.NativeClassPtr, 100664696);
		NativeMethodInfoPtr__RegisterDebugUI_b__17_4_Private_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugFrameTiming>.NativeClassPtr, 100664697);
		NativeMethodInfoPtr__RegisterDebugUI_b__17_5_Private_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugFrameTiming>.NativeClassPtr, 100664698);
		NativeMethodInfoPtr__RegisterDebugUI_b__17_6_Private_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugFrameTiming>.NativeClassPtr, 100664699);
		NativeMethodInfoPtr__RegisterDebugUI_b__17_7_Private_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugFrameTiming>.NativeClassPtr, 100664700);
		NativeMethodInfoPtr__RegisterDebugUI_b__17_8_Private_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugFrameTiming>.NativeClassPtr, 100664701);
		NativeMethodInfoPtr__RegisterDebugUI_b__17_9_Private_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugFrameTiming>.NativeClassPtr, 100664702);
		NativeMethodInfoPtr__RegisterDebugUI_b__17_10_Private_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugFrameTiming>.NativeClassPtr, 100664703);
		NativeMethodInfoPtr__RegisterDebugUI_b__17_11_Private_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugFrameTiming>.NativeClassPtr, 100664704);
		NativeMethodInfoPtr__RegisterDebugUI_b__17_12_Private_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugFrameTiming>.NativeClassPtr, 100664705);
		NativeMethodInfoPtr__RegisterDebugUI_b__17_13_Private_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugFrameTiming>.NativeClassPtr, 100664706);
		NativeMethodInfoPtr__RegisterDebugUI_b__17_14_Private_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugFrameTiming>.NativeClassPtr, 100664707);
		NativeMethodInfoPtr__RegisterDebugUI_b__17_15_Private_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugFrameTiming>.NativeClassPtr, 100664708);
		NativeMethodInfoPtr__RegisterDebugUI_b__17_16_Private_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugFrameTiming>.NativeClassPtr, 100664709);
		NativeMethodInfoPtr__RegisterDebugUI_b__17_17_Private_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugFrameTiming>.NativeClassPtr, 100664710);
		NativeMethodInfoPtr__RegisterDebugUI_b__17_18_Private_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugFrameTiming>.NativeClassPtr, 100664711);
		NativeMethodInfoPtr__RegisterDebugUI_b__17_19_Private_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugFrameTiming>.NativeClassPtr, 100664712);
		NativeMethodInfoPtr__RegisterDebugUI_b__17_20_Private_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugFrameTiming>.NativeClassPtr, 100664713);
		NativeMethodInfoPtr__RegisterDebugUI_b__17_21_Private_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugFrameTiming>.NativeClassPtr, 100664714);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1032050, RefRangeEnd = 1032052, XrefRangeStart = 1032014, XrefRangeEnd = 1032050, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe DebugFrameTiming()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DebugFrameTiming>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1032102, RefRangeEnd = 1032103, XrefRangeStart = 1032052, XrefRangeEnd = 1032102, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void UpdateFrameTiming()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UpdateFrameTiming_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1032584, RefRangeEnd = 1032585, XrefRangeStart = 1032103, XrefRangeEnd = 1032584, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void RegisterDebugUI(List<DebugUI.Widget> list)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RegisterDebugUI_Public_Void_List_1_Widget_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1032585, XrefRangeEnd = 1032587, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Reset()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Reset_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1032587, XrefRangeEnd = 1032589, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Il2CppSystem.Object _RegisterDebugUI_b__17_0()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__RegisterDebugUI_b__17_0_Private_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1032589, XrefRangeEnd = 1032591, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Il2CppSystem.Object _RegisterDebugUI_b__17_1()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__RegisterDebugUI_b__17_1_Private_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1032591, XrefRangeEnd = 1032593, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Il2CppSystem.Object _RegisterDebugUI_b__17_2()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__RegisterDebugUI_b__17_2_Private_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1032593, XrefRangeEnd = 1032595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Il2CppSystem.Object _RegisterDebugUI_b__17_3()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__RegisterDebugUI_b__17_3_Private_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1032595, XrefRangeEnd = 1032597, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Il2CppSystem.Object _RegisterDebugUI_b__17_4()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__RegisterDebugUI_b__17_4_Private_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1032597, XrefRangeEnd = 1032599, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Il2CppSystem.Object _RegisterDebugUI_b__17_5()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__RegisterDebugUI_b__17_5_Private_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1032599, XrefRangeEnd = 1032601, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Il2CppSystem.Object _RegisterDebugUI_b__17_6()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__RegisterDebugUI_b__17_6_Private_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1032601, XrefRangeEnd = 1032603, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Il2CppSystem.Object _RegisterDebugUI_b__17_7()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__RegisterDebugUI_b__17_7_Private_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1032603, XrefRangeEnd = 1032605, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Il2CppSystem.Object _RegisterDebugUI_b__17_8()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__RegisterDebugUI_b__17_8_Private_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1032605, XrefRangeEnd = 1032607, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Il2CppSystem.Object _RegisterDebugUI_b__17_9()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__RegisterDebugUI_b__17_9_Private_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1032607, XrefRangeEnd = 1032609, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Il2CppSystem.Object _RegisterDebugUI_b__17_10()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__RegisterDebugUI_b__17_10_Private_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1032609, XrefRangeEnd = 1032611, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Il2CppSystem.Object _RegisterDebugUI_b__17_11()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__RegisterDebugUI_b__17_11_Private_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1032611, XrefRangeEnd = 1032613, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Il2CppSystem.Object _RegisterDebugUI_b__17_12()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__RegisterDebugUI_b__17_12_Private_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1032613, XrefRangeEnd = 1032615, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Il2CppSystem.Object _RegisterDebugUI_b__17_13()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__RegisterDebugUI_b__17_13_Private_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1032615, XrefRangeEnd = 1032617, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Il2CppSystem.Object _RegisterDebugUI_b__17_14()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__RegisterDebugUI_b__17_14_Private_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1032617, XrefRangeEnd = 1032619, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Il2CppSystem.Object _RegisterDebugUI_b__17_15()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__RegisterDebugUI_b__17_15_Private_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1032619, XrefRangeEnd = 1032621, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Il2CppSystem.Object _RegisterDebugUI_b__17_16()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__RegisterDebugUI_b__17_16_Private_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1032621, XrefRangeEnd = 1032623, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Il2CppSystem.Object _RegisterDebugUI_b__17_17()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__RegisterDebugUI_b__17_17_Private_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1032623, XrefRangeEnd = 1032625, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Il2CppSystem.Object _RegisterDebugUI_b__17_18()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__RegisterDebugUI_b__17_18_Private_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1032625, XrefRangeEnd = 1032627, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Il2CppSystem.Object _RegisterDebugUI_b__17_19()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__RegisterDebugUI_b__17_19_Private_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1032627, XrefRangeEnd = 1032629, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Il2CppSystem.Object _RegisterDebugUI_b__17_20()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__RegisterDebugUI_b__17_20_Private_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1032629, XrefRangeEnd = 1032631, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Il2CppSystem.Object _RegisterDebugUI_b__17_21()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__RegisterDebugUI_b__17_21_Private_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
	}

	public DebugFrameTiming(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
