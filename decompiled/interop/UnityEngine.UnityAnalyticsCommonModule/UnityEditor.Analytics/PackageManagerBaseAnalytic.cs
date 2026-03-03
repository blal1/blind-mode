using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using UnityEngine.Analytics;

namespace UnityEditor.Analytics;

[Serializable]
public class PackageManagerBaseAnalytic : AnalyticsEventBase
{
	private static readonly IntPtr NativeFieldInfoPtr_start_ts;

	private static readonly IntPtr NativeFieldInfoPtr_duration;

	private static readonly IntPtr NativeFieldInfoPtr_blocking;

	private static readonly IntPtr NativeFieldInfoPtr_package_id;

	private static readonly IntPtr NativeFieldInfoPtr_status_code;

	private static readonly IntPtr NativeFieldInfoPtr_error_message;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;

	public unsafe long start_ts
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_start_ts);
			return *(long*)num;
		}
		set
		{
			*(long*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_start_ts)) = value;
		}
	}

	public unsafe long duration
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_duration);
			return *(long*)num;
		}
		set
		{
			*(long*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_duration)) = value;
		}
	}

	public unsafe bool blocking
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_blocking);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_blocking)) = value;
		}
	}

	public unsafe string package_id
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_package_id);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_package_id)), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe int status_code
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_status_code);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_status_code)) = value;
		}
	}

	public unsafe string error_message
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_error_message);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_error_message)), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	static PackageManagerBaseAnalytic()
	{
		Il2CppClassPointerStore<PackageManagerBaseAnalytic>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UnityAnalyticsCommonModule.dll", "UnityEditor.Analytics", "PackageManagerBaseAnalytic");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PackageManagerBaseAnalytic>.NativeClassPtr);
		NativeFieldInfoPtr_start_ts = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PackageManagerBaseAnalytic>.NativeClassPtr, "start_ts");
		NativeFieldInfoPtr_duration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PackageManagerBaseAnalytic>.NativeClassPtr, "duration");
		NativeFieldInfoPtr_blocking = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PackageManagerBaseAnalytic>.NativeClassPtr, "blocking");
		NativeFieldInfoPtr_package_id = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PackageManagerBaseAnalytic>.NativeClassPtr, "package_id");
		NativeFieldInfoPtr_status_code = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PackageManagerBaseAnalytic>.NativeClassPtr, "status_code");
		NativeFieldInfoPtr_error_message = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PackageManagerBaseAnalytic>.NativeClassPtr, "error_message");
		NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PackageManagerBaseAnalytic>.NativeClassPtr, 100663331);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1407780, XrefRangeEnd = 1407783, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe PackageManagerBaseAnalytic(string eventName)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PackageManagerBaseAnalytic>.NativeClassPtr))
	{
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(eventName);
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public PackageManagerBaseAnalytic(IntPtr pointer)
		: base(pointer)
	{
	}
}
