using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine.Analytics;

namespace UnityEditor.Analytics;

[Serializable]
public class ProjectSettingsInformationAnalytic : AnalyticsEventBase
{
	private static readonly IntPtr NativeFieldInfoPtr_agent_types_count;

	private static readonly IntPtr NativeFieldInfoPtr_areas_count;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_CreateProjectSettingsInformationAnalytic_Internal_Static_ProjectSettingsInformationAnalytic_0;

	public unsafe int agent_types_count
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_agent_types_count);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_agent_types_count)) = value;
		}
	}

	public unsafe int areas_count
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_areas_count);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_areas_count)) = value;
		}
	}

	static ProjectSettingsInformationAnalytic()
	{
		Il2CppClassPointerStore<ProjectSettingsInformationAnalytic>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UnityAnalyticsCommonModule.dll", "UnityEditor.Analytics", "ProjectSettingsInformationAnalytic");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ProjectSettingsInformationAnalytic>.NativeClassPtr);
		NativeFieldInfoPtr_agent_types_count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProjectSettingsInformationAnalytic>.NativeClassPtr, "agent_types_count");
		NativeFieldInfoPtr_areas_count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProjectSettingsInformationAnalytic>.NativeClassPtr, "areas_count");
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectSettingsInformationAnalytic>.NativeClassPtr, 100663327);
		NativeMethodInfoPtr_CreateProjectSettingsInformationAnalytic_Internal_Static_ProjectSettingsInformationAnalytic_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectSettingsInformationAnalytic>.NativeClassPtr, 100663328);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1407754, XrefRangeEnd = 1407759, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ProjectSettingsInformationAnalytic()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ProjectSettingsInformationAnalytic>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1407759, XrefRangeEnd = 1407767, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static ProjectSettingsInformationAnalytic CreateProjectSettingsInformationAnalytic()
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CreateProjectSettingsInformationAnalytic_Internal_Static_ProjectSettingsInformationAnalytic_0, (IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (IntPtr)0) ? Il2CppObjectPool.Get<ProjectSettingsInformationAnalytic>(intPtr2) : null;
	}

	public ProjectSettingsInformationAnalytic(IntPtr pointer)
		: base(pointer)
	{
	}
}
