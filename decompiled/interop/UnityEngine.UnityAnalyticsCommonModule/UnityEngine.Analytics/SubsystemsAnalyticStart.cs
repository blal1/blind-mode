using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;

namespace UnityEngine.Analytics;

[Serializable]
public class SubsystemsAnalyticStart : SubsystemsAnalyticBase
{
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_CreateSubsystemsAnalyticStart_Internal_Static_SubsystemsAnalyticStart_0;

	static SubsystemsAnalyticStart()
	{
		Il2CppClassPointerStore<SubsystemsAnalyticStart>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UnityAnalyticsCommonModule.dll", "UnityEngine.Analytics", "SubsystemsAnalyticStart");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SubsystemsAnalyticStart>.NativeClassPtr);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SubsystemsAnalyticStart>.NativeClassPtr, 100663298);
		NativeMethodInfoPtr_CreateSubsystemsAnalyticStart_Internal_Static_SubsystemsAnalyticStart_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SubsystemsAnalyticStart>.NativeClassPtr, 100663299);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1407587, XrefRangeEnd = 1407592, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe SubsystemsAnalyticStart()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SubsystemsAnalyticStart>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1407592, XrefRangeEnd = 1407600, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static SubsystemsAnalyticStart CreateSubsystemsAnalyticStart()
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CreateSubsystemsAnalyticStart_Internal_Static_SubsystemsAnalyticStart_0, (IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (IntPtr)0) ? Il2CppObjectPool.Get<SubsystemsAnalyticStart>(intPtr2) : null;
	}

	public SubsystemsAnalyticStart(IntPtr pointer)
		: base(pointer)
	{
	}
}
