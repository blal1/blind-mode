using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;

namespace UnityEngine.Analytics;

[Serializable]
public class SubsystemsAnalyticInfo : SubsystemsAnalyticBase
{
	private static readonly IntPtr NativeFieldInfoPtr_id;

	private static readonly IntPtr NativeFieldInfoPtr_plugin_name;

	private static readonly IntPtr NativeFieldInfoPtr_version;

	private static readonly IntPtr NativeFieldInfoPtr_library_name;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_CreateSubsystemsAnalyticInfo_Internal_Static_SubsystemsAnalyticInfo_0;

	public unsafe string id
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_id);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_id)), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe string plugin_name
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_plugin_name);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_plugin_name)), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe string version
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_version);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_version)), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe string library_name
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_library_name);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_library_name)), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	static SubsystemsAnalyticInfo()
	{
		Il2CppClassPointerStore<SubsystemsAnalyticInfo>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UnityAnalyticsCommonModule.dll", "UnityEngine.Analytics", "SubsystemsAnalyticInfo");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SubsystemsAnalyticInfo>.NativeClassPtr);
		NativeFieldInfoPtr_id = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SubsystemsAnalyticInfo>.NativeClassPtr, "id");
		NativeFieldInfoPtr_plugin_name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SubsystemsAnalyticInfo>.NativeClassPtr, "plugin_name");
		NativeFieldInfoPtr_version = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SubsystemsAnalyticInfo>.NativeClassPtr, "version");
		NativeFieldInfoPtr_library_name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SubsystemsAnalyticInfo>.NativeClassPtr, "library_name");
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SubsystemsAnalyticInfo>.NativeClassPtr, 100663302);
		NativeMethodInfoPtr_CreateSubsystemsAnalyticInfo_Internal_Static_SubsystemsAnalyticInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SubsystemsAnalyticInfo>.NativeClassPtr, 100663303);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1407613, XrefRangeEnd = 1407618, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe SubsystemsAnalyticInfo()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SubsystemsAnalyticInfo>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1407618, XrefRangeEnd = 1407626, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static SubsystemsAnalyticInfo CreateSubsystemsAnalyticInfo()
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CreateSubsystemsAnalyticInfo_Internal_Static_SubsystemsAnalyticInfo_0, (IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (IntPtr)0) ? Il2CppObjectPool.Get<SubsystemsAnalyticInfo>(intPtr2) : null;
	}

	public SubsystemsAnalyticInfo(IntPtr pointer)
		: base(pointer)
	{
	}
}
