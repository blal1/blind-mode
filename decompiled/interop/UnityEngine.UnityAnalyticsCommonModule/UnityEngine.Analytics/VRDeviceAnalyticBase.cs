using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace UnityEngine.Analytics;

[Serializable]
public class VRDeviceAnalyticBase : AnalyticsEventBase
{
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	static VRDeviceAnalyticBase()
	{
		Il2CppClassPointerStore<VRDeviceAnalyticBase>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UnityAnalyticsCommonModule.dll", "UnityEngine.Analytics", "VRDeviceAnalyticBase");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VRDeviceAnalyticBase>.NativeClassPtr);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VRDeviceAnalyticBase>.NativeClassPtr, 100663304);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1407626, XrefRangeEnd = 1407631, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe VRDeviceAnalyticBase()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VRDeviceAnalyticBase>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public VRDeviceAnalyticBase(IntPtr pointer)
		: base(pointer)
	{
	}
}
