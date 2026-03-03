using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;

namespace UnityEngine.Analytics;

[Serializable]
public class SubsystemsAnalyticStop : SubsystemsAnalyticBase
{
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_CreateSubsystemsAnalyticStop_Internal_Static_SubsystemsAnalyticStop_0;

	static SubsystemsAnalyticStop()
	{
		Il2CppClassPointerStore<SubsystemsAnalyticStop>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UnityAnalyticsCommonModule.dll", "UnityEngine.Analytics", "SubsystemsAnalyticStop");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SubsystemsAnalyticStop>.NativeClassPtr);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SubsystemsAnalyticStop>.NativeClassPtr, 100663300);
		NativeMethodInfoPtr_CreateSubsystemsAnalyticStop_Internal_Static_SubsystemsAnalyticStop_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SubsystemsAnalyticStop>.NativeClassPtr, 100663301);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1407600, XrefRangeEnd = 1407605, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe SubsystemsAnalyticStop()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SubsystemsAnalyticStop>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1407605, XrefRangeEnd = 1407613, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static SubsystemsAnalyticStop CreateSubsystemsAnalyticStop()
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CreateSubsystemsAnalyticStop_Internal_Static_SubsystemsAnalyticStop_0, (IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (IntPtr)0) ? Il2CppObjectPool.Get<SubsystemsAnalyticStop>(intPtr2) : null;
	}

	public SubsystemsAnalyticStop(IntPtr pointer)
		: base(pointer)
	{
	}
}
