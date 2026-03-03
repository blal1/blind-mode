using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine.Analytics;

namespace UnityEditor.Analytics;

[Serializable]
public class StallSummaryAnalytic : AnalyticsEventBase
{
	private static readonly IntPtr NativeFieldInfoPtr_Duration;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_CreateStallSummaryAnalytic_Internal_Static_StallSummaryAnalytic_0;

	public unsafe double Duration
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Duration);
			return *(double*)num;
		}
		set
		{
			*(double*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Duration)) = value;
		}
	}

	static StallSummaryAnalytic()
	{
		Il2CppClassPointerStore<StallSummaryAnalytic>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UnityAnalyticsCommonModule.dll", "UnityEditor.Analytics", "StallSummaryAnalytic");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StallSummaryAnalytic>.NativeClassPtr);
		NativeFieldInfoPtr_Duration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StallSummaryAnalytic>.NativeClassPtr, "Duration");
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StallSummaryAnalytic>.NativeClassPtr, 100663354);
		NativeMethodInfoPtr_CreateStallSummaryAnalytic_Internal_Static_StallSummaryAnalytic_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StallSummaryAnalytic>.NativeClassPtr, 100663355);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1407926, XrefRangeEnd = 1407931, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe StallSummaryAnalytic()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StallSummaryAnalytic>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1407931, XrefRangeEnd = 1407939, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static StallSummaryAnalytic CreateStallSummaryAnalytic()
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CreateStallSummaryAnalytic_Internal_Static_StallSummaryAnalytic_0, (IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (IntPtr)0) ? Il2CppObjectPool.Get<StallSummaryAnalytic>(intPtr2) : null;
	}

	public StallSummaryAnalytic(IntPtr pointer)
		: base(pointer)
	{
	}
}
