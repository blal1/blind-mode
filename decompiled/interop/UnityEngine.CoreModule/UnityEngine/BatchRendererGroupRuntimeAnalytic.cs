using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine.Analytics;

namespace UnityEngine;

[Serializable]
public class BatchRendererGroupRuntimeAnalytic : AnalyticsEventBase
{
	private static readonly IntPtr NativeFieldInfoPtr_brgRuntimeStatus;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Private_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_CreateBatchRendererGroupRuntimeAnalytic_Public_Static_BatchRendererGroupRuntimeAnalytic_0;

	public unsafe int brgRuntimeStatus
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_brgRuntimeStatus);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_brgRuntimeStatus)) = value;
		}
	}

	static BatchRendererGroupRuntimeAnalytic()
	{
		Il2CppClassPointerStore<BatchRendererGroupRuntimeAnalytic>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "BatchRendererGroupRuntimeAnalytic");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BatchRendererGroupRuntimeAnalytic>.NativeClassPtr);
		NativeFieldInfoPtr_brgRuntimeStatus = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BatchRendererGroupRuntimeAnalytic>.NativeClassPtr, "brgRuntimeStatus");
		NativeMethodInfoPtr__ctor_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BatchRendererGroupRuntimeAnalytic>.NativeClassPtr, 100663869);
		NativeMethodInfoPtr_CreateBatchRendererGroupRuntimeAnalytic_Public_Static_BatchRendererGroupRuntimeAnalytic_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BatchRendererGroupRuntimeAnalytic>.NativeClassPtr, 100663870);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1168086, XrefRangeEnd = 1168091, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe BatchRendererGroupRuntimeAnalytic()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BatchRendererGroupRuntimeAnalytic>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1168091, XrefRangeEnd = 1168099, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static BatchRendererGroupRuntimeAnalytic CreateBatchRendererGroupRuntimeAnalytic()
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CreateBatchRendererGroupRuntimeAnalytic_Public_Static_BatchRendererGroupRuntimeAnalytic_0, (IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (IntPtr)0) ? Il2CppObjectPool.Get<BatchRendererGroupRuntimeAnalytic>(intPtr2) : null;
	}

	public BatchRendererGroupRuntimeAnalytic(IntPtr pointer)
		: base(pointer)
	{
	}
}
