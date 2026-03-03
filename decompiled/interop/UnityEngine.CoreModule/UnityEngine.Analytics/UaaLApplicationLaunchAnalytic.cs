using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;

namespace UnityEngine.Analytics;

[Serializable]
public class UaaLApplicationLaunchAnalytic : AnalyticsEventBase
{
	private static readonly IntPtr NativeFieldInfoPtr_launch_type;

	private static readonly IntPtr NativeFieldInfoPtr_launch_process_type;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_CreateUaaLApplicationLaunchAnalytic_Public_Static_UaaLApplicationLaunchAnalytic_0;

	public unsafe int launch_type
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_launch_type);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_launch_type)) = value;
		}
	}

	public unsafe int launch_process_type
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_launch_process_type);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_launch_process_type)) = value;
		}
	}

	static UaaLApplicationLaunchAnalytic()
	{
		Il2CppClassPointerStore<UaaLApplicationLaunchAnalytic>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Analytics", "UaaLApplicationLaunchAnalytic");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UaaLApplicationLaunchAnalytic>.NativeClassPtr);
		NativeFieldInfoPtr_launch_type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UaaLApplicationLaunchAnalytic>.NativeClassPtr, "launch_type");
		NativeFieldInfoPtr_launch_process_type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UaaLApplicationLaunchAnalytic>.NativeClassPtr, "launch_process_type");
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UaaLApplicationLaunchAnalytic>.NativeClassPtr, 100667628);
		NativeMethodInfoPtr_CreateUaaLApplicationLaunchAnalytic_Public_Static_UaaLApplicationLaunchAnalytic_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UaaLApplicationLaunchAnalytic>.NativeClassPtr, 100667629);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1231665, XrefRangeEnd = 1231672, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe UaaLApplicationLaunchAnalytic()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UaaLApplicationLaunchAnalytic>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1231672, XrefRangeEnd = 1231682, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static UaaLApplicationLaunchAnalytic CreateUaaLApplicationLaunchAnalytic()
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CreateUaaLApplicationLaunchAnalytic_Public_Static_UaaLApplicationLaunchAnalytic_0, (IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (IntPtr)0) ? Il2CppObjectPool.Get<UaaLApplicationLaunchAnalytic>(intPtr2) : null;
	}

	public UaaLApplicationLaunchAnalytic(IntPtr pointer)
		: base(pointer)
	{
	}
}
