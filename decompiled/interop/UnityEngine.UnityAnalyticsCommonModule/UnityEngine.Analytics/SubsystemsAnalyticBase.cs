using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace UnityEngine.Analytics;

[Serializable]
public class SubsystemsAnalyticBase : AnalyticsEventBase
{
	private static readonly IntPtr NativeFieldInfoPtr_subsystem;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;

	public unsafe string subsystem
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_subsystem);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_subsystem)), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	static SubsystemsAnalyticBase()
	{
		Il2CppClassPointerStore<SubsystemsAnalyticBase>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UnityAnalyticsCommonModule.dll", "UnityEngine.Analytics", "SubsystemsAnalyticBase");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SubsystemsAnalyticBase>.NativeClassPtr);
		NativeFieldInfoPtr_subsystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SubsystemsAnalyticBase>.NativeClassPtr, "subsystem");
		NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SubsystemsAnalyticBase>.NativeClassPtr, 100663297);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1407584, XrefRangeEnd = 1407587, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe SubsystemsAnalyticBase(string eventName)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SubsystemsAnalyticBase>.NativeClassPtr))
	{
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(eventName);
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public SubsystemsAnalyticBase(IntPtr pointer)
		: base(pointer)
	{
	}
}
